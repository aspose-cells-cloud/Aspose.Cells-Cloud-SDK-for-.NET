using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents save result task parameter.</summary>
public class SaveResultTaskParameter : TaskParameter
{
    /// <summary>Represents result data source.</summary>
    [JsonPropertyName("ResultSource")]
    public string? ResultSource { get; set; }

    /// <summary>Represents result destination data.</summary>
    [JsonPropertyName("ResultDestination")]
    public ResultDestination? ResultDestination { get; set; }

}
