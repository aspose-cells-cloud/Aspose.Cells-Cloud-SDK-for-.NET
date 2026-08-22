using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update page footer in the worksheet.</summary>
public class PostFooterRequest : IRequestOption
{
    public PostFooterRequest(string name, string sheetName, int section, string script, bool isFirstPage)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        Section = section;
        if (string.IsNullOrEmpty(script)) throw new ArgumentException("script is required", nameof(script));
        Script = script;
        IsFirstPage = isFirstPage;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int Section { get; }
    public string Script { get; }
    public bool IsFirstPage { get; }
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
            "/pagesetup/footer";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["section"] = Section.ToString();
        query["script"] = Script;
        query["isFirstPage"] = IsFirstPage ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
