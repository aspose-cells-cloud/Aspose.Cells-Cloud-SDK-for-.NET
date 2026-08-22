using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the LegendEntry Response.</summary>
public class LegendEntryResponse : CellsCloudResponse
{
    /// <summary>A public property called LegendEntry of type LegendEntry with both getter and setter methods.</summary>
    [JsonPropertyName("LegendEntry")]
    public LegendEntry? LegendEntry { get; set; }

}
