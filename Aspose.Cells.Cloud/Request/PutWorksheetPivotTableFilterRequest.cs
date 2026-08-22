using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a pivot filter to the PivotTable.</summary>
public class PutWorksheetPivotTableFilterRequest : IRequestOption
{
    public PutWorksheetPivotTableFilterRequest(string name, string sheetName, int pivotTableIndex, PivotFilter filter)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        if (filter is null) throw new ArgumentNullException(nameof(filter));
        Filter = filter;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public PivotFilter Filter { get; }
    public bool? NeedReCalculate { get; set; }
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
            "/pivottables/" +
            Uri.EscapeDataString(PivotTableIndex.ToString()) +
            "/PivotFilters";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (NeedReCalculate.HasValue) query["needReCalculate"] = NeedReCalculate.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Filter;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
