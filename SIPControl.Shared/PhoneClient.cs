using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using SIPControl.Shared.Data;
using SIPControl.Shared.Data.Yealink;

namespace SIPControl.Shared
{
    public class PhoneClient : IDisposable
    {
        private readonly string _host;
        private readonly CookieContainer _cookies = new();
        private readonly HttpClient _http;
        private string? _csrf;
        public PhoneClient(string host)
        {
            _host = host;
            
            var h = new HttpClientHandler
            {
                CookieContainer = _cookies,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                ServerCertificateCustomValidationCallback = (_, __, ___, ____) => true
            };
            HttpMessageHandler pipeline = h;
            //if (log) pipeline = new LoggingHandler(pipeline);
            _http = new HttpClient(pipeline) { BaseAddress = new Uri($"https://{_host}") };

            // Browser-ish headers
            _http.DefaultRequestHeaders.TryAddWithoutValidation("sec-ch-ua",
                "\"Chromium\";v=\"140\", \"Not=A?Brand\";v=\"24\", \"Google Chrome\";v=\"140\"");
            _http.DefaultRequestHeaders.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
            _http.DefaultRequestHeaders.TryAddWithoutValidation("sec-ch-ua-platform", "\"Windows\"");
            _http.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/140.0.0.0 Safari/537.36");
            _http.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "nl-NL,nl;q=0.9,en-US;q=0.8,en;q=0.7");
            _http.DefaultRequestHeaders.Referrer = new Uri($"https://{_host}/");
        }
        
        public async Task<LoginResponse> LoginAsync(string user, string password)
        {
            var resp = await _http.PostAsync($"/api/auth/login?p=Login&t={Ms()}",
                new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", user),
                    new KeyValuePair<string, string>("pwd", password),
                }));
            var loginResponse = await resp.Content.ReadFromJsonAsync<LoginResponse>();
            return loginResponse;
        }
        
        public async Task PostLoginInfoAndCaptureCsrfAsync()
        {
            var r = await _http.PostAsync($"/api/common/info?p=Login&t={Ms()}", Json("{\"idlist\":[\"wui\"]}"));
            var result = await r.Content.ReadFromJsonAsync<LoginInfoResponse>();
            r.EnsureSuccessStatusCode();
            _csrf = result?.Data.WuiCommonToken;
            _http.DefaultRequestHeaders.Remove("X-CSRFToken");
            _http.DefaultRequestHeaders.TryAddWithoutValidation("X-CSRFToken", _csrf);
            _cookies.Add(new Cookie("csrfToken", _csrf, "/", _host));
        }

        public Task<IsTalkingResponse> GetTalkingAsync()
        {
            return _http.GetFromJsonAsync<IsTalkingResponse>($"/api/common/info/status/talking?p=DSSKeyExp&t={Ms()}");
        }

        public async Task PostConfigUpdate(List<ExpKey> keys)
        {
            await PostWriteConfigAsync();
            await PostDssKeysAsync(keys);
        }
        
        private Task PostWriteConfigAsync()
        {
            NeedCsrf();
            return _http.PostAsync($"/api/inner/writeconfig?p=DSSKeyExp&t={Ms()}", Json("{\"formData\":{}}"));
        }

        public async Task<ExtensionResponse> GetExtensionsAsync()
        {
            var url = $"/api/dsskey/info?model=expkey&expno=1&p=DSSKeyExp&t={Ms()}";
            return await _http.GetFromJsonAsync<ExtensionResponse>(url);
        }
        private async Task PostDssKeysAsync(List<ExpKey> keys)
        {
            if (string.IsNullOrEmpty(_csrf))
                throw new InvalidOperationException("CSRF missing! Make sure you call PostLoginInfoAndCaptureCsrfAsync");

            var url = $"/api/dsskey/info?model=expkey&expno=1&p=DSSKeyExp&t={Ms()}";

            using var content = new StringContent(JsonSerializer.Serialize(keys), Encoding.UTF8, "application/json");
            var resp = await _http.PostAsync(url, content);
            var text = await resp.Content.ReadAsStringAsync();
        }

        public async Task<AccountInfoResponse> GetAccountInfoAsync()
        {
            var url = $"/api/account/info?type=sip&p=AccountRegister&t={Ms()}";
            
            var result = await _http.GetFromJsonAsync<AccountInfoResponse>(url);
            return result;
        }
        public async Task<GeneralInfoResponse?> GetGeneralStatus()
        {
            var url = $"/api/common/info?p=StatusGeneral&t={Ms()}";
            var content =
                new StringContent(
                    @"{""idlist"":[""system"",""network"",""cert"",""account.info"",""dsskey.expkey.list"",""dsskey.ehs40"",""accessory.mic_info""]}");
            var result = await _http.PostAsync(url, content);
            return await result.Content.ReadFromJsonAsync<GeneralInfoResponse>();
        }
        private void NeedCsrf()
        {
            if (string.IsNullOrEmpty(_csrf)) throw new InvalidOperationException("CSRF missing");
        }
        
        private static long Ms() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        
        private StringContent Json(string s) => new (s, Encoding.UTF8, "application/json");


        public void Dispose()
        {
            _http.Dispose();
        }
    }
}
