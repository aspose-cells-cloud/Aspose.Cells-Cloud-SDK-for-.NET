using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Efficiently divides Excel cell content into columns or rows based on specified delimiters or patterns. Supports Character-based splitting, Custom string splitting, Mask and wildcard splitting for pattern-based division, Line break division, Column or row splitting, Delimiter removal or retention.</summary>
public class PostSplitTextRequest : IRequestOption
{
    public PostSplitTextRequest(SplitTextOptions splitTextOptions)
    {
        if (splitTextOptions is null) throw new ArgumentNullException(nameof(splitTextOptions));
        SplitTextOptions = splitTextOptions;
    }

    public SplitTextOptions SplitTextOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/splittext";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => SplitTextOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
