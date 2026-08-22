using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class Ranges
{
    /// <summary>Property Summary: Contains a list of ranges specified by the XmlElement "Range".</summary>
    [JsonPropertyName("RangeList")]
    public List<Range>? RangeList { get; set; }

}
