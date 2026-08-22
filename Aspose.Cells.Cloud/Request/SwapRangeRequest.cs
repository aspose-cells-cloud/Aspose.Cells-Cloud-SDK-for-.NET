using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>The Swap Ranges for Excel API provides a powerful tool to move any two columns, rows, ranges, or individual cells within an Excel file. This API allows users to re-arrange their tables quickly and efficiently, ensuring that the original data formatting is preserved and all existing formulas continue to function correctly. By leveraging this API, users can streamline their data manipulation tasks and maintain the integrity of their spreadsheets.</summary>
public class SwapRangeRequest : IRequestOption
{
    public SwapRangeRequest(FileParameter spreadsheet, string worksheet1, string range1, string worksheet2, string range2)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(worksheet1)) throw new ArgumentException("worksheet1 is required", nameof(worksheet1));
        Worksheet1 = worksheet1;
        if (string.IsNullOrEmpty(range1)) throw new ArgumentException("range1 is required", nameof(range1));
        Range1 = range1;
        if (string.IsNullOrEmpty(worksheet2)) throw new ArgumentException("worksheet2 is required", nameof(worksheet2));
        Worksheet2 = worksheet2;
        if (string.IsNullOrEmpty(range2)) throw new ArgumentException("range2 is required", nameof(range2));
        Range2 = range2;
    }

    public FileParameter Spreadsheet { get; }
    public string Worksheet1 { get; }
    public string Range1 { get; }
    public string Worksheet2 { get; }
    public string Range2 { get; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/swap/range";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["worksheet1"] = Worksheet1;
        query["range1"] = Range1;
        query["worksheet2"] = Worksheet2;
        query["range2"] = Range2;
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
