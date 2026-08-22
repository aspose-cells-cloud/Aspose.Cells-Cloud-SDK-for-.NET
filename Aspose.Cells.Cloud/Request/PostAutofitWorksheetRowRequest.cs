using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Autofit a row in the worksheet.</summary>
public class PostAutofitWorksheetRowRequest : IRequestOption
{
    public PostAutofitWorksheetRowRequest(string name, string sheetName, int rowIndex)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        RowIndex = rowIndex;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int RowIndex { get; }
    public int? FirstColumn { get; set; }
    public int? LastColumn { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public int? RowCount { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/autofitrow";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["rowIndex"] = RowIndex.ToString();
        if (FirstColumn.HasValue) query["firstColumn"] = FirstColumn.Value.ToString();
        if (LastColumn.HasValue) query["lastColumn"] = LastColumn.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (RowCount.HasValue) query["rowCount"] = RowCount.Value.ToString();
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
