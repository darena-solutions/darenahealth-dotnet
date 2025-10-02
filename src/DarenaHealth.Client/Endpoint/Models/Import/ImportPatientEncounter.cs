using System.Text.Json.Serialization;
using DarenaHealth.Models.HR;

namespace DarenaHealth.Client.Endpoint.Models.Import;

/// <summary>
/// import patient and encounter request
/// </summary>
public class ImportPatientEncounter
{
    /// <summary>
    /// creates the payload instance
    /// </summary>
    /// <param name="patient">patient information</param>
    /// <param name="encounter">patient encounter</param>
    public ImportPatientEncounter(Patient patient, Encounter encounter)
    {
        Patient = patient;
        Encounter = encounter;
    }

    /// <summary>
    /// Gets or sets patient data
    /// </summary>
    public Patient Patient { get; set; }

    /// <summary>
    /// Gets or sets patient encounter data
    /// </summary>
    public Encounter Encounter { get; set; }

    /// <summary>
    /// Gets or sets the generate ccda flag, if set to true a CCDA will be generated for the patient-encounter
    /// </summary>
    [JsonIgnore]
    public bool GenerateCcda { get; set; }
}
