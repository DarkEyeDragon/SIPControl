using Microsoft.Extensions.Options;
using SIPControl.Shared.Data.PbxOnline;
using SIPControl.Shared.Data.Yealink;

namespace SIPControl.Shared;

public class PbxOnlineFactory : IPbxOnlineFactory
{
    private readonly IOptions<PbxLoginOptions> _opts;
    
    public PbxOnlineFactory(IOptions<PbxLoginOptions> opts)
    {
        _opts = opts;
        _pbxOnline = new PbxOnline();
    }

    private PbxOnline _pbxOnline;

    public async Task<PbxOnline> CreateAsync()
    {
        if (!_pbxOnline.IsAuthenticated)
        {
            await _pbxOnline.LoginAsync(_opts.Value.Username, _opts.Value.Password);
        }
        return _pbxOnline;
    }
}