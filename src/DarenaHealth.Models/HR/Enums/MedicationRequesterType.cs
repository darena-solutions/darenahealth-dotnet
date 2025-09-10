namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Different types of MedicationRequest requesters
/// </summary>
public enum MedicationRequesterType
{
    /// <summary>
    /// Practitioner
    /// </summary>
    Practitioner = 0,
        
    /// <summary>
    /// Patient
    /// </summary>
    Patient = 1,
        
    /// <summary>
    /// Organization
    /// </summary>
    Organization = 2,
        
    /// <summary>
    /// PractitionerRole
    /// </summary>
    PractitionerRole = 3,
        
    /// <summary>
    /// RelatedPerson
    /// </summary>
    RelatedPerson = 4,
        
    /// <summary>
    /// Device
    /// </summary>
    Device = 5,
}