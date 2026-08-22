using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents an area format.</summary>
public class Area
{
    /// <summary>Gets or sets the background  of the .</summary>
    [JsonPropertyName("BackgroundColor")]
    public Color? BackgroundColor { get; set; }

    /// <summary>Represents a  object that contains fill formatting properties for the specified chart or shape.</summary>
    [JsonPropertyName("FillFormat")]
    public FillFormat? FillFormat { get; set; }

    /// <summary>Gets or sets the foreground .</summary>
    [JsonPropertyName("ForegroundColor")]
    public Color? ForegroundColor { get; set; }

    /// <summary>This class has a property named "Format" of type string with both getter and setter methods.</summary>
    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    /// <summary>If the property is true and the value of chart point is a negative number,</summary>
    [JsonPropertyName("InvertIfNegative")]
    public bool? InvertIfNegative { get; set; }

    /// <summary>Returns or sets the degree of transparency of the area as a value from 0.0 (opaque) through 1.0 (clear).</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

}
