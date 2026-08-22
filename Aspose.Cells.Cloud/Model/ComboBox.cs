using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the control form ComboBox.</summary>
public class ComboBox : Shape
{
    /// <summary>Gets or sets the number of list lines displayed in the drop-down portion of a combo box.</summary>
    [JsonPropertyName("DropDownLines")]
    public int? DropDownLines { get; set; }

    /// <summary>Property Summary: Contains a public string property named "InputRange" with both get and set accessors.</summary>
    [JsonPropertyName("InputRange")]
    public string? InputRange { get; set; }

    /// <summary>Gets the selected cell in the input range of the combo box.</summary>
    [JsonPropertyName("SelectedCell")]
    public LinkElement? SelectedCell { get; set; }

    /// <summary>Gets or sets the index number of the currently selected item in a list box or combo box.</summary>
    [JsonPropertyName("SelectedIndex")]
    public int? SelectedIndex { get; set; }

    /// <summary>Gets the selected value of the combox box.</summary>
    [JsonPropertyName("SelectedValue")]
    public string? SelectedValue { get; set; }

    /// <summary>Indicates whether the combobox has 3-D shading.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

}
