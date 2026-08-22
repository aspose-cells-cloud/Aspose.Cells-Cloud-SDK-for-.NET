using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DataLabels Response.</summary>
public class DataLabelsResponse : CellsCloudResponse
{
    /// <summary>This class has a property named DataLabels of type DataLabels that can be accessed and modified.</summary>
    [JsonPropertyName("DataLabels")]
    public DataLabels? DataLabels { get; set; }

}
