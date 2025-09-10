namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Problem / Condition Verification Status
/// https://hl7.org/fhir/R4/valueset-condition-ver-status.html
/// </summary>
public enum ProblemVerificationStatus
{
    /// <summary>
    /// There is not sufficient diagnostic and/or clinical evidence to treat this as a confirmed condition.
    /// </summary>
    Unconfirmed = 0,

    /// <summary>
    /// This is a tentative diagnosis - still a candidate that is under consideration.
    /// </summary>
    Provisional = 1,

    /// <summary>
    /// One of a set of potential (and typically mutually exclusive) diagnoses asserted to further guide the diagnostic process and preliminary treatment.
    /// </summary>
    Differential = 2,

    /// <summary>
    /// There is sufficient diagnostic and/or clinical evidence to treat this as a confirmed condition.
    /// </summary>
    Confirmed = 3,

    /// <summary>
    /// This condition has been ruled out by diagnostic and clinical evidence.
    /// </summary>
    Refuted = 4,

    /// <summary>
    /// The statement was entered in error and is not valid.
    /// </summary>
    Error = 5,
}