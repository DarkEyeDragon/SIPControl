using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data.PbxOnline;

public class LoginRequest
{
    [JsonPropertyName("login")]
    public string Login { get; set; }
    [JsonPropertyName("password")]
    public string Password { get; set; }
}