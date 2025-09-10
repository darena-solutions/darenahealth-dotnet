using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Coverage Payor
/// https://hl7.org/fhir/R4/coverage.html
/// </summary>
public class CoverageClass
{
    /// <summary>
    /// Gets or sets the coverage class type such as 'group' or 'plan'
    /// </summary>
    public CoverageClassType Type { get; set; }

    /// <summary>
    /// Gets or sets the coverage class number
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Gets or sets the coverage class name
    /// </summary>
    public string Name { get; set; }
}
