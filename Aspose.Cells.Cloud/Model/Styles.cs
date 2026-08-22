using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data style collection.</summary>
public class Styles : LinkElement
{
    /// <summary>This property contains a list of elements with the tag "style".</summary>
    [JsonPropertyName("StyleList")]
    public List<Style>? StyleList { get; set; }

}
