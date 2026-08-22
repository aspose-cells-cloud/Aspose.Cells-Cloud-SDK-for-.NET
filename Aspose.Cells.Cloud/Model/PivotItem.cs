using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a item in a PivotField report.</summary>
public class PivotItem
{
    /// <summary>Gets the index of the pivot item in cache field.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Represents whether the specified item visible.</summary>
    [JsonPropertyName("IsHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>Gets the name</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets the value of the specified item.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

}
