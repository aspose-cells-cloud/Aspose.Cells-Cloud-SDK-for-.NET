using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TickLabels Response.</summary>
public class TickLabelsResponse : CellsCloudResponse
{
    /// <summary>Property that represents tick labels for a class.</summary>
    [JsonPropertyName("TickLabels")]
    public TickLabels? TickLabels { get; set; }

}
