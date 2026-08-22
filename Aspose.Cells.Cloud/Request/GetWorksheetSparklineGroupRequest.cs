using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve description of a sparkline group in the worksheet.</summary>
public class GetWorksheetSparklineGroupRequest : IRequestOption
{
    public GetWorksheetSparklineGroupRequest(string name, string sheetName, int sparklineIndex)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        SparklineIndex = sparklineIndex;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int SparklineIndex { get; }
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
            "/sparklineGroups/" +
            Uri.EscapeDataString(SparklineIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
