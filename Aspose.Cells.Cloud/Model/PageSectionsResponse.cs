using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PageSections Response.</summary>
public class PageSectionsResponse : CellsCloudResponse
{
    /// <summary>A property named PageSections of type List PageSection  to store a collection of PageSection objects.</summary>
    [JsonPropertyName("PageSections")]
    public List<PageSection>? PageSections { get; set; }

}
