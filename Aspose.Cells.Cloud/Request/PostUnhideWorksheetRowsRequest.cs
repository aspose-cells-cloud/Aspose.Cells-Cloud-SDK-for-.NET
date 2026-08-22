using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Unhide rows in the worksheet.</summary>
public class PostUnhideWorksheetRowsRequest : IRequestOption
{
    public PostUnhideWorksheetRowsRequest(string name, string sheetName, int startrow, int totalRows)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        Startrow = startrow;
        TotalRows = totalRows;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int Startrow { get; }
    public int TotalRows { get; }
    public double? Height { get; set; }
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
            "/cells/rows/unhide";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["startrow"] = Startrow.ToString();
        query["totalRows"] = TotalRows.ToString();
        if (Height.HasValue) query["height"] = Height.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
