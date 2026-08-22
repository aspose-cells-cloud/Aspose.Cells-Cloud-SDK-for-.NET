using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Finds and removes repeated substrings inside every cell of the chosen range, using user-defined or preset delimiters, while preserving formulas, formatting and data-validation.</summary>
public class RemoveDuplicateSubstringsInRemoteSpreadsheetRequest : IRequestOption
{
    public RemoveDuplicateSubstringsInRemoteSpreadsheetRequest(string name, string worksheet, string range, string delimiters)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        if (string.IsNullOrEmpty(delimiters)) throw new ArgumentException("delimiters is required", nameof(delimiters));
        Delimiters = delimiters;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Range { get; }
    public string Delimiters { get; }
    public bool? TreatConsecutiveDelimitersAsOne { get; set; }
    public bool? CaseSensitive { get; set; }
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
            "/range/" +
            Uri.EscapeDataString(Range) +
            "/content/remove/duplicate-substrings";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["delimiters"] = Delimiters;
        if (TreatConsecutiveDelimitersAsOne.HasValue) query["treatConsecutiveDelimitersAsOne"] = TreatConsecutiveDelimitersAsOne.Value ? "true" : "false";
        if (CaseSensitive.HasValue) query["caseSensitive"] = CaseSensitive.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
