using System.Collections.Generic;

namespace Aspose.Cells.Cloud;

/// <summary>
/// Common interface implemented by every API request option. A request object resolves the HTTP
/// method, path, query, headers, and payload for a single API operation.
/// </summary>
public interface IRequestOption
{
    /// <summary>Returns the HTTP verb (GET, POST, PUT, or DELETE).</summary>
    string GetMethod();

    /// <summary>Returns the request path with every <c>{param}</c> placeholder already substituted.</summary>
    string GetPath();

    /// <summary>Returns the query string parameters (wire name → value).</summary>
    Dictionary<string, string> GetQueryParameters();

    /// <summary>Returns the header parameters (name → value).</summary>
    Dictionary<string, string> GetHeaderParameters();

    /// <summary>Returns the JSON body object, or <c>null</c> when the operation has no body.</summary>
    object? GetJsonBody();

    /// <summary>Returns the multipart form fields, or <c>null</c> when the operation has no form data.</summary>
    Dictionary<string, object>? GetMultipartForm();
}
