using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Create a pivot table with a list object in the worksheet.</summary>
public class PostWorksheetListObjectSummarizeWithPivotTableRequest : IRequestOption
{
    public PostWorksheetListObjectSummarizeWithPivotTableRequest(string name, string sheetName, int listObjectIndex, string destsheetName, CreatePivotTableRequest createPivotTableRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ListObjectIndex = listObjectIndex;
        if (string.IsNullOrEmpty(destsheetName)) throw new ArgumentException("destsheetName is required", nameof(destsheetName));
        DestsheetName = destsheetName;
        if (createPivotTableRequest is null) throw new ArgumentNullException(nameof(createPivotTableRequest));
        CreatePivotTableRequest = createPivotTableRequest;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ListObjectIndex { get; }
    public string DestsheetName { get; }
    public CreatePivotTableRequest CreatePivotTableRequest { get; }
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
            "/listobjects/" +
            Uri.EscapeDataString(ListObjectIndex.ToString()) +
            "/SummarizeWithPivotTable";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["destsheetName"] = DestsheetName;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => CreatePivotTableRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
