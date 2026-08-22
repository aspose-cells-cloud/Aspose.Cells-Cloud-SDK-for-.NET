using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Set the value of the range in the worksheet.</summary>
public class PostSetCellRangeValueRequest : IRequestOption
{
    public PostSetCellRangeValueRequest(string name, string sheetName, string cellarea, string value, string type)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(cellarea)) throw new ArgumentException("cellarea is required", nameof(cellarea));
        Cellarea = cellarea;
        if (string.IsNullOrEmpty(value)) throw new ArgumentException("value is required", nameof(value));
        Value = value;
        if (string.IsNullOrEmpty(type)) throw new ArgumentException("type is required", nameof(type));
        Type = type;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Cellarea { get; }
    public string Value { get; }
    public string Type { get; }
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
            "/cells";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["cellarea"] = Cellarea;
        query["value"] = Value;
        query["type"] = Type;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
