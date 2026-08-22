using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the AutoFilter Response.</summary>
public class AutoFilterResponse : CellsCloudResponse
{
    /// <summary>A property named "AutoFilter" with a type of "AutoFilter" that can be read from and written to.</summary>
    [JsonPropertyName("AutoFilter")]
    public AutoFilter? AutoFilter { get; set; }

}
