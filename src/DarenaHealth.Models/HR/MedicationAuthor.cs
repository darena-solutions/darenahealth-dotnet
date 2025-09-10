using System;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents an author of a medication
/// </summary>
public class MedicationAuthor
{
    /// <summary>
    /// Gets or sets the date time the medication was authored
    /// </summary>
    public DateTime Time { get; set; }

    /// <summary>
    /// Gets or sets the assigned author id
    /// </summary>
    public string AssignedAuthorId { get; set; }
}