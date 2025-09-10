using System;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a quantity
/// </summary>
public class Quantity
{
    /// <summary>
    /// Gets or sets the value of the quantity
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Gets or sets the unit of the quantity
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Gets or sets the system of quantity
    /// </summary>
    public Uri System { get; set; }

    /// <summary>
    /// Gets or sets the Code
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the coded value quantity
    /// </summary>
    public CodeValue CodeValue { get; set; }
}