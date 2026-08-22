using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents that the data column is populated with the specified value.</summary>
public class DataColumnFillValue
{
    /// <summary>Represents specified column index.</summary>
    [JsonPropertyName("ColumnIndex")]
    public int? ColumnIndex { get; set; }

    /// <summary>Represents specified data fill value.</summary>
    [JsonPropertyName("DataFillValue")]
    public DataFillValue? DataFillValue { get; set; }

}
