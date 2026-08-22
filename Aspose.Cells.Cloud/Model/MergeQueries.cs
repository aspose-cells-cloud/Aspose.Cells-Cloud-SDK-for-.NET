using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents merge quesies.</summary>
public class MergeQueries : AppliedOperate
{
    /// <summary>Indicates the name of the data query , it is matched in the data query set.</summary>
    [JsonPropertyName("DataQueryNameA")]
    public string? DataQueryNameA { get; set; }

    /// <summary>Represents index field  of DataA.</summary>
    [JsonPropertyName("DataAIndexField")]
    public string? DataAIndexField { get; set; }

    /// <summary>Indicates the name of the data query , it is matched in the data query set.</summary>
    [JsonPropertyName("DataQueryNameB")]
    public string? DataQueryNameB { get; set; }

    /// <summary>Represents index field  of DataB.</summary>
    [JsonPropertyName("DataBIndexField")]
    public string? DataBIndexField { get; set; }

    /// <summary>Represents ethods of data consolidation.</summary>
    [JsonPropertyName("JoinType")]
    public string? JoinType { get; set; }

}
