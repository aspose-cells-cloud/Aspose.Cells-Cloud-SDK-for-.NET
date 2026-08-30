using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ImportPictureOption model.</summary>
public class ImportPictureOption : ImportOption
{
    /// <summary>A property "UpperLeftRow" of type integer with a public getter and setter is defined.</summary>
    [JsonPropertyName("UpperLeftRow")]
    public int? UpperLeftRow { get; set; }

    /// <summary>Gets or sets the UpperLeftColumn.</summary>
    [JsonPropertyName("UpperLeftColumn")]
    public int? UpperLeftColumn { get; set; }

    /// <summary>Gets or sets the LowerRightRow.</summary>
    [JsonPropertyName("LowerRightRow")]
    public int? LowerRightRow { get; set; }

    /// <summary>Gets or sets the LowerRightColumn.</summary>
    [JsonPropertyName("LowerRightColumn")]
    public int? LowerRightColumn { get; set; }

    /// <summary>Gets or sets the Filename.</summary>
    [JsonPropertyName("Filename")]
    public string? Filename { get; set; }

    /// <summary>Gets or sets the Data.</summary>
    [JsonPropertyName("Data")]
    public string? Data { get; set; }

}
