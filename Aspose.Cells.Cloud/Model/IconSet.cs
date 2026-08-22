using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Describe the IconSet conditional formatting rule. This conditional formatting</summary>
public class IconSet
{
    /// <summary>Get the from the collection</summary>
    [JsonPropertyName("CfIcons")]
    public List<ConditionalFormattingIcon>? CfIcons { get; set; }

    /// <summary>Get the CFValueObjects instance.</summary>
    [JsonPropertyName("Cfvos")]
    public List<ConditionalFormattingValue>? Cfvos { get; set; }

    /// <summary>Indicates whether the icon set is custom.</summary>
    [JsonPropertyName("IsCustom")]
    public bool? IsCustom { get; set; }

    /// <summary>Get or set the flag indicating whether to reverses the default order of the icons in this icon set.</summary>
    [JsonPropertyName("Reverse")]
    public bool? Reverse { get; set; }

    /// <summary>Get or set the flag indicating whether to show the values of the cells on which this icon set is applied.</summary>
    [JsonPropertyName("ShowValue")]
    public bool? ShowValue { get; set; }

    /// <summary>Get or Set the icon set type to display.  Setting the type will auto check</summary>
    [JsonPropertyName("IconSetType")]
    public string? IconSetType { get; set; }

}
