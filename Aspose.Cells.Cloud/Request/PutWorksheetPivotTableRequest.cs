using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a PivotTable in the worksheet.</summary>
public class PutWorksheetPivotTableRequest : IRequestOption
{
    public PutWorksheetPivotTableRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string? Folder { get; set; }
    public string? SourceData { get; set; }
    public string? DestCellName { get; set; }
    public string? TableName { get; set; }
    public bool? UseSameSource { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/pivottables";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(SourceData)) query["sourceData"] = SourceData;
        if (!string.IsNullOrEmpty(DestCellName)) query["destCellName"] = DestCellName;
        if (!string.IsNullOrEmpty(TableName)) query["tableName"] = TableName;
        if (UseSameSource.HasValue) query["useSameSource"] = UseSameSource.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
