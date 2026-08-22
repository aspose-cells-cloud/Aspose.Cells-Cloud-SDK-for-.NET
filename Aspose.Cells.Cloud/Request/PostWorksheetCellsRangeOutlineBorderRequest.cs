using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Apply an outline border around a range of cells.</summary>
public class PostWorksheetCellsRangeOutlineBorderRequest : IRequestOption
{
    public PostWorksheetCellsRangeOutlineBorderRequest(string name, string sheetName, RangeSetOutlineBorderRequest rangeOperate)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (rangeOperate is null) throw new ArgumentNullException(nameof(rangeOperate));
        RangeOperate = rangeOperate;
    }

    public string Name { get; }
    public string SheetName { get; }
    public RangeSetOutlineBorderRequest RangeOperate { get; }
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
            "/ranges/outlineBorder";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => RangeOperate;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
