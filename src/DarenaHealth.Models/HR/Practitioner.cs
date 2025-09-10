using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a practitioner
/// </summary>
public class Practitioner
{
    /// <summary>
    /// Gets or sets the Practitioner id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the npi
    /// </summary>
    public string Npi { get; set; }
        
    /// <summary>
    /// Gets or sets the list of names for the practitioner
    /// </summary>
    public List<Name> Names { get; set; }

    /// <summary>
    /// Gets or sets the list of address for the practitioner
    /// </summary>
    public List<Address> Addresses { get; set; }

    /// <summary>
    ///  Gets or sets the list of phones for the practitioner
    /// </summary>
    public List<Telecom> Telecom { get; set; }

    /// <summary>
    /// Gets or sets the practitioner roles
    /// </summary>
    public List<PractitionerRole> OrganizationRoles { get; set; }
}