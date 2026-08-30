using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RemoveCharactersByCharacter model.</summary>
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
