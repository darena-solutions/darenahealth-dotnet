using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a location
/// </summary>
public class Location
{
    /// <summary>
    /// Gets or sets the id of location
    /// </summary>
    public string Id { get; set; }
        
    /// <summary>
    /// Gets or sets the location status
    /// </summary>
    public LocationStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the name of location
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the coded location type
    /// </summary>
    public CodeValue LocationType { get; set; }

    /// <summary>
    /// Gets or sets the address of the location
    /// </summary>
    public Address Address { get; set; }
        
    /// <summary>
    /// Gets or sets the location phone numbers
    /// </summary>
    public List<Phone> Phones { get; set; }
        
    /// <summary>
    /// Gets or sets the id of managing organization id
    /// </summary>
    public string OrganizationId { get; set; }
}