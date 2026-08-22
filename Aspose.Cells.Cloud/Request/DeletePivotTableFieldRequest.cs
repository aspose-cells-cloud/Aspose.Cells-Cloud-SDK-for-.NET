using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Delete a pivot field in the PivotTable.</summary>
public class DeletePivotTableFieldRequest : IRequestOption
{
    public DeletePivotTableFieldRequest(string name, string sheetName, int pivotTableIndex, string pivotFieldType, PivotTableFieldRequest pivotTableFieldRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        if (string.IsNullOrEmpty(pivotFieldType)) throw new ArgumentException("pivotFieldType is required", nameof(pivotFieldType));
        PivotFieldType = pivotFieldType;
        if (pivotTableFieldRequest is null) throw new ArgumentNullException(nameof(pivotTableFieldRequest));
        PivotTableFieldRequest = pivotTableFieldRequest;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public string PivotFieldType { get; }
    public PivotTableFieldRequest PivotTableFieldRequest { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "DELETE";

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
        query["pivotFieldType"] = PivotFieldType;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => PivotTableFieldRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
