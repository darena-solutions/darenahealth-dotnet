namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents instructions for taking a medication
/// </summary>
public class Instructions
{
    /// <summary>
    /// Gets or sets the code value
    /// </summary>
    public CodeValue CodeValue { get; set; }

    /// <summary>
    /// Gets or sets the free text
    /// </summary>
    public string FreeText { get; set; }
}