using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the msodrawing object.</summary>
public class Shape : LinkElement
{
    /// <summary>Gets and sets the name of the shape.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets mso drawing type.</summary>
    [JsonPropertyName("MsoDrawingType")]
    public string? MsoDrawingType { get; set; }

    /// <summary>Gets and sets the auto shape type.</summary>
    [JsonPropertyName("AutoShapeType")]
    public string? AutoShapeType { get; set; }

    /// <summary>Represents the way the drawing object is attached to the cells below it.</summary>
    [JsonPropertyName("Placement")]
    public string? Placement { get; set; }

    /// <summary>Represents upper left corner row index.</summary>
    [JsonPropertyName("UpperLeftRow")]
    public int? UpperLeftRow { get; set; }

    /// <summary>Represents the vertical offset of shape from its top row, in unit of pixels.</summary>
    [JsonPropertyName("Top")]
    public int? Top { get; set; }

    /// <summary>Represents upper left corner column index.</summary>
    [JsonPropertyName("UpperLeftColumn")]
    public int? UpperLeftColumn { get; set; }

    /// <summary>Represents the horizontal offset of shape from its left column, in unit of pixels.</summary>
    [JsonPropertyName("Left")]
    public int? Left { get; set; }

    /// <summary>Represents lower right corner row index.</summary>
    [JsonPropertyName("LowerRightRow")]
    public int? LowerRightRow { get; set; }

    /// <summary>Represents the width of the shape's vertical offset from its lower bottom corner row, in unit of pixels.</summary>
    [JsonPropertyName("Bottom")]
    public int? Bottom { get; set; }

    /// <summary>Represents lower right corner column index.</summary>
    [JsonPropertyName("LowerRightColumn")]
    public int? LowerRightColumn { get; set; }

    /// <summary>Represents the width of the shape's horizontal  offset from its lower right corner column, in unit of pixels.</summary>
    [JsonPropertyName("Right")]
    public int? Right { get; set; }

    /// <summary>Represents the width of shape, in unit of pixels.</summary>
    [JsonPropertyName("Width")]
    public int? Width { get; set; }

    /// <summary>Represents the height of shape, in unit of pixel.</summary>
    [JsonPropertyName("Height")]
    public int? Height { get; set; }

    /// <summary>Gets and sets the horizontal offset of shape from worksheet left border,in unit of pixels.</summary>
    [JsonPropertyName("X")]
    public int? X { get; set; }

    /// <summary>Gets and sets the vertical offset of shape from worksheet top border,in unit of pixels.</summary>
    [JsonPropertyName("Y")]
    public int? Y { get; set; }

    /// <summary>Gets and sets the rotation of the shape.</summary>
    [JsonPropertyName("RotationAngle")]
    public double? RotationAngle { get; set; }

    /// <summary>Gets and sets the html string which contains data and some formats in this textbox.</summary>
    [JsonPropertyName("HtmlText")]
    public string? HtmlText { get; set; }

    /// <summary>Represents the string in this TextBox object.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>Returns or sets the descriptive (alternative) text string of the  object.</summary>
    [JsonPropertyName("AlternativeText")]
    public string? AlternativeText { get; set; }

    /// <summary>Gets and sets the text horizontal alignment type of the shape.</summary>
    [JsonPropertyName("TextHorizontalAlignment")]
    public string? TextHorizontalAlignment { get; set; }

    /// <summary>Gets and sets the text horizontal overflow type of the shape which contains text.</summary>
    [JsonPropertyName("TextHorizontalOverflow")]
    public string? TextHorizontalOverflow { get; set; }

    /// <summary>Gets and sets the text orientation type of the shape.</summary>
    [JsonPropertyName("TextOrientationType")]
    public string? TextOrientationType { get; set; }

    /// <summary>Gets and sets the text vertical alignment type of the shape.</summary>
    [JsonPropertyName("TextVerticalAlignment")]
    public string? TextVerticalAlignment { get; set; }

    /// <summary>Gets and sets the text vertical overflow type of the shape which contains text.</summary>
    [JsonPropertyName("TextVerticalOverflow")]
    public string? TextVerticalOverflow { get; set; }

    /// <summary>Indicates whether the shape is a group.</summary>
    [JsonPropertyName("IsGroup")]
    public bool? IsGroup { get; set; }

    /// <summary>Indicates whether the object is visible.</summary>
    [JsonPropertyName("IsHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>True means that don't allow changes in aspect ratio.</summary>
    [JsonPropertyName("IsLockAspectRatio")]
    public bool? IsLockAspectRatio { get; set; }

    /// <summary>True if the object is locked, False if the object can be modified when the sheet is protected.</summary>
    [JsonPropertyName("IsLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>True if the object is printable</summary>
    [JsonPropertyName("IsPrintable")]
    public bool? IsPrintable { get; set; }

    /// <summary>Gets and sets the text wrapped type of the shape which contains text.</summary>
    [JsonPropertyName("IsTextWrapped")]
    public bool? IsTextWrapped { get; set; }

    /// <summary>Indicates whether this shape is a word art.</summary>
    [JsonPropertyName("IsWordArt")]
    public bool? IsWordArt { get; set; }

    /// <summary>Gets or sets the worksheet range linked to the control's value.</summary>
    [JsonPropertyName("LinkedCell")]
    public string? LinkedCell { get; set; }

    /// <summary>Returns the position of a shape in the z-order.</summary>
    [JsonPropertyName("ZOrderPosition")]
    public int? ZOrderPosition { get; set; }

    /// <summary>Represents the font of shape.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>Gets the hyperlink of the shape.</summary>
    [JsonPropertyName("Hyperlink")]
    public string? Hyperlink { get; set; }

}
