using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Hyperlink Response.</summary>
public class HyperlinkResponse : CellsCloudResponse
{
    /// <summary>A public property named "Hyperlink" of type Hyperlink with both getter and setter methods.</summary>
    [JsonPropertyName("Hyperlink")]
    public Hyperlink? Hyperlink { get; set; }

}
