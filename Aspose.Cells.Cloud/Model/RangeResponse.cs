using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Range Response.</summary>
public class RangeResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "Range" of type Range with both getter and setter methods.</summary>
    [JsonPropertyName("Range")]
    public Range? Range { get; set; }

}
