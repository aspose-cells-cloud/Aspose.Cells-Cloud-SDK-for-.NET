using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SaveOptionsData model.</summary>
public class SaveOptionsData
{
    /// <summary>Gets or sets the SaveOptions.</summary>
    [JsonPropertyName("SaveOptions")]
    public SaveOptions? SaveOptions { get; set; }

    /// <summary>Gets or sets the Filename.</summary>
    [JsonPropertyName("Filename")]
    public string? Filename { get; set; }

    /// <summary>Gets or sets the StorageName.</summary>
    [JsonPropertyName("StorageName")]
    public string? StorageName { get; set; }

}
