using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents sort key.</summary>
public class SortKey
{
    /// <summary>Represents the key of sorting.</summary>
    [JsonPropertyName("Key")]
    public int? Key { get; set; }

    /// <summary>Represents the order of sorting.</summary>
    [JsonPropertyName("SortOrder")]
    public string? SortOrder { get; set; }

    /// <summary>This class includes a property named CustomList that is an array of strings with both getter and setter methods.</summary>
    [JsonPropertyName("CustomList")]
    public List<string>? CustomList { get; set; }

    /// <summary>Indicates the order of sorting.</summary>
    [JsonPropertyName("Order")]
    public string? Order { get; set; }

    /// <summary>Gets the sorted column index(absolute position, column A is 0, B is 1, ...).</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Represents the type of sorting.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
