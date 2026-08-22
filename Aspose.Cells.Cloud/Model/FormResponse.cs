using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Form Response.</summary>
public class FormResponse : CellsCloudResponse
{
    /// <summary>Property summary: A public property named "Form" with both get and set accessors, allowing access to a Form object.</summary>
    [JsonPropertyName("Form")]
    public Form? Form { get; set; }

}
