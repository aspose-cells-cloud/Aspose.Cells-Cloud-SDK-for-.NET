using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Names Response.</summary>
public class NamesResponse : CellsCloudResponse
{
    /// <summary>Property: This property represents an XML element named "names" and holds a Names object.</summary>
    [JsonPropertyName("Names")]
    public Names? Names { get; set; }

}
