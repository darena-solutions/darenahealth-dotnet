namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Service Request Status
/// </summary>
public enum RequestStatus
{
    /// <summary>
    /// The request has been created but is not yet complete or ready for action.
    /// </summary>
    Draft = 0,

    /// <summary>
    /// The request is in force and ready to be acted upon.
    /// </summary>
    Active = 1,

    /// <summary>
    /// The request (and any implicit authorization to act) has been temporarily withdrawn but is expected to resume in the future.
    /// </summary>
    OnHold = 2,

    /// <summary>
    /// The request (and any implicit authorization to act) has been terminated prior to the known full completion of the intended actions. No further activity should occur.
    /// </summary>
    Revoked = 3,

    /// <summary>
    /// The activity described by the request has been fully performed. No further activity will occur.
    /// </summary>
    Completed = 4,

    /// <summary>
    /// This request should never have existed and should be considered 'void'. (It is possible that real-world decisions were based on it. If real-world activity has occurred, the status should be "revoked" rather than "entered-in-error".).
    /// </summary>
    EnteredInError = 5,

    /// <summary>
    /// The authoring/source system does not know which of the status values currently applies for this request. Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, but the authoring/source system does not know which.
    /// </summary>
    Unknown = 6
}
