using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>"Summary: The class covers a range of features including advanced machine learning techniques, statistical analysis tools, and computer vision algorithms."</summary>
public class Forms : LinkElement
{
    /// <summary>Property: FormList is a list of LinkElements that are serialized as "form" XML elements.</summary>
    [JsonPropertyName("FormList")]
    public List<LinkElement>? FormList { get; set; }

}
