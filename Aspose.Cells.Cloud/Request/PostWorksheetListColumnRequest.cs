using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update list column in list object.</summary>
public class PostWorksheetListColumnRequest : IRequestOption
{
    public PostWorksheetListColumnRequest(string name, string sheetName, int listObjectIndex, int columnIndex, ListColumn listColumn)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ListObjectIndex = listObjectIndex;
        ColumnIndex = columnIndex;
        if (listColumn is null) throw new ArgumentNullException(nameof(listColumn));
        ListColumn = listColumn;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ListObjectIndex { get; }
    public int ColumnIndex { get; }
    public ListColumn ListColumn { get; }
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
            "/listcolumns/" +
            Uri.EscapeDataString(ColumnIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => ListColumn;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
