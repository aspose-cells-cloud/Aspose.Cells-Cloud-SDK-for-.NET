using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve descriptions of pivot fields in the PivotTable.</summary>
public class GetPivotTableFieldRequest : IRequestOption
{
    public GetPivotTableFieldRequest(string name, string sheetName, int pivotTableIndex, int pivotFieldIndex, string pivotFieldType)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        PivotFieldIndex = pivotFieldIndex;
        if (string.IsNullOrEmpty(pivotFieldType)) throw new ArgumentException("pivotFieldType is required", nameof(pivotFieldType));
        PivotFieldType = pivotFieldType;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public int PivotFieldIndex { get; }
    public string PivotFieldType { get; }
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
            "/pivottables/" +
            Uri.EscapeDataString(PivotTableIndex.ToString()) +
            "/PivotField";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["pivotFieldIndex"] = PivotFieldIndex.ToString();
        query["pivotFieldType"] = PivotFieldType;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
