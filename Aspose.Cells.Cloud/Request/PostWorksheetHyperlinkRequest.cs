using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update hyperlink by index in the worksheet.</summary>
public class PostWorksheetHyperlinkRequest : IRequestOption
{
    public PostWorksheetHyperlinkRequest(string name, string sheetName, int hyperlinkIndex, Hyperlink hyperlink)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        HyperlinkIndex = hyperlinkIndex;
        if (hyperlink is null) throw new ArgumentNullException(nameof(hyperlink));
        Hyperlink = hyperlink;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int HyperlinkIndex { get; }
    public Hyperlink Hyperlink { get; }
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
            "/hyperlinks/" +
            Uri.EscapeDataString(HyperlinkIndex.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Hyperlink;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
