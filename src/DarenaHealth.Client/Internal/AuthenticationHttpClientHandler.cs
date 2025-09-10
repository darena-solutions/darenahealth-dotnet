using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using DarenaHealth.Client.Exceptions;

namespace DarenaHealth.Client.Internal;

internal class AuthenticationHttpClientHandler : HttpClientHandler
{
    private readonly DarenaHealthClientOptions _options;
    private readonly SemaphoreSlim _authFlag;

    public AuthenticationHttpClientHandler(DarenaHealthClientOptions options)
    {
        _options = options;
        _authFlag = new SemaphoreSlim(1);
    }

    private TokenResponse TokenResponse { get; set; }
    private DateTime RefreshTokenAt { get; set; }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        await EnsureTokenResponse(cancellationToken);
        if (TokenResponse == null)
        {
            throw new Exception("failed to obtain a authorization tokens");
        }

        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenResponse.AccessToken);

        return await base.SendAsync(request, cancellationToken);
    }

    private async Task EnsureTokenResponse(CancellationToken cancellationToken)
    {
        if (TokenResponse != null && RefreshTokenAt > DateTime.Now)
        {
            return;
        }

        await _authFlag.WaitAsync(cancellationToken);

        try
        {
            if (TokenResponse != null)
            {
                return;
            }

            await GetAccessToken();
        }
        finally
        {
            _authFlag.Release();
        }

        return;

        async Task GetAccessToken()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{_options.BaseUrl}/connect/token")
            {
                Content = new FormUrlEncodedContent(
                    new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("grant_type", "client_credentials")
                    }
                )
            };

            request.Headers.Authorization = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(
                    Encoding.UTF8.GetBytes($"{_options.ClientId}:{_options.ClientSecret}")
                )
            );

            var tokenResponse = await base.SendAsync(request, cancellationToken);
            if (!tokenResponse.IsSuccessStatusCode)
            {
                throw new GetAccessTokenException(
                    "error getting access token",
                    (int)tokenResponse.StatusCode,
                    await tokenResponse.Content.ReadAsStringAsync()
                );
            }

            tokenResponse.EnsureSuccessStatusCode();

            TokenResponse = await JsonSerializer.DeserializeAsync<TokenResponse>(await tokenResponse.Content.ReadAsStreamAsync(), cancellationToken: cancellationToken);
            RefreshTokenAt = DateTime.Now.AddSeconds(TokenResponse.ExpiresIn).AddMinutes(-1);
        }
    }
}
