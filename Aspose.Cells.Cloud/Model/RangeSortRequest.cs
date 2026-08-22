using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates range sort request</summary>
public class RangeSortRequest
{
    /// <summary>Summary description for DataSorter.</summary>
    [JsonPropertyName("DataSorter")]
    public DataSorter? DataSorter { get; set; }

    /// <summary>Encapsulates the object that represents a range of cells within a spreadsheet.</summary>
    [JsonPropertyName("CellArea")]
    public Range? CellArea { get; set; }

}
