using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a check box object in a worksheet.</summary>
public class CheckBox : Shape
{
    /// <summary>Gets or set checkbox' value.</summary>
    [JsonPropertyName("CheckedValue")]
    public string? CheckedValue { get; set; }

    /// <summary>Indicates whether the combobox has 3-D shading.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

    /// <summary>Indicates if the checkbox is checked or not.</summary>
    [JsonPropertyName("Value")]
    public bool? Value { get; set; }

}
