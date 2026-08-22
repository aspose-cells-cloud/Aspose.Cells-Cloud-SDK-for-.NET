using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents page setup operate parameter.</summary>
public class PageSetupOperateParameter : OperateParameter
{
    /// <summary>Represents worksheet page setup.</summary>
    [JsonPropertyName("PageSetup")]
    public PageSetup? PageSetup { get; set; }

}
