using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a groupbox in a spreadsheet.</summary>
public class GroupBox : Shape
{
    /// <summary>Indicates whether the groupbox has shadow.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

}
