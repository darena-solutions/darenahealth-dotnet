using System;

namespace DarenaHealth.Client.Exceptions;

public class GetAccessTokenException : Exception
{

    public GetAccessTokenException(string message, int statusCode, string content) : base(message)
    {
        StatusCode = statusCode;
        Content = content;
    }
    public int StatusCode { get; }
    public string Content { get; }
}
