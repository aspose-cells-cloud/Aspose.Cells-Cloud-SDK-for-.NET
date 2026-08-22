using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Border Response.</summary>
public class BorderResponse : CellsCloudResponse
{
    /// <summary>This class has a public property named Border of type Border that can be both read from and written to.</summary>
    [JsonPropertyName("Border")]
    public Border? Border { get; set; }

}
