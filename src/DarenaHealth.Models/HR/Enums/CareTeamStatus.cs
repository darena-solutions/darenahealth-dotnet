namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Care Team Status
/// https://hl7.org/fhir/R4/valueset-care-team-status.html
/// </summary>
public enum CareTeamStatus
{
    /// <summary>
    /// The care team has been drafted and proposed, but not yet participating in the coordination and delivery of patient care.	
    /// </summary>
    Proposed = 0,

    /// <summary>
    /// The care team is currently participating in the coordination and delivery of care.	
    /// </summary>
    Active = 1,

    /// <summary>
    /// The care team is temporarily on hold or suspended and not participating in the coordination and delivery of care.	
    /// </summary>
    Suspended = 2,

    /// <summary>
    /// The care team was, but is no longer, participating in the coordination and delivery of care.	
    /// </summary>
    Inactive = 3,

    /// <summary>
    /// The care team should have never existed.	
    /// </summary>
    Error = 4,
}