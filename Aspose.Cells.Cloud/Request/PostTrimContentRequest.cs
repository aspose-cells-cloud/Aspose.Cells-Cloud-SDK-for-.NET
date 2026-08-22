using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>The PostTrimContent API is designed to process and trim content within a specified range in a spreadsheet. This API allows users to remove extra spaces, line breaks, or other unnecessary characters from the content of selected cells. It is particularly useful for cleaning up data entries and ensuring consistency in spreadsheet formatting</summary>
public class PostTrimContentRequest : IRequestOption
{
    public PostTrimContentRequest(TrimContentOptions trimContentOptions)
    {
        if (trimContentOptions is null) throw new ArgumentNullException(nameof(trimContentOptions));
        TrimContentOptions = trimContentOptions;
    }

    public TrimContentOptions TrimContentOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/trimcontent";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => TrimContentOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
