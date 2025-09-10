using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent an immunization resource
/// </summary>
public class Immunization : PatientBase
{
    /// <summary>
    /// Gets or sets the current status of the immunization
    /// </summary>
    public ImmunizationStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the immunization product details
    /// </summary>
    public ProductDetails Product { get; set; }

    /// <summary>
    /// Gets or sets the administration details
    /// </summary>
    public Administration Administration { get; set; }

    /// <summary>
    /// Gets or sets the NPI of the provider that created this immunization
    /// </summary>
    public string ProviderNpi { get; set; }

    /// <summary>
    /// Gets or sets the instructions required for this immunization
    /// </summary>
    public Instructions Instructions { get; set; }

    /// <summary>
    /// Gets or sets the reason text if this immunization was refused
    /// </summary>
    public string RefusalReason { get; set; }
        
    /// <summary>
    /// Gets or sets the context the data was recorded in i.e confirms this is an authoritative record, not historical.
    /// </summary>
    public bool PrimarySource { get; set; }
}