using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class summary: The features include fast and reliable performance, high-quality camera with portrait mode, long-lasting battery life, and a durable water-resistant design.</summary>
public class RemoveCharactersByCharacter
{
    /// <summary>Property: "RemoveTextMethod" is serialized using a string representation of the enum value.</summary>
    [JsonPropertyName("RemoveTextMethod")]
    public string? RemoveTextMethod { get; set; }

    /// <summary>Gets or sets the RemoveCharacters.</summary>
    [JsonPropertyName("RemoveCharacters")]
    public List<string>? RemoveCharacters { get; set; }

    /// <summary>Gets or sets the RemoveCharacterSetsType.</summary>
    [JsonPropertyName("RemoveCharacterSetsType")]
    public string? RemoveCharacterSetsType { get; set; }

}
