using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SaveResult model.</summary>
public class SaveResult
{
    /// <summary>Gets or sets the Documents.</summary>
    [JsonPropertyName("Documents")]
    public List<CellsCloudFileInfo>? Documents { get; set; }

}
