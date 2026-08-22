using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Repair abnormal files and generate files in various formats.</summary>
public class PostRepairRequest : IRequestOption
{
    public PostRepairRequest(FileParameter file)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
    }

    public FileParameter File { get; }
    public string? OutFormat { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/repair";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(OutFormat)) query["outFormat"] = OutFormat;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
