using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the BrokenLink model.</summary>
public class BrokenLink
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

    /// <summary>Gets or sets the LinkAddress.</summary>
    [JsonPropertyName("LinkAddress")]
    public string? LinkAddress { get; set; }

}
