using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>The TrimSpreadsheetContent API is designed to process and trim content within a spreadsheet. This API allows users to remove extra spaces, line breaks, or other unnecessary characters from the content of selected cells. It is particularly useful for cleaning up data entries and ensuring consistency in spreadsheet formatting</summary>
public class TrimCharacterInRemoteSpreadsheetRequest : IRequestOption
{
    public TrimCharacterInRemoteSpreadsheetRequest(string name, string worksheet, string range)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Range { get; }
    public string? TrimContent { get; set; }
    public bool? TrimLeading { get; set; }
    public bool? TrimTrailing { get; set; }
    public bool? TrimSpaceBetweenWordTo1 { get; set; }
    public bool? TrimNonBreakingSpaces { get; set; }
    public bool? RemoveExtraLineBreaks { get; set; }
    public bool? RemoveAllLineBreaks { get; set; }
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
            "/content/trim";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(TrimContent)) query["trimContent"] = TrimContent;
        if (TrimLeading.HasValue) query["trimLeading"] = TrimLeading.Value ? "true" : "false";
        if (TrimTrailing.HasValue) query["trimTrailing"] = TrimTrailing.Value ? "true" : "false";
        if (TrimSpaceBetweenWordTo1.HasValue) query["trimSpaceBetweenWordTo1"] = TrimSpaceBetweenWordTo1.Value ? "true" : "false";
        if (TrimNonBreakingSpaces.HasValue) query["trimNonBreakingSpaces"] = TrimNonBreakingSpaces.Value ? "true" : "false";
        if (RemoveExtraLineBreaks.HasValue) query["removeExtraLineBreaks"] = RemoveExtraLineBreaks.Value ? "true" : "false";
        if (RemoveAllLineBreaks.HasValue) query["removeAllLineBreaks"] = RemoveAllLineBreaks.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
