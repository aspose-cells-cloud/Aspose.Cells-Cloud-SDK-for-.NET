using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Replace text in the range of remoted spreadsheet.</summary>
public class ReplaceContentInRemoteRangeRequest : IRequestOption
{
    public ReplaceContentInRemoteRangeRequest(string name, string searchText, string replaceText, string worksheet, string cellArea)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(searchText)) throw new ArgumentException("searchText is required", nameof(searchText));
        SearchText = searchText;
        if (string.IsNullOrEmpty(replaceText)) throw new ArgumentException("replaceText is required", nameof(replaceText));
        ReplaceText = replaceText;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(cellArea)) throw new ArgumentException("cellArea is required", nameof(cellArea));
        CellArea = cellArea;
    }

    public string Name { get; }
    public string SearchText { get; }
    public string ReplaceText { get; }
    public string Worksheet { get; }
    public string CellArea { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(Worksheet) +
            "/ranges/" +
            Uri.EscapeDataString(CellArea) +
            "/replace/content";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["searchText"] = SearchText;
        query["replaceText"] = ReplaceText;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
