using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a care team resource
/// </summary>
public class CareTeam : PatientBase
{
    /// <summary>
    /// Gets or sets the care team status
    /// </summary>
    public CareTeamStatus Status { get; set; }
        
    /// <summary>
    /// Gets or sets the participants for procedure
    /// </summary>
    public List<CareTeamParticipant> Participants { get; set; }
}