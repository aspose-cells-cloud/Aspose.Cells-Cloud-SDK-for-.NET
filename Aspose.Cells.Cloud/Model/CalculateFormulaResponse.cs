using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CalculateFormula Response.</summary>
public class CalculateFormulaResponse : CellsCloudResponse
{
    /// <summary>A public property "Result" that can be accessed and modified with a string data type.</summary>
    [JsonPropertyName("Result")]
    public string? Result { get; set; }

}
