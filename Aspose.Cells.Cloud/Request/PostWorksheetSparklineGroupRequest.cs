using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update a sparkline group in the worksheet.</summary>
public class PostWorksheetSparklineGroupRequest : IRequestOption
{
    public PostWorksheetSparklineGroupRequest(string name, string sheetName, int sparklineGroupIndex, SparklineGroup sparklineGroup)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        SparklineGroupIndex = sparklineGroupIndex;
        if (sparklineGroup is null) throw new ArgumentNullException(nameof(sparklineGroup));
        SparklineGroup = sparklineGroup;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int SparklineGroupIndex { get; }
    public SparklineGroup SparklineGroup { get; }
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
            "/sparklineGroups/" +
            Uri.EscapeDataString(SparklineGroupIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => SparklineGroup;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
