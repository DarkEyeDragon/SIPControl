using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using SIPControl.Shared.Data.PbxOnline;

namespace SIPControl.Shared;

public class PbxOnline
{
    private readonly HttpClient _httpClient;

    public bool IsAuthenticated { get; private set; }

    public PbxOnline()
    {
        var handler = new LoggingHandler(new HttpClientHandler { UseCookies = true });
        _httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://pbxonline.be/api/v2/250501/")
        };

        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task LoginAsync(string user, string password)
    {
        var payload = new LoginRequest { Login = user, Password = password };
        var json = JsonSerializer.Serialize(payload, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        // Use ByteArrayContent to avoid StringContent's automatic charset
        using var content = new ByteArrayContent(Encoding.UTF8.GetBytes(json));
        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        using var req = new HttpRequestMessage(HttpMethod.Post, "pbxonline/login")
        {
            Content = content
        };

        using var resp = await _httpClient.SendAsync(req);
        resp.EnsureSuccessStatusCode();

        var result = await resp.Content.ReadFromJsonAsync<LoginResponse>()
                     ?? throw new InvalidOperationException("Empty login response.");

        if (!string.IsNullOrWhiteSpace(result.Token))
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", result.Token);
            IsAuthenticated = true;
        }
    }

    public async Task<PbxExtensionResponse> GetExtensions()
    {
        using var req = new HttpRequestMessage(HttpMethod.Get, "pbx/extension");

        req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        req.Content = new ByteArrayContent([]);
        req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        using var resp = await _httpClient.SendAsync(req);
        var body = await resp.Content.ReadAsStringAsync();

        if (!resp.IsSuccessStatusCode)
            throw new HttpRequestException(
                $"GET extensions failed {(int)resp.StatusCode} {resp.ReasonPhrase}. Body: {body}");

        return JsonSerializer.Deserialize<PbxExtensionResponse>(body)!;
    }
}

public sealed class LoggingHandler : DelegatingHandler
{
    private readonly bool _maskAuth;

    /// <param name="innerHandler">Usually HttpClientHandler</param>
    /// <param name="maskAuthorizationHeader">true to mask Bearer tokens in logs</param>
    public LoggingHandler(HttpMessageHandler innerHandler, bool maskAuthorizationHeader = true)
        : base(innerHandler)
    {
        _maskAuth = maskAuthorizationHeader;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
    {
        await LogRequestAsync(request, ct);
        var response = await base.SendAsync(request, ct);
        await LogResponseAsync(response, ct);
        return response;
    }

    private async Task LogRequestAsync(HttpRequestMessage req, CancellationToken ct)
    {
        var sb = new StringBuilder();
        sb.AppendLine("==== HTTP REQUEST ====");
        sb.AppendLine($"{req.Method} {req.RequestUri}");
        DumpHeaders(sb, req.Headers);

        if (req.Content is not null)
        {
            DumpHeaders(sb, req.Content.Headers, isContentHeaders: true);
            var body = await req.Content.ReadAsStringAsync(ct);
            if (!string.IsNullOrWhiteSpace(body))
                sb.AppendLine($"Body: {body}");
        }

        Console.WriteLine(sb.ToString());
    }

    private async Task LogResponseAsync(HttpResponseMessage resp, CancellationToken ct)
    {
        var sb = new StringBuilder();
        sb.AppendLine("==== HTTP RESPONSE ====");
        sb.AppendLine($"Status: {(int)resp.StatusCode} {resp.ReasonPhrase}");
        DumpHeaders(sb, resp.Headers);

        if (resp.Content is not null)
        {
            DumpHeaders(sb, resp.Content.Headers, isContentHeaders: true);
            // Comment out next 2 lines if bodies are large or sensitive
            var body = await resp.Content.ReadAsStringAsync(ct);
            if (!string.IsNullOrWhiteSpace(body))
                sb.AppendLine($"Body: {body}");
        }

        Console.WriteLine(sb.ToString());
    }

    private void DumpHeaders(StringBuilder sb, HttpHeaders headers, bool isContentHeaders = false)
    {
        foreach (var h in headers)
        {
            var name = h.Key;
            foreach (var v in h.Value)
            {
                var value = v;
                
                sb.AppendLine($"{(isContentHeaders ? "Content-" : "")}Header: {name}: {value}");
            }
        }
    }
}