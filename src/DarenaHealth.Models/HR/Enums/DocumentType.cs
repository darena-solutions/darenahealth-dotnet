
namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Type of document. https://build.fhir.org/ig/HL7/US-Core/ValueSet-us-core-clinical-note-type.html
/// </summary>
public enum DocumentType
{
    /// <summary>
    /// Discharge summary
    /// </summary>
    DischargeSummary = 0,

    /// <summary>
    /// Consult note
    /// </summary>
    ConsultNote = 1,

    /// <summary>
    /// History and physical note
    /// </summary>
    HistoryAndPhysicalNote = 2,

    /// <summary>
    /// Progress note
    /// </summary>
    ProgressNote = 3,

    /// <summary>
    /// Procedure note
    /// </summary>
    ProcedureNote = 4,

    /// <summary>
    /// Diagnostic imaging study
    /// </summary>
    DiagnosticImagingStudy = 5,

    /// <summary>
    /// Laboratory report
    /// </summary>
    LaboratoryReport = 6,

    /// <summary>
    /// Pathology study
    /// </summary>
    PathologyStudy = 7,

    /// <summary>
    /// Surgical operation note
    /// </summary>
    SurgicalOperationNote = 8,

    /// <summary>
    /// Emergency department Note
    /// </summary>
    EmergencyDepartmentNote = 9,

    /// <summary>
    /// Summary of episode note
    /// </summary>
    SummaryOfEpisodeNote = 10

}
