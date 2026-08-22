using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a hyperlink.</summary>
public class Hyperlink : LinkElement
{
    /// <summary>Represents the address of a hyperlink.</summary>
    [JsonPropertyName("Address")]
    public string? Address { get; set; }

    /// <summary>Gets the range of hyperlink.</summary>
    [JsonPropertyName("Area")]
    public CellArea? Area { get; set; }

    /// <summary>Returns or sets the ScreenTip text for the specified hyperlink.</summary>
    [JsonPropertyName("ScreenTip")]
    public string? ScreenTip { get; set; }

    /// <summary>Represents the text to be displayed for the specified hyperlink. The default value is the address of the hyperlink.</summary>
    [JsonPropertyName("TextToDisplay")]
    public string? TextToDisplay { get; set; }

    /// <summary>Gets the link type.</summary>
    [JsonPropertyName("LinkType")]
    public string? LinkType { get; set; }

}
