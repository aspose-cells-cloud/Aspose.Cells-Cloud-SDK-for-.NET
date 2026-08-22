using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a cell area for the format condition in the worksheet.</summary>
public class PutWorksheetFormatConditionAreaRequest : IRequestOption
{
    public PutWorksheetFormatConditionAreaRequest(string name, string sheetName, int index, string cellArea)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        Index = index;
        if (string.IsNullOrEmpty(cellArea)) throw new ArgumentException("cellArea is required", nameof(cellArea));
        CellArea = cellArea;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int Index { get; }
    public string CellArea { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/conditionalFormattings/" +
            Uri.EscapeDataString(Index.ToString()) +
            "/area";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["cellArea"] = CellArea;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
