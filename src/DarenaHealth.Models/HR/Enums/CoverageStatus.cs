namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Coverage Status
/// https://hl7.org/fhir/R4/valueset-fm-status.html
/// </summary>
public enum CoverageStatus
{
    /// <summary>
    /// The instance is currently in-force.
    /// </summary>
    Active = 0,

    /// <summary>
    /// The instance is withdrawn, rescinded or reversed.
    /// </summary>
    Cancelled = 1,

    /// <summary>
    /// A new instance the contents of which is not complete.
    /// </summary>
    Draft = 2,

    /// <summary>
    /// The instance was entered in error.
    /// </summary>
    EnteredInError = 3
}
