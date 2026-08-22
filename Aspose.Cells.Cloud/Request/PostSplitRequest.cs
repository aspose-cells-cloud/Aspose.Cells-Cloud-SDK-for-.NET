using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Split Excel spreadsheet files based on worksheets and create output files in various formats.</summary>
public class PostSplitRequest : IRequestOption
{
    public PostSplitRequest(FileParameter file, string outFormat)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
        if (string.IsNullOrEmpty(outFormat)) throw new ArgumentException("outFormat is required", nameof(outFormat));
        OutFormat = outFormat;
    }

    public FileParameter File { get; }
    public string OutFormat { get; }
    public string? Password { get; set; }
    public int? From { get; set; }
    public int? To { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? Region { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/split";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["outFormat"] = OutFormat;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (From.HasValue) query["from"] = From.Value.ToString();
        if (To.HasValue) query["to"] = To.Value.ToString();
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
