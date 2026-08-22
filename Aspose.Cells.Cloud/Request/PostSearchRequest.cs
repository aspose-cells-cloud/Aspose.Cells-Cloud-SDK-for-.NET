using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Search for specified text within Excel files.</summary>
public class PostSearchRequest : IRequestOption
{
    public PostSearchRequest(FileParameter file, string text)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
        if (string.IsNullOrEmpty(text)) throw new ArgumentException("text is required", nameof(text));
        Text = text;
    }

    public FileParameter File { get; }
    public string Text { get; }
    public string? Password { get; set; }
    public string? Sheetname { get; set; }
    public bool? CheckExcelRestriction { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/search";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["text"] = Text;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (!string.IsNullOrEmpty(Sheetname)) query["sheetname"] = Sheetname;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
