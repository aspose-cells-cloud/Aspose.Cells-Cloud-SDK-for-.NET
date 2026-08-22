using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the custom filter.</summary>
public class CustomFilter
{
    /// <summary>Gets and sets the criteria.</summary>
    [JsonPropertyName("Criteria")]
    public object? Criteria { get; set; }

    /// <summary>Gets and sets the filter operator type.</summary>
    [JsonPropertyName("FilterOperatorType")]
    public string? FilterOperatorType { get; set; }

}
