using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a participant
/// </summary>
public class CareTeamParticipant
{
    /// <summary>
    /// Gets or sets the participant id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the code value for participant type / role
    /// https://hl7.org/fhir/R4/valueset-participant-role.html
    /// </summary>
    public CodeValue CodeValue { get; set; }

    /// <summary>
    /// Gets or sets the type member
    /// </summary>
    public CareTeamMemberType Type { get; set; }
}