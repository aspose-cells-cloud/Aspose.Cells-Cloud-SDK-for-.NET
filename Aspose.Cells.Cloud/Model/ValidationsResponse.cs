using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Validations Response.</summary>
public class ValidationsResponse : CellsCloudResponse
{
    /// <summary>This class has a public property named "Validations" of type "Validations" that includes both a getter and a setter.</summary>
    [JsonPropertyName("Validations")]
    public Validations? Validations { get; set; }

}
