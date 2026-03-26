using System.Text.Json;
using System.Text.Json.Serialization;
using DarenaHealth.Client.Internal;
using Hl7.Fhir.Serialization;

namespace DarenaHealth.Client;

/// <summary>
/// Options for the <see cref="DarenaHealthClient"/>
/// </summary>
public class DarenaHealthClientOptions
{
    /// <summary>
    /// Darena Health system staging url
    /// </summary>
    public const string StagingUrl = "https://app.stg.meldrx.com";

    /// <summary>
    /// Darena Health system live url
    /// </summary>
    public const string LiveUrl = "https://app.meldrx.com";

    private string _baseUrl = null;

    /// <summary>
    /// create a new instance
    /// </summary>
    /// <param name="clientId">oidc client id</param>
    /// <param name="clientSecret">oidc client secret</param>
    /// <param name="scope">oidc scopes</param>
    public DarenaHealthClientOptions(string clientId, string clientSecret, string scope)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
        Scope = scope;

        JsonOptions = new JsonSerializerOptions()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };
        JsonOptions.Converters.Add(new JsonStringEnumConverter());
        JsonOptions.Converters.Add(new ObservationComponentConverter());
        FhirJsonOptions = JsonOptions.ForFhir();
    }

    /// <summary>
    /// Gets the client id
    /// </summary>
    public string ClientId { get; }

    /// <summary>
    /// Gets the client secret
    /// </summary>
    public string ClientSecret { get; }

    /// <summary>
    /// Gets the access scope
    /// </summary>
    public string Scope { get; }

    /// <summary>
    /// Gets or sets the flag for staging environment
    /// </summary>
    public bool Staging { get; set; }

    /// <summary>
    /// Gets the base JsonSerializerOptions
    /// </summary>
    public JsonSerializerOptions JsonOptions { get; }

    /// <summary>
    /// Gets the fhir initialized JsonSerializerOptions
    /// </summary>
    public JsonSerializerOptions FhirJsonOptions { get; }

    /// <summary>
    /// Gets or sets the base url used for all requests
    /// </summary>
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
