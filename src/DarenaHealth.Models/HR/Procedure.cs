using System;
using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a procedure
/// </summary>
public class Procedure : PatientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Procedure"/> class
    /// </summary>
    public Procedure()
    {
        Participants = new List<Participant>();
        BodySitesList = new List<CodeValue>();
        ProviderNpis = new List<string>();
        Locations = new List<Location>();
        Source = new List<SourceReference>();
    }

    /// <summary>
    /// Gets or sets the coded body site for procedure
    /// </summary>
    public CodeValue BodySite { get; set; }

    /// <summary>
    /// Gets or sets the participants for procedure
    /// </summary>
    public List<Participant> Participants { get; set; }

    /// <summary>
    /// Gets or sets the procedure Type
    /// </summary>
    public ProcedureType ProcedureType { get; set; }

    /// <summary>
    /// Gets or sets the coded Category Value
    /// </summary>
    public CodeValue Category { get; set; }

    /// <summary>
    /// Gets or sets the status
    /// </summary>
    public ProcedureStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the coded list of body sites
    /// </summary>
    public List<CodeValue> BodySitesList { get; set; }

    /// <summary>
    /// Gets or sets the specimen details
    /// </summary>
    public Specimen DsSpecimen { get; set; }

    /// <summary>
    /// Gets or sets the provider NPIs for procedure
    /// </summary>
    public List<string> ProviderNpis { get; set; }

    /// <summary>
    /// Gets or sets the coded value for priority
    /// </summary>
    public CodeValue Priority { get; set; }

    /// <summary>
    /// Gets or sets the list of locations for procedure
    /// </summary>
    public List<Location> Locations { get; set; }

    /// <summary>
    /// Gets or sets the coded result value
    /// </summary>
    public CodeValue Result { get; set; }

    /// <summary>
    /// Gets or sets the related result id
    /// </summary>
    public string ResultId { get; set; }

    /// <summary>
    /// Gets or sets the text description for procedure
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Reference to the reason for this procedure
    /// </summary>
    public List<SourceReference> Source { get; set; }

    /// <summary>
    /// Gets or sets the id of a referral request (use <see cref="Source"/> to specify a service request reference)
    /// </summary>
    [Obsolete(ObsoleteReasons.Legacy)]
    public string ReferralId { get; set; }

    /// <summary>
    /// Gets or sets the intent of the Service Request
    /// </summary>
    [Obsolete(ObsoleteReasons.Legacy)]
    public RequestIntent ReferralIntent { get; set; }

    /// <summary>
    /// Get the status of the referral request
    /// </summary>
    [Obsolete(ObsoleteReasons.Legacy)]
    public RequestStatus ReferralStatus { get; set; }

    /// <summary>
    /// Reference to the requester of the referral
    /// </summary>
    public class SourceReference
    {
        /// <summary>
        /// Gets or sets the id of the reference
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference
        /// </summary>
        public SourceType Type { get; set; }
    }

    /// <summary>
    /// Referral Source Types
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// CarePlans
        /// </summary>
        CarePlan,

        /// <summary>
        /// ServiceRequest
        /// </summary>
        ServiceRequest,
    }
}
