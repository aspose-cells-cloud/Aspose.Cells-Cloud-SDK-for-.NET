using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents task data.</summary>
public class TaskData
{
    /// <summary>Represents task description list.</summary>
    [JsonPropertyName("Tasks")]
    public List<TaskDescription>? Tasks { get; set; }

}
