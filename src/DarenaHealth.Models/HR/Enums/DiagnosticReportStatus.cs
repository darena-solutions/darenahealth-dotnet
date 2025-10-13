namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// DiagnosticReport Status
/// https://hl7.org/fhir/R4/valueset-diagnostic-report-status.html
/// </summary>
public enum DiagnosticReportStatus
{
    /// <summary>
    /// The existence of the report is registered, but there is nothing yet available.
    /// </summary>
    Registered = 0,

    /// <summary>
    /// This is a partial (e.g. initial, interim or preliminary) report: data in the report may be incomplete or unverified.
    /// </summary>
    Partial = 1,

    /// <summary>
    /// Verified early results are available, but not all results are final.
    /// </summary>
    Preliminary = 2,

    /// <summary>
    /// The report is complete and verified by an authorized person.
    /// </summary>
    Final = 3,

    /// <summary>
    /// Subsequent to being final, the report has been modified. This includes any change in the results, diagnosis, narrative text, or other content of a report that has been issued.
    /// </summary>
    Amended = 4,

    /// <summary>
    /// Subsequent to being final, the report has been modified to correct an error in the report or referenced results.
    /// </summary>
    Corrected = 5,

    /// <summary>
    /// Subsequent to being final, the report has been modified by adding new content. The existing content is unchanged.
    /// </summary>
    Appended = 6,

    /// <summary>
    /// The report is unavailable because the measurement was not started or not completed (also sometimes called "aborted").
    /// </summary>
    Cancelled = 7,

    /// <summary>
    /// The report has been withdrawn following a previous final release. This electronic record should never have existed, though it is possible that real-world decisions were based on it. (If real-world activity has occurred, the status should be "cancelled" rather than "entered-in-error".).
    /// </summary>
    EnteredinError = 8,

    /// <summary>
    /// The authoring/source system does not know which of the status values currently applies for this observation. Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, but the authoring/source system does not know which.
    /// </summary>
    Unknown = 9
}
