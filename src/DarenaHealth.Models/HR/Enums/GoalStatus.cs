namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Goal Life Cycle Status
/// https://hl7.org/fhir/R4/valueset-goal-status.html
/// </summary>
public enum GoalStatus
{
    /// <summary>
    /// A goal is proposed for this patient.
    /// </summary>
    Proposed = 0,

    /// <summary>
    /// A goal is planned for this patient.
    /// </summary>
    Planned = 1,

    /// <summary>
    /// A proposed goal was accepted or acknowledged.
    /// </summary>
    Accepted = 2,

    /// <summary>
    /// The goal is being sought actively.
    /// </summary>
    Active = 3,

    /// <summary>
    /// The goal remains a long term objective but is no longer being actively pursued for a temporary period of time.	
    /// </summary>
    OnHold = 4,

    /// <summary>
    /// The goal is no longer being sought.	
    /// </summary>
    Completed = 5,

    /// <summary>
    /// The goal has been abandoned.	
    /// </summary>
    Cancelled = 6,

    /// <summary>
    /// The goal was entered in error and voided.	
    /// </summary>
    EnteredInError = 7,

    /// <summary>
    /// A proposed goal was rejected.	
    /// </summary>
    Rejected = 8,
}