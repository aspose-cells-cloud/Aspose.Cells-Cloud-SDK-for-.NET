using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the multiple filter collection.</summary>
public class MultipleFilters
{
    /// <summary>A nullable boolean property that determines if a blank space should be matched.</summary>
    [JsonPropertyName("MatchBlank")]
    public bool? MatchBlank { get; set; }

    /// <summary>Gets or sets the MultipleFilterList.</summary>
    [JsonPropertyName("MultipleFilterList")]
    public List<MultipleFilter>? MultipleFilterList { get; set; }

}
