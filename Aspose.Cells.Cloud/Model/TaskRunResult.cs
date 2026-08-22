using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents task run result.</summary>
public class TaskRunResult
{
    /// <summary>Represents task run result description.</summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>Represents out data file list.</summary>
    [JsonPropertyName("OutFileList")]
    public List<DataSource>? OutFileList { get; set; }

}
