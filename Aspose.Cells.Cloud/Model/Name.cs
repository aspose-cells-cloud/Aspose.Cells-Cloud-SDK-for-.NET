using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a defined name for a range of cells.</summary>
public class Name : LinkElement
{
    /// <summary>Gets and sets the comment of the name.</summary>
    [JsonPropertyName("Comment")]
    public string? Comment { get; set; }

    /// <summary>Property Summary: WorksheetIndex is an optional integer property marked with the XmlElement attribute "worksheetindex".</summary>
    [JsonPropertyName("WorksheetIndex")]
    public int? WorksheetIndex { get; set; }

    /// <summary>Indicates whether this name is referred by other formulas.</summary>
    [JsonPropertyName("IsReferred")]
    public bool? IsReferred { get; set; }

    /// <summary>Indicates whether the name is visible.</summary>
    [JsonPropertyName("IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>Gets or sets a R1C1 reference of the .</summary>
    [JsonPropertyName("R1C1RefersTo")]
    public string? R1C1RefersTo { get; set; }

    /// <summary>Returns or sets the formula that the name is defined to refer to, beginning with an equal sign.</summary>
    [JsonPropertyName("RefersTo")]
    public string? RefersTo { get; set; }

    /// <summary>Gets the name text of the object.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

}
