using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsDocumentProperties Response.</summary>
public class CellsDocumentPropertiesResponse : CellsCloudResponse
{
    /// <summary>The class has a property that represents the document properties of cells.</summary>
    [JsonPropertyName("DocumentProperties")]
    public CellsDocumentProperties? DocumentProperties { get; set; }

}
