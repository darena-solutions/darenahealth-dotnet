using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Coverage Payor
/// https://hl7.org/fhir/R4/coverage.html
/// </summary>
public class CoveragePayor
{
    /// <summary>
    /// Gets or sets the payor reference id
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or sets the payor reference type
    /// </summary>
    public CoveragePayorType Type { get; set; }
}