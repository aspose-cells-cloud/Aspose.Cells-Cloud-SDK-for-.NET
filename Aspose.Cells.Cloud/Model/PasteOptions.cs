using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the paste special options.</summary>
public class PasteOptions
{
    /// <summary>True means only copying visible cells.</summary>
    [JsonPropertyName("OnlyVisibleCells")]
    public bool? OnlyVisibleCells { get; set; }

    /// <summary>The paste special type.</summary>
    [JsonPropertyName("PasteType")]
    public string? PasteType { get; set; }

    /// <summary>Indicates whether skips blank cells.</summary>
    [JsonPropertyName("SkipBlanks")]
    public bool? SkipBlanks { get; set; }

    /// <summary>True to transpose rows and columns when the range is pasted. The default value is False.</summary>
    [JsonPropertyName("Transpose")]
    public bool? Transpose { get; set; }

}
