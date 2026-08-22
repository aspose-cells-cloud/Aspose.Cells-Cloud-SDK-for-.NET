using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents results of analyzed data.</summary>
public class AnalyzedResult
{
    /// <summary>Represents the file name of data file.</summary>
    [JsonPropertyName("Filename")]
    public string? Filename { get; set; }

    /// <summary>Represents summary about results of analyzed data.</summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>Represents Excel data statistics.</summary>
    [JsonPropertyName("BasicStatistics")]
    public ExcelDataStatistics? BasicStatistics { get; set; }

    /// <summary>Represents analyzed table description.</summary>
    [JsonPropertyName("Results")]
    public List<AnalyzedTableDescription>? Results { get; set; }

    /// <summary>base64String Excel file</summary>
    [JsonPropertyName("SuggestedFile")]
    public string? SuggestedFile { get; set; }

}
