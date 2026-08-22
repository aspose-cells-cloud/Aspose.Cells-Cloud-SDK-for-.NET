using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Column Response.</summary>
public class ColumnResponse : CellsCloudResponse
{
    /// <summary>This class has a public property called "Column" of type "Column" with both getter and setter methods.</summary>
    [JsonPropertyName("Column")]
    public Column? Column { get; set; }

}
