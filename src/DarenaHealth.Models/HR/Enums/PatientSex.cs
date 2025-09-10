namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Patient Sex
/// http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex
/// </summary>
public enum PatientSex
{
    /// <summary>
    /// Male
    /// </summary>
    Male = 0,
    
    /// <summary>
    /// Female
    /// </summary>
    Female = 1,
    
    /// <summary>
    /// Patient Sex Unknown
    /// </summary>
    Unknown = 2,
    
    /// <summary>
    /// Asked Declined
    /// </summary>
    Declined = 3,
}