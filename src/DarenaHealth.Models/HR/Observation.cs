using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model used to represent an observation resource
/// </summary>
public class Observation : PatientBase
{
    /// <summary>
    /// initializes a new instance of an Observation class
    /// </summary>
    public Observation()
    {
        Components = new List<ComponentCodeValue>();
        Members = new List<MemberReference>();
        DerivedFrom = new List<DerivedFromReference>();
    }

    /// <summary>
    /// Gets or sets the coded values for reason for a missing observation
    /// </summary>
    public CodeValue DataAbsentReason { get; set; }

    /// <summary>
    /// Gets or sets the coded value
    /// </summary>
    public CodeValue ValueCodeValue { get; set; }

    /// <summary>
    /// Gets or sets the period
    /// </summary>
    public TimeRange ValuePeriod { get; set; }

    /// <summary>
    /// Gets or sets the string value
    /// </summary>
    public string ValueString { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this observation's outcome was <c>true</c> or <c>false</c>
    /// </summary>
    public bool ValueBoolean { get; set; }

    /// <summary>
    /// Gets or sets the quantity value
    /// </summary>
    public Quantity ValueQuantity { get; set; }

    /// <summary>
    /// Gets or sets the observation type
    /// </summary>
    public ObservationType AssessmentType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this observation is used to identity the absence of an observation
    /// </summary>
    public bool NegationInd { get; set; }

    /// <summary>
    /// Gets or sets the group code
    /// </summary>
    public string GroupId { get; set; }

    /// <summary>
    /// Gets or sets the mood code
    /// </summary>
    public string MoodCode { get; set; }

    /// <summary>
    /// Gets or sets the author id
    /// </summary>
    public string AuthorId { get; set; }

    /// <summary>
    /// Gets or sets the status code
    /// </summary>
    public string StatusCode { get; set; }

    /// <summary>
    /// ResourceId for specimen
    /// </summary>
    public string SpecimenId { get; set; }

    /// <summary>
    /// Speciment type: https://vsac.nlm.nih.gov/valueset/2.16.840.1.113762.1.4.1099.54/expansion
    /// </summary>
    public CodeValue SpecimenCode { get; set; }

    /// <summary>
    /// Gets or sets the component slice in Observation like (Occupation Industry and Coresponding Code)
    /// </summary>
    public List<ComponentCodeValue> Components { get; set; }

    /// <summary>
    /// Category codes used in the US Core Observation Screening Assessment Profile to help identify the type of USCDI Health Status/Assessment data class being reported.
    /// </summary>
    public ObservationScreeningAssessment ScreeningType { get; set; }

    /// <summary>
    /// Reference to multi-select responses
    /// </summary>
    public List<MemberReference> Members { get; set; }

    /// <summary>
    /// Related Observation(s) or other resource the observation is made from
    /// </summary>
    public List<DerivedFromReference> DerivedFrom { get; set; }

    /// <summary>
    /// Reference to resource which other observation were derived from
    /// </summary>
    public class DerivedFromReference
    {
        /// <summary>
        /// Gets or sets the id of the reference
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference
        /// </summary>
        public DerivedFromType Type { get; set; }
    }

    /// <summary>
    /// Reference to resource which are members (parts) of another observation
    /// </summary>
    public class MemberReference
    {
        /// <summary>
        /// Gets or sets the id of the reference
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference
        /// </summary>
        public MemberType Type { get; set; }
    }

    /// <summary>
    /// Types of resources an observation can be derived from
    /// </summary>
    public enum DerivedFromType
    {
        /// <summary>
        /// Observation
        /// </summary>
        Observation,
    }

    /// <summary>
    /// Types of resources that can be members of an observation
    /// </summary>
    public enum MemberType
    {
        /// <summary>
        /// Observation
        /// </summary>
        Observation,
    }
}
