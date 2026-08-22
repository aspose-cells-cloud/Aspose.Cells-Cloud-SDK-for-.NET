using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>PostConvertWorkbook operation.</summary>
public class PostConvertWorkbookRequest : IRequestOption
{
    public PostConvertWorkbookRequest(ConvertWorkbookOptions convertWorkbookOptions)
    {
        if (convertWorkbookOptions is null) throw new ArgumentNullException(nameof(convertWorkbookOptions));
        ConvertWorkbookOptions = convertWorkbookOptions;
    }

    public ConvertWorkbookOptions ConvertWorkbookOptions { get; }
    public string? FontsLocation { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/convertWorkbook";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(FontsLocation)) query["FontsLocation"] = FontsLocation;
        return query;
    }

    public object? GetJsonBody() => ConvertWorkbookOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
