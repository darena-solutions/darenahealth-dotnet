using System;

namespace DarenaHealth.Client.Exceptions;

/// <summary>
/// An exception that is thrown when the client fails to obtain an access token
/// </summary>
public class GetAccessTokenException : Exception
{
    internal GetAccessTokenException(string message, int statusCode, string content) : base(message)
    {
        StatusCode = statusCode;
        Content = content;
    }

    /// <summary>
    /// Gets the status code of the token endpoint response
    /// </summary>
    public int StatusCode { get; }

    /// <summary>
    /// Gets the content of the token endpoint response
    /// </summary>
    public string Content { get; }
}
