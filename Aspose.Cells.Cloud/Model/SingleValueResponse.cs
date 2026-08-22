using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SingleValue Response.</summary>
public class SingleValueResponse : CellsCloudResponse
{
    /// <summary>A property named "Value" of type "SingleValue" that can be accessed and modified is declared in the class.</summary>
    [JsonPropertyName("Value")]
    public SingleValue? Value { get; set; }

}
