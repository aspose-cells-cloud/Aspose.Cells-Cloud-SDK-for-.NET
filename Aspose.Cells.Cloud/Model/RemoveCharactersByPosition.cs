using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RemoveCharactersByPosition model.</summary>
public class RemoveCharactersByPosition
{
    /// <summary>Gets or sets the TheFirstNCharacters.</summary>
    [JsonPropertyName("TheFirstNCharacters")]
    public int? TheFirstNCharacters { get; set; }

    /// <summary>Gets or sets the TheLastNCharacters.</summary>
    [JsonPropertyName("TheLastNCharacters")]
    public int? TheLastNCharacters { get; set; }

    /// <summary>Gets or sets the AllCharactersBeforeText.</summary>
    [JsonPropertyName("AllCharactersBeforeText")]
    public string? AllCharactersBeforeText { get; set; }

    /// <summary>Gets or sets the AllCharactersAfterText.</summary>
    [JsonPropertyName("AllCharactersAfterText")]
    public string? AllCharactersAfterText { get; set; }

}
