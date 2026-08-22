using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class ConditionalFormattings : LinkElement
{
    /// <summary>The property "Count" is decorated with [XmlElement("count")] attribute for XML serialization.</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the ConditionalFormattingList.</summary>
    [JsonPropertyName("ConditionalFormattingList")]
    public List<ConditionalFormatting>? ConditionalFormattingList { get; set; }

}
