using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Indicates performing text segmentation on the specified area according to the segmentation method, and outputting to the designated interval.</summary>
public class SplitTextRequest : IRequestOption
{
    public SplitTextRequest(FileParameter spreadsheet, string delimiters)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(delimiters)) throw new ArgumentException("delimiters is required", nameof(delimiters));
        Delimiters = delimiters;
    }

    public FileParameter Spreadsheet { get; }
    public string Delimiters { get; }
    public bool? KeepDelimitersInResultingCells { get; set; }
    public string? KeepDelimitersPosition { get; set; }
    public string? HowToSplit { get; set; }
    public string? OutPositionRange { get; set; }
    public string? Worksheet { get; set; }
    public string? Range { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/content/split/text";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["delimiters"] = Delimiters;
        if (KeepDelimitersInResultingCells.HasValue) query["keepDelimitersInResultingCells"] = KeepDelimitersInResultingCells.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(KeepDelimitersPosition)) query["keepDelimitersPosition"] = KeepDelimitersPosition;
        if (!string.IsNullOrEmpty(HowToSplit)) query["HowToSplit"] = HowToSplit;
        if (!string.IsNullOrEmpty(OutPositionRange)) query["outPositionRange"] = OutPositionRange;
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Range)) query["range"] = Range;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
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
