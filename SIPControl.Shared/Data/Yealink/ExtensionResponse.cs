using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data.Yealink;

public class ExtensionResponse
{
    [JsonPropertyName("ret")]
    public string Ret { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }
}

public class Data
{
    [JsonPropertyName("DSSKEY_DATA")]
    public DssKeyData DssKeyData { get; set; }

    [JsonPropertyName("DSSKEY_TYPE_LIST")]
    public List<DssKeyType> DssKeyTypeList { get; set; }

    [JsonPropertyName("expinfo")]
    public ExpInfo ExpInfo { get; set; }

    [JsonPropertyName("EXP_DEV_NUM")]
    public int ExpDevNum { get; set; }

    [JsonPropertyName("uselock")]
    public bool UseLock { get; set; }

    [JsonPropertyName("g_enableAutoLinekeys")]
    public bool EnableAutoLinekeys { get; set; }

    [JsonPropertyName("g_bsftDirUpdateEnable")]
    public bool BsftDirUpdateEnable { get; set; }

    [JsonPropertyName("g_autoBlflistEnable")]
    public bool AutoBlfListEnable { get; set; }

    [JsonPropertyName("g_bMobileContactEnable")]
    public int MobileContactEnable { get; set; }

    [JsonPropertyName("g_favoritemode")]
    public bool FavoriteMode { get; set; }

    [JsonPropertyName("g_fortinet")]
    public bool Fortinet { get; set; }

    [JsonPropertyName("g_global_mute")]
    public bool GlobalMute { get; set; }

    [JsonPropertyName("g_dsskey_length")]
    public bool DsskeyLength { get; set; }

    [JsonPropertyName("g_dsskey_pagetips")]
    public bool DsskeyPageTips { get; set; }

    [JsonPropertyName("g_b_shortlabel")]
    public bool ShortLabel { get; set; }

    [JsonPropertyName("g_type_order")]
    public List<int> TypeOrder { get; set; }

    [JsonPropertyName("linelist")]
    public List<Dictionary<string,string>> LineList { get; set; }

    [JsonPropertyName("localhistory")]
    public Dictionary<string,string> LocalHistory { get; set; }

    [JsonPropertyName("locklist")]
    public Dictionary<string,string> LockList { get; set; }

    [JsonPropertyName("localgroup")]
    public Dictionary<string,string> LocalGroup { get; set; }

    [JsonPropertyName("remotegroup")]
    public Dictionary<string,string> RemoteGroup { get; set; }

    [JsonPropertyName("networkgroup")]
    public Dictionary<string,string> NetworkGroup { get; set; }

    [JsonPropertyName("netcalllist")]
    public Dictionary<string,string> NetCallList { get; set; }

    [JsonPropertyName("handsetlist")]
    public Dictionary<string,string> HandsetList { get; set; }

    [JsonPropertyName("forwardlist")]
    public List<Dictionary<string,string>> ForwardList { get; set; }
}

public class DssKeyData
{
    [JsonPropertyName("expkey")]
    public List<ExpKey> ExpKeys { get; set; }
}

public class ExpKey
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("keyname")]
    public string KeyName { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("line")]
    public string Line { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("extension")]
    public string Extension { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }
}

public class DssKeyType
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("value")]
    public bool Value { get; set; }

    [JsonPropertyName("label")]
    public bool Label { get; set; }

    [JsonPropertyName("line")]
    public object Line { get; set; }

    [JsonPropertyName("extension")]
    public bool Extension { get; set; }
}

public class ExpInfo
{
    [JsonPropertyName("index")]
    public string Index { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("hwver")]
    public string HardwareVersion { get; set; }

    [JsonPropertyName("swver")]
    public string SoftwareVersion { get; set; }
}
