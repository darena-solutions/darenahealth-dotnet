using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a participant
/// </summary>
public class Participant
{
    /// <summary>
    /// Gets or sets the practitioner id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the code value for participant type
    /// </summary>
    public CodeValue CodeValue { get; set; }

    /// <summary>
    /// Gets or sets the type of participation
    /// </summary>
    public ParticipationType Type { get; set; }

    /// <summary>
    /// Gets or sets the string value for role class
    /// </summary>
    public string RoleClassCode { get; set; }

    /// <summary>
    /// Gets or sets the period of participation
    /// </summary>
    public TimeRange Period { get; set; }
}