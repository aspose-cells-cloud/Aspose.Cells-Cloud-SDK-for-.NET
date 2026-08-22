using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>A comprehensive set of tools for cleaning text content within selected cells. It allows users to remove specific characters, character sets, and substrings, ensuring that the text is standardized and free from unwanted symbols or sequences.</summary>
public class PostRemoveCharactersRequest : IRequestOption
{
    public PostRemoveCharactersRequest(RemoveCharactersOptions removeCharactersOptions)
    {
        if (removeCharactersOptions is null) throw new ArgumentNullException(nameof(removeCharactersOptions));
        RemoveCharactersOptions = removeCharactersOptions;
    }

    public RemoveCharactersOptions RemoveCharactersOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/removecharacters";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => RemoveCharactersOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
