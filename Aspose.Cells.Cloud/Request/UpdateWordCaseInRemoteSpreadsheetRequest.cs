using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Specify changing the text case in a remote spreadsheet to switch between uppercase, lowercase, capitalizing the first letter of each word, or capitalizing the first letter of a sentence, and adjust the text according to specific needs.</summary>
public class UpdateWordCaseInRemoteSpreadsheetRequest : IRequestOption
{
    public UpdateWordCaseInRemoteSpreadsheetRequest(string name, string worksheet, string range, string wordCaseType)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        if (string.IsNullOrEmpty(wordCaseType)) throw new ArgumentException("wordCaseType is required", nameof(wordCaseType));
        WordCaseType = wordCaseType;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Range { get; }
    public string WordCaseType { get; }
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
            "/content/wordcase";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["wordCaseType"] = WordCaseType;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
