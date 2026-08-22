using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update a named range in the workbook.</summary>
public class PostWorkbookNameRequest : IRequestOption
{
    public PostWorkbookNameRequest(string name, string nameName, Name newName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(nameName)) throw new ArgumentException("nameName is required", nameof(nameName));
        NameName = nameName;
        if (newName is null) throw new ArgumentNullException(nameof(newName));
        NewName = newName;
    }

    public string Name { get; }
    public string NameName { get; }
    public Name NewName { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/names/" +
            Uri.EscapeDataString(NameName);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => NewName;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
