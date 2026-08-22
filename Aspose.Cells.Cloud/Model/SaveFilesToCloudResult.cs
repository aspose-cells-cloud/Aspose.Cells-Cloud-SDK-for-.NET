using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents save file to cloud result.</summary>
public class SaveFilesToCloudResult : TaskRunResult
{
    /// <summary>This class has a property named SavedFiles of type List Link.</summary>
    [JsonPropertyName("SavedFiles")]
    public List<Link>? SavedFiles { get; set; }

}
