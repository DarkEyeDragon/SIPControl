using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data.PbxOnline;

public class LoginResponse
{
    [JsonPropertyName("login")]
    public string Login { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("tokenExpires")]
    public int TokenExpires { get; set; }

    [JsonPropertyName("refreshToken")]
    public string RefreshToken { get; set; }

    [JsonPropertyName("refreshTokenExpires")]
    public int RefreshTokenExpires { get; set; }

    [JsonPropertyName("2fa")]
    public bool _2fa { get; set; }

    [JsonPropertyName("loginType")]
    public string LoginType { get; set; }

    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }
}