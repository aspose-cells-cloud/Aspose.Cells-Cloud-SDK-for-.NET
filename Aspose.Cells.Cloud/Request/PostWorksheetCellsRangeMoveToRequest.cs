using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Move the current range to the destination range.</summary>
public class PostWorksheetCellsRangeMoveToRequest : IRequestOption
{
    public PostWorksheetCellsRangeMoveToRequest(string name, string sheetName, Aspose.Cells.Cloud.Model.Range range, int destRow, int destColumn)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (range is null) throw new ArgumentNullException(nameof(range));
        Range = range;
        DestRow = destRow;
        DestColumn = destColumn;
    }

    public string Name { get; }
    public string SheetName { get; }
    public Aspose.Cells.Cloud.Model.Range Range { get; }
    public int DestRow { get; }
    public int DestColumn { get; }
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
            "/ranges/moveto";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["destRow"] = DestRow.ToString();
        query["destColumn"] = DestColumn.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Range;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
