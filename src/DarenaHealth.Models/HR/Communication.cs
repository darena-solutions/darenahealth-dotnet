using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a communication resource
/// </summary>
public class Communication : PatientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Communication"/> class
    /// </summary>
    public Communication()
    {
        Participants = new List<Participant>();
    }

    /// <summary>
    /// Gets or sets the list of participants for this communication
    /// </summary>
    public List<Participant> Participants { get; set; }

    /// <summary>
    /// Gets or sets the ID for which the communication was response for
    /// </summary>
    public string InFulfillmentOfId { get; set; }

    /// <summary>
    /// Gets or sets the type of communication
    /// </summary>
    public CommunicationType CommunicationType { get; set; }

    /// <summary>
    /// Status of the Task
    /// </summary>
    public TaskStatus Status { get; set; }

    /// <summary>        
    /// Intent of the Task
    /// </summary>
    public TaskIntent Intent { get; set; }

    /// <summary>
    /// Code for Task Type
    /// </summary>
    public CodeValue Code { get; set; }

    /// <summary>
    /// Task Execution Period
    /// </summary>
    public TimeRange ExecutionPeriod { get; set; }
}