using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TxtSaveOptions model.</summary>
public class TxtSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the QuoteType.</summary>
    [JsonPropertyName("QuoteType")]
    public string? QuoteType { get; set; }

    /// <summary>Gets or sets the Separator.</summary>
    [JsonPropertyName("Separator")]
    public string? Separator { get; set; }

    /// <summary>Gets or sets the SeparatorString.</summary>
    [JsonPropertyName("SeparatorString")]
    public string? SeparatorString { get; set; }

    /// <summary>Gets or sets the AlwaysQuoted.</summary>
    [JsonPropertyName("AlwaysQuoted")]
    public bool? AlwaysQuoted { get; set; }

}
