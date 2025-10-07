using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data;

public class AccountInfoResponse
{
    [JsonPropertyName("data")] public List<Datum> Data { get; set; }

    [JsonPropertyName("ret")] public string Ret { get; set; }
    public class Datum
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("status")] public string Status { get; set; }

        [JsonPropertyName("userName")] public string UserName { get; set; }

        [JsonPropertyName("label")] public string Label { get; set; }

        [JsonPropertyName("displayName")] public string DisplayName { get; set; }

        [JsonPropertyName("registerName")] public string RegisterName { get; set; }

        [JsonPropertyName("sipServer")] public string SipServer { get; set; }
    }
    
}