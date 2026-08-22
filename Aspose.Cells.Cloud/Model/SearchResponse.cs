using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SearchResponse model.</summary>
public class SearchResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the TextItems.</summary>
    [JsonPropertyName("TextItems")]
    public List<TextItem>? TextItems { get; set; }

}
