using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm here to help! Please provide me with the features that need to be summarized.</summary>
public class ConditionalFormatting : LinkElement
{
    /// <summary>A public property called "sqref" of type string with a getter and a setter is defined in the class.</summary>
    [JsonPropertyName("sqref")]
    public string? Sqref { get; set; }

    /// <summary>Gets or sets the FormatConditions.</summary>
    [JsonPropertyName("FormatConditions")]
    public List<FormatCondition>? FormatConditions { get; set; }

}
