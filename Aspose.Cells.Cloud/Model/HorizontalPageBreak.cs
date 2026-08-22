using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a horizontal page break.</summary>
public class HorizontalPageBreak
{
    /// <summary>Gets the zero based row index.</summary>
    [JsonPropertyName("Row")]
    public int? Row { get; set; }

    /// <summary>Gets the end column index of this horizontal page break.</summary>
    [JsonPropertyName("EndColumn")]
    public int? EndColumn { get; set; }

    /// <summary>Gets the start column index of this horizontal page break.</summary>
    [JsonPropertyName("StartColumn")]
    public int? StartColumn { get; set; }

}
