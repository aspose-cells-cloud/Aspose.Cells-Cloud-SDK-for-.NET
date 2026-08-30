using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Form model.</summary>
public class Form : Shape
{
    /// <summary>A property named "FormType" of type string which can be both accessed and modified.</summary>
    [JsonPropertyName("FormType")]
    public string? FormType { get; set; }

    /// <summary>Gets or sets the CheckedValue.</summary>
    [JsonPropertyName("CheckedValue")]
    public string? CheckedValue { get; set; }

    /// <summary>Gets or sets the Shadow.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

    /// <summary>Gets or sets the InputRange.</summary>
    [JsonPropertyName("InputRange")]
    public string? InputRange { get; set; }

    /// <summary>Gets or sets the SelectedIndex.</summary>
    [JsonPropertyName("SelectedIndex")]
    public int? SelectedIndex { get; set; }

    /// <summary>Gets or sets the SelectedValue.</summary>
    [JsonPropertyName("SelectedValue")]
    public string? SelectedValue { get; set; }

    /// <summary>Gets or sets the SelectedCell.</summary>
    [JsonPropertyName("SelectedCell")]
    public LinkElement? SelectedCell { get; set; }

    /// <summary>Gets or sets the DropDownLines.</summary>
    [JsonPropertyName("DropDownLines")]
    public int? DropDownLines { get; set; }

    /// <summary>Gets or sets the ItemCount.</summary>
    [JsonPropertyName("ItemCount")]
    public int? ItemCount { get; set; }

    /// <summary>Gets or sets the SelectedCells.</summary>
    [JsonPropertyName("SelectedCells")]
    public List<LinkElement>? SelectedCells { get; set; }

    /// <summary>Gets or sets the SelectionType.</summary>
    [JsonPropertyName("SelectionType")]
    public string? SelectionType { get; set; }

    /// <summary>Gets or sets the IsChecked.</summary>
    [JsonPropertyName("IsChecked")]
    public bool? IsChecked { get; set; }

    /// <summary>Gets or sets the CurrentValue.</summary>
    [JsonPropertyName("CurrentValue")]
    public int? CurrentValue { get; set; }

    /// <summary>Gets or sets the Min.</summary>
    [JsonPropertyName("Min")]
    public int? Min { get; set; }

    /// <summary>Gets or sets the Max.</summary>
    [JsonPropertyName("Max")]
    public int? Max { get; set; }

    /// <summary>Gets or sets the IncrementalChange.</summary>
    [JsonPropertyName("IncrementalChange")]
    public int? IncrementalChange { get; set; }

    /// <summary>Gets or sets the PageChange.</summary>
    [JsonPropertyName("PageChange")]
    public int? PageChange { get; set; }

    /// <summary>Gets or sets the IsHorizontal.</summary>
    [JsonPropertyName("IsHorizontal")]
    public bool? IsHorizontal { get; set; }

}
