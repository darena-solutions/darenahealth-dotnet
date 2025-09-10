using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a coverage resource
/// https://hl7.org/fhir/R4/coverage.html
/// </summary>
public class Coverage : PatientBase
{
    /// <summary>
    /// Gets or sets the member id
    /// </summary>
    public string MemberId { get; set; }

    /// <summary>
    /// Gets or sets the coverage status
    /// </summary>
    public CoverageStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the subscriber id
    /// </summary>
    public string SubscriberId { get; set; }

    /// <summary>
    /// Gets or sets the subscriber relationship
    /// </summary>
    public CoverageRelationship Relationship { get; set; }

    /// <summary>
    /// Gets or sets the payor reference
    /// </summary>
    public CoveragePayor Payor { get; set; }

    /// <summary>
    /// Gets or sets the coverage classes such as 'group' or 'plan'
    /// </summary>
    public List<CoverageClass> Classes { get; set; }
}
