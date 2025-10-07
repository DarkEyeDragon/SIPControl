using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data;

public class GeneralInfoResponse
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    [JsonPropertyName("ret")]
    public string Ret { get; set; }

    [JsonPropertyName("data")]
    public Datas Data { get; set; }
    public class AccountInfo
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("registerName")]
        public string RegisterName { get; set; }

        [JsonPropertyName("sipServer")]
        public string SipServer { get; set; }
    }

    public class Datas
    {
        [JsonPropertyName("system.localtime")]
        public string SystemLocaltime { get; set; }

        [JsonPropertyName("system.localtime.timefmt")]
        public string SystemLocaltimeTimefmt { get; set; }

        [JsonPropertyName("system.localtime.datefmt")]
        public string SystemLocaltimeDatefmt { get; set; }

        [JsonPropertyName("system.powerontime")]
        public string SystemPowerontime { get; set; }

        [JsonPropertyName("system.version.firmware")]
        public string SystemVersionFirmware { get; set; }

        [JsonPropertyName("system.version.hardware")]
        public string SystemVersionHardware { get; set; }

        [JsonPropertyName("system.version.config")]
        public string SystemVersionConfig { get; set; }

        [JsonPropertyName("system.version.cfgmac")]
        public string SystemVersionCfgmac { get; set; }

        [JsonPropertyName("system.version.cfgcom")]
        public string SystemVersionCfgcom { get; set; }

        [JsonPropertyName("system.devname")]
        public string SystemDevname { get; set; }

        [JsonPropertyName("system.productid")]
        public string SystemProductid { get; set; }

        [JsonPropertyName("network.mode")]
        public string NetworkMode { get; set; }

        [JsonPropertyName("network.ipv4.addr")]
        public string NetworkIpv4Addr { get; set; }

        [JsonPropertyName("network.ipv4.gateway")]
        public string NetworkIpv4Gateway { get; set; }

        [JsonPropertyName("network.ipv4.mask")]
        public string NetworkIpv4Mask { get; set; }

        [JsonPropertyName("network.ipv4.dns1")]
        public string NetworkIpv4Dns1 { get; set; }

        [JsonPropertyName("network.ipv4.dns2")]
        public string NetworkIpv4Dns2 { get; set; }

        [JsonPropertyName("network.ipv4.dns3")]
        public string NetworkIpv4Dns3 { get; set; }

        [JsonPropertyName("network.ipv4.dns4")]
        public string NetworkIpv4Dns4 { get; set; }

        [JsonPropertyName("network.ipv4.wantype")]
        public string NetworkIpv4Wantype { get; set; }

        [JsonPropertyName("network.ipv6.fulladdr")]
        public string NetworkIpv6Fulladdr { get; set; }

        [JsonPropertyName("network.ipv6.gateway")]
        public string NetworkIpv6Gateway { get; set; }

        [JsonPropertyName("network.ipv6.dns1")]
        public string NetworkIpv6Dns1 { get; set; }

        [JsonPropertyName("network.ipv6.dns2")]
        public string NetworkIpv6Dns2 { get; set; }

        [JsonPropertyName("network.ipv6.dns3")]
        public string NetworkIpv6Dns3 { get; set; }

        [JsonPropertyName("network.ipv6.dns4")]
        public string NetworkIpv6Dns4 { get; set; }

        [JsonPropertyName("network.ipv6.wantype")]
        public string NetworkIpv6Wantype { get; set; }

        [JsonPropertyName("network.vpn.name")]
        public string NetworkVpnName { get; set; }

        [JsonPropertyName("network.vpn.ipv4.addr")]
        public string NetworkVpnIpv4Addr { get; set; }

        [JsonPropertyName("network.8021x.cacert.name")]
        public string Network8021xCacertName { get; set; }

        [JsonPropertyName("network.8021x.devcert.name")]
        public string Network8021xDevcertName { get; set; }

        [JsonPropertyName("network.common.mac")]
        public string NetworkCommonMac { get; set; }

        [JsonPropertyName("network.common.machineid")]
        public string NetworkCommonMachineid { get; set; }

        [JsonPropertyName("network.common.wifissid")]
        public string NetworkCommonWifissid { get; set; }

        [JsonPropertyName("network.common.wifimac")]
        public string NetworkCommonWifimac { get; set; }

        [JsonPropertyName("network.common.vlanid")]
        public string NetworkCommonVlanid { get; set; }

        [JsonPropertyName("network.common.bluetoothmac")]
        public string NetworkCommonBluetoothmac { get; set; }

        [JsonPropertyName("network.common.wanportstatus")]
        public string NetworkCommonWanportstatus { get; set; }

        [JsonPropertyName("network.common.pcportstatus")]
        public string NetworkCommonPcportstatus { get; set; }

        [JsonPropertyName("network.common.networklantype")]
        public string NetworkCommonNetworklantype { get; set; }

        [JsonPropertyName("network.advanced.wansupportspeed")]
        public string NetworkAdvancedWansupportspeed { get; set; }

        [JsonPropertyName("network.advanced.pcsupportspeed")]
        public string NetworkAdvancedPcsupportspeed { get; set; }

        [JsonPropertyName("cert.installedstatus")]
        public string CertInstalledstatus { get; set; }

        [JsonPropertyName("cert.amrlicensestatus")]
        public string CertAmrlicensestatus { get; set; }

        [JsonPropertyName("cert.rsaprikey")]
        public string CertRsaprikey { get; set; }

        [JsonPropertyName("account.info")]
        public List<AccountInfo> AccountInfo { get; set; }

        [JsonPropertyName("dsskey.expkey.list")]
        public List<DsskeyExpkeyList> DsskeyExpkeyList { get; set; }

        [JsonPropertyName("dsskey.ehs40")]
        public DsskeyEhs40 DsskeyEhs40 { get; set; }

        [JsonPropertyName("accessory.mic_info")]
        public List<object> AccessoryMicInfo { get; set; }
    }

    public class DsskeyEhs40
    {
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }

        [JsonPropertyName("hwver")]
        public string Hwver { get; set; }

        [JsonPropertyName("swver")]
        public string Swver { get; set; }
    }

    public class DsskeyExpkeyList
    {
        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("hwver")]
        public string Hwver { get; set; }

        [JsonPropertyName("swver")]
        public string Swver { get; set; }
    }

}