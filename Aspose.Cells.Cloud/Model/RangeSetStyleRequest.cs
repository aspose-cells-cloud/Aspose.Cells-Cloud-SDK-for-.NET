using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates range set style request.</summary>
public class RangeSetStyleRequest
{
    /// <summary>Encapsulates the object that represents a range of cells within a spreadsheet.</summary>
    [JsonPropertyName("Range")]
    public Range? Range { get; set; }

    /// <summary>Represents display style of excel document,such as font,color,alignment,border,etc.</summary>
    [JsonPropertyName("Style")]
    public Style? Style { get; set; }

}
