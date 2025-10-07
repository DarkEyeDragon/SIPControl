namespace SIPControl.Models;

public class PhoneDto
{
    public required string Id { get; set; }
    public string Name { get; set; }
    public string IpAddress { get; set; }
    public string Version { get; set; }
    public string MacAdress { get; set; }
    public DateTimeOffset DiscoveredAt { get; set; }
}