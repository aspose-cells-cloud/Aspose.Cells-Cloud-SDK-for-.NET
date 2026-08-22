using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>CopyFolder operation.</summary>
public class CopyFolderRequest : IRequestOption
{
    public CopyFolderRequest(string srcPath, string destPath)
    {
        if (string.IsNullOrEmpty(srcPath)) throw new ArgumentException("srcPath is required", nameof(srcPath));
        SrcPath = srcPath;
        if (string.IsNullOrEmpty(destPath)) throw new ArgumentException("destPath is required", nameof(destPath));
        DestPath = destPath;
    }

    public string SrcPath { get; }
    public string DestPath { get; }
    public string? SrcStorageName { get; set; }
    public string? DestStorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/storage/folder/copy/" +
            Uri.EscapeDataString(SrcPath);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["destPath"] = DestPath;
        if (!string.IsNullOrEmpty(SrcStorageName)) query["srcStorageName"] = SrcStorageName;
        if (!string.IsNullOrEmpty(DestStorageName)) query["destStorageName"] = DestStorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
