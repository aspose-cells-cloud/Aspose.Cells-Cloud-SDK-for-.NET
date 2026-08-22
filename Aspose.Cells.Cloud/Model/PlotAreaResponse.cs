using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PlotArea Response.</summary>
public class PlotAreaResponse : CellsCloudResponse
{
    /// <summary>A property that allows getting and setting the PlotArea for the class.</summary>
    [JsonPropertyName("PlotArea")]
    public PlotArea? PlotArea { get; set; }

}
