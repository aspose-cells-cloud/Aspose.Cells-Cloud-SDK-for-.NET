using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Set cell value using cell name in the worksheet.</summary>
public class PostWorksheetCellSetValueRequest : IRequestOption
{
    public PostWorksheetCellSetValueRequest(string name, string sheetName, string cellName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(cellName)) throw new ArgumentException("cellName is required", nameof(cellName));
        CellName = cellName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string CellName { get; }
    public string? Value { get; set; }
    public string? Type { get; set; }
    public string? Formula { get; set; }
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
            "/cells/" +
            Uri.EscapeDataString(CellName);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Value)) query["value"] = Value;
        if (!string.IsNullOrEmpty(Type)) query["type"] = Type;
        if (!string.IsNullOrEmpty(Formula)) query["formula"] = Formula;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
