using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>The TrimSpreadsheetContent API is designed to process and trim content within a remote spreadsheet. This API allows users to remove extra spaces, line breaks, or other unnecessary characters from the content of selected cells. It is particularly useful for cleaning up data entries and ensuring consistency in spreadsheet formatting</summary>
public class TrimCharacterRequest : IRequestOption
{
    public TrimCharacterRequest(FileParameter spreadsheet)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
    }

    public FileParameter Spreadsheet { get; }
    public string? TrimContent { get; set; }
    public bool? TrimLeading { get; set; }
    public bool? TrimTrailing { get; set; }
    public bool? TrimSpaceBetweenWordTo1 { get; set; }
    public bool? TrimNonBreakingSpaces { get; set; }
    public bool? RemoveExtraLineBreaks { get; set; }
    public bool? RemoveAllLineBreaks { get; set; }
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
        "/v4.0/cells/content/trim";

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
