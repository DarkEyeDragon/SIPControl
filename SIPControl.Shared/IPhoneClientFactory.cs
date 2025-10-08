namespace SIPControl.Shared;

public interface IPhoneClientFactory
{
    Task<PhoneClient> CreateAsync(string host);
}