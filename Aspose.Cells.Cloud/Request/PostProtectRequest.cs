using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Excel files encryption.</summary>
public class PostProtectRequest : IRequestOption
{
    public PostProtectRequest(FileParameter file, ProtectWorkbookRequest protectWorkbookRequest)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
        if (protectWorkbookRequest is null) throw new ArgumentNullException(nameof(protectWorkbookRequest));
        ProtectWorkbookRequest = protectWorkbookRequest;
    }

    public FileParameter File { get; }
    public ProtectWorkbookRequest ProtectWorkbookRequest { get; }
    public string? Password { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/protect";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => ProtectWorkbookRequest;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
