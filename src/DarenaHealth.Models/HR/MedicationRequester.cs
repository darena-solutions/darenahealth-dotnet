using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// MedicationRequest Requester
/// </summary>
public class MedicationRequester
{
    /// <summary>
    /// Gets or sets the requester id
    /// </summary>
    public string Id { get; set; }
        
    /// <summary>
    /// Gets or sets the requester type
    /// </summary>
    public MedicationRequesterType Type { get; set; }
}