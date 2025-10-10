namespace SIPControl.Models;

public class ExtensionKeyDto
{
    public required int Index { get; set; }
    public string KeyName { get; set; }
    public string Type { get; set; }
    public string Value { get; set; }
    public string Label { get; set; }
    public string LineIndex { get; set; }
    public string ExtensionCode { get; set; }
    
    public bool CanEditExtension { get; set; }
    public bool CanEditLabel { get; set; }
    public bool CanEditValue { get; set; }
}