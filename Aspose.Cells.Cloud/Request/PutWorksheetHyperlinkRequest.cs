using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add hyperlink in the worksheet.</summary>
public class PutWorksheetHyperlinkRequest : IRequestOption
{
    public PutWorksheetHyperlinkRequest(string name, string sheetName, int firstRow, int firstColumn, int totalRows, int totalColumns, string address)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        FirstRow = firstRow;
        FirstColumn = firstColumn;
        TotalRows = totalRows;
        TotalColumns = totalColumns;
        if (string.IsNullOrEmpty(address)) throw new ArgumentException("address is required", nameof(address));
        Address = address;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int FirstRow { get; }
    public int FirstColumn { get; }
    public int TotalRows { get; }
    public int TotalColumns { get; }
    public string Address { get; }
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
            "/hyperlinks";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["firstRow"] = FirstRow.ToString();
        query["firstColumn"] = FirstColumn.ToString();
        query["totalRows"] = TotalRows.ToString();
        query["totalColumns"] = TotalColumns.ToString();
        query["address"] = Address;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
