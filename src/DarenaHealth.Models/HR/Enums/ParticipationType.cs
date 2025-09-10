namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// The different types of participation's
/// </summary>
public enum ParticipationType
{
    /// <summary>
    /// The practitioner who is responsible for admitting a patient to a patient encounter.
    /// </summary>
    Admitter = 0,

    /// <summary>
    /// The practitioner that has responsibility for overseeing a patient's care during a patient encounter.
    /// </summary>
    Attender = 1,

    /// <summary>
    /// A person or organization who should be contacted for follow-up questions about the act in place of the author.
    /// </summary>
    CallbackContact = 2,

    /// <summary>
    /// An advisor participating in the service by performing evaluations and making recommendations.
    /// </summary>
    Consultant = 3,

    /// <summary>
    /// The practitioner who is responsible for the discharge of a patient from a patient encounter.
    /// </summary>
    Discharger = 4,

    /// <summary>
    /// Only with Transportation services. A person who escorts the patient.
    /// </summary>
    Escort = 5,

    /// <summary>
    /// A person having referred the subject of the service to the performer (referring physician). Typically, a referring physician will receive a report.
    /// </summary>
    Referrer = 6,

    /// <summary>
    /// A translator who is facilitating communication with the patient during the encounter.
    /// </summary>
    Translator = 7,

    /// <summary>
    /// A person to be contacted in case of an emergency during the encounter.
    /// </summary>
    Emergency = 8,
}