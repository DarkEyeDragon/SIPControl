using Microsoft.Extensions.Options;
using SIPControl.Shared.Data;
using SIPControl.Shared.Data.Yealink;

namespace SIPControl.Shared;

public class PhoneClientFactory : IPhoneClientFactory
{
    private readonly IOptions<LoginOptions> _opts;
    public PhoneClientFactory(IOptions<LoginOptions> opts) => _opts = opts;

    public async Task<PhoneClient> CreateAsync(string host)
    {
        var client = new PhoneClient(host);
        await client.LoginAsync(_opts.Value.Username, _opts.Value.Password);
        await client.PostLoginInfoAndCaptureCsrfAsync();
        return client;
    }
}