using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a care plan resource
/// </summary>
public class CarePlan : PatientBase
{
    /// <summary>
    /// Gets or sets the care plan's coded entry category
    /// </summary>
    public CodeValue Category { get; set; }

    /// <summary>
    /// Gets or sets the type of care plan
    /// </summary>
    public CarePlanType CarePlanType { get; set; }

    /// <summary>
    /// Gets or sets the plan author
    /// </summary>
    public MedicationAuthor Author { get; set; }

    /// <summary>
    /// Gets or sets the plan text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Indicates whether the plan is currently being acted upon, represents future intentions or is now a historical record.
    /// </summary>
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Codes indicating the degree of authority/intentionality associated with a care plan
    /// </summary>
    public CarePlanIntent Intent { get; set; }

}