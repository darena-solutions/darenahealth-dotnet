namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a payer
/// </summary>
public class Payer : PatientBase
{
      
    /// <summary>
    /// Gets or sets the coded Value for payer
    /// </summary>
    public CodeValue Value { get; set; }
}