using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents text item collection.</summary>
public class TextItems : LinkElement
{
    /// <summary>Represents text item collection</summary>
    [JsonPropertyName("TextItemList")]
    public List<TextItem>? TextItemList { get; set; }

}
