namespace DarenaHealth.Models.HR;

/// <summary>
/// Unique Device Identifier (UDI) Barcode string
/// </summary>
public class DeviceUdiCarrier
{
    /// <summary>
    /// Gets or sets Mandatory fixed portion of UDI
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or sets The UDI Human Readable Barcode String
    /// </summary>
    public string CarrierHrf { get; set; }
    
    /// <summary>
    /// Gets or sets the UDI Issuing Organization
    /// </summary>
    public string Issuer { get; set; }
}