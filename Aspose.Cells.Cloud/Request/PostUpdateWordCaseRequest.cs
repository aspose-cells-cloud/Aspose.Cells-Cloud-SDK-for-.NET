using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Managing inconsistent text case in spreadsheets (Excel, Google Sheets, CSV) can be frustrating, especially with large datasets. The PostUpdateWordCase WEB API solves this by automating text case conversions, ensuring clean and standardized data.</summary>
public class PostUpdateWordCaseRequest : IRequestOption
{
    public PostUpdateWordCaseRequest(WordCaseOptions wordCaseOptions)
    {
        if (wordCaseOptions is null) throw new ArgumentNullException(nameof(wordCaseOptions));
        WordCaseOptions = wordCaseOptions;
    }

    public WordCaseOptions WordCaseOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/updatewordcase";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => WordCaseOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
