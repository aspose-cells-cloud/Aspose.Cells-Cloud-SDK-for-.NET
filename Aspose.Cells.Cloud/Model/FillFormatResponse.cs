using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the FillFormat Response.</summary>
public class FillFormatResponse : CellsCloudResponse
{
    /// <summary>Property Summary: Allows access to the FillFormat property to get or set fill formatting properties for an object.</summary>
    [JsonPropertyName("FillFormat")]
    public FillFormat? FillFormat { get; set; }

}
