using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates convert parameter</summary>
public class ConvertParameter
{
    /// <summary>A property "Name" of type string with a getter and setter is declared in the class.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the Value.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

}
