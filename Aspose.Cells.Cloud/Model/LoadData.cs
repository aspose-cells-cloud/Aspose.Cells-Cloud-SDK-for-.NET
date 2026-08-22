using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Loading data information.</summary>
public class LoadData
{
    /// <summary>Indicates begin position for loading data.</summary>
    [JsonPropertyName("LoadTo")]
    public LoadTo? LoadTo { get; set; }

    /// <summary>Indicates data query for data loading.</summary>
    [JsonPropertyName("DataQuery")]
    public DataQuery? DataQuery { get; set; }

}
