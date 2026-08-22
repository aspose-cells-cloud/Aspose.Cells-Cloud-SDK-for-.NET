using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Define the specific range in your Excel worksheet where you want the spreadsheet operations to be performed. This ensures that only the cells within the selected range are processed, and any operations are confined to this area.</summary>
public class ScopeItem
{
    /// <summary>The specific worksheet of spreadsheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>The specific ranges of worksheet.</summary>
    [JsonPropertyName("Ranges")]
    public List<string>? Ranges { get; set; }

}
