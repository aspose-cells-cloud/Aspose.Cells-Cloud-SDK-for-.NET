using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Indicates converting the numbers stored as text into the correct number format, replacing unwanted characters and line breaks with the desired characters, and converting accented characters to their equivalent characters without accents.</summary>
public class ConvertTextInRemoteSpreadsheetRequest : IRequestOption
{
    public ConvertTextInRemoteSpreadsheetRequest(string name, string worksheet, string range, string convertTextType)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        if (string.IsNullOrEmpty(convertTextType)) throw new ArgumentException("convertTextType is required", nameof(convertTextType));
        ConvertTextType = convertTextType;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Range { get; }
    public string ConvertTextType { get; }
    public string? SourceCharacters { get; set; }
    public string? TargetCharacters { get; set; }
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
            "/content/convert/text";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["convertTextType"] = ConvertTextType;
        if (!string.IsNullOrEmpty(SourceCharacters)) query["sourceCharacters"] = SourceCharacters;
        if (!string.IsNullOrEmpty(TargetCharacters)) query["targetCharacters"] = TargetCharacters;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
