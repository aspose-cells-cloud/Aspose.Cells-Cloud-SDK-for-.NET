using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Set cell style using cell name in the worksheet.</summary>
public class PostUpdateWorksheetCellStyleRequest : IRequestOption
{
    public PostUpdateWorksheetCellStyleRequest(string name, string sheetName, string cellName, Style style)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(cellName)) throw new ArgumentException("cellName is required", nameof(cellName));
        CellName = cellName;
        if (style is null) throw new ArgumentNullException(nameof(style));
        Style = style;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string CellName { get; }
    public Style Style { get; }
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
            Uri.EscapeDataString(CellName) +
            "/style";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Style;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
