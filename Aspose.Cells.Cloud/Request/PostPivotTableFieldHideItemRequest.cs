using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Hide a pivot field item in the PivotTable.</summary>
public class PostPivotTableFieldHideItemRequest : IRequestOption
{
    public PostPivotTableFieldHideItemRequest(string name, string sheetName, int pivotTableIndex, string pivotFieldType, int fieldIndex, int itemIndex, bool isHide)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        if (string.IsNullOrEmpty(pivotFieldType)) throw new ArgumentException("pivotFieldType is required", nameof(pivotFieldType));
        PivotFieldType = pivotFieldType;
        FieldIndex = fieldIndex;
        ItemIndex = itemIndex;
        IsHide = isHide;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public string PivotFieldType { get; }
    public int FieldIndex { get; }
    public int ItemIndex { get; }
    public bool IsHide { get; }
    public bool? NeedReCalculate { get; set; }
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
            "/pivottables/" +
            Uri.EscapeDataString(PivotTableIndex.ToString()) +
            "/PivotField/Hide";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["pivotFieldType"] = PivotFieldType;
        query["fieldIndex"] = FieldIndex.ToString();
        query["itemIndex"] = ItemIndex.ToString();
        query["isHide"] = IsHide ? "true" : "false";
        if (NeedReCalculate.HasValue) query["needReCalculate"] = NeedReCalculate.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
