using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a color filter in the worksheet.</summary>
public class PutWorksheetColorFilterRequest : IRequestOption
{
    public PutWorksheetColorFilterRequest(string name, string sheetName, string range, int fieldIndex, ColorFilterRequest colorFilter)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        FieldIndex = fieldIndex;
        if (colorFilter is null) throw new ArgumentNullException(nameof(colorFilter));
        ColorFilter = colorFilter;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Range { get; }
    public int FieldIndex { get; }
    public ColorFilterRequest ColorFilter { get; }
    public bool? MatchBlanks { get; set; }
    public bool? Refresh { get; set; }
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
            "/autoFilter/colorFilter";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["range"] = Range;
        query["fieldIndex"] = FieldIndex.ToString();
        if (MatchBlanks.HasValue) query["matchBlanks"] = MatchBlanks.Value ? "true" : "false";
        if (Refresh.HasValue) query["refresh"] = Refresh.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => ColorFilter;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
