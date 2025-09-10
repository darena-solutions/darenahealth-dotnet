namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Problem / Condition Category
/// https://hl7.org/fhir/R4/valueset-medicationrequest-category.html
/// </summary>
public enum MedicationRequestCategory
{
    /// <summary>
    /// Includes requests for medications to be administered or consumed in an inpatient or acute care setting
    /// </summary>
    Inpatient = 0,

    /// <summary>
    /// Includes requests for medications to be administered or consumed in an outpatient setting (for example, Emergency Department, Outpatient Clinic, Outpatient Surgery, Doctor's office)
    /// </summary>
    Outpatient = 1,

    /// <summary>
    /// Includes requests for medications to be administered or consumed by the patient in their home (this would include long term care or nursing homes, hospices, etc.)
    /// </summary>
    Community = 2,
        
    /// <summary>
    /// Includes requests for medications created when the patient is being released from a facility
    /// </summary>
    Discharge = 3,
}