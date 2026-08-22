using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the MergeTableOptions model.</summary>
public class MergeTableOptions
{
    /// <summary>Gets or sets the MainTable.</summary>
    [JsonPropertyName("MainTable")]
    public CombinationSourceData? MainTable { get; set; }

    /// <summary>Gets or sets the SecondaryTable.</summary>
    [JsonPropertyName("SecondaryTable")]
    public CombinationSourceData? SecondaryTable { get; set; }

    /// <summary>Gets or sets the DataMergeType.</summary>
    [JsonPropertyName("DataMergeType")]
    public string? DataMergeType { get; set; }

    /// <summary>Gets or sets the OverwriteMainTable.</summary>
    [JsonPropertyName("OverwriteMainTable")]
    public bool? OverwriteMainTable { get; set; }

    /// <summary>Gets or sets the SyncDataToTargetWorkbook.</summary>
    [JsonPropertyName("SyncDataToTargetWorkbook")]
    public bool? SyncDataToTargetWorkbook { get; set; }

    /// <summary>Gets or sets the MergedDataToPosition.</summary>
    [JsonPropertyName("MergedDataToPosition")]
    public DataOutputLocation? MergedDataToPosition { get; set; }

}
