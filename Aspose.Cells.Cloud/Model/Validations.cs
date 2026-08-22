using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data validation collection.</summary>
public class Validations : LinkElement
{
    /// <summary>Property summary: The property "Count" with an XML element name "count" returns the number of items in the "ValidationList".</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the ValidationList.</summary>
    [JsonPropertyName("ValidationList")]
    public List<LinkElement>? ValidationList { get; set; }

}
