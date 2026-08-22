using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Import data into an Excel file and generate output files in various formats.</summary>
public class PostImportRequest : IRequestOption
{
    public PostImportRequest(FileParameter file)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
    }

    public FileParameter File { get; }
    public string? OutFormat { get; set; }
    public string? Password { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? Region { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/import";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(OutFormat)) query["outFormat"] = OutFormat;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
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
