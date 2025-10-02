
namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Type of observation component
/// </summary>
public enum ObservationComponent
{
    /// <summary>
    /// http://loinc.org - 86188-0 https://hl7.org/fhir/us/core/STU6.1/StructureDefinition-us-core-observation-occupation.html
    /// </summary>
    Industry = 0,

    /// <summary>
    /// http://loinc.org - 8480-6 https://hl7.org/fhir/us/core/STU6.1/StructureDefinition-us-core-blood-pressure.html
    /// </summary>
    Systolic = 1,

    /// <summary>
    /// http://loinc.org - 8462-4 https://hl7.org/fhir/us/core/STU6.1/StructureDefinition-us-core-blood-pressure.html
    /// </summary>
    Diastolic = 2,

    /// <summary>
    /// http://loinc.org - 3151-8 https://hl7.org/fhir/us/core/STU6.1/StructureDefinition-us-core-pulse-oximetry.html
    /// </summary>
    FlowRate = 3,

    /// <summary>
    /// http://loinc.org - 3150-0 https://hl7.org/fhir/us/core/STU6.1/StructureDefinition-us-core-pulse-oximetry.html
    /// </summary>
    Concentration = 4,

}
