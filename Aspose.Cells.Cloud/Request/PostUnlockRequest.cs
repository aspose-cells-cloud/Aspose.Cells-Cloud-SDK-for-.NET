using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Unlock Excel files.</summary>
public class PostUnlockRequest : IRequestOption
{
    public PostUnlockRequest(FileParameter file, string password)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
        if (string.IsNullOrEmpty(password)) throw new ArgumentException("password is required", nameof(password));
        Password = password;
    }

    public FileParameter File { get; }
    public string Password { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/unlock";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
