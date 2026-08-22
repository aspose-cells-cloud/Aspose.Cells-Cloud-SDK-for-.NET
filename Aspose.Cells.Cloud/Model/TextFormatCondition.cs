using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents text format condition.</summary>
public class TextFormatCondition : FormulaFormatCondition
{
    /// <summary>The text value in a "text contains" conditional formatting rule. Valid only</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

}
