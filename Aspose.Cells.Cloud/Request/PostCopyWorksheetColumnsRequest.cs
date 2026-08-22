using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Copy data from source columns to destination columns in the worksheet.</summary>
public class PostCopyWorksheetColumnsRequest : IRequestOption
{
    public PostCopyWorksheetColumnsRequest(string name, string sheetName, int sourceColumnIndex, int destinationColumnIndex, int columnNumber)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        SourceColumnIndex = sourceColumnIndex;
        DestinationColumnIndex = destinationColumnIndex;
        ColumnNumber = columnNumber;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int SourceColumnIndex { get; }
    public int DestinationColumnIndex { get; }
    public int ColumnNumber { get; }
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
            "/cells/columns/copy";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["sourceColumnIndex"] = SourceColumnIndex.ToString();
        query["destinationColumnIndex"] = DestinationColumnIndex.ToString();
        query["columnNumber"] = ColumnNumber.ToString();
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
