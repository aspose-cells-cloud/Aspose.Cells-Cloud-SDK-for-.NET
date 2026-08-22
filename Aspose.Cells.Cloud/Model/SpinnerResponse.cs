using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Spinner Response.</summary>
public class SpinnerResponse : CellsCloudResponse
{
    /// <summary>A property named Shape of type Spinner, with both get and set accessors.</summary>
    [JsonPropertyName("Shape")]
    public Spinner? Shape { get; set; }

}
