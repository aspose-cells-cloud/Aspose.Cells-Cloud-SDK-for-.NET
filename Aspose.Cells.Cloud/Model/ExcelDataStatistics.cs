using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents Excel data statistics.</summary>
public class ExcelDataStatistics
{
    /// <summary>Represents worksheet data statistics list.</summary>
    [JsonPropertyName("WorksheetDataStatistics")]
    public List<WorksheetDataStatistics>? WorksheetDataStatistics { get; set; }

}
