using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Translates text file content to the specified target language.</summary>
public class TranslateTextFileRequest : IRequestOption
{
    public TranslateTextFileRequest(FileParameter spreadsheet, string targetLanguage)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(targetLanguage)) throw new ArgumentException("targetLanguage is required", nameof(targetLanguage));
        TargetLanguage = targetLanguage;
    }

    public FileParameter Spreadsheet { get; }
    public string TargetLanguage { get; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/ai/translate/text-file";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["targetLanguage"] = TargetLanguage;
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
