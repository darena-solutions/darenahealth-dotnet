using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace DarenaHealth.Client;

public class DarenaHealthClientOptions
{
    public const string StagingUrl = "https://app.stg.meldrx.com";
    public const string LiveUrl = "https://app.meldrx.com";
    private string _baseUrl = null;

    public DarenaHealthClientOptions(string clientId, string clientSecret, string scope)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
        Scope = scope;

        JsonOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
        JsonOptions.Converters.Add(new JsonStringEnumConverter());
        FhirJsonOptions = JsonOptions.ForFhir();
    }

    public string ClientId { get; }
    public string ClientSecret { get; }
    public string Scope { get; }
    public bool Staging { get; set; }
    public JsonSerializerOptions JsonOptions { get; }
    public JsonSerializerOptions FhirJsonOptions { get; }

    public string BaseUrl
    {
        get
        {
            if (!string.IsNullOrWhiteSpace(_baseUrl))
            {
                return _baseUrl;
            }

            return Staging ? StagingUrl : LiveUrl;
        }
        set => _baseUrl = value;
    }
}
