using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the MergedCell Response.</summary>
public class MergedCellResponse : CellsCloudResponse
{
    /// <summary>A property named "MergedCell" of type "MergedCell" which allows getting and setting its value.</summary>
    [JsonPropertyName("MergedCell")]
    public MergedCell? MergedCell { get; set; }

}
