using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Rows Response.</summary>
public class RowsResponse : CellsCloudResponse
{
    /// <summary>A property named "Rows" of type "Rows" which has both getter and setter methods.</summary>
    [JsonPropertyName("Rows")]
    public Rows? Rows { get; set; }

}
