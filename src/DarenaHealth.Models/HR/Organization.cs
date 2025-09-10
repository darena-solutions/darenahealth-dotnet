using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents an organization
/// </summary>
public class Organization
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Organization"/> class
    /// </summary>
    public Organization()
    {
        Addresses = new List<Address>();
        Telecom = new List<Telecom>();
    }

    /// <summary>
    /// Gets or sets the id of organization
    /// </summary>
    public string Id { get; set; }
        
    /// <summary>
    /// Gets or sets the NPI of organization
    /// </summary>
    public string Npi { get; set; }
        
    /// <summary>
    /// Gets or sets the active status of organization
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the organization name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the list of address for the organization
    /// </summary>
    public List<Address> Addresses { get; set; }

    /// <summary>
    ///  Gets or sets the list of phones for the organization
    /// </summary>
    public List<Telecom> Telecom { get; set; }
}