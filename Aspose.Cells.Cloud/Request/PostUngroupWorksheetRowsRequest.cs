using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Ungroup rows in the worksheet.</summary>
public class PostUngroupWorksheetRowsRequest : IRequestOption
{
    public PostUngroupWorksheetRowsRequest(string name, string sheetName, int firstIndex, int lastIndex)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        FirstIndex = firstIndex;
        LastIndex = lastIndex;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int FirstIndex { get; }
    public int LastIndex { get; }
    public bool? IsAll { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/cells/rows/ungroup";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["firstIndex"] = FirstIndex.ToString();
        query["lastIndex"] = LastIndex.ToString();
        if (IsAll.HasValue) query["isAll"] = IsAll.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
