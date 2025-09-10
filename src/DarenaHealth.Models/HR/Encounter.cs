using System;
using System.Collections.Generic;

namespace DarenaHealth.Models.HR;

/// <summary>
/// The model that represents an encounter resource
/// </summary>
public class Encounter : BaseDto
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Encounter"/> class
    /// </summary>
    public Encounter()
    {
        CptCodes = new List<CodeValue>();
        NumeratorCodes = new List<CodeValue>();
        Payers = new List<Payer>();
        Medications = new List<Medication>();
        Allergies = new List<Allergy>();
        Immunizations = new List<Immunization>();
        Communications = new List<Communication>();
        Problems = new List<Problem>();
        Procedures = new List<Procedure>();
        Observations = new List<Observation>();
        CarePlanItems = new List<CarePlan>();
        Devices = new List<Device>();
        Organizations = new List<Organization>();
        CareTeams = new List<CareTeam>();
        Goals = new List<Goal>();
        Locations = new List<Location>();
        Coverage = new List<Coverage>();
    }

    /// <summary>
    /// Gets or sets the patient id
    /// </summary>
    public string PatientId { get; set; }

    /// <summary>
    /// Gets or sets the facility id
    /// </summary>
    public string FacilityId { get; set; }

    /// <summary>
    /// Gets or sets the place of service
    /// </summary>
    public string Pos { get; set; }

    /// <summary>
    /// Gets or sets the external encounter id
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or sets the provider id
    /// </summary>
    public string ProviderId { get; set; }

    /// <summary>
    /// Gets or sets the measure id
    /// </summary>
    public string MeasureId { get; set; }

    /// <summary>
    /// Gets or sets the encounter classification
    /// </summary>
    public EncounterClassification? Class { get; set; } = null;

    /// <summary>
    /// Gets or sets the encounter date
    /// </summary>
    public DateTime EncounterDate { get; set; }

    /// <summary>
    /// Gets or sets the cptcodes valuesset
    /// </summary>
    public List<CodeValue> CptCodes { get; set; }

    /// <summary>
    /// Gets or sets the numeratorcodes valueset
    /// </summary>
    public List<CodeValue> NumeratorCodes { get; set; }

    /// <summary>
    /// Gets or sets the principal diagnosis as a coded entry
    /// </summary>
    public CodeValue PrincipalDiagnosis { get; set; }

    /// <summary>
    /// Gets or sets the discharge disposition coded entry
    /// </summary>
    public CodeValue DischargeDisposition { get; set; }

    /// <summary>
    /// Gets or sets the location coded entry
    /// </summary>
    public CodeValue LocationCode { get; set; }

    /// <summary>
    /// Gets or sets the time period a patient was admitted and then discharged from a location
    /// </summary>
    public TimeRange LocationPeriod { get; set; }

    /// <summary>
    /// Gets or sets the reason's for this encounter to happen
    /// </summary>
    public List<CodeValue> ReasonCodes { get; set; }

    /// <summary>
    /// Gets or sets the list of practitioners for encounter
    /// </summary>
    public List<Practitioner> Practitioners { get; set; }

    /// <summary>
    /// Gets or sets the list of practitioners for encounter
    /// </summary>
    public List<PractitionerRole> PractitionerRoles { get; set; }

    /// <summary>
    /// Gets or sets the list of payers for encounter
    /// </summary>
    public List<Payer> Payers { get; set; }

    /// <summary>
    /// Gets or sets the list of medications for encounter
    /// </summary>
    public List<Medication> Medications { get; set; }

    /// <summary>
    /// Gets or sets the list of allergies for encounter
    /// </summary>
    public List<Allergy> Allergies { get; set; }

    /// <summary>
    /// Gets or sets the list of immunizations for encounter
    /// </summary>
    public List<Immunization> Immunizations { get; set; }

    /// <summary>
    /// Gets or sets the list of communications for encounter
    /// </summary>
    public List<Communication> Communications { get; set; }

    /// <summary>
    /// Gets or sets the list of problems for encounter
    /// </summary>
    public List<Problem> Problems { get; set; }

    /// <summary>
    /// Gets or sets the list of procedures for encounter
    /// </summary>
    public List<Procedure> Procedures { get; set; }

    /// <summary>
    /// Gets or sets the list of observations for encounter
    /// </summary>
    public List<Observation> Observations { get; set; }

    /// <summary>
    /// Gets or sets the list of care plan items for encounter
    /// </summary>
    public List<CarePlan> CarePlanItems { get; set; }

    /// <summary>
    /// Gets or sets the list of devices for encounter
    /// </summary>
    public List<Device> Devices { get; set; }

    /// <summary>
    /// Gets or sets the list of locations for encounter
    /// </summary>
    public List<Location> Locations { get; set; }

    /// <summary>
    /// Gets or sets the list of goals for encounter
    /// </summary>
    public List<Goal> Goals { get; set; }

    /// <summary>
    /// Gets or sets the list of organizations for encounter
    /// </summary>
    public List<Organization> Organizations { get; set; }

    /// <summary>
    /// Gets or sets the list of care teams for encounter
    /// </summary>
    public List<CareTeam> CareTeams { get; set; }

    /// <summary>
    /// Gets or sets the list of devices for encounter
    /// </summary>
    public List<Coverage> Coverage { get; set; }
}