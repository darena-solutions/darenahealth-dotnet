namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Allergy Clinical Status
/// https://hl7.org/fhir/R4/valueset-allergyintolerance-clinical.html
/// </summary>
public enum AllergyClinicalStatus
{
    /// <summary>
    /// The subject is currently experiencing, or is at risk of, a reaction to the identified substance.
    /// </summary>
    Active = 0,

    /// <summary>
    /// The subject is no longer at risk of a reaction to the identified substance.
    /// </summary>
    Inactive = 1,

    /// <summary>
    /// 	A reaction to the identified substance has been clinically reassessed by testing or re-exposure and is considered no longer to be present. Re-exposure could be accidental, unplanned, or outside of any clinical setting.
    /// </summary>
    Resolved = 2,
}