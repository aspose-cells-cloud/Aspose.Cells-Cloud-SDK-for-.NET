using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data deduplication region.</summary>
public class DeduplicationRegion
{
    /// <summary>Represents data range.</summary>
    [JsonPropertyName("Ranges")]
    public List<Range>? Ranges { get; set; }

    /// <summary>Represents worksheet name list.</summary>
    [JsonPropertyName("WorksheetNameList")]
    public List<string>? WorksheetNameList { get; set; }

}
