using DarenaHealth.Models.HR;

namespace DarenaHealth.Client.Endpoint.Models.Import;

public class ImportPatientEncounter
{
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
}
