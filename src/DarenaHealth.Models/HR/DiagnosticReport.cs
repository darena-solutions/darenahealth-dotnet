using System;
using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a Diagnostic Report
/// </summary>
public class DiagnosticReport : PatientBase
{
    /// <summary>
    /// Gets or sets the diagnostic report status
    /// </summary>
    public DiagnosticReportStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the diagnostic report category
    /// </summary>
    public CodeValue Category { get; set; }

    /// <summary>
    /// Gets or sets the diagnostic report effective date
    /// </summary>
    public DateTime EffectiveDate { get; set; }

    /// <summary>
    /// Gets or sets the diagnostic report issued date
    /// </summary>
    public DateTime IssuedAt { get; set; }

    /// <summary>
    /// Gets or sets Responsible Diagnostic Service references
    /// </summary>
    public List<DiagnosticReportPerformer> Performers { get; set; }

    /// <summary>
    /// Gets or sets the diagnostic report result references
    /// </summary>
    public List<string> Results { get; set; }

    /// <summary>
    /// Gets or sets the list Entire reports as issued
    /// </summary>
    public List<DiagnosticReportAttachment> Reports { get; set; }

    /// <summary>
    /// The model that represents a diagnostic report performer
    /// </summary>
    public class DiagnosticReportPerformer
    {
        /// <summary>
        /// Gets or sets the participant id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the performer type
        /// </summary>
        public DiagnosticReportPerformerType Type { get; set; }
    }

    /// <summary>
    /// The model that represents a diagnostic report attachment
    /// </summary>
    public class DiagnosticReportAttachment
    {
        /// <summary>
        /// Gets or sets the text content of the report
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the attachment content type
        /// </summary>
        public string ContentType { get; set; }
    }

    /// <summary>
    /// The different types of participation's
    /// https://hl7.org/fhir/R4/diagnosticreport.html
    /// </summary>
    public enum DiagnosticReportPerformerType
    {
        /// <summary>
        /// Practitioner
        /// </summary>
        Practitioner = 0,

        /// <summary>
        /// PractitionerRole
        /// </summary>
        PractitionerRole = 1,

        /// <summary>
        /// Organization
        /// </summary>
        Organization = 2,

        /// <summary>
        /// CareTeam
        /// </summary>
        CareTeam = 3,
    }
}
