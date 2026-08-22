using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Excel protection.</summary>
public class PostProtectWorkbookRequest : IRequestOption
{
    public PostProtectWorkbookRequest(string name, ProtectWorkbookRequest protectWorkbookRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (protectWorkbookRequest is null) throw new ArgumentNullException(nameof(protectWorkbookRequest));
        ProtectWorkbookRequest = protectWorkbookRequest;
    }

    public string Name { get; }
    public ProtectWorkbookRequest ProtectWorkbookRequest { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/protection";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => ProtectWorkbookRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
