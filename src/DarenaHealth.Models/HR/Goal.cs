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
    /// Gets or sets The parameter whose value is being tracked
    /// </summary>
    public CodeValue Measure { get; set; }
}
