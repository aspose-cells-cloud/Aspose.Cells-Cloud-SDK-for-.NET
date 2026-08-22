using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Deletes user-defined characters, predefined symbol sets, or any substring from every cell in the chosen range while preserving formulas, formatting and data-validation for a remote spreadsheet.</summary>
public class RemoveCharactersInRemoteSpreadsheetRequest : IRequestOption
{
    public RemoveCharactersInRemoteSpreadsheetRequest(string name, string worksheet, string range)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Range { get; }
    public string? RemoveTextMethod { get; set; }
    public string? CharacterSets { get; set; }
    public string? RemoveCustomValue { get; set; }
    public bool? CaseSensitive { get; set; }
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
            "/content/remove/characters";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(RemoveTextMethod)) query["removeTextMethod"] = RemoveTextMethod;
        if (!string.IsNullOrEmpty(CharacterSets)) query["characterSets"] = CharacterSets;
        if (!string.IsNullOrEmpty(RemoveCustomValue)) query["removeCustomValue"] = RemoveCustomValue;
        if (CaseSensitive.HasValue) query["caseSensitive"] = CaseSensitive.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
