using System;
using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// Model that represents a service request
/// </summary>
public class ServiceRequest : PatientBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceRequest"/> class
    /// </summary>
    public ServiceRequest()
    {
        Reasons = new List<ReasonReference>();
    }

    /// <summary>
    /// Gets or sets the intent of the Service Request
    /// </summary>
    public RequestIntent Intent { get; set; }

    /// <summary>
    /// Get the status of the referral request
    /// </summary>
    public RequestStatus Status { get; set; }

    /// <summary>
    ///  Classification of service request
    /// </summary>
    public RequestCategory Category { get; set; }

    /// <summary>
    /// When was the referral event created
    /// </summary>
    public DateTime AuthoredOn { get; set; }

    /// <summary>
    /// Who/what is requesting service
    /// </summary>
    public RequesterReference Requester { get; set; }

    /// <summary>
    /// Reasons for requesting this service
    /// </summary>
    public List<ReasonReference> Reasons { get; set; }

    /// <summary>
    /// Reference to the requester of the referral
    /// </summary>
    public class RequesterReference
    {
        /// <summary>
        /// Gets or sets the id of the reference
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference
        /// </summary>
        public RequesterType Type { get; set; }
    }

    /// <summary>
    /// Reference to the reason for the referral
    /// </summary>
    public class ReasonReference
    {
        /// <summary>
        /// Gets or sets the id of the reference
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference
        /// </summary>
        public ReasonType Type { get; set; }
    }

    /// <summary>
    /// Types of requestors of a referral
    /// </summary>
    public enum RequesterType
    {
        /// <summary>
        /// Practitioner
        /// </summary>
        Practitioner,

        /// <summary>
        /// PractitionerRole
        /// </summary>
        PractitionerRole,

        /// <summary>
        /// Patient
        /// </summary>
        Patient,

        /// <summary>
        /// RelatedPerson
        /// </summary>
        RelatedPerson,
    }

    /// <summary>
    /// Types of reasons for a referral
    /// </summary>
    public enum ReasonType
    {
        /// <summary>
        /// Condition
        /// </summary>
        Condition,

        /// <summary>
        /// Observation
        /// </summary>
        Observation,

        /// <summary>
        /// DiagnosticReport
        /// </summary>
        DiagnosticReport,

        /// <summary>
        /// DocumentReference
        /// </summary>
        DocumentReference,
    }
}
