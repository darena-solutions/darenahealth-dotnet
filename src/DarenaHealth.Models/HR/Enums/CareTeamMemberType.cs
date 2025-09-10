namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// The different types of participation's
/// https://hl7.org/fhir/R4/careteam.html
/// </summary>
public enum CareTeamMemberType
{
    /// <summary>
    /// The practitioner who is responsible for admitting a patient to a patient encounter.
    /// </summary>
    Practitioner = 0,

    /// <summary>
    /// The practitioner that has responsibility for overseeing a patient's care during a patient encounter.
    /// </summary>
    PractitionerRole = 1,

    /// <summary>
    /// A person or organization who should be contacted for follow-up questions about the act in place of the author.
    /// </summary>
    Organization = 2,

    /// <summary>
    /// An advisor participating in the service by performing evaluations and making recommendations.
    /// </summary>
    Patient = 3,

    /// <summary>
    /// The practitioner who is responsible for the discharge of a patient from a patient encounter.
    /// </summary>
    RelatedPerson = 4,

}