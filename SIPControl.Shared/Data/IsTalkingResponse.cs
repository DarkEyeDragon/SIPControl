using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data;

public class IsTalkingResponse
{
    [JsonPropertyName("ret")] public string Ret { get; set; }

    [JsonPropertyName("data")] public bool Data { get; set; }
}