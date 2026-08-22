using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Worksheet Response.</summary>
public class WorksheetResponse : CellsCloudResponse
{
    /// <summary>The class has a property called "Worksheet" of type "Worksheet" that can be accessed and modified.</summary>
    [JsonPropertyName("Worksheet")]
    public Worksheet? Worksheet { get; set; }

}
