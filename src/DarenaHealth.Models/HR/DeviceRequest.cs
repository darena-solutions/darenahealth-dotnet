using System;
using DarenaHealth.Models.HR.Enums;
using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent a DeviceRequest resource
/// https://hl7.org/fhir/us/davinci-crd/en/StructureDefinition-profile-devicerequest.html
/// </summary>
public class DeviceRequest : PatientBase
{
    /// <summary>
    /// Gets or sets the status of the device request
    /// </summary>
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the kind of diagnostic request
    /// </summary>
    public RequestIntent Intent { get; set; }

    /// <summary>
    /// Gets or sets reference to a specific Device id, this is optional if provding device code via:CodeValue
    /// </summary>
    public string DeviceReference { get; set; } = null;

    /// <summary>
    /// Gets or sets when the request was recorded
    /// </summary>
    public DateTime AuthoredOn { get; set; }

    /// <summary>
    /// Gets or sets Who/what is requesting diagnostics
    /// </summary>
    public RequesterReference Requester { get; set; }

    /// <summary>
    /// Gets or sets reference to a list of reasons supporting the request
    /// </summary>
    public List<ReasonReference> ReasonReferences { get; set; } = null;

    /// <summary>
    /// Represents the reference to the requester of the device request
    /// </summary>
    public class RequesterReference
    {
        /// <summary>
        /// Gets or sets id of requester
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets type of requester
        /// </summary>
        public RequesterReferenceType Type { get; set; }
    }

    /// <summary>
    /// Represents a reference to a reason supporting the device request
    /// </summary>
    public class ReasonReference
    {
        /// <summary>
        /// Gets or sets id of reason reference
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets type of reason reference
        /// </summary>
        public ReasonReferenceType Type { get; set; }
    }

    /// <summary>
    /// Different types of Requester
    /// </summary>
    public enum RequesterReferenceType
    {
        /// <summary>
        /// Device
        /// </summary>
        Device = 0,

        /// <summary>
        /// Practitioner
        /// </summary>
        Practitioner = 1,

        /// <summary>
        /// PractitionerRole
        /// </summary>
        PractitionerRole = 2,

        /// <summary>
        /// Organization
        /// </summary>
        Organization = 3
    }

    /// <summary>
    /// Different types of reasons for the device request
    /// </summary>
    public enum ReasonReferenceType
    {
        /// <summary>
        /// Condition
        /// </summary>
        Condition = 0,

        /// <summary>
        /// Observation
        /// </summary>
        Observation = 1,

        /// <summary>
        /// DiagnosticReport
        /// </summary>
        DiagnosticReport = 2,

        /// <summary>
        /// DocumentReference
        /// </summary>
        DocumentReference = 3
    }
}
