using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Unhide worksheet columns in the worksheet.</summary>
public class PostUnhideWorksheetColumnsRequest : IRequestOption
{
    public PostUnhideWorksheetColumnsRequest(string name, string sheetName, int startColumn, int totalColumns)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        StartColumn = startColumn;
        TotalColumns = totalColumns;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int StartColumn { get; }
    public int TotalColumns { get; }
    public double? Width { get; set; }
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
            "/cells/columns/unhide";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["startColumn"] = StartColumn.ToString();
        query["totalColumns"] = TotalColumns.ToString();
        if (Width.HasValue) query["width"] = Width.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
