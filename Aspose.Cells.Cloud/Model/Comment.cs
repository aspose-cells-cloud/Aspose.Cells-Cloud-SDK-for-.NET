using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a cell comment.</summary>
public class Comment : LinkElement
{
    /// <summary>Property: CellName attribute with XmlElement tag in the class.</summary>
    [JsonPropertyName("CellName")]
    public string? CellName { get; set; }

    /// <summary>Gets and sets Name of the original comment author</summary>
    [JsonPropertyName("Author")]
    public string? Author { get; set; }

    /// <summary>Gets and sets the html string which contains data and some formats in this comment.</summary>
    [JsonPropertyName("HtmlNote")]
    public string? HtmlNote { get; set; }

    /// <summary>Represents the content of comment.</summary>
    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    /// <summary>Indicates if size of comment is adjusted automatically according to its content.</summary>
    [JsonPropertyName("AutoSize")]
    public bool? AutoSize { get; set; }

    /// <summary>Represents if the comment is visible or not.</summary>
    [JsonPropertyName("IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>Represents the width of the comment, in unit of pixels.</summary>
    [JsonPropertyName("Width")]
    public int? Width { get; set; }

    /// <summary>Represents the Height of the comment, in unit of pixels.</summary>
    [JsonPropertyName("Height")]
    public int? Height { get; set; }

    /// <summary>Gets and sets the text horizontal alignment type of the comment.</summary>
    [JsonPropertyName("TextHorizontalAlignment")]
    public string? TextHorizontalAlignment { get; set; }

    /// <summary>Gets and sets the text orientation type of the comment.</summary>
    [JsonPropertyName("TextOrientationType")]
    public string? TextOrientationType { get; set; }

    /// <summary>Gets and sets the text vertical alignment type of the comment.</summary>
    [JsonPropertyName("TextVerticalAlignment")]
    public string? TextVerticalAlignment { get; set; }

}
