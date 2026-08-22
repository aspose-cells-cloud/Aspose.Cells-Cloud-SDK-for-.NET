using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents Xml map information.</summary>
public class XmlMap
{
    /// <summary>Returns or sets the name of the object.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets root element name.</summary>
    [JsonPropertyName("RootElementName")]
    public string? RootElementName { get; set; }

    /// <summary>Gets an  of this map.</summary>
    [JsonPropertyName("DataBinding")]
    public XmlDataBinding? DataBinding { get; set; }

}
