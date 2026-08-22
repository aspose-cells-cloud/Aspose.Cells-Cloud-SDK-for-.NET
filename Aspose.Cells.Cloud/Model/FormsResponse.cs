using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Forms Response.</summary>
public class FormsResponse : CellsCloudResponse
{
    /// <summary>This class has a property named Forms of type Forms that has both a getter and setter.</summary>
    [JsonPropertyName("Forms")]
    public Forms? Forms { get; set; }

}
