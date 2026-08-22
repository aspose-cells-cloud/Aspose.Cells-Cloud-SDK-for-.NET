using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Adds text content to a specified location within a document. It requires an object that defines the text to be added and the insertion location.</summary>
public class PostAddTextContentRequest : IRequestOption
{
    public PostAddTextContentRequest(AddTextOptions addTextOptions)
    {
        if (addTextOptions is null) throw new ArgumentNullException(nameof(addTextOptions));
        AddTextOptions = addTextOptions;
    }

    public AddTextOptions AddTextOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/addtext";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => AddTextOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
