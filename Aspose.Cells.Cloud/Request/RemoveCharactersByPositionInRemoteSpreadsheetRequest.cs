using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Deletes characters from every cell in the target range by position (first/last N, before/after a substring, or between two delimiters) while preserving formulas, formatting and data-validation.</summary>
public class RemoveCharactersByPositionInRemoteSpreadsheetRequest : IRequestOption
{
    public RemoveCharactersByPositionInRemoteSpreadsheetRequest(string name, string worksheet, string range)
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
    public int? TheFirstNCharacters { get; set; }
    public int? TheLastNCharacters { get; set; }
    public string? AllCharactersBeforeText { get; set; }
    public string? AllCharactersAfterText { get; set; }
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
            "/content/remove/characters-by-position";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (TheFirstNCharacters.HasValue) query["theFirstNCharacters"] = TheFirstNCharacters.Value.ToString();
        if (TheLastNCharacters.HasValue) query["theLastNCharacters"] = TheLastNCharacters.Value.ToString();
        if (!string.IsNullOrEmpty(AllCharactersBeforeText)) query["allCharactersBeforeText"] = AllCharactersBeforeText;
        if (!string.IsNullOrEmpty(AllCharactersAfterText)) query["allCharactersAfterText"] = AllCharactersAfterText;
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
