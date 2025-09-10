namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Immunization Status
/// https://hl7.org/fhir/R4/valueset-immunization-status.html
/// </summary>
public enum ImmunizationStatus
{
    /// <summary>
    /// The event has now concluded.
    /// </summary>
    Completed = 0,

    /// <summary>
    /// This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be "stopped" rather than "entered-in-error".).
    /// </summary>
    EnteredInError = 1,

    /// <summary>
    /// The event was terminated prior to any activity beyond preparation. I.e. The 'main' activity has not yet begun. The boundary between preparatory and the 'main' activity is context-specific.
    /// </summary>
    NotDone = 2,
}