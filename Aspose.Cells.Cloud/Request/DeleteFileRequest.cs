using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>DeleteFile operation.</summary>
public class DeleteFileRequest : IRequestOption
{
    public DeleteFileRequest(string path)
    {
        if (string.IsNullOrEmpty(path)) throw new ArgumentException("path is required", nameof(path));
        Path = path;
    }

    public string Path { get; }
    public string? StorageName { get; set; }
    public string? VersionId { get; set; }

    public string GetMethod() => "DELETE";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/storage/file/" +
            Uri.EscapeDataString(Path);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(VersionId)) query["versionId"] = VersionId;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
