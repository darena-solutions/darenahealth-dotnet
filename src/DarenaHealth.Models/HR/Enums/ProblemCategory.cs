namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Problem / Condition Category
/// https://hl7.org/fhir/R4/valueset-condition-category.html
/// https://hl7.org/fhir/us/core/STU8/ValueSet-us-core-problem-or-health-concern.html
/// </summary>
public enum ProblemCategory
{
    /// <summary>
    /// An item on a problem list that can be managed over time and can be expressed by a practitioner (e.g. physician, nurse), patient, or related person.
    /// </summary>
    ProblemListItem = 0,

    /// <summary>
    /// A point in time diagnosis (e.g. from a physician or nurse) in context of an encounter.
    /// </summary>
    EncounterDiagnosis = 1,

    /// <summary>
    /// Additional health concerns from other stakeholders
    /// </summary>
    HealthConcern = 2,
}