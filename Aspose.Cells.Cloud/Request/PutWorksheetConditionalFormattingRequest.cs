using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add conditional formatting in the worksheet.</summary>
public class PutWorksheetConditionalFormattingRequest : IRequestOption
{
    public PutWorksheetConditionalFormattingRequest(string name, string sheetName, FormatCondition formatcondition, string cellArea)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (formatcondition is null) throw new ArgumentNullException(nameof(formatcondition));
        Formatcondition = formatcondition;
        if (string.IsNullOrEmpty(cellArea)) throw new ArgumentException("cellArea is required", nameof(cellArea));
        CellArea = cellArea;
    }

    public string Name { get; }
    public string SheetName { get; }
    public FormatCondition Formatcondition { get; }
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
            "/conditionalFormattings";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["cellArea"] = CellArea;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Formatcondition;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
