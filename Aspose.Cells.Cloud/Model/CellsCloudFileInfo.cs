using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsCloudFileInfo model.</summary>
public class CellsCloudFileInfo
{
    /// <summary>Gets or sets the Name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the Size.</summary>
    [JsonPropertyName("Size")]
    public long? Size { get; set; }

    /// <summary>Gets or sets the Folder.</summary>
    [JsonPropertyName("Folder")]
    public string? Folder { get; set; }

    /// <summary>Gets or sets the Storage.</summary>
    [JsonPropertyName("Storage")]
    public string? Storage { get; set; }

}
