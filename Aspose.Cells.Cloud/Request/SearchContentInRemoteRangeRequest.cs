using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Search text in the range of remoted spreadsheet.</summary>
public class SearchContentInRemoteRangeRequest : IRequestOption
{
    public SearchContentInRemoteRangeRequest(string name, string worksheet, string cellArea, string searchText)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(cellArea)) throw new ArgumentException("cellArea is required", nameof(cellArea));
        CellArea = cellArea;
        if (string.IsNullOrEmpty(searchText)) throw new ArgumentException("searchText is required", nameof(searchText));
        SearchText = searchText;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string CellArea { get; }
    public string SearchText { get; }
    public bool? IgnoringCase { get; set; }
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
            "/search/content";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["searchText"] = SearchText;
        if (IgnoringCase.HasValue) query["ignoringCase"] = IgnoringCase.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
