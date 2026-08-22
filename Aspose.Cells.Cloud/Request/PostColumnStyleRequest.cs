using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Set column style in the worksheet.</summary>
public class PostColumnStyleRequest : IRequestOption
{
    public PostColumnStyleRequest(string name, string sheetName, int columnIndex, Style style)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        ColumnIndex = columnIndex;
        if (style is null) throw new ArgumentNullException(nameof(style));
        Style = style;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int ColumnIndex { get; }
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
            "/cells/columns/" +
            Uri.EscapeDataString(ColumnIndex.ToString()) +
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
