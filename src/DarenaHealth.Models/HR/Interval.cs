namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a time interval
/// </summary>
public class Interval
{
    /// <summary>
    /// Gets or sets the period of the interval
    /// </summary>
    public PhysicalQuantity Period { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this interval has a frequency
    /// </summary>
    public bool Frequency { get; set; }
}