using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Hyperlinks Response.</summary>
public class HyperlinksResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "Hyperlinks" of type Hyperlinks which can be accessed and modified.</summary>
    [JsonPropertyName("Hyperlinks")]
    public Hyperlinks? Hyperlinks { get; set; }

}
