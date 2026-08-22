using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Each data manipulation step that is performed when you get the query data.</summary>
public class AppliedStep
{
    /// <summary>Data manipulation step name.</summary>
    [JsonPropertyName("StepName")]
    public string? StepName { get; set; }

    /// <summary>Data manipulation name.</summary>
    [JsonPropertyName("AppliedOperate")]
    public AppliedOperate? AppliedOperate { get; set; }

}
