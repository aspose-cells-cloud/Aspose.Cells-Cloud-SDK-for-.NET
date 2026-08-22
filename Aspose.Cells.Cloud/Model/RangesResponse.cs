using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Ranges Response.</summary>
public class RangesResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "Ranges" of type "Ranges" that can be accessed and modified.</summary>
    [JsonPropertyName("Ranges")]
    public Ranges? Ranges { get; set; }

}
