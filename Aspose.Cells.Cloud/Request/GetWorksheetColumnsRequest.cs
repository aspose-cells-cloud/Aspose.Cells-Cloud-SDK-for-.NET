using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve descriptions of worksheet columns.</summary>
public class GetWorksheetColumnsRequest : IRequestOption
{
    public GetWorksheetColumnsRequest()
    {
    }

    public string? Name { get; set; }
    public string? SheetName { get; set; }
    public int? Offset { get; set; }
    public int? Count { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name ?? string.Empty) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName ?? string.Empty) +
            "/cells/columns/";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (Offset.HasValue) query["offset"] = Offset.Value.ToString();
        if (Count.HasValue) query["count"] = Count.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
