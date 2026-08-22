using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the border of the data bars specified by a conditional formatting rule.</summary>
public class DataBarBorder
{
    /// <summary>Gets or sets the border's color of data bars specified by a conditional formatting rule.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets or sets the border's type of data bars specified by a conditional formatting rule.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
