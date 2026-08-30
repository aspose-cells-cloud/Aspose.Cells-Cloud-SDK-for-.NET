using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the FormulaFormatCondition model.</summary>
public class FormulaFormatCondition
{
    /// <summary>Gets and sets the value or expression associated with conditional formatting.</summary>
    [JsonPropertyName("Formula1")]
    public string? Formula1 { get; set; }

    /// <summary>Gets and sets the value or expression associated with conditional formatting.</summary>
    [JsonPropertyName("Formula2")]
    public string? Formula2 { get; set; }

    /// <summary>Gets and sets the conditional format operator type.</summary>
    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

}
