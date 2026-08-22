using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TextItem model.</summary>
public class TextItem
{
    /// <summary>Gets or sets the Filename.</summary>
    [JsonPropertyName("Filename")]
    public string? Filename { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>Gets or sets the Position.</summary>
    [JsonPropertyName("Position")]
    public string? Position { get; set; }

    /// <summary>Gets or sets the Content.</summary>
    [JsonPropertyName("Content")]
    public string? Content { get; set; }

}
