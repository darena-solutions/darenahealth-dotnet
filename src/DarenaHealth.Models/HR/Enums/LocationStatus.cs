
namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// https://hl7.org/fhir/R4/valueset-location-status.html
/// </summary>
public enum LocationStatus
{

    /// <summary>
    /// The location is operational.	
    /// </summary>
    Active = 0,

    /// <summary>
    /// The location is temporarily closed.	
    /// </summary>
    Suspended = 1,

    /// <summary>
    /// The location is no longer used.	
    /// </summary>
    Inactive = 2,
}