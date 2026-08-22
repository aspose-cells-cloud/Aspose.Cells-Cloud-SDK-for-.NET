using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update cell style in the PivotTable.</summary>
public class PostPivotTableCellStyleRequest : IRequestOption
{
    public PostPivotTableCellStyleRequest(string name, string sheetName, int pivotTableIndex, int column, int row, Style style)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PivotTableIndex = pivotTableIndex;
        Column = column;
        Row = row;
        if (style is null) throw new ArgumentNullException(nameof(style));
        Style = style;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PivotTableIndex { get; }
    public int Column { get; }
    public int Row { get; }
    public Style Style { get; }
    public bool? NeedReCalculate { get; set; }
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
            "/Format";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["column"] = Column.ToString();
        query["row"] = Row.ToString();
        if (NeedReCalculate.HasValue) query["needReCalculate"] = NeedReCalculate.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Style;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
