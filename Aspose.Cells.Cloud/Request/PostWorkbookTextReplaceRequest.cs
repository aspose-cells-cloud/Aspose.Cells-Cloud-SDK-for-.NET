using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Replace text in the workbook.</summary>
public class PostWorkbookTextReplaceRequest : IRequestOption
{
    public PostWorkbookTextReplaceRequest(string name, string oldValue, string newValue)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(oldValue)) throw new ArgumentException("oldValue is required", nameof(oldValue));
        OldValue = oldValue;
        if (string.IsNullOrEmpty(newValue)) throw new ArgumentException("newValue is required", nameof(newValue));
        NewValue = newValue;
    }

    public string Name { get; }
    public string OldValue { get; }
    public string NewValue { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/replaceText";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["oldValue"] = OldValue;
        query["newValue"] = NewValue;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
