using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellArea model.</summary>
public class CellArea
{
    /// <summary>Gets or sets the EndColumn.</summary>
    [JsonPropertyName("EndColumn")]
    public int? EndColumn { get; set; }

    /// <summary>Gets or sets the EndRow.</summary>
    [JsonPropertyName("EndRow")]
    public int? EndRow { get; set; }

    /// <summary>Gets or sets the StartColumn.</summary>
    [JsonPropertyName("StartColumn")]
    public int? StartColumn { get; set; }

    /// <summary>Gets or sets the StartRow.</summary>
    [JsonPropertyName("StartRow")]
    public int? StartRow { get; set; }

}
