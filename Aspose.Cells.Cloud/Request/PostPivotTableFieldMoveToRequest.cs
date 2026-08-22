using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Move a pivot field in the PivotTable.</summary>
public class PostPivotTableFieldMoveToRequest : IRequestOption
{
    public PostPivotTableFieldMoveToRequest(string name, string sheetName, int pivotTableIndex, int fieldIndex, string from, string to)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        FieldIndex = fieldIndex;
        if (string.IsNullOrEmpty(from)) throw new ArgumentException("from is required", nameof(from));
        From = from;
        if (string.IsNullOrEmpty(to)) throw new ArgumentException("to is required", nameof(to));
        To = to;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public int FieldIndex { get; }
    public string From { get; }
    public string To { get; }
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
            "/PivotField/Move";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["fieldIndex"] = FieldIndex.ToString();
        query["from"] = From;
        query["to"] = To;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
