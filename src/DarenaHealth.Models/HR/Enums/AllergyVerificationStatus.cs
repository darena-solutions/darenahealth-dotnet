namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Allergy Verification Status
/// https://hl7.org/fhir/R4/valueset-allergyintolerance-clinical.html
/// </summary>
public enum AllergyVerificationStatus
{
    /// <summary>
    /// A low level of certainty about the propensity for a reaction to the identified substance.
    /// </summary>
    Unconfirmed = 0,

    /// <summary>
    /// A high level of certainty about the propensity for a reaction to the identified substance, which may include clinical evidence by testing or rechallenge.
    /// </summary>
    Confirmed = 1,

    /// <summary>
    /// TA propensity for a reaction to the identified substance has been disputed or disproven with a sufficient level of clinical certainty to justify invalidating the assertion. This might or might not include testing or rechallenge.
    /// </summary>
    Refuted = 2,

    /// <summary>
    /// The statement was entered in error and is not valid.
    /// </summary>
    Error = 3,
}