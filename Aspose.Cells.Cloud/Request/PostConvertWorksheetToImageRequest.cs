using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>PostConvertWorksheetToImage operation.</summary>
public class PostConvertWorksheetToImageRequest : IRequestOption
{
    public PostConvertWorksheetToImageRequest(ConvertWorksheetOptions convertWorksheetOptions)
    {
        if (convertWorksheetOptions is null) throw new ArgumentNullException(nameof(convertWorksheetOptions));
        ConvertWorksheetOptions = convertWorksheetOptions;
    }

    public ConvertWorksheetOptions ConvertWorksheetOptions { get; }
    public string? FontsLocation { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/convertWorksheetToImage";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(FontsLocation)) query["FontsLocation"] = FontsLocation;
        return query;
    }

    public object? GetJsonBody() => ConvertWorksheetOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
