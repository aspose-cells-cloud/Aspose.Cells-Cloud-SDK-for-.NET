using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>StorageExists operation.</summary>
public class StorageExistsRequest : IRequestOption
{
    public StorageExistsRequest(string storageName)
    {
        if (string.IsNullOrEmpty(storageName)) throw new ArgumentException("storageName is required", nameof(storageName));
        StorageName = storageName;
    }

    public string StorageName { get; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/storage/" +
            Uri.EscapeDataString(StorageName) +
            "/exist";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
