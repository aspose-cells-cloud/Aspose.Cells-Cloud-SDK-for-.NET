using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents task description.</summary>
public class TaskDescription
{
    /// <summary>Represents task type.</summary>
    [JsonPropertyName("TaskType")]
    public string? TaskType { get; set; }

    /// <summary>Represents task parameter.</summary>
    [JsonPropertyName("TaskParameter")]
    public TaskParameter? TaskParameter { get; set; }

}
