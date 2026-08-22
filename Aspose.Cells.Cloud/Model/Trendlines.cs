using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a collection of all the  objects for the specified data series.</summary>
public class Trendlines : LinkElement
{
    /// <summary>This property allows for a list of Trendline objects to be stored under the XmlElement "TrendLine".</summary>
    [JsonPropertyName("TrendlineList")]
    public List<Trendline>? TrendlineList { get; set; }

}
