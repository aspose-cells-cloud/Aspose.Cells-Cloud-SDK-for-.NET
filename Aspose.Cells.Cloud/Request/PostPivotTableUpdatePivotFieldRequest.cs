using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update pivot field in the PivotTable.</summary>
public class PostPivotTableUpdatePivotFieldRequest : IRequestOption
{
    public PostPivotTableUpdatePivotFieldRequest(string name, string sheetName, int pivotTableIndex, int pivotFieldIndex, string pivotFieldType, PivotField pivotField)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        PivotFieldIndex = pivotFieldIndex;
        if (string.IsNullOrEmpty(pivotFieldType)) throw new ArgumentException("pivotFieldType is required", nameof(pivotFieldType));
        PivotFieldType = pivotFieldType;
        if (pivotField is null) throw new ArgumentNullException(nameof(pivotField));
        PivotField = pivotField;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public int PivotFieldIndex { get; }
    public string PivotFieldType { get; }
    public PivotField PivotField { get; }
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
            "/PivotFields/" +
            Uri.EscapeDataString(PivotFieldIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["pivotFieldType"] = PivotFieldType;
        if (NeedReCalculate.HasValue) query["needReCalculate"] = NeedReCalculate.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => PivotField;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
