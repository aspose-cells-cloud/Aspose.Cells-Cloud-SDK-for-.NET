using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Compress files and generate target files in various formats, supported file formats are include Xls, Xlsx, Xlsm, Xlsb, Ods and more.</summary>
public class PostCompressRequest : IRequestOption
{
    public PostCompressRequest(FileParameter file)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
    }

    public FileParameter File { get; }
    public int? CompressLevel { get; set; }
    public string? Password { get; set; }
    public bool? CheckExcelRestriction { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/compress";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (CompressLevel.HasValue) query["CompressLevel"] = CompressLevel.Value.ToString();
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
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
