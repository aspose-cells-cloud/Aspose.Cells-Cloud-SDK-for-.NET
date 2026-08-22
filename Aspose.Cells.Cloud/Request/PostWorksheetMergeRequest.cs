using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Merge cells in the worksheet.</summary>
public class PostWorksheetMergeRequest : IRequestOption
{
    public PostWorksheetMergeRequest(string name, string sheetName, int startRow, int startColumn, int totalRows, int totalColumns)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        StartRow = startRow;
        StartColumn = startColumn;
        TotalRows = totalRows;
        TotalColumns = totalColumns;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int StartRow { get; }
    public int StartColumn { get; }
    public int TotalRows { get; }
    public int TotalColumns { get; }
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
            "/cells/merge";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["startRow"] = StartRow.ToString();
        query["startColumn"] = StartColumn.ToString();
        query["totalRows"] = TotalRows.ToString();
        query["totalColumns"] = TotalColumns.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
