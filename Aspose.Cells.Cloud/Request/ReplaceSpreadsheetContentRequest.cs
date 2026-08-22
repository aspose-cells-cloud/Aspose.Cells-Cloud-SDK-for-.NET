using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Replace text in the local spreadsheet.</summary>
public class ReplaceSpreadsheetContentRequest : IRequestOption
{
    public ReplaceSpreadsheetContentRequest(FileParameter spreadsheet, string searchText, string replaceText)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(searchText)) throw new ArgumentException("searchText is required", nameof(searchText));
        SearchText = searchText;
        if (string.IsNullOrEmpty(replaceText)) throw new ArgumentException("replaceText is required", nameof(replaceText));
        ReplaceText = replaceText;
    }

    public FileParameter Spreadsheet { get; }
    public string SearchText { get; }
    public string ReplaceText { get; }
    public string? Worksheet { get; set; }
    public string? CellArea { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/replace/content";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["searchText"] = SearchText;
        query["replaceText"] = ReplaceText;
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(CellArea)) query["cellArea"] = CellArea;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + Spreadsheet.FileName] = Spreadsheet,
        };
}
