using System.Collections.Generic;
using DarenaSolutions.MyMipsScore.Core.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents an Endpoint
/// </summary>
public class Endpoint : PatientBase
{
    /// <summary>
    /// Gets or sets the status ( active | suspended | error | off | entered-in-error | test )
    /// </summary>
    public EndpointStatus Status { get; set; }
    
    /// <summary>
    /// Gets or sets the Protocol/Profile/Standard to be used with this endpoint connection
    /// </summary>
    public EndpointConnectionType ConnectionType { get; set; }
    
    /// <summary>
    /// Gets or sets A name that this endpoint can be identified by
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or sets The type of content that may be used at this endpoint
    /// </summary>
    public List<CodeValue> PayloadTypes { get; set; }
    
    /// <summary>
    /// Gets or sets the Organization that manages this endpoint
    /// </summary>
    public string ManagingOrganization { get; set; }
    
    /// <summary>
    /// Gets or sets the technical base address for connecting to this endpoint
    /// </summary>
    public string Uri { get; set; }
}