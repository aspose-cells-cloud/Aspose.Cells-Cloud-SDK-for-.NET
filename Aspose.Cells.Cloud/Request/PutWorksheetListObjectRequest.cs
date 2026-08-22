using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a ListObject in the worksheet.</summary>
public class PutWorksheetListObjectRequest : IRequestOption
{
    public PutWorksheetListObjectRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int? StartRow { get; set; }
    public int? StartColumn { get; set; }
    public int? EndRow { get; set; }
    public int? EndColumn { get; set; }
    public string? Folder { get; set; }
    public bool? HasHeaders { get; set; }
    public string? DisplayName { get; set; }
    public bool? ShowTotals { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/listobjects";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (StartRow.HasValue) query["startRow"] = StartRow.Value.ToString();
        if (StartColumn.HasValue) query["startColumn"] = StartColumn.Value.ToString();
        if (EndRow.HasValue) query["endRow"] = EndRow.Value.ToString();
        if (EndColumn.HasValue) query["endColumn"] = EndColumn.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (HasHeaders.HasValue) query["hasHeaders"] = HasHeaders.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(DisplayName)) query["displayName"] = DisplayName;
        if (ShowTotals.HasValue) query["showTotals"] = ShowTotals.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
