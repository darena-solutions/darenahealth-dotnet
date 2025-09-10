namespace DarenaHealth.Models.HR.Enums;

/// <summary>
/// Coverage Payor Type
/// https://hl7.org/fhir/R4/coverage.html
/// </summary>
public enum CoveragePayorType
{
    /// <summary>
    /// Organization
    /// </summary>
    Organization = 0,
    
    /// <summary>
    /// Patient	
    /// </summary>
    Patient = 1,
    
    /// <summary>
    /// RelatedPerson	
    /// </summary>
    RelatedPerson = 2,
}