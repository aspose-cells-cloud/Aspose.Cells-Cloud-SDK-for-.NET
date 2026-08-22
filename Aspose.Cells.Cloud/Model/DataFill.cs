using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data filling.</summary>
public class DataFill
{
    /// <summary>Represents range of data filling.</summary>
    [JsonPropertyName("Ranges")]
    public List<Range>? Ranges { get; set; }

    /// <summary>Represents that the data column is populated with the default value.</summary>
    [JsonPropertyName("DataFillDefaultValue")]
    public DataFillValue? DataFillDefaultValue { get; set; }

    /// <summary>Represents that the data column is populated with the specified value.</summary>
    [JsonPropertyName("DataColumnFillValueList")]
    public List<DataColumnFillValue>? DataColumnFillValueList { get; set; }

}
