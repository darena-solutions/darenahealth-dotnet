using Hl7.Fhir.Model;

namespace DarenaHealth.Client.Endpoint.Models.Import;

public class ImportPatientEncounterResponse
{
    public Bundle Bundle { get; set; }
    public OperationOutcome Errors { get; set; }
}
