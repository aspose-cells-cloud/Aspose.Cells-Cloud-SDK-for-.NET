using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Copy data and formats from specific entire rows in the worksheet.</summary>
public class PostCopyWorksheetRowsRequest : IRequestOption
{
    public PostCopyWorksheetRowsRequest(string name, string sheetName, int sourceRowIndex, int destinationRowIndex, int rowNumber)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        SourceRowIndex = sourceRowIndex;
        DestinationRowIndex = destinationRowIndex;
        RowNumber = rowNumber;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int SourceRowIndex { get; }
    public int DestinationRowIndex { get; }
    public int RowNumber { get; }
    public string? Worksheet { get; set; }
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
            "/cells/rows/copy";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["sourceRowIndex"] = SourceRowIndex.ToString();
        query["destinationRowIndex"] = DestinationRowIndex.ToString();
        query["rowNumber"] = RowNumber.ToString();
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
