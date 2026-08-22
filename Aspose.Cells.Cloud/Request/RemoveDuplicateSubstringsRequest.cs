using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Finds and removes repeated substrings inside every cell of the chosen range, using user-defined or preset delimiters, while preserving formulas, formatting and data-validation.</summary>
public class RemoveDuplicateSubstringsRequest : IRequestOption
{
    public RemoveDuplicateSubstringsRequest(FileParameter spreadsheet, string delimiters)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(delimiters)) throw new ArgumentException("delimiters is required", nameof(delimiters));
        Delimiters = delimiters;
    }

    public FileParameter Spreadsheet { get; }
    public string Delimiters { get; }
    public bool? TreatConsecutiveDelimitersAsOne { get; set; }
    public bool? CaseSensitive { get; set; }
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
        "/v4.0/cells/content/remove/duplicate-substrings";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["delimiters"] = Delimiters;
        if (TreatConsecutiveDelimitersAsOne.HasValue) query["treatConsecutiveDelimitersAsOne"] = TreatConsecutiveDelimitersAsOne.Value ? "true" : "false";
        if (CaseSensitive.HasValue) query["caseSensitive"] = CaseSensitive.Value ? "true" : "false";
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
