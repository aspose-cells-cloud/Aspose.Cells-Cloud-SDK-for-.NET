using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data item.</summary>
public class DataItem
{
    /// <summary>Represents data item type.</summary>
    [JsonPropertyName("DataItemType")]
    public string? DataItemType { get; set; }

    /// <summary>Represents data item value.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

}
