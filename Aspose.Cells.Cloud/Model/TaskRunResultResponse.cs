using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TaskRunResult Response.</summary>
public class TaskRunResultResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "TaskRunResult" of type "TaskRunResult" that can be both accessed and modified.</summary>
    [JsonPropertyName("TaskRunResult")]
    public TaskRunResult? TaskRunResult { get; set; }

}
