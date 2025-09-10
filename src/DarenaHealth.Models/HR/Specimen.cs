namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a specimen
/// </summary>
public class Specimen
{
    /// <summary>
    /// Gets or sets the id of specimen
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the coded Value
    /// </summary>
    public CodeValue CodeValue { get; set; }
}