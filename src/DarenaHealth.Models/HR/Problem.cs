using System;
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
    /// Gets or sets the text for describing problem
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets the patient id
    /// </summary>
    public string PatientId { get; set; }

    /// <summary>
    /// Date of When in resolution/remission
    /// </summary>
    public DateTime AbatementDateTime {get;set;}

    /// <summary>
    /// Date of When in resolution/remission
    /// </summary>
    public DateTime RecordedDate { get; set; }

    /// <summary>
    /// Category codes used in the US Core Condition Screening Assessment Profile to help identify the type of USCDI Health Status/Assessment data class being reported.
    /// </summary>
    public ProblemScreeningAssessment? ProblemScreeningAssessment { get; set; }

}