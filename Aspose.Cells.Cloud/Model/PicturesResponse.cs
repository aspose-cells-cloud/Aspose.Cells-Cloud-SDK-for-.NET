using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Pictures Response.</summary>
public class PicturesResponse : CellsCloudResponse
{
    /// <summary>This class has a property called "Pictures" with the feature of being serialized as "pictures" in XML elements.</summary>
    [JsonPropertyName("Pictures")]
    public Pictures? Pictures { get; set; }

}
