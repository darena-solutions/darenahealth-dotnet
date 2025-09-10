
namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// https://hl7.org/fhir/us/core/STU6.1/ValueSet-us-core-screening-assessment-condition-category.html
/// </summary>
public enum ProblemScreeningAssessment
{
    /// <summary>
    /// Social Determinants of Health category
    /// </summary>
    SDOH = 100,

    /// <summary>
    /// Functional Status category
    /// </summary>
    FunctionalStatus = 101,

    /// <summary>
    /// Disability Status category
    /// </summary>
    DisabilityStatus = 102,

    /// <summary>
    /// Cognitive Status category22
    /// </summary>
    CognitiveStatus = 103

}
