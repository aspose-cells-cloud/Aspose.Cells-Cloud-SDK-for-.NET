using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Delete worksheet columns in the worksheet.</summary>
public class DeleteWorksheetColumnsRequest : IRequestOption
{
    public DeleteWorksheetColumnsRequest(string name, string sheetName, int columnIndex, int columns, bool updateReference)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ColumnIndex = columnIndex;
        Columns = columns;
        UpdateReference = updateReference;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ColumnIndex { get; }
    public int Columns { get; }
    public bool UpdateReference { get; }
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
            "/cells/columns/" +
            Uri.EscapeDataString(ColumnIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["columns"] = Columns.ToString();
        query["updateReference"] = UpdateReference ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
