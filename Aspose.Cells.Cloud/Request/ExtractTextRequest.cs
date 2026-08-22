using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Indicates extracting substrings, text characters, and numbers from a spreadsheet cell into another cell without having to use complex FIND, MIN, LEFT, or RIGHT formulas.</summary>
public class ExtractTextRequest : IRequestOption
{
    public ExtractTextRequest(FileParameter spreadsheet, string extractTextType, string outPositionRange)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(extractTextType)) throw new ArgumentException("extractTextType is required", nameof(extractTextType));
        ExtractTextType = extractTextType;
        if (string.IsNullOrEmpty(outPositionRange)) throw new ArgumentException("outPositionRange is required", nameof(outPositionRange));
        OutPositionRange = outPositionRange;
    }

    public FileParameter Spreadsheet { get; }
    public string ExtractTextType { get; }
    public string OutPositionRange { get; }
    public string? BeforeText { get; set; }
    public string? AfterText { get; set; }
    public int? BeforePosition { get; set; }
    public int? AfterPosition { get; set; }
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
        "/v4.0/cells/content/extract/text";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["extractTextType"] = ExtractTextType;
        query["outPositionRange"] = OutPositionRange;
        if (!string.IsNullOrEmpty(BeforeText)) query["beforeText"] = BeforeText;
        if (!string.IsNullOrEmpty(AfterText)) query["afterText"] = AfterText;
        if (BeforePosition.HasValue) query["beforePosition"] = BeforePosition.Value.ToString();
        if (AfterPosition.HasValue) query["afterPosition"] = AfterPosition.Value.ToString();
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
