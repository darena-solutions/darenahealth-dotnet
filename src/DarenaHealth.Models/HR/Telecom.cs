using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model to represent a contactPoint resource
/// https://hl7.org/fhir/R4/datatypes.html#ContactPoint
/// </summary>
public class Telecom
{
    /// <summary>
    /// Gets or sets The actual contact point details
    /// </summary>
    public string Value { get; set; }
    
    /// <summary>
    /// Gets or sets the contact point system
    /// </summary>
    public ContactPointSystem System { get; set; }
    
    /// <summary>
    /// Gets or sets the contact point use
    /// </summary>
    public ContactPointUse Use { get; set; }
}