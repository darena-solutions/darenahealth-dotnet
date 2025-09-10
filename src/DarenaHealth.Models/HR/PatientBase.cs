using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The base class that all patient related models must inherit from
/// </summary>
public class PatientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatientBase"/> class
    /// </summary>
    protected PatientBase()
    {
        Identifiers = new List<Identifier>();
    }

    /// <summary>
    /// Gets or sets the identifier for the patient data element
    /// </summary>
    public List<Identifier> Identifiers { get; set; }

    /// <summary>
    /// Gets or sets the time period for the patient data
    /// </summary>
    public TimeRange Period { get; set; }

    /// <summary>
    /// Gets or sets the coded value for the patient data
    /// </summary>
    public CodeValue CodeValue { get; set; }

    /// <summary>
    /// Gets or sets the coded value for a missing action or observation
    /// </summary>
    public CodeValue NotDoneReason { get; set; }

    /// <summary>
    /// Gets or sets the coded value for the reason
    /// </summary>
    public CodeValue ReasonCodeValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the action or observation was done
    /// </summary>
    public bool NotDone { get; set; }

    /// <summary>
    /// To be used as resource id for all elements
    /// </summary>
    public string ResourceId { get; set; }
}