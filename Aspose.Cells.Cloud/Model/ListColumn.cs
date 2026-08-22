using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a column in a Table.</summary>
public class ListColumn
{
    /// <summary>Gets and sets the name of the column.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets the range of this list column.</summary>
    [JsonPropertyName("Range")]
    public Range? Range { get; set; }

    /// <summary>Gets and sets the type of calculation in the Totals row of the list column.</summary>
    [JsonPropertyName("TotalsCalculation")]
    public string? TotalsCalculation { get; set; }

    /// <summary>Gets and sets the formula of the list column.</summary>
    [JsonPropertyName("Formula")]
    public string? Formula { get; set; }

    /// <summary>Gets and sets the display labels of total row.</summary>
    [JsonPropertyName("TotalsRowLabel")]
    public string? TotalsRowLabel { get; set; }

}
