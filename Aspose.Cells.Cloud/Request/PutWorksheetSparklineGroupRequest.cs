using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a sparkline group in the worksheet.</summary>
public class PutWorksheetSparklineGroupRequest : IRequestOption
{
    public PutWorksheetSparklineGroupRequest(string name, string sheetName, string type, string dataRange, bool isVertical, string locationRange)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(type)) throw new ArgumentException("type is required", nameof(type));
        Type = type;
        if (string.IsNullOrEmpty(dataRange)) throw new ArgumentException("dataRange is required", nameof(dataRange));
        DataRange = dataRange;
        IsVertical = isVertical;
        if (string.IsNullOrEmpty(locationRange)) throw new ArgumentException("locationRange is required", nameof(locationRange));
        LocationRange = locationRange;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Type { get; }
    public string DataRange { get; }
    public bool IsVertical { get; }
    public string LocationRange { get; }
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
            "/sparklineGroups";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["type"] = Type;
        query["dataRange"] = DataRange;
        query["isVertical"] = IsVertical ? "true" : "false";
        query["locationRange"] = LocationRange;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
