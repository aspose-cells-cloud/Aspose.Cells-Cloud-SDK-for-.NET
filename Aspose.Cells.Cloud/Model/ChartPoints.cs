using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a collection that contains all the points in one series.</summary>
public class ChartPoints : LinkElement
{
    /// <summary>This class has a property named ChartPointList of type List ChartPoint  with an XmlElement attribute "ChartPoint".</summary>
    [JsonPropertyName("ChartPointList")]
    public List<ChartPoint>? ChartPointList { get; set; }

}
