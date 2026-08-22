using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a range of characters within the cell text.</summary>
public class FontSetting
{
    /// <summary>Returns the font of this object.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>Gets the length of the characters.</summary>
    [JsonPropertyName("Length")]
    public int? Length { get; set; }

    /// <summary>Gets the start index of the characters.</summary>
    [JsonPropertyName("StartIndex")]
    public int? StartIndex { get; set; }

    /// <summary>Returns the text options.</summary>
    [JsonPropertyName("TextOptions")]
    public TextOptions? TextOptions { get; set; }

    /// <summary>Gets the type of text node.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
