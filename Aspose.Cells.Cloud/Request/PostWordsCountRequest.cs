using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>PostWordsCount operation.</summary>
public class PostWordsCountRequest : IRequestOption
{
    public PostWordsCountRequest(WordsCountOptions wordsCountOptions)
    {
        if (wordsCountOptions is null) throw new ArgumentNullException(nameof(wordsCountOptions));
        WordsCountOptions = wordsCountOptions;
    }

    public WordsCountOptions WordsCountOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/wordscount";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => WordsCountOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
