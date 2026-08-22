using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Insert a range of cells and shift existing cells based on the specified shift option.</summary>
public class PutWorksheetCellsRangeRequest : IRequestOption
{
    public PutWorksheetCellsRangeRequest(string name, string sheetName, string range, string shift)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        if (string.IsNullOrEmpty(shift)) throw new ArgumentException("shift is required", nameof(shift));
        Shift = shift;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Range { get; }
    public string Shift { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/ranges";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["range"] = Range;
        query["shift"] = Shift;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
