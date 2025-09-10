namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents and administration item
/// </summary>
public class Administration
{
    /// <summary>
    /// Gets or sets the route of administration of drug
    /// </summary>
    public CodeValue Route { get; set; }

    /// <summary>
    /// Gets or sets the drug form
    /// </summary>
    public CodeValue Form { get; set; }

    /// <summary>
    /// Gets or sets the dose of administration
    /// </summary>
    public PhysicalQuantity Dose { get; set; }

    /// <summary>
    /// Gets or sets the rate of administration
    /// </summary>
    public PhysicalQuantity Rate { get; set; }

    /// <summary>
    /// Gets or sets the interval
    /// </summary>
    public Interval Interval { get; set; }
}