using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add an icon filter in the worksheet.</summary>
public class PutWorksheetIconFilterRequest : IRequestOption
{
    public PutWorksheetIconFilterRequest(string name, string sheetName, string range, int fieldIndex, string iconSetType, int iconId)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        FieldIndex = fieldIndex;
        if (string.IsNullOrEmpty(iconSetType)) throw new ArgumentException("iconSetType is required", nameof(iconSetType));
        IconSetType = iconSetType;
        IconId = iconId;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Range { get; }
    public int FieldIndex { get; }
    public string IconSetType { get; }
    public int IconId { get; }
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
            "/autoFilter/iconFilter";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["range"] = Range;
        query["fieldIndex"] = FieldIndex.ToString();
        query["iconSetType"] = IconSetType;
        query["iconId"] = IconId.ToString();
        if (MatchBlanks.HasValue) query["matchBlanks"] = MatchBlanks.Value ? "true" : "false";
        if (Refresh.HasValue) query["refresh"] = Refresh.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
