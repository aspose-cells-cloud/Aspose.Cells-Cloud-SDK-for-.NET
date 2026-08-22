using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update list object by index in the worksheet.</summary>
public class PostWorksheetListObjectRequest : IRequestOption
{
    public PostWorksheetListObjectRequest(string name, string sheetName, int listObjectIndex, ListObject listObject)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ListObjectIndex = listObjectIndex;
        if (listObject is null) throw new ArgumentNullException(nameof(listObject));
        ListObject = listObject;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ListObjectIndex { get; }
    public ListObject ListObject { get; }
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
            Uri.EscapeDataString(ListObjectIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => ListObject;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
