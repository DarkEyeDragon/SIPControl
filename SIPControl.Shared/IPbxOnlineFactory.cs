namespace SIPControl.Shared;

public interface IPbxOnlineFactory
{
    Task<PbxOnline> CreateAsync();
}