using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Specify appending text to multiple cells at once, allowing you to add prefixes, suffixes, labels, or any specific characters. You can choose the exact position of the text—in the beginning, at the end, or before or after certain characters in the cell.</summary>
public class AddTextInRemoteSpreadsheetRequest : IRequestOption
{
    public AddTextInRemoteSpreadsheetRequest(string name, string worksheet, string range, string text, string position)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        if (string.IsNullOrEmpty(text)) throw new ArgumentException("text is required", nameof(text));
        Text = text;
        if (string.IsNullOrEmpty(position)) throw new ArgumentException("position is required", nameof(position));
        Position = position;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Range { get; }
    public string Text { get; }
    public string Position { get; }
    public string? SelectText { get; set; }
    public bool? SkipEmptyCells { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(Worksheet) +
            "/range/" +
            Uri.EscapeDataString(Range) +
            "/content/add/text";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["text"] = Text;
        query["position"] = Position;
        if (!string.IsNullOrEmpty(SelectText)) query["selectText"] = SelectText;
        if (SkipEmptyCells.HasValue) query["skipEmptyCells"] = SkipEmptyCells.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
