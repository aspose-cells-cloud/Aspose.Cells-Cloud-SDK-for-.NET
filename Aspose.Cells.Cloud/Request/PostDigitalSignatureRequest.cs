using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Excel file digital signature.</summary>
public class PostDigitalSignatureRequest : IRequestOption
{
    public PostDigitalSignatureRequest(string name, string digitalsignaturefile, string password)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(digitalsignaturefile)) throw new ArgumentException("digitalsignaturefile is required", nameof(digitalsignaturefile));
        Digitalsignaturefile = digitalsignaturefile;
        if (string.IsNullOrEmpty(password)) throw new ArgumentException("password is required", nameof(password));
        Password = password;
    }

    public string Name { get; }
    public string Digitalsignaturefile { get; }
    public string Password { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/digitalsignature";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["digitalsignaturefile"] = Digitalsignaturefile;
        query["password"] = Password;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
