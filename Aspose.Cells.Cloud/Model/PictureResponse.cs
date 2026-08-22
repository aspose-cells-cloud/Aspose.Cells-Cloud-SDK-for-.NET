using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Picture Response.</summary>
public class PictureResponse : CellsCloudResponse
{
    /// <summary>Property Summary: This class has a public property named "Picture" of type "Picture" that has both getter and setter methods.</summary>
    [JsonPropertyName("Picture")]
    public Picture? Picture { get; set; }

}
