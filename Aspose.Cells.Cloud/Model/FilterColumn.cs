using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a filter for a single column. The Filter object is a member of the Filters collection</summary>
public class FilterColumn
{
    /// <summary>Gets and sets the column offset in the range.</summary>
    [JsonPropertyName("FieldIndex")]
    public int? FieldIndex { get; set; }

    /// <summary>Gets and sets the type fo filtering data.</summary>
    [JsonPropertyName("FilterType")]
    public string? FilterType { get; set; }

    /// <summary>This class contains a property named "MultipleFilters" of type "MultipleFilters" that can be both read and written.</summary>
    [JsonPropertyName("MultipleFilters")]
    public MultipleFilters? MultipleFilters { get; set; }

    /// <summary>Gets or sets the ColorFilter.</summary>
    [JsonPropertyName("ColorFilter")]
    public ColorFilter? ColorFilter { get; set; }

    /// <summary>Gets or sets the CustomFilters.</summary>
    [JsonPropertyName("CustomFilters")]
    public List<CustomFilter>? CustomFilters { get; set; }

    /// <summary>Gets or sets the DynamicFilter.</summary>
    [JsonPropertyName("DynamicFilter")]
    public DynamicFilter? DynamicFilter { get; set; }

    /// <summary>Gets or sets the IconFilter.</summary>
    [JsonPropertyName("IconFilter")]
    public IconFilter? IconFilter { get; set; }

    /// <summary>Gets or sets the Top10Filter.</summary>
    [JsonPropertyName("Top10Filter")]
    public Top10Filter? Top10Filter { get; set; }

    /// <summary>Indicates whether the AutoFilter button for this column is visible.</summary>
    [JsonPropertyName("Visibledropdown")]
    public string? Visibledropdown { get; set; }

}
