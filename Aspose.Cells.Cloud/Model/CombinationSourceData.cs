using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CombinationSourceData model.</summary>
public class CombinationSourceData
{
    /// <summary>Gets or sets the Tag.</summary>
    [JsonPropertyName("Tag")]
    public string? Tag { get; set; }

    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>Gets or sets the TableName.</summary>
    [JsonPropertyName("TableName")]
    public string? TableName { get; set; }

    /// <summary>Gets or sets the CellArea.</summary>
    [JsonPropertyName("CellArea")]
    public string? CellArea { get; set; }

    /// <summary>Gets or sets the HasHeader.</summary>
    [JsonPropertyName("HasHeader")]
    public bool? HasHeader { get; set; }

}
