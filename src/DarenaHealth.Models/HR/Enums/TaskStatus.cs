namespace DarenaHealth.Models.HR.Enums;

public enum TaskStatus
{
    /// <summary>
    /// The task is not yet ready to be acted upon.
    /// </summary>
    Draft = 0,

    /// <summary>
    /// The task is ready to be acted upon and action is sought.
    /// </summary>
    Requested = 1,

    /// <summary>
    /// A potential performer has claimed ownership of the task and is evaluating whether to perform it.
    /// </summary>
    Received = 2,

    /// <summary>
    /// The potential performer has agreed to execute the task but has not yet started work.
    /// </summary>
    Accepted = 3,

    /// <summary>
    /// The potential performer who claimed ownership of the task has decided not to execute it prior to performing any action.
    /// </summary>
    Rejected = 4,

    /// <summary>
    /// The task is ready to be performed, but no action has yet been taken. Used in place of requested/received/accepted/rejected when request assignment and acceptance is a given.
    /// </summary>
    Ready = 5,

    /// <summary>
    /// The task was not completed.
    /// </summary>
    Cancelled = 6,

    /// <summary>
    /// The task has been started but is not yet complete.
    /// </summary>
    InProgress = 7,

    /// <summary>
    /// The task has been started but work has been paused.
    /// </summary>
    OnHold = 8,

    /// <summary>
    /// The task was attempted but could not be completed due to some error.
    /// </summary>
    Failed = 9,

    /// <summary>
    /// The task has been completed.
    /// </summary>
    Completed = 10,

    /// <summary>
    /// The task should never have existed and is retained only because of the possibility it may have used.
    /// </summary>
    EnteredInError = 11
}