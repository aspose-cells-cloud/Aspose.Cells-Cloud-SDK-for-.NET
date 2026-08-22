using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ErrorBar Response.</summary>
public class ErrorBarResponse : CellsCloudResponse
{
    /// <summary>The class has a public property named ErrorBar of type ErrorBar with a getter and setter.</summary>
    [JsonPropertyName("ErrorBar")]
    public ErrorBar? ErrorBar { get; set; }

}
