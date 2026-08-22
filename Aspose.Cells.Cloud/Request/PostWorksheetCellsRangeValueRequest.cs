using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Assign a value to the range; if necessary, the value will be converted to another data type, and the cell's number format will be reset.</summary>
public class PostWorksheetCellsRangeValueRequest : IRequestOption
{
    public PostWorksheetCellsRangeValueRequest(string name, string sheetName, Aspose.Cells.Cloud.Model.Range range, string value)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (range is null) throw new ArgumentNullException(nameof(range));
        Range = range;
        if (string.IsNullOrEmpty(value)) throw new ArgumentException("Value is required", nameof(value));
        Value = value;
    }

    public string Name { get; }
    public string SheetName { get; }
    public Aspose.Cells.Cloud.Model.Range Range { get; }
    public string Value { get; }
    public bool? IsConverted { get; set; }
    public bool? SetStyle { get; set; }
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
            "/ranges/value";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["Value"] = Value;
        if (IsConverted.HasValue) query["isConverted"] = IsConverted.Value ? "true" : "false";
        if (SetStyle.HasValue) query["setStyle"] = SetStyle.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Range;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
