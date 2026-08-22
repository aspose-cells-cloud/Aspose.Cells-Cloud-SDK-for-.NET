using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Styles Response.</summary>
public class StylesResponse : CellsCloudResponse
{
    /// <summary>collection of styles.</summary>
    [JsonPropertyName("Styles")]
    public Styles? Styles { get; set; }

}
