using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsDocumentProperty Response.</summary>
public class CellsDocumentPropertyResponse : CellsCloudResponse
{
    /// <summary>A property named DocumentProperty of type CellsDocumentProperty is defined with get and set accessors.</summary>
    [JsonPropertyName("DocumentProperty")]
    public CellsDocumentProperty? DocumentProperty { get; set; }

}
