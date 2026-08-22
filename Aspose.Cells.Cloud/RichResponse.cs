using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Aspose.Cells.Cloud;

/// <summary>Carries the raw result of an executed API request: status code, headers, and body bytes.</summary>
public class RichResponse
{
    /// <summary>Gets the HTTP status code.</summary>
    public int StatusCode { get; }

    /// <summary>Gets the response headers (name → joined value).</summary>
    public Dictionary<string, string> Headers { get; }

    /// <summary>Gets the raw response body.</summary>
    public byte[] Body { get; }

    public RichResponse(int statusCode, Dictionary<string, string>? headers, byte[]? body)
    {
        StatusCode = statusCode;
        Headers = headers ?? new Dictionary<string, string>();
        Body = body ?? Array.Empty<byte>();
    }

    /// <summary>Returns the body decoded as UTF-8 text.</summary>
    public override string ToString() => Encoding.UTF8.GetString(Body);

    /// <summary>Returns the raw response body bytes.</summary>
    public byte[] ToBytes() => Body;

    /// <summary>Deserializes the body into the requested type.</summary>
    public T GetJson<T>(JsonSerializerOptions? options = null)
    {
        if (Body.Length == 0)
        {
            return default!;
        }

        var serializerOptions = options ?? new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        return JsonSerializer.Deserialize<T>(Body, serializerOptions)!;
    }
}
