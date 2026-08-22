using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Copy data from a source cell to a destination cell in the worksheet.</summary>
public class PostCopyCellIntoCellRequest : IRequestOption
{
    public PostCopyCellIntoCellRequest(string name, string destCellName, string sheetName, string worksheet)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(destCellName)) throw new ArgumentException("destCellName is required", nameof(destCellName));
        DestCellName = destCellName;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
    }

    public string Name { get; }
    public string DestCellName { get; }
    public string SheetName { get; }
    public string Worksheet { get; }
    public string? Cellname { get; set; }
    public int? Row { get; set; }
    public int? Column { get; set; }
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
            "/cells/" +
            Uri.EscapeDataString(DestCellName) +
            "/copy";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Cellname)) query["cellname"] = Cellname;
        if (Row.HasValue) query["row"] = Row.Value.ToString();
        if (Column.HasValue) query["column"] = Column.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
