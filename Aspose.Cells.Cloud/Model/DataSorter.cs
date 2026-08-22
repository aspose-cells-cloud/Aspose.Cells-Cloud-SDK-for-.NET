using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Summary description for DataSorter.</summary>
public class DataSorter
{
    /// <summary>Gets and sets whether case sensitive when comparing string.</summary>
    [JsonPropertyName("CaseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>Represents whether the range has headers.</summary>
    [JsonPropertyName("HasHeaders")]
    public bool? HasHeaders { get; set; }

    /// <summary>Gets the key list of data sorter.</summary>
    [JsonPropertyName("KeyList")]
    public List<SortKey>? KeyList { get; set; }

    /// <summary>True means that sorting orientation is from left to right.</summary>
    [JsonPropertyName("SortLeftToRight")]
    public bool? SortLeftToRight { get; set; }

    /// <summary>Indicates whether sorting anything that looks like a number.</summary>
    [JsonPropertyName("SortAsNumber")]
    public bool? SortAsNumber { get; set; }

    /// <summary>Gets the key list of data sorter.</summary>
    [JsonPropertyName("Keys")]
    public List<DataSorterKey>? Keys { get; set; }

}
