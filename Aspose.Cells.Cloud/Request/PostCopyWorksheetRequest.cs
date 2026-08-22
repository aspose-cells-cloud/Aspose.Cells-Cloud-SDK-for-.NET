using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Copy contents and formats from another worksheet.</summary>
public class PostCopyWorksheetRequest : IRequestOption
{
    public PostCopyWorksheetRequest(string name, string sheetName, string sourceSheet, CopyOptions options)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(sourceSheet)) throw new ArgumentException("sourceSheet is required", nameof(sourceSheet));
        SourceSheet = sourceSheet;
        if (options is null) throw new ArgumentNullException(nameof(options));
        Options = options;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string SourceSheet { get; }
    public CopyOptions Options { get; }
    public string? SourceWorkbook { get; set; }
    public string? SourceFolder { get; set; }
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
            "/copy";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["sourceSheet"] = SourceSheet;
        if (!string.IsNullOrEmpty(SourceWorkbook)) query["sourceWorkbook"] = SourceWorkbook;
        if (!string.IsNullOrEmpty(SourceFolder)) query["sourceFolder"] = SourceFolder;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Options;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
