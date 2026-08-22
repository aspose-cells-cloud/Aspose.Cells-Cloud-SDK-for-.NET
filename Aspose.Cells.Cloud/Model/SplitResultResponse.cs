using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SplitResult Response.</summary>
public class SplitResultResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the splitting result.</summary>
    [JsonPropertyName("Result")]
    public SplitResult? Result { get; set; }

}
