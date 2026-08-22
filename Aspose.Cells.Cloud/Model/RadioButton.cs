using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a radio button.</summary>
public class RadioButton : Shape
{
    /// <summary>Gets the GroupBox that contains this RadioButton.</summary>
    [JsonPropertyName("GroupBox")]
    public GroupBox? GroupBox { get; set; }

    /// <summary>Indicates if the radiobutton is checked or not.</summary>
    [JsonPropertyName("IsChecked")]
    public bool? IsChecked { get; set; }

    /// <summary>Indicates whether the combobox has 3-D shading.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

}
