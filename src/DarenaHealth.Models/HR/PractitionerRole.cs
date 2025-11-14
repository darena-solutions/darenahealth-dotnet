using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a practitioner role within an organization
/// </summary>
public class PractitionerRole
{
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    public string Id { get; set; }
        
    /// <summary>
    /// Gets or sets the OrganizationId
    /// </summary>
    public string OrganizationId { get; set; }
        
    /// <summary>
    /// Gets or sets the PractitionerId
    /// </summary>
    public string PractitionerId { get; set; }
        
    /// <summary>
    /// Gets or sets The location(s) at which this practitioner provides care
    /// </summary>
    public List<Location> Locations { get; set; }
        
    /// <summary>
    /// Gets or sets the list of healthcare services that this worker provides for this role's Organization/Location(s)
    /// </summary>
    public List<HealthcareService> HealthcareServices { get; set; }
        
    /// <summary>
    /// Gets or sets the Technical endpoints providing access to services operated for the practitioner with this role
    /// </summary>
    public List<Endpoint> Endpoints { get; set; }

    /// <summary>
    /// Gets or sets practitioner roles within the organization
    /// </summary>
    public List<CodeValue> Roles { get; set; }

    /// <summary>
    /// Gets or sets specialities of the practitioner
    /// </summary>
    public List<CodeValue> Specialities { get; set; }
        
    /// <summary>
    /// Gets or sets practitioner roles within the organization
    /// </summary>
    public List<Telecom> Telecom { get; set; }

}