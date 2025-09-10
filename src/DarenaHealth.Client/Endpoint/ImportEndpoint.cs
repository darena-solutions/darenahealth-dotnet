using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DarenaHealth.Client.Endpoint.Models.Import;

namespace DarenaHealth.Client.Endpoint;

public class ImportEndpoint
{
    private readonly HttpClient _client;
    private readonly DarenaHealthClientOptions _options;

    public ImportEndpoint(HttpClient client, DarenaHealthClientOptions options)
    {
        _client = client;
        _options = options;
    }

    /// <summary>
    /// Import patient encounter data in to workspace
    /// </summary>
    /// <param name="workspace">Ether workspace id, slug or identifier.</param>
    /// <param name="request">Request payload</param>
    /// <returns>Import result</returns>
    public async Task<ImportPatientEncounterResponse> ImportPatientEncounterAsync(string workspace, ImportPatientEncounter request)
    {
        var result = await _client.PostAsJsonAsync($"/api/import/{workspace}/dh", request, _options.JsonOptions);
        return await result.Content.ReadFromJsonAsync<ImportPatientEncounterResponse>(_options.FhirJsonOptions);
    }
}
