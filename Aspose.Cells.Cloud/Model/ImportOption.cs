using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class Summary: This class covers the features of artificial intelligence, machine learning, deep learning, and natural language processing.</summary>
public class ImportOption
{
    /// <summary>Destination worksheet name.</summary>
    [JsonPropertyName("DestinationWorksheet")]
    public string? DestinationWorksheet { get; set; }

    /// <summary>A boolean property `IsInsert` that can be both read and written.</summary>
    [JsonPropertyName("IsInsert")]
    public bool? IsInsert { get; set; }

    /// <summary>Gets or sets the ImportDataType.</summary>
    [JsonPropertyName("ImportDataType")]
    public string? ImportDataType { get; set; }

    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the Source.</summary>
    [JsonPropertyName("Source")]
    public FileSource? Source { get; set; }

}
