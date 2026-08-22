using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the key of the data sorter.</summary>
public class DataSorterKey
{
    /// <summary>Indicates the order of sorting.</summary>
    [JsonPropertyName("Order")]
    public string? Order { get; set; }

    /// <summary>Gets the sorted column index(absolute position, column A is 0, B is 1, ...).</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Represents the type of sorting.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Represents the icon set type.</summary>
    [JsonPropertyName("IconSetType")]
    public string? IconSetType { get; set; }

    /// <summary>Represents the id of the icon set type.</summary>
    [JsonPropertyName("IconId")]
    public int? IconId { get; set; }

    /// <summary>Gets the sorted color.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

}
