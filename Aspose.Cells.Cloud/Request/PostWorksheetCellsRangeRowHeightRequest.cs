using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Sets row height of range.</summary>
public class PostWorksheetCellsRangeRowHeightRequest : IRequestOption
{
    public PostWorksheetCellsRangeRowHeightRequest(string name, string sheetName, Aspose.Cells.Cloud.Model.Range range, double value)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (range is null) throw new ArgumentNullException(nameof(range));
        Range = range;
        Value = value;
    }

    public string Name { get; }
    public string SheetName { get; }
    public Aspose.Cells.Cloud.Model.Range Range { get; }
    public double Value { get; }
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
            "/ranges/rowHeight";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["value"] = Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Range;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
