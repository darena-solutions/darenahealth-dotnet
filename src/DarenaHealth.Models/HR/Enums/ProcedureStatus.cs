namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Procedure Status
/// </summary>
public enum ProcedureStatus
{
    /// <summary>
    /// unknown: The authoring/source system does not know which of the status values currently applies for this event. Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, but the authoring/source system does not know which.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// preparation: The core event has not started yet, but some staging activities have begun (e.g. surgical suite preparation). Preparation stages may be tracked for billing purposes.
    /// </summary>
    Preparation = 1,

    /// <summary>
    /// in-progress: The event is currently occurring.
    /// </summary>
    InProgress = 2,

    /// <summary>
    /// not-done: The event was terminated prior to any activity beyond preparation. I.e. The 'main' activity has not yet begun. The boundary between preparatory and the 'main' activity is context-specific.
    /// </summary>
    NotDone = 3,

    /// <summary>
    /// on-hold: The event has been temporarily stopped but is expected to resume in the future.
    /// </summary>
    OnHold = 4,

    /// <summary>
    /// stopped: The event was terminated prior to the full completion of the intended activity but after at least some of the 'main' activity (beyond preparation) has occurred.
    /// </summary>
    Stopped = 5,

    /// <summary>
    /// completed: The event has now concluded.
    /// </summary>
    Completed = 6,

    /// <summary>
    /// entered-in-error: This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be "stopped" rather than "entered-in-error".).
    /// </summary>
    EnteredInError = 7,
}
