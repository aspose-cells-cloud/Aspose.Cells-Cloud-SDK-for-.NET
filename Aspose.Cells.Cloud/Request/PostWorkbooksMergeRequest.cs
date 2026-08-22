using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Merge a workbook into the existing workbook.</summary>
public class PostWorkbooksMergeRequest : IRequestOption
{
    public PostWorkbooksMergeRequest(string name, string mergeWith)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(mergeWith)) throw new ArgumentException("mergeWith is required", nameof(mergeWith));
        MergeWith = mergeWith;
    }

    public string Name { get; }
    public string MergeWith { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? MergedStorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/merge";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["mergeWith"] = MergeWith;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(MergedStorageName)) query["mergedStorageName"] = MergedStorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
