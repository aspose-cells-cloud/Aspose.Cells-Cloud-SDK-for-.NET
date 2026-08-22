using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>PostSpecifyWordsCount operation.</summary>
public class PostSpecifyWordsCountRequest : IRequestOption
{
    public PostSpecifyWordsCountRequest(SpecifyWordsCountOptions specifyWordsCountOptions)
    {
        if (specifyWordsCountOptions is null) throw new ArgumentNullException(nameof(specifyWordsCountOptions));
        SpecifyWordsCountOptions = specifyWordsCountOptions;
    }

    public SpecifyWordsCountOptions SpecifyWordsCountOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/specifywordscount";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => SpecifyWordsCountOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
