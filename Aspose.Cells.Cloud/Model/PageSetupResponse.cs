using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PageSetup Response.</summary>
public class PageSetupResponse : CellsCloudResponse
{
    /// <summary>Property Summary: The class has a public property named PageSetup of type PageSetup that can be accessed and modified.</summary>
    [JsonPropertyName("PageSetup")]
    public PageSetup? PageSetup { get; set; }

}
