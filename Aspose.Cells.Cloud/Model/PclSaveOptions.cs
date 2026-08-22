using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PclSaveOptions model.</summary>
public class PclSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the fontFullName.</summary>
    [JsonPropertyName("fontFullName")]
    public string? FontFullName { get; set; }

    /// <summary>Gets or sets the fontPclName.</summary>
    [JsonPropertyName("fontPclName")]
    public string? FontPclName { get; set; }

}
