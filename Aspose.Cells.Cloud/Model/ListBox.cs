using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a list box object.</summary>
public class ListBox : Shape
{
    /// <summary>This property stores the input range for the class.</summary>
    [JsonPropertyName("InputRange")]
    public string? InputRange { get; set; }

    /// <summary>Gets the number of items in the list box.</summary>
    [JsonPropertyName("ItemCount")]
    public int? ItemCount { get; set; }

    /// <summary>Specifies the amount by which the control's value is changed</summary>
    [JsonPropertyName("PageChange")]
    public int? PageChange { get; set; }

    /// <summary>Gets the selected cells.</summary>
    [JsonPropertyName("SelectedCells")]
    public List<LinkElement>? SelectedCells { get; set; }

    /// <summary>Gets or sets the index number of the currently selected item in a list box or combo box.</summary>
    [JsonPropertyName("SelectedIndex")]
    public int? SelectedIndex { get; set; }

    /// <summary>Gets or sets the selection mode of the specified list box.</summary>
    [JsonPropertyName("SelectionType")]
    public string? SelectionType { get; set; }

    /// <summary>Indicates whether the combobox has 3-D shading.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

}
