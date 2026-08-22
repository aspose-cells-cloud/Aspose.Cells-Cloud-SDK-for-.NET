using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve the values of cells within the specified range.</summary>
public class GetWorksheetCellsRangeValueRequest : IRequestOption
{
    public GetWorksheetCellsRangeValueRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string? Namerange { get; set; }
    public int? FirstRow { get; set; }
    public int? FirstColumn { get; set; }
    public int? RowCount { get; set; }
    public int? ColumnCount { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/ranges/value";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Namerange)) query["namerange"] = Namerange;
        if (FirstRow.HasValue) query["firstRow"] = FirstRow.Value.ToString();
        if (FirstColumn.HasValue) query["firstColumn"] = FirstColumn.Value.ToString();
        if (RowCount.HasValue) query["rowCount"] = RowCount.Value.ToString();
        if (ColumnCount.HasValue) query["columnCount"] = ColumnCount.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
