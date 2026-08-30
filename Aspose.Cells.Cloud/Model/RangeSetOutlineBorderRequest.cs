using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates range set outline border request.</summary>
public class RangeSetOutlineBorderRequest
{
    /// <summary>Encapsulates the object that represents a range of cells within a spreadsheet.</summary>
    [JsonPropertyName("Range")]
    public Range? Range { get; set; }

    /// <summary>LeftBorder, RightBorder, TopBorder, BottomBorder, DiagonalDown, DiagonalUp, Vertical and Horizontal.</summary>
    [JsonPropertyName("borderEdge")]
    public string? BorderEdge { get; set; }

    /// <summary>None, Thin, Medium, Dashed, Dotted, Thick, Double, Hair, MediumDashed, DashDot, MediumDashDot, DashDotDot, MediumDashDotDot and SlantedDashDot.</summary>
    [JsonPropertyName("borderStyle")]
    public string? BorderStyle { get; set; }

    /// <summary>Gets or sets the borderColor.</summary>
    [JsonPropertyName("borderColor")]
    public Color? BorderColor { get; set; }

}
