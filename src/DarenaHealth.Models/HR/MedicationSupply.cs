namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a medication supply item
/// </summary>
public class MedicationSupply
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MedicationSupply"/> class
    /// </summary>
    /// <param name="id">The id of the medication supply</param>
    /// <param name="medicationCodeValue">The code value of the medication</param>
    /// <param name="quantity">The quantity</param>
    /// <param name="unit">The unit</param>
    /// <param name="repeat">The number of times to repeat the medication. (Default: '0')</param>
    public MedicationSupply(string id, CodeValue medicationCodeValue, double quantity, string unit, int repeat = 0)
    {
        Id = id;
        MedicationCodeValue = medicationCodeValue;
        Quantity = quantity;
        Unit = unit;
        Repeat = repeat;
    }

    /// <summary>
    /// Gets or sets the id of medication supply
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the code value for medication
    /// </summary>
    public CodeValue MedicationCodeValue { get; set; }

    /// <summary>
    /// Gets or sets the quantity of medication
    /// </summary>
    public double Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit of medication quantity
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// Gets or sets the number of times to repeat medication
    /// </summary>
    public int Repeat { get; set; }
}