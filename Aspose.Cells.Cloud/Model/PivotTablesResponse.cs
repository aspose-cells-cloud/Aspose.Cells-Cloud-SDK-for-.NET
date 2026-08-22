using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PivotTables Response.</summary>
public class PivotTablesResponse : CellsCloudResponse
{
    /// <summary>This class has a property named PivotTables of type PivotTables that can be both accessed and modified.</summary>
    [JsonPropertyName("PivotTables")]
    public PivotTables? PivotTables { get; set; }

}
