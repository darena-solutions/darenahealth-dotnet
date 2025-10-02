using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a Goal resource
/// </summary>
public class Goal : PatientBase
{
    /// <summary>
    /// Gets or sets the status of the Goal
    /// </summary>
    public GoalStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the text description of the goal, this can be specified instead of the CodeValue
    /// </summary>
    public string Text { get; set; }
}
