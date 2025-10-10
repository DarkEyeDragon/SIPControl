using System.Text.Json.Serialization;

namespace SIPControl.Shared.Data.Yealink;

public class LoginInfoResponse
{
    [JsonPropertyName("ret")]
    public string Ret { get; set; }

    [JsonPropertyName("data")]
    public ConfigData Data { get; set; }
    
    public class ConfigData
    {
        [JsonPropertyName("wui.config.BSFTActive")]
        public string WuiConfigBSFTActive { get; set; }

        [JsonPropertyName("wui.config.MTSWActive")]
        public string WuiConfigMTSWActive { get; set; }

        [JsonPropertyName("wui.config.XSISwitch")]
        public string WuiConfigXSISwitch { get; set; }

        [JsonPropertyName("wui.config.EnableUC")]
        public string WuiConfigEnableUC { get; set; }

        [JsonPropertyName("wui.config.VCAccountActive")]
        public string WuiConfigVCAccountActive { get; set; }

        [JsonPropertyName("wui.config.AutoProvisionCustomProtect")]
        public string WuiConfigAutoProvisionCustomProtect { get; set; }

        [JsonPropertyName("wui.config.LocalTimeDateFormatType")]
        public string WuiConfigLocalTimeDateFormatType { get; set; }

        [JsonPropertyName("wui.config.LocalTimeTimeFormatType")]
        public string WuiConfigLocalTimeTimeFormatType { get; set; }

        [JsonPropertyName("wui.config.CustomDateFmt")]
        public string WuiConfigCustomDateFmt { get; set; }

        [JsonPropertyName("wui.config.DisplayVQReportOnWeb")]
        public string WuiConfigDisplayVQReportOnWeb { get; set; }

        [JsonPropertyName("wui.config.CallWaitingMode")]
        public string WuiConfigCallWaitingMode { get; set; }

        [JsonPropertyName("wui.config.BluetoothFuncEnable")]
        public string WuiConfigBluetoothFuncEnable { get; set; }

        [JsonPropertyName("wui.config.DigitMapSwtich")]
        public string WuiConfigDigitMapSwtich { get; set; }

        [JsonPropertyName("wui.config.TR069FORBID")]
        public string WuiConfigTR069FORBID { get; set; }

        [JsonPropertyName("wui.config.GoogleAccountReg")]
        public string WuiConfigGoogleAccountReg { get; set; }

        [JsonPropertyName("wui.config.ForwardForbidden")]
        public string WuiConfigForwardForbidden { get; set; }

        [JsonPropertyName("wui.config.DndForbidden")]
        public string WuiConfigDndForbidden { get; set; }

        [JsonPropertyName("wui.config.TransferAllow")]
        public string WuiConfigTransferAllow { get; set; }

        [JsonPropertyName("wui.config.rps_switch")]
        public string WuiConfigRpsSwitch { get; set; }

        [JsonPropertyName("wui.config.TeamsVersion")]
        public string WuiConfigTeamsVersion { get; set; }

        [JsonPropertyName("wui.config.FavoriteDirAutoSetSwitch")]
        public string WuiConfigFavoriteDirAutoSetSwitch { get; set; }

        [JsonPropertyName("wui.config.SMSEnable")]
        public string WuiConfigSMSEnable { get; set; }

        [JsonPropertyName("wui.config.SupportCustomDoorPhone")]
        public string WuiConfigSupportCustomDoorPhone { get; set; }

        [JsonPropertyName("wui.config.LicenseManageList")]
        public string WuiConfigLicenseManageList { get; set; }

        [JsonPropertyName("wui.config.AMRLicenseEnable")]
        public string WuiConfigAMRLicenseEnable { get; set; }

        [JsonPropertyName("wui.config.WuiSupportPhoneMode")]
        public string WuiConfigWuiSupportPhoneMode { get; set; }

        [JsonPropertyName("wui.config.EnterpriseDirectoryEnable")]
        public string WuiConfigEnterpriseDirectoryEnable { get; set; }

        [JsonPropertyName("wui.config.ContactNumberType")]
        public string WuiConfigContactNumberType { get; set; }

        [JsonPropertyName("wui.config.WuiSupportUCAP")]
        public string WuiConfigWuiSupportUCAP { get; set; }

        [JsonPropertyName("wui.config.SupportDectMode")]
        public string WuiConfigSupportDectMode { get; set; }

        [JsonPropertyName("wui.config.ImsMode")]
        public string WuiConfigImsMode { get; set; }

        [JsonPropertyName("wui.device.mac")]
        public string WuiDeviceMac { get; set; }

        [JsonPropertyName("wui.device.firmware")]
        public string WuiDeviceFirmware { get; set; }

        [JsonPropertyName("wui.device.hardware")]
        public string WuiDeviceHardware { get; set; }

        [JsonPropertyName("wui.device.webbasever")]
        public string WuiDeviceWebbasever { get; set; }

        [JsonPropertyName("wui.device.webTimestamp")]
        public string WuiDeviceWebTimestamp { get; set; }

        [JsonPropertyName("wui.device.phoneName")]
        public string WuiDevicePhoneName { get; set; }

        [JsonPropertyName("wui.device.phoneTimeYear")]
        public string WuiDevicePhoneTimeYear { get; set; }

        [JsonPropertyName("wui.device.bTalking")]
        public bool WuiDeviceBTalking { get; set; }

        [JsonPropertyName("wui.device.dectDongleStatus")]
        public string WuiDeviceDectDongleStatus { get; set; }

        [JsonPropertyName("wui.device.bSupportWifi")]
        public bool WuiDeviceBSupportWifi { get; set; }

        [JsonPropertyName("wui.device.bSupportWifiAP")]
        public bool WuiDeviceBSupportWifiAP { get; set; }

        [JsonPropertyName("wui.device.bSupportBlueTooth")]
        public bool WuiDeviceBSupportBlueTooth { get; set; }

        [JsonPropertyName("wui.device.bColorScreenPhone")]
        public bool WuiDeviceBColorScreenPhone { get; set; }

        [JsonPropertyName("wui.device.bSingleAccount")]
        public bool WuiDeviceBSingleAccount { get; set; }

        [JsonPropertyName("wui.device.bTouchScreenPhone")]
        public bool WuiDeviceBTouchScreenPhone { get; set; }

        [JsonPropertyName("wui.device.bGMSEnable")]
        public bool WuiDeviceBGMSEnable { get; set; }

        [JsonPropertyName("wui.device.headsetFeatureSet")]
        public WuiDeviceHeadsetFeatureSet WuiDeviceHeadsetFeatureSet { get; set; }

        [JsonPropertyName("wui.device.bZoom")]
        public bool WuiDeviceBZoom { get; set; }

        [JsonPropertyName("wui.common.rsaN")]
        public string WuiCommonRsaN { get; set; }

        [JsonPropertyName("wui.common.rsaE")]
        public string WuiCommonRsaE { get; set; }

        [JsonPropertyName("wui.common.loginUser")]
        public string WuiCommonLoginUser { get; set; }

        [JsonPropertyName("wui.common.curLang")]
        public string WuiCommonCurLang { get; set; }

        [JsonPropertyName("wui.common.langFileName")]
        public string WuiCommonLangFileName { get; set; }

        [JsonPropertyName("wui.common.langList")]
        public List<string> WuiCommonLangList { get; set; }

        [JsonPropertyName("wui.common.token")]
        public string WuiCommonToken { get; set; }

        [JsonPropertyName("wui.common.resSizeLimit")]
        public WuiCommonResSizeLimit WuiCommonResSizeLimit { get; set; }

        [JsonPropertyName("wui.common.loginNote")]
        public string WuiCommonLoginNote { get; set; }

        [JsonPropertyName("wui.common.modelName")]
        public string WuiCommonModelName { get; set; }

        [JsonPropertyName("wui.common.logoLink")]
        public string WuiCommonLogoLink { get; set; }

        [JsonPropertyName("wui.common.guidesUrl")]
        public string WuiCommonGuidesUrl { get; set; }

        [JsonPropertyName("wui.common.aboutInfo")]
        public string WuiCommonAboutInfo { get; set; }

        [JsonPropertyName("wui.common.levelMap")]
        public WuiCommonLevelMap WuiCommonLevelMap { get; set; }

        [JsonPropertyName("wui.common.bSupportContactSameName")]
        public bool WuiCommonBSupportContactSameName { get; set; }

        [JsonPropertyName("wui.common.bActionUriOff")]
        public bool WuiCommonBActionUriOff { get; set; }

        [JsonPropertyName("wui.common.bNotCallOnWeb")]
        public bool WuiCommonBNotCallOnWeb { get; set; }

        [JsonPropertyName("wui.common.bDateShowBefore")]
        public bool WuiCommonBDateShowBefore { get; set; }

        [JsonPropertyName("wui.common.bDDPhoneMode")]
        public bool WuiCommonBDDPhoneMode { get; set; }

        [JsonPropertyName("wui.common.accessoriesUpgrade")]
        public WuiCommonAccessoriesUpgrade WuiCommonAccessoriesUpgrade { get; set; }

        [JsonPropertyName("wui.common.bUpgradeUseChunk")]
        public bool WuiCommonBUpgradeUseChunk { get; set; }

        [JsonPropertyName("wui.common.bSupportCSR")]
        public bool WuiCommonBSupportCSR { get; set; }

        [JsonPropertyName("wui.common.bSupportPSTN")]
        public bool WuiCommonBSupportPSTN { get; set; }

        [JsonPropertyName("wui.common.bSupportDnsMode")]
        public bool WuiCommonBSupportDnsMode { get; set; }

        [JsonPropertyName("wui.common.bPasswordRuleEnable")]
        public bool WuiCommonBPasswordRuleEnable { get; set; }

        [JsonPropertyName("wui.common.defPasswordInfo")]
        public WuiCommonDefPasswordInfo WuiCommonDefPasswordInfo { get; set; }

        [JsonPropertyName("wui.common.bCacheConfigStatus")]
        public bool WuiCommonBCacheConfigStatus { get; set; }

        [JsonPropertyName("wui.common.bthInfo")]
        public WuiCommonBthInfo WuiCommonBthInfo { get; set; }

        [JsonPropertyName("wui.common.certsAlertInfo")]
        public WuiCommonCertsAlertInfo WuiCommonCertsAlertInfo { get; set; }

        [JsonPropertyName("wui.common.bRemoveShowPWD")]
        public bool WuiCommonBRemoveShowPWD { get; set; }
    }

    public class Items
    {
        [JsonPropertyName("LanguageWebLang")]
        public string LanguageWebLang { get; set; }

        [JsonPropertyName("ScreenshotLevel")]
        public string ScreenshotLevel { get; set; }
    }

    public class Pages
    {
        [JsonPropertyName("Common")]
        public string Common { get; set; }

        [JsonPropertyName("WuiLogicConfig")]
        public string WuiLogicConfig { get; set; }

        [JsonPropertyName("StatusGeneral")]
        public string StatusGeneral { get; set; }

        [JsonPropertyName("StatusPhoneMode")]
        public string StatusPhoneMode { get; set; }

        [JsonPropertyName("StatusTalk")]
        public string StatusTalk { get; set; }

        [JsonPropertyName("StatusRTP")]
        public string StatusRTP { get; set; }

        [JsonPropertyName("StatusVoip")]
        public string StatusVoip { get; set; }

        [JsonPropertyName("StatusMemoryInfo")]
        public string StatusMemoryInfo { get; set; }

        [JsonPropertyName("StatusWifi")]
        public string StatusWifi { get; set; }

        [JsonPropertyName("StatusAP")]
        public string StatusAP { get; set; }

        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("AccountRegister")]
        public string AccountRegister { get; set; }

        [JsonPropertyName("AccountBasic")]
        public string AccountBasic { get; set; }

        [JsonPropertyName("AccountCodec")]
        public string AccountCodec { get; set; }

        [JsonPropertyName("AccountAdvanced")]
        public string AccountAdvanced { get; set; }

        [JsonPropertyName("AccountAssignment")]
        public string AccountAssignment { get; set; }

        [JsonPropertyName("AccountAlarmAssign")]
        public string AccountAlarmAssign { get; set; }

        [JsonPropertyName("Account")]
        public string Account { get; set; }

        [JsonPropertyName("PstnAccountRegister")]
        public string PstnAccountRegister { get; set; }

        [JsonPropertyName("PstnAccountBasic")]
        public string PstnAccountBasic { get; set; }

        [JsonPropertyName("PstnAccount")]
        public string PstnAccount { get; set; }

        [JsonPropertyName("NetworkGeneral")]
        public string NetworkGeneral { get; set; }

        [JsonPropertyName("NetworkPCWANPort")]
        public string NetworkPCWANPort { get; set; }

        [JsonPropertyName("NetworkPCPort")]
        public string NetworkPCPort { get; set; }

        [JsonPropertyName("NetworkNat")]
        public string NetworkNat { get; set; }

        [JsonPropertyName("NetworkAdvanced")]
        public string NetworkAdvanced { get; set; }

        [JsonPropertyName("NetworkWifi")]
        public string NetworkWifi { get; set; }

        [JsonPropertyName("NetworkAP")]
        public string NetworkAP { get; set; }

        [JsonPropertyName("NetworkDiagnose")]
        public string NetworkDiagnose { get; set; }

        [JsonPropertyName("Network")]
        public string Network { get; set; }

        [JsonPropertyName("DSSKeyLine")]
        public string DSSKeyLine { get; set; }

        [JsonPropertyName("DSSKeyProgramable")]
        public string DSSKeyProgramable { get; set; }

        [JsonPropertyName("DSSKeyShortcut")]
        public string DSSKeyShortcut { get; set; }

        [JsonPropertyName("DSSKeyExp")]
        public string DSSKeyExp { get; set; }

        [JsonPropertyName("DSSKey")]
        public string DSSKey { get; set; }

        [JsonPropertyName("FeaturesForward")]
        public string FeaturesForward { get; set; }

        [JsonPropertyName("FeaturesGeneral")]
        public string FeaturesGeneral { get; set; }

        [JsonPropertyName("FeaturesAlarm")]
        public string FeaturesAlarm { get; set; }

        [JsonPropertyName("FeaturesAudio")]
        public string FeaturesAudio { get; set; }

        [JsonPropertyName("FeaturesIntercom")]
        public string FeaturesIntercom { get; set; }

        [JsonPropertyName("FeaturesTransfer")]
        public string FeaturesTransfer { get; set; }

        [JsonPropertyName("FeaturesCallPickUp")]
        public string FeaturesCallPickUp { get; set; }

        [JsonPropertyName("FeaturesRemoteControl")]
        public string FeaturesRemoteControl { get; set; }

        [JsonPropertyName("FeaturesPhoneLock")]
        public string FeaturesPhoneLock { get; set; }

        [JsonPropertyName("FeaturesACD")]
        public string FeaturesACD { get; set; }

        [JsonPropertyName("FeaturesSMS")]
        public string FeaturesSMS { get; set; }

        [JsonPropertyName("FeaturesActionUrl")]
        public string FeaturesActionUrl { get; set; }

        [JsonPropertyName("FeaturesBluetooth")]
        public string FeaturesBluetooth { get; set; }

        [JsonPropertyName("FeaturesPowerLED")]
        public string FeaturesPowerLED { get; set; }

        [JsonPropertyName("FeaturesNotifyPop")]
        public string FeaturesNotifyPop { get; set; }

        [JsonPropertyName("FeaturesDoorPhone")]
        public string FeaturesDoorPhone { get; set; }

        [JsonPropertyName("Features")]
        public string Features { get; set; }

        [JsonPropertyName("SettingGeneral")]
        public string SettingGeneral { get; set; }

        [JsonPropertyName("SettingDatetime")]
        public string SettingDatetime { get; set; }

        [JsonPropertyName("SettingCallDisplay")]
        public string SettingCallDisplay { get; set; }

        [JsonPropertyName("SettingUpgrade")]
        public string SettingUpgrade { get; set; }

        [JsonPropertyName("SettingAutop")]
        public string SettingAutop { get; set; }

        [JsonPropertyName("SettingConfig")]
        public string SettingConfig { get; set; }

        [JsonPropertyName("SettingDialPlan")]
        public string SettingDialPlan { get; set; }

        [JsonPropertyName("SettingVoice")]
        public string SettingVoice { get; set; }

        [JsonPropertyName("SettingRing")]
        public string SettingRing { get; set; }

        [JsonPropertyName("SettingTone")]
        public string SettingTone { get; set; }

        [JsonPropertyName("SettingSoftkey")]
        public string SettingSoftkey { get; set; }

        [JsonPropertyName("SettingTR069")]
        public string SettingTR069 { get; set; }

        [JsonPropertyName("SettingVoiceMonitoring")]
        public string SettingVoiceMonitoring { get; set; }

        [JsonPropertyName("SettingSIP")]
        public string SettingSIP { get; set; }

        [JsonPropertyName("SettingVideo")]
        public string SettingVideo { get; set; }

        [JsonPropertyName("SettingPowerSaving")]
        public string SettingPowerSaving { get; set; }

        [JsonPropertyName("SettingApk")]
        public string SettingApk { get; set; }

        [JsonPropertyName("SettingGMS")]
        public string SettingGMS { get; set; }

        [JsonPropertyName("Settings")]
        public string Settings { get; set; }

        [JsonPropertyName("ContactsLocal")]
        public string ContactsLocal { get; set; }

        [JsonPropertyName("ContactsDect")]
        public string ContactsDect { get; set; }

        [JsonPropertyName("ContactsGoogle")]
        public string ContactsGoogle { get; set; }

        [JsonPropertyName("ContactsRemote")]
        public string ContactsRemote { get; set; }

        [JsonPropertyName("ContactsCalllog")]
        public string ContactsCalllog { get; set; }

        [JsonPropertyName("ContactsLDAP")]
        public string ContactsLDAP { get; set; }

        [JsonPropertyName("ContactsEnterprise")]
        public string ContactsEnterprise { get; set; }

        [JsonPropertyName("ContactsMulticast")]
        public string ContactsMulticast { get; set; }

        [JsonPropertyName("ContactsSource")]
        public string ContactsSource { get; set; }

        [JsonPropertyName("Contacts")]
        public string Contacts { get; set; }

        [JsonPropertyName("SecurityLicense")]
        public string SecurityLicense { get; set; }

        [JsonPropertyName("SecurityUser")]
        public string SecurityUser { get; set; }

        [JsonPropertyName("SecurityBasePin")]
        public string SecurityBasePin { get; set; }

        [JsonPropertyName("SecurityTrustedCert")]
        public string SecurityTrustedCert { get; set; }

        [JsonPropertyName("SecurityServerCert")]
        public string SecurityServerCert { get; set; }

        [JsonPropertyName("SecurityGenerateCSR")]
        public string SecurityGenerateCSR { get; set; }

        [JsonPropertyName("Security")]
        public string Security { get; set; }

        [JsonPropertyName("AppsBroadsoftXSI")]
        public string AppsBroadsoftXSI { get; set; }

        [JsonPropertyName("AppsBroadsoftXMPP")]
        public string AppsBroadsoftXMPP { get; set; }

        [JsonPropertyName("Apps")]
        public string Apps { get; set; }

        [JsonPropertyName("TestMode")]
        public string TestMode { get; set; }

        [JsonPropertyName("ActionUri")]
        public string ActionUri { get; set; }

        [JsonPropertyName("MainHidden")]
        public string MainHidden { get; set; }
    }

    public class WuiCommonAccessoriesUpgrade
    {
        [JsonPropertyName("bHandsetUpgrading")]
        public bool BHandsetUpgrading { get; set; }

        [JsonPropertyName("bHeadsetUpgrading")]
        public bool BHeadsetUpgrading { get; set; }
    }

    public class WuiCommonBthInfo
    {
    }

    public class WuiCommonCertsAlertInfo
    {
        [JsonPropertyName("warnTrustedCert")]
        public int WarnTrustedCert { get; set; }

        [JsonPropertyName("expiredTrustedCert")]
        public int ExpiredTrustedCert { get; set; }

        [JsonPropertyName("warnServerCert")]
        public int WarnServerCert { get; set; }

        [JsonPropertyName("expiredServerCert")]
        public int ExpiredServerCert { get; set; }
    }

    public class WuiCommonDefPasswordInfo
    {
        [JsonPropertyName("bForceChangePwd")]
        public bool BForceChangePwd { get; set; }

        [JsonPropertyName("defPwdUsername")]
        public string DefPwdUsername { get; set; }
    }

    public class WuiCommonLevelMap
    {
        [JsonPropertyName("pages")]
        public Pages Pages { get; set; }

        [JsonPropertyName("items")]
        public Items Items { get; set; }
    }

    public class WuiCommonResSizeLimit
    {
        [JsonPropertyName("ringtone")]
        public string Ringtone { get; set; }

        [JsonPropertyName("wallpaper")]
        public string Wallpaper { get; set; }

        [JsonPropertyName("screensaver")]
        public string Screensaver { get; set; }

        [JsonPropertyName("photo")]
        public string Photo { get; set; }

        [JsonPropertyName("contactxml")]
        public string Contactxml { get; set; }

        [JsonPropertyName("contactcsv")]
        public string Contactcsv { get; set; }

        [JsonPropertyName("vpn")]
        public string Vpn { get; set; }

        [JsonPropertyName("eapdev")]
        public string Eapdev { get; set; }

        [JsonPropertyName("eapca")]
        public string Eapca { get; set; }

        [JsonPropertyName("license")]
        public string License { get; set; }

        [JsonPropertyName("servercert")]
        public string Servercert { get; set; }

        [JsonPropertyName("trustedcert")]
        public string Trustedcert { get; set; }

        [JsonPropertyName("lcdlogo")]
        public string Lcdlogo { get; set; }

        [JsonPropertyName("rsaprikey")]
        public string Rsaprikey { get; set; }

        [JsonPropertyName("adblicense")]
        public string Adblicense { get; set; }
    }

    public class WuiDeviceHeadsetFeatureSet
    {
        [JsonPropertyName("logExport")]
        public bool LogExport { get; set; }

        [JsonPropertyName("upgrade")]
        public bool Upgrade { get; set; }
    }
    
}