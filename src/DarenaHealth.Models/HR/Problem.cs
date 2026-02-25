using System;
using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a problem
/// </summary>
public class Problem : PatientBase
{
    /// <summary>
    /// Gets or sets the ICD 10 Code
    /// </summary>
    public string Icd10Code { get; set; }

    /// <summary>
    /// Gets or sets the ICD 10 Code Description
    /// </summary>
    public string Icd10Description { get; set; }

    /// <summary>
    /// Gets or sets the target Site for Diagnosis
    /// </summary>
    public CodeValue TargetSite { get; set; }

    /// <summary>
    /// Gets or sets the severity of Diagnosis
    /// </summary>
    public CodeValue Severity { get; set; }

    /// <summary>
    /// Gets or sets the verification status of the problem
    /// </summary>
    public ProblemCategory Category { get; set; } = ProblemCategory.ProblemListItem;

    /// <summary>
    /// Gets or sets the verification status of the problem
    /// </summary>
    public ProblemVerificationStatus VerificationStatus { get; set; } = ProblemVerificationStatus.Confirmed;

    /// <summary>
    /// Gets or sets the clinical status of the problem
    /// </summary>
    public ProblemClinicalStatus ClinicalStatus { get; set; } = ProblemClinicalStatus.Active;

    /// <summary>
    /// Gets or sets the patient id
    /// </summary>
    public string PatientId { get; set; }

    /// <summary>
    /// Date of when problem was first recorded
    /// </summary>
    public DateTime RecordedDate { get; set; }

    /// <summary>
    /// Category codes used in the US Core Condition Screening Assessment Profile to help identify the type of USCDI Health Status/Assessment data class being reported.
    /// </summary>
    public ProblemScreeningAssessment? ProblemScreeningAssessment { get; set; }

    /// <summary>
    /// Gets or sets the problem body site
    /// </summary>
    public List<CodeValue> BodySite { get; set; }

    /// <summary>
    /// Problem Stage
    /// </summary>
    public List<ProblemStage> Stage { get; set; }

    /// <summary>
    /// Problem Evidence
    /// </summary>
    public List<ProblemEvidence> Evidence { get; set; }

    /// <summary>
    /// Problem stage
    /// </summary>
    public class ProblemStage
    {
        /// <summary>
        /// problem stage summary
        /// </summary>
        public CodeValue Summary { get; set; }

        /// <summary>
        /// problem stage assessment reference
        /// </summary>
        public AssessmentReference Assessment { get; set; }

        /// <summary>
        /// Document Author
        /// </summary>
        public class AssessmentReference
        {
            /// <summary>
            /// Gets or sets id of assessment
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// Gets or sets type of assessment
            /// </summary>
            public AssessmentType Type { get; set; }
        }

        /// <summary>
        /// Type of stage assessment
        /// </summary>
        public enum AssessmentType
        {
            /// <summary>
            /// Observation
            /// </summary>
            Observation,
        }
    }

    /// <summary>
    /// Problem Evidence
    /// </summary>
    public class ProblemEvidence
    {
        /// <summary>
        /// problem evidence codes
        /// </summary>
        public List<CodeValue> Code { get; set; }

        /// <summary>
        /// problem evidence detail
        /// </summary>
        public List<DetailReference> Detail { get; set; }

        /// <summary>
        /// Evidence detail
        /// </summary>
        public class DetailReference
        {
            /// <summary>
            /// Gets or sets id of detail
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// Gets or sets type of detail
            /// </summary>
            public DetailType Type { get; set; }
        }

        /// <summary>
        /// Type of evidence detail
        /// </summary>
        public enum DetailType
        {
            /// <summary>
            /// Observation
            /// </summary>
            Observation,

            /// <summary>
            /// Document/Media
            /// </summary>
            Document,
        }
    }
}
