using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Deletes characters from every cell in the target range by position (first/last N, before/after a substring, or between two delimiters) while preserving formulas, formatting and data-validation.</summary>
public class RemoveCharactersByPositionRequest : IRequestOption
{
    public RemoveCharactersByPositionRequest(FileParameter spreadsheet)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
    }

    public FileParameter Spreadsheet { get; }
    public int? TheFirstNCharacters { get; set; }
    public int? TheLastNCharacters { get; set; }
    public string? AllCharactersBeforeText { get; set; }
    public string? AllCharactersAfterText { get; set; }
    public bool? CaseSensitive { get; set; }
    public string? Worksheet { get; set; }
    public string? Range { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/content/remove/characters-by-position";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (TheFirstNCharacters.HasValue) query["theFirstNCharacters"] = TheFirstNCharacters.Value.ToString();
        if (TheLastNCharacters.HasValue) query["theLastNCharacters"] = TheLastNCharacters.Value.ToString();
        if (!string.IsNullOrEmpty(AllCharactersBeforeText)) query["allCharactersBeforeText"] = AllCharactersBeforeText;
        if (!string.IsNullOrEmpty(AllCharactersAfterText)) query["allCharactersAfterText"] = AllCharactersAfterText;
        if (CaseSensitive.HasValue) query["caseSensitive"] = CaseSensitive.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Range)) query["range"] = Range;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + Spreadsheet.FileName] = Spreadsheet,
        };
}
