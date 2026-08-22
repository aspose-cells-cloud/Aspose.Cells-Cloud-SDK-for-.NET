using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents user's custom calculation engine to extend the default calculation engine of Aspose.Cells.</summary>
public class AbstractCalculationEngine
{
    /// <summary>Indicates whether this engine needs the literal text of parameter while doing calculation. Default value is false.</summary>
    [JsonPropertyName("IsParamLiteralRequired")]
    public bool? IsParamLiteralRequired { get; set; }

    /// <summary>Indicates whether this engine needs the parameter to be calculated in array mode. Default value is false.</summary>
    [JsonPropertyName("IsParamArrayModeRequired")]
    public bool? IsParamArrayModeRequired { get; set; }

    /// <summary>Whether built-in functions that have been supported by the built-in engine</summary>
    [JsonPropertyName("ProcessBuiltInFunctions")]
    public bool? ProcessBuiltInFunctions { get; set; }

}
