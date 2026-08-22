using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Clear cell formats in the worksheet.</summary>
public class PostClearFormatsRequest : IRequestOption
{
    public PostClearFormatsRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string? Range { get; set; }
    public int? StartRow { get; set; }
    public int? StartColumn { get; set; }
    public int? EndRow { get; set; }
    public int? EndColumn { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/cells/clearformats";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Range)) query["range"] = Range;
        if (StartRow.HasValue) query["startRow"] = StartRow.Value.ToString();
        if (StartColumn.HasValue) query["startColumn"] = StartColumn.Value.ToString();
        if (EndRow.HasValue) query["endRow"] = EndRow.Value.ToString();
        if (EndColumn.HasValue) query["endColumn"] = EndColumn.Value.ToString();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
