namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// The different types of medication statement events
/// </summary>
public enum MedicationStatementEventType
{
    /// <summary>
    /// The event is a medication request
    /// </summary>
    MedicationRequest,

    /// <summary>
    /// The event is a medication dispensation
    /// </summary>
    MedicationDispense,

    /// <summary>
    /// The event is a medication administration
    /// </summary>
    MedicationAdministration,

    /// <summary>
    /// The event is a medication activity
    /// </summary>
    MedicationActivity,
        
    /// <summary>
    /// The event is a medication resource
    /// </summary>
    MedicationResource
}