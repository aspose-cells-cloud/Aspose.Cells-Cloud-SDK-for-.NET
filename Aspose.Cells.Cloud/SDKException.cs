using System;

namespace Aspose.Cells.Cloud;

/// <summary>Exception thrown when an API request fails at the transport or HTTP level.</summary>
public class SDKException : Exception
{
    /// <summary>Gets the HTTP status code, when available.</summary>
    public int? StatusCode { get; }

    /// <summary>Gets the raw response body, when available.</summary>
    public string? ResponseBody { get; }

    public SDKException()
    {
    }

    public SDKException(string message)
        : base(message)
    {
    }

    public SDKException(int statusCode, string message)
        : base(message)
    {
        StatusCode = statusCode;
    }

    public SDKException(RichResponse response)
        : base($"HTTP {(response.StatusCode)}: {response}")
    {
        StatusCode = response.StatusCode;
        ResponseBody = response.ToString();
    }

    public SDKException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
