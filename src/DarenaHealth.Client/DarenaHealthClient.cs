using System;
using System.Net.Http;
using DarenaHealth.Client.Endpoint;
using DarenaHealth.Client.Internal;

namespace DarenaHealth.Client;

/// <summary>
/// Client to interact with darenahealth system
/// </summary>
public class DarenaHealthClient : HttpClient
{
    /// <summary>
    /// creates the client
    /// </summary>
    /// <param name="options">client options</param>
    public DarenaHealthClient(DarenaHealthClientOptions options)
    {
        var http = new HttpClient(new AuthenticationHttpClientHandler(options))
        {
            BaseAddress = new Uri(options.BaseUrl),
        };

        Import = new ImportEndpoint(http, options);
    }

    /// <summary>
    /// Preform data import actions on your workspace. url: /api/import/{workspace}/...
    /// </summary>
    public ImportEndpoint Import { get; }
}
