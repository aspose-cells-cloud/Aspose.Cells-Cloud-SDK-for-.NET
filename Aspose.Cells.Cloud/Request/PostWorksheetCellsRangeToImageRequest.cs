using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>PostWorksheetCellsRangeToImage operation.</summary>
public class PostWorksheetCellsRangeToImageRequest : IRequestOption
{
    public PostWorksheetCellsRangeToImageRequest(string name, string sheetName, RangeConvertRequest rangeConvertRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (rangeConvertRequest is null) throw new ArgumentNullException(nameof(rangeConvertRequest));
        RangeConvertRequest = rangeConvertRequest;
    }

    public string Name { get; }
    public string SheetName { get; }
    public RangeConvertRequest RangeConvertRequest { get; }
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
            "/ranges/convertToImage";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => RangeConvertRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
