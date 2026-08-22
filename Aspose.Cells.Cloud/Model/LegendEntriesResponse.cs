using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the LegendEntries Response.</summary>
public class LegendEntriesResponse : CellsCloudResponse
{
    /// <summary>Property Summary: The class includes a property for managing legend entries.</summary>
    [JsonPropertyName("LegendEntries")]
    public LegendEntries? LegendEntries { get; set; }

}
