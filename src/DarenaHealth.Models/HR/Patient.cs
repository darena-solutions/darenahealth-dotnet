using System;
using System.Collections.Generic;
using DarenaHealth.Models.HR.Enums;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents a patient resource
/// </summary>
public class Patient : BaseDto
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Patient"/> class
    /// </summary>
    public Patient()
    {
        Identifiers = new List<Identifier>();
        Addresses = new List<Address>();
        PhoneNumbers = new List<Phone>();
    }

    /// <summary>
    /// Gets or sets the date of birth
    /// </summary>
    public DateTime Dob { get; set; }

    /// <summary>
    /// Gets or sets the date of deceased
    /// </summary>
    public DateTime? DateDeceased { get; set; }

    /// <summary>
    /// Gets or sets the gender
    /// </summary>
    public Gender? Gender { get; set; }

    /// <summary>
    /// Gets or sets the external id
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or sets the medical record number
    /// </summary>
    public string Mrn { get; set; }

    /// <summary>
    /// Gets or sets the patient identifiers
    /// </summary>
    public List<Identifier> Identifiers { get; set; }

    /// <summary>
    /// Gets or sets the patient name
    /// </summary>
    public Name Name { get; set; }

    /// <summary>
    /// Gets or sets the patient previous names
    /// </summary>
    public List<Name> PreviousNames { get; set; }

    /// <summary>
    /// Gets or sets the patient addresses
    /// </summary>
    public List<Address> Addresses { get; set; }

    /// <summary>
    /// Gets or sets the patient birth address
    /// </summary>
    public Address BirthPlace { get; set; }

    /// <summary>
    /// Gets or sets the generation of patient
    /// </summary>
    public Generation? Generation { get; set; }

    /// <summary>
    /// Gets or sets the patient phone numbers
    /// </summary>
    public List<Phone> PhoneNumbers { get; set; }

    /// <summary>
    /// Gets or sets the patient email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the comments for patient
    /// </summary>
    public string Comments { get; set; }

    /// <summary>
    /// Gets or sets the race of patient
    /// </summary>
    public List<CodeValue> Race { get; set; }

    /// <summary>
    /// Gets or sets the ethnicity of patient
    /// </summary>
    public CodeValue Ethnicity { get; set; }

    /// <summary>
    /// Gets or sets the patient deceased status
    /// </summary>
    public CodeValue Deceased { get; set; }

    /// <summary>
    /// Gets or sets the marital status of patient
    /// </summary>
    public CodeValue MaritalStatus { get; set; }

    /// <summary>
    /// Gets or sets the religion of patient
    /// </summary>
    public CodeValue Religion { get; set; }

    /// <summary>
    /// Gets or sets the sex of the patient
    /// </summary>
    public PatientSex? Sex { get; set; }

    /// <summary>
    /// Gets or sets the tribal affiliation of the patient
    /// </summary>
    public CodeValue TribalAffiliation { get; set; }

    /// <summary>
    /// Gets or sets the preferred language of the patient
    /// </summary>
    public CodeValue PreferredLanguage { get; set; }

    /// <summary>
    /// Gets or sets the list of related people
    /// </summary>
    public List<RelatedPerson> RelatedPeople { get; set; }
}