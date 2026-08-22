using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a collection of all the  objects in the spreadsheet.</summary>
public class Names : LinkElement
{
    /// <summary>This class property is tagged as an XML element named "count" and stores an integer value.</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the NameList.</summary>
    [JsonPropertyName("NameList")]
    public List<LinkElement>? NameList { get; set; }

}
