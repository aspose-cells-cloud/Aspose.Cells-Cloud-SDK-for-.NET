using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a new chart in the worksheet.</summary>
public class PutWorksheetChartRequest : IRequestOption
{
    public PutWorksheetChartRequest(string name, string sheetName, string chartType)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(chartType)) throw new ArgumentException("chartType is required", nameof(chartType));
        ChartType = chartType;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string ChartType { get; }
    public int? UpperLeftRow { get; set; }
    public int? UpperLeftColumn { get; set; }
    public int? LowerRightRow { get; set; }
    public int? LowerRightColumn { get; set; }
    public string? Area { get; set; }
    public bool? IsVertical { get; set; }
    public string? CategoryData { get; set; }
    public bool? IsAutoGetSerialName { get; set; }
    public string? Title { get; set; }
    public string? Folder { get; set; }
    public bool? DataLabels { get; set; }
    public string? DataLabelsPosition { get; set; }
    public string? PivotTableSheet { get; set; }
    public string? PivotTableName { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/charts";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["chartType"] = ChartType;
        if (UpperLeftRow.HasValue) query["upperLeftRow"] = UpperLeftRow.Value.ToString();
        if (UpperLeftColumn.HasValue) query["upperLeftColumn"] = UpperLeftColumn.Value.ToString();
        if (LowerRightRow.HasValue) query["lowerRightRow"] = LowerRightRow.Value.ToString();
        if (LowerRightColumn.HasValue) query["lowerRightColumn"] = LowerRightColumn.Value.ToString();
        if (!string.IsNullOrEmpty(Area)) query["area"] = Area;
        if (IsVertical.HasValue) query["isVertical"] = IsVertical.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(CategoryData)) query["categoryData"] = CategoryData;
        if (IsAutoGetSerialName.HasValue) query["isAutoGetSerialName"] = IsAutoGetSerialName.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Title)) query["title"] = Title;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (DataLabels.HasValue) query["dataLabels"] = DataLabels.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(DataLabelsPosition)) query["dataLabelsPosition"] = DataLabelsPosition;
        if (!string.IsNullOrEmpty(PivotTableSheet)) query["pivotTableSheet"] = PivotTableSheet;
        if (!string.IsNullOrEmpty(PivotTableName)) query["pivotTableName"] = PivotTableName;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
