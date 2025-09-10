using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent an observation resource
/// </summary>
public class Observation : PatientBase
{
    /// <summary>
    /// Gets or sets the coded values for reason for a missing observation
    /// </summary>
    public CodeValue DataAbsentReason { get; set; }

    /// <summary>
    /// Gets or sets the coded value
    /// </summary>
    public CodeValue ValueCodeValue { get; set; }

    /// <summary>
    /// Gets or sets the period
    /// </summary>
    public TimeRange ValuePeriod { get; set; }

    /// <summary>
    /// Gets or sets the string value
    /// </summary>
    public string ValueString { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this observation's outcome was <c>true</c> or <c>false</c>
    /// </summary>
    public bool ValueBoolean { get; set; }

    /// <summary>
    /// Gets or sets the quantity value
    /// </summary>
    public Quantity ValueQuantity { get; set; }

    /// <summary>
    /// Gets or sets the observation type
    /// </summary>
    public ObservationType AssessmentType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this observation is used to identity the absence of an observation
    /// </summary>
    public bool NegationInd { get; set; }

    /// <summary>
    /// Gets or sets the group code
    /// </summary>
    public string GroupId { get; set; }

    /// <summary>
    /// Gets or sets the mood code
    /// </summary>
    public string MoodCode { get; set; }

    /// <summary>
    /// Gets or sets the author id
    /// </summary>
    public string AuthorId { get; set; }

    /// <summary>
    /// Gets or sets the status code
    /// </summary>
    public string StatusCode { get; set; }
}