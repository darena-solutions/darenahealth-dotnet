using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// RelatedPerson resource
/// https://hl7.org/fhir/R4/relatedperson.html
/// </summary>
public class RelatedPerson : PatientBase
{
    /// <summary>
    /// Gets or sets the active status
    /// </summary>
    public bool Active { get; set; }
    
    /// <summary>
    /// Gets or sets the name associated with the person
    /// </summary>
    public Name Name { get; set; }
    
    /// <summary>
    /// Gets or sets the contact detail for the person
    /// </summary>
    public List<Telecom> Telecom { get; set; }
    
    /// <summary>
    /// Gets or sets the Address where the related person can be contacted or visited
    /// </summary>
    public List<Address> Addresses { get; set; }
}