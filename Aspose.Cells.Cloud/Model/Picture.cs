using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a single picture in a spreadsheet.</summary>
public class Picture : Shape
{
    /// <summary>Represents the  of the border line of a picture.</summary>
    [JsonPropertyName("BorderLineColor")]
    public Color? BorderLineColor { get; set; }

    /// <summary>Gets or sets the weight of the border line of a picture in units of pt.</summary>
    [JsonPropertyName("BorderWeight")]
    public double? BorderWeight { get; set; }

    /// <summary>Gets the original height of the picture.</summary>
    [JsonPropertyName("OriginalHeight")]
    public int? OriginalHeight { get; set; }

    /// <summary>Gets the original width of the picture.</summary>
    [JsonPropertyName("OriginalWidth")]
    public int? OriginalWidth { get; set; }

    /// <summary>This class has a property called "ImageFormat" that allows getting and setting a string value.</summary>
    [JsonPropertyName("ImageFormat")]
    public string? ImageFormat { get; set; }

    /// <summary>Gets or sets the path and name of the source file for the linked image.</summary>
    [JsonPropertyName("SourceFullName")]
    public string? SourceFullName { get; set; }

}
