using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the result of the file split.</summary>
public class SplitResult
{
    /// <summary>Represents cells cloud file information.</summary>
    [JsonPropertyName("Documents")]
    public List<CellsCloudFileInfo>? Documents { get; set; }

}
