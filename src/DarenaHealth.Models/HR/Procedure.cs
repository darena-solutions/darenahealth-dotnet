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
        BodySitesList = new List<CodeValue>();
        ProviderNpis = new List<string>();
        Locations = new List<Location>();
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
    public string Status { get; set; }

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
    /// Gets or sets the id of a referral request
    /// </summary>
    public string ReferralId { get; set; }

    /// <summary>
    /// Gets or sets the intent of the Service Request
    /// </summary>
    public RequestIntent ReferralIntent { get; set; }

    /// <summary>
    /// Get the status of the referral request
    /// </summary>
    public RequestStatus ReferralStatus { get; set; }

    /// <summary>
    ///  Classification of service request
    /// </summary>
    public RequestCategory ReferralCategory { get; set; }

    /// <summary>
    /// When was the referral event created
    /// </summary>
    public DateTime ReferralAuthoredOn { get; set;}

    /// <summary>
    /// Who/what is requesting service (Practioner, PractionerRole, Patient, RelatedPerson)
    /// </summary>
    public string ReferralRequester { get; set; }

    /// <summary>
    /// Condition | Observation | DiagnosticReport | DocumentReference, which request this service
    /// </summary>
    public string ReferralReference { get; set; }

    /// <summary>
    /// CarePlan | ServiceRequest
    /// </summary>
    public string ReferralSource { get; set; }



}