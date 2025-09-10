namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// The different care plan types
/// </summary>
public enum CarePlanType
{
    /// <summary>
    /// Diet Plan for the patient to consume food of a specified nature
    /// </summary>
    Diet,

    /// <summary>
    /// Drug Plan for the patient to consume/receive a drug,vaccine or other product
    /// </summary>
    Drug,

    /// <summary>
    /// Encounter Plan to meet or communicate with the patient(in-patient, out-patient,phone call,etc.)
    /// </summary>
    Encounter,

    /// <summary>
    /// Observation Plan to capture information about a patient(vitals,labs,diagnostic images,etc.)
    /// </summary>
    Observation,

    /// <summary>
    /// Procedure Plan to modify the patient in some way(surgery,physiotherapy,education,counseling,etc.)
    /// </summary>
    Procedure,

    /// <summary>
    /// Supply Plan to provide something to the patient(medication,medical supply,etc.)
    /// </summary>
    Supply,

    /// <summary>
    /// Other Some other form of action
    /// </summary>
    Other
}