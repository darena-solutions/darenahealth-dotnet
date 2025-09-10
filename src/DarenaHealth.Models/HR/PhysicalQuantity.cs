namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a physical quantity
/// </summary>
public class PhysicalQuantity
{
    /// <summary>
    /// Gets or sets the type of physical quantity
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the unit of physical quantity
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Gets or sets the value of physical quantity
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the range of values are inclusive
    /// </summary>
    public bool Inclusive { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the quantity is derived
    /// </summary>
    public bool Derived { get; set; }
}