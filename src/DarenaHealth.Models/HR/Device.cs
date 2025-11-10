using System;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a device resource
/// https://hl7.org/fhir/R4/device.html
/// </summary>
public class Device : PatientBase
{
    /// <summary>
    /// Gets or sets the device type associated with this resource
    /// </summary>
    public DeviceType? Type { get; set; }

    /// <summary>
    /// Gets or sets the anatomical site or structure where the diagnosis/problem manifests itself
    /// or is the focus of the action represented by the device type.
    /// </summary>
    public string AnatomicalLocationSite { get; set; }

    /// <summary>
    /// Gets or sets the time the data element was entered into the clinical software.
    /// </summary>
    public DateTime? AuthoredOn { get; set; }
        
    /// <summary>
    /// Gets or sets the Unique Device Identifier (UDI) Barcode string
    /// </summary>
    public DeviceUdiCarrier Carrier { get; set; }
        
    /// <summary>
    /// Gets or sets The distinct identification string
    /// </summary>
    public string DistinctId { get; set; }
        
    /// <summary>
    /// Gets or sets the Lot number of manufacture
    /// </summary>
    public string LotNumber { get; set; }
        
    /// <summary>
    /// Gets or sets the Serial number assigned by the manufacturer
    /// </summary>
    public string SerialNumber { get; set; }
        
    /// <summary>
    /// Gets or sets the Assigning Authority of the device (FDA/other)
    /// </summary>
    public string AssigningAuthority { get; set; }
}