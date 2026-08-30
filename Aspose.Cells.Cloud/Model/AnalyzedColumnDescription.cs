using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents description of analyzed column.</summary>
public class AnalyzedColumnDescription
{
    /// <summary>Gets or sets the Index.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>The true position index value of the column.</summary>
    [JsonPropertyName("ColumnIndex")]
    public int? ColumnIndex { get; set; }

    /// <summary>This class has a public property "Title" of type string with a default value of an empty string.</summary>
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    /// <summary>When the repetition rate is high, can it be viewed as a group display?</summary>
    [JsonPropertyName("RepetitionRate")]
    public double? RepetitionRate { get; set; }

    /// <summary>The column type is identified, and the attributes of the column are determined after data analysis.</summary>
    [JsonPropertyName("ColumnDataDataType")]
    public string? ColumnDataDataType { get; set; }

    /// <summary>Gets or sets the NumberCategoryType.</summary>
    [JsonPropertyName("NumberCategoryType")]
    public string? NumberCategoryType { get; set; }

    /// <summary>Gets or sets the TextCategoryType.</summary>
    [JsonPropertyName("TextCategoryType")]
    public string? TextCategoryType { get; set; }

    /// <summary>Gets or sets the StyleNumber.</summary>
    [JsonPropertyName("StyleNumber")]
    public int? StyleNumber { get; set; }

    /// <summary>Column data exception description.</summary>
    [JsonPropertyName("columnDataExceptionDescription")]
    public string? ColumnDataExceptionDescription { get; set; }

}
