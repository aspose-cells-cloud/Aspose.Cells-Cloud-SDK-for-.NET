using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a PivotFilter in PivotFilter Collection.</summary>
public class PivotFilter
{
    /// <summary>Gets the autofilter of the pivot filter.</summary>
    [JsonPropertyName("AutoFilter")]
    public AutoFilter? AutoFilter { get; set; }

    /// <summary>Gets the Evaluation Order of the pivot filter.</summary>
    [JsonPropertyName("EvaluationOrder")]
    public int? EvaluationOrder { get; set; }

    /// <summary>Gets the field index of the pivot filter.</summary>
    [JsonPropertyName("FieldIndex")]
    public int? FieldIndex { get; set; }

    /// <summary>Gets the autofilter type of the pivot filter.</summary>
    [JsonPropertyName("FilterType")]
    public string? FilterType { get; set; }

    /// <summary>Gets the measure field index of the pivot filter.</summary>
    [JsonPropertyName("ValueFieldIndex")]
    public int? ValueFieldIndex { get; set; }

    /// <summary>Gets the member property field index of the pivot filter.</summary>
    [JsonPropertyName("MemberPropertyFieldIndex")]
    public int? MemberPropertyFieldIndex { get; set; }

    /// <summary>Gets the name of the pivot filter.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets the string value1 of the label pivot filter.</summary>
    [JsonPropertyName("Value1")]
    public string? Value1 { get; set; }

    /// <summary>Gets the string value2 of the label pivot filter.</summary>
    [JsonPropertyName("Value2")]
    public string? Value2 { get; set; }

    /// <summary>A property that allows for setting and getting a Top10Filter object for filtering data.</summary>
    [JsonPropertyName("Top10Filter")]
    public Top10Filter? Top10Filter { get; set; }

}
