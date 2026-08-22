using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Efficiently remove duplicate substrings from Excel cells. Select a range, specify delimiters, and apply options to eliminate repeated text segments.</summary>
public class PostRemoveDuplicatesRequest : IRequestOption
{
    public PostRemoveDuplicatesRequest(RemoveDuplicatesOptions removeDuplicatesOptions)
    {
        if (removeDuplicatesOptions is null) throw new ArgumentNullException(nameof(removeDuplicatesOptions));
        RemoveDuplicatesOptions = removeDuplicatesOptions;
    }

    public RemoveDuplicatesOptions RemoveDuplicatesOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/removeduplicates";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => RemoveDuplicatesOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
