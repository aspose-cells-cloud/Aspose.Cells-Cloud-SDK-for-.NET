using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve the worksheet in a specified format from the workbook.</summary>
public class GetWorksheetWithFormatRequest : IRequestOption
{
    public GetWorksheetWithFormatRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string? Format { get; set; }
    public int? VerticalResolution { get; set; }
    public int? HorizontalResolution { get; set; }
    public string? Area { get; set; }
    public int? PageIndex { get; set; }
    public bool? OnePagePerSheet { get; set; }
    public bool? PrintHeadings { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Format)) query["format"] = Format;
        if (VerticalResolution.HasValue) query["verticalResolution"] = VerticalResolution.Value.ToString();
        if (HorizontalResolution.HasValue) query["horizontalResolution"] = HorizontalResolution.Value.ToString();
        if (!string.IsNullOrEmpty(Area)) query["area"] = Area;
        if (PageIndex.HasValue) query["pageIndex"] = PageIndex.Value.ToString();
        if (OnePagePerSheet.HasValue) query["onePagePerSheet"] = OnePagePerSheet.Value ? "true" : "false";
        if (PrintHeadings.HasValue) query["printHeadings"] = PrintHeadings.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
