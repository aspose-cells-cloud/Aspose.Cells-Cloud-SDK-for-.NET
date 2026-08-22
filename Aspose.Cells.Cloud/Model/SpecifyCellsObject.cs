using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SpecifyCellsObject model.</summary>
public class SpecifyCellsObject
{
    /// <summary>Gets or sets the WorksheetName.</summary>
    [JsonPropertyName("WorksheetName")]
    public string? WorksheetName { get; set; }

    /// <summary>Gets or sets the PageIndex.</summary>
    [JsonPropertyName("PageIndex")]
    public int? PageIndex { get; set; }

    /// <summary>Gets or sets the Region.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

}
