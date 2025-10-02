using Hl7.Fhir.Model;

namespace DarenaHealth.Client.Endpoint.Models.Import;

/// <summary>
/// import patient-encounter response
/// </summary>
public class ImportPatientEncounterResponse
{
    /// <summary>
    /// Result bundle, if errors are present will contain the unprocessed bundle
    /// </summary>
    public Bundle Bundle { get; set; }

    /// <summary>
    /// Gets any errors that occured during the import process
    /// </summary>
    public OperationOutcome Errors { get; set; }
}
