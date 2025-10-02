namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// <see cref="Observation"/> with <see cref="Observation.AssessmentType"/> of <see cref="ObservationType.Survey"/>
/// https://hl7.org/fhir/us/core/STU6.1/ValueSet-us-core-screening-assessment-observation-category.html
/// </summary>
public enum ObservationScreeningAssessment
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
    /// Cognitive Status category
    /// </summary>
    CognitiveStatus = 103,
}
