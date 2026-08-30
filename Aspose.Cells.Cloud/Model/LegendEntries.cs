using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the LegendEntries model.</summary>
public class LegendEntries : LinkElement
{
    /// <summary>Property: Utilizes XML element "LengendEntry" to represent a list of LinkElement items in the class.</summary>
    [JsonPropertyName("legendEntryList")]
    public List<LinkElement>? LegendEntryList { get; set; }

}
