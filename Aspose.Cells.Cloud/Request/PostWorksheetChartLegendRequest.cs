using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update chart legend in the worksheet.</summary>
public class PostWorksheetChartLegendRequest : IRequestOption
{
    public PostWorksheetChartLegendRequest(string name, string sheetName, int chartIndex, Legend legend)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ChartIndex = chartIndex;
        if (legend is null) throw new ArgumentNullException(nameof(legend));
        Legend = legend;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ChartIndex { get; }
    public Legend Legend { get; }
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
            "/charts/" +
            Uri.EscapeDataString(ChartIndex.ToString()) +
            "/legend";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Legend;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
