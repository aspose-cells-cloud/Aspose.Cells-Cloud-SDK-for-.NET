using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Perform data sorting around a range of cells.</summary>
public class PostWorksheetCellsRangeSortRequest : IRequestOption
{
    public PostWorksheetCellsRangeSortRequest(string name, string sheetName, RangeSortRequest rangeSortRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (rangeSortRequest is null) throw new ArgumentNullException(nameof(rangeSortRequest));
        RangeSortRequest = rangeSortRequest;
    }

    public string Name { get; }
    public string SheetName { get; }
    public RangeSortRequest RangeSortRequest { get; }
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
            "/ranges/sort";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => RangeSortRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
