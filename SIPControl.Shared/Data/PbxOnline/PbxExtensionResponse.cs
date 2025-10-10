using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data.PbxOnline;

public class PbxExtensionResponse
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("previous")]
    public string Previous { get; set; }

    [JsonPropertyName("metadata")]
    public List<Metadata> Metadatas { get; set; }

    [JsonPropertyName("results")]
    public List<Result> Results { get; set; }

    [JsonPropertyName("error")]
    public string Error { get; set; }
    
    public class AttachInfo
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("logicalName")]
        public string LogicalName { get; set; }

        [JsonPropertyName("sipUsername")]
        public string SipUsername { get; set; }
    }

    public class MandatoryField
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("showFields")]
        public List<ShowField> ShowFields { get; set; }

        [JsonPropertyName("showExport")]
        public bool? ShowExport { get; set; }

        [JsonPropertyName("showImport")]
        public bool? ShowImport { get; set; }

        [JsonPropertyName("exportFields")]
        public List<string> ExportFields { get; set; }

        [JsonPropertyName("importFields")]
        public List<object> ImportFields { get; set; }

        [JsonPropertyName("mandatoryFields")]
        public List<MandatoryField> MandatoryFields { get; set; }

        [JsonPropertyName("sortFields")]
        public List<string> SortFields { get; set; }

        [JsonPropertyName("/pbx/sipaccount")]
        public List<PbxSipaccount> PbxSipaccount { get; set; }

        [JsonPropertyName("/pbx/dialgroup")]
        public List<PbxDialgroup> PbxDialgroup { get; set; }

        [JsonPropertyName("/pbx/mixedgroup")]
        public List<object> PbxMixedgroup { get; set; }

        [JsonPropertyName("/pbx/dialplan")]
        public List<PbxDialplan> PbxDialplan { get; set; }

        [JsonPropertyName("/pbx/shortnumber")]
        public List<PbxShortnumber> PbxShortnumber { get; set; }
    }

    public class PbxDialgroup
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("logicalName")]
        public string LogicalName { get; set; }
    }

    public class PbxDialplan
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("logicalName")]
        public string LogicalName { get; set; }
    }

    public class PbxShortnumber
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("logicalName")]
        public string LogicalName { get; set; }

        [JsonPropertyName("shortNumber")]
        public int ShortNumber { get; set; }

        [JsonPropertyName("telephoneNumber")]
        public string TelephoneNumber { get; set; }
    }

    public class PbxSipaccount
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("logicalName")]
        public string LogicalName { get; set; }

        [JsonPropertyName("sipUsername")]
        public string SipUsername { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("extension")]
        public int Extension { get; set; }

        [JsonPropertyName("attachType")]
        public string AttachType { get; set; }

        [JsonPropertyName("attachID")]
        public int AttachID { get; set; }

        [JsonPropertyName("blfExtension")]
        public string BlfExtension { get; set; }

        [JsonPropertyName("attachInfo")]
        public AttachInfo? AttachInfo { get; set; }
    }

    public class ShowField
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("show")]
        public bool Show { get; set; }

        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }
    }
    
}