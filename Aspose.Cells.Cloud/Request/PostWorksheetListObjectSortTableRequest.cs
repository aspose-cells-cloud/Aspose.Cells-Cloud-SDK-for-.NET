using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Sort list object in the worksheet.</summary>
public class PostWorksheetListObjectSortTableRequest : IRequestOption
{
    public PostWorksheetListObjectSortTableRequest(string name, string sheetName, int listObjectIndex, DataSorter dataSorter)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ListObjectIndex = listObjectIndex;
        if (dataSorter is null) throw new ArgumentNullException(nameof(dataSorter));
        DataSorter = dataSorter;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ListObjectIndex { get; }
    public DataSorter DataSorter { get; }
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
            "/sort";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => DataSorter;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
