using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Move PivotTable in the worksheet.</summary>
public class PostWorksheetPivotTableMoveRequest : IRequestOption
{
    public PostWorksheetPivotTableMoveRequest(string name, string sheetName, int pivotTableIndex)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public int? Row { get; set; }
    public int? Column { get; set; }
    public string? DestCellName { get; set; }
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
            "/pivottables/" +
            Uri.EscapeDataString(PivotTableIndex.ToString()) +
            "/Move";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (Row.HasValue) query["row"] = Row.Value.ToString();
        if (Column.HasValue) query["column"] = Column.Value.ToString();
        if (!string.IsNullOrEmpty(DestCellName)) query["destCellName"] = DestCellName;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
