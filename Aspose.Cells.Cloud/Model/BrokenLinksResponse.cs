using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the BrokenLinksResponse model.</summary>
public class BrokenLinksResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the BrokenLinks.</summary>
    [JsonPropertyName("BrokenLinks")]
    public List<BrokenLink>? BrokenLinks { get; set; }

}
