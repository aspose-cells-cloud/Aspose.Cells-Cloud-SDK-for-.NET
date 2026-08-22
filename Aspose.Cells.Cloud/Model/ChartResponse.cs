using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Chart Response.</summary>
public class ChartResponse : CellsCloudResponse
{
    /// <summary>A property named "Chart" of type Chart is defined with a getter and setter in the class.</summary>
    [JsonPropertyName("Chart")]
    public Chart? Chart { get; set; }

}
