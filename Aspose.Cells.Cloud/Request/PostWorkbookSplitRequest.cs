using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Split the workbook with a specific format.</summary>
public class PostWorkbookSplitRequest : IRequestOption
{
    public PostWorkbookSplitRequest(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
    }

    public string Name { get; }
    public string? Format { get; set; }
    public string? OutFolder { get; set; }
    public int? From { get; set; }
    public int? To { get; set; }
    public int? HorizontalResolution { get; set; }
    public int? VerticalResolution { get; set; }
    public string? SplitNameRule { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? OutStorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/split";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Format)) query["format"] = Format;
        if (!string.IsNullOrEmpty(OutFolder)) query["outFolder"] = OutFolder;
        if (From.HasValue) query["from"] = From.Value.ToString();
        if (To.HasValue) query["to"] = To.Value.ToString();
        if (HorizontalResolution.HasValue) query["horizontalResolution"] = HorizontalResolution.Value.ToString();
        if (VerticalResolution.HasValue) query["verticalResolution"] = VerticalResolution.Value.ToString();
        if (!string.IsNullOrEmpty(SplitNameRule)) query["splitNameRule"] = SplitNameRule;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
