using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Columns Response.</summary>
public class ColumnsResponse : CellsCloudResponse
{
    /// <summary>This property allows access to the columns within the class.</summary>
    [JsonPropertyName("Columns")]
    public Columns? Columns { get; set; }

}
