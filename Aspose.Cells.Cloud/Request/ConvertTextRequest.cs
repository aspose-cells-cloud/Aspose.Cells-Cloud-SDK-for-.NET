using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Indicates converting the numbers stored as text into the correct number format, replacing unwanted characters and line breaks with the desired characters, and converting accented characters to their equivalent characters without accents.</summary>
public class ConvertTextRequest : IRequestOption
{
    public ConvertTextRequest(FileParameter spreadsheet, string convertTextType)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(convertTextType)) throw new ArgumentException("convertTextType is required", nameof(convertTextType));
        ConvertTextType = convertTextType;
    }

    public FileParameter Spreadsheet { get; }
    public string ConvertTextType { get; }
    public string? SourceCharacters { get; set; }
    public string? TargetCharacters { get; set; }
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
        "/v4.0/cells/content/convert/text";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["convertTextType"] = ConvertTextType;
        if (!string.IsNullOrEmpty(SourceCharacters)) query["sourceCharacters"] = SourceCharacters;
        if (!string.IsNullOrEmpty(TargetCharacters)) query["targetCharacters"] = TargetCharacters;
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
