using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Validation Response.</summary>
public class ValidationResponse : CellsCloudResponse
{
    /// <summary>The class has a public property for Validation.</summary>
    [JsonPropertyName("Validation")]
    public Validation? Validation { get; set; }

}
