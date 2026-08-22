using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Enhance Excel data through essential text conversions: convert text to numbers, replace characters and line breaks, and remove accents.</summary>
public class PostConvertTextRequest : IRequestOption
{
    public PostConvertTextRequest(ConvertTextOptions convertTextOptions)
    {
        if (convertTextOptions is null) throw new ArgumentNullException(nameof(convertTextOptions));
        ConvertTextOptions = convertTextOptions;
    }

    public ConvertTextOptions ConvertTextOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/converttext";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => ConvertTextOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
