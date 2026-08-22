using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add cell comment in the worksheet.</summary>
public class PutWorksheetCommentRequest : IRequestOption
{
    public PutWorksheetCommentRequest(string name, string sheetName, string cellName, Comment comment)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(cellName)) throw new ArgumentException("cellName is required", nameof(cellName));
        CellName = cellName;
        if (comment is null) throw new ArgumentNullException(nameof(comment));
        Comment = comment;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string CellName { get; }
    public Comment Comment { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/comments/" +
            Uri.EscapeDataString(CellName);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Comment;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
