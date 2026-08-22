using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>The Aggregate by Color API provides a convenient way to perform calculations on cells that share the same fill or font color. This API supports a range of aggregate operations, including count, sum, maximum value, minimum value, and average value, enabling you to analyze and summarize data based on color distinctions.</summary>
public class AggregateCellsByColorRequest : IRequestOption
{
    public AggregateCellsByColorRequest(FileParameter spreadsheet)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
    }

    public FileParameter Spreadsheet { get; }
    public string? Worksheet { get; set; }
    public string? Range { get; set; }
    public string? Operation { get; set; }
    public string? ColorPosition { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/calculate/aggergate/color";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Range)) query["range"] = Range;
        if (!string.IsNullOrEmpty(Operation)) query["operation"] = Operation;
        if (!string.IsNullOrEmpty(ColorPosition)) query["colorPosition"] = ColorPosition;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + Spreadsheet.FileName] = Spreadsheet,
        };
}
