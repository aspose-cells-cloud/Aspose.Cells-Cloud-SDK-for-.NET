using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>MathCalculate operation.</summary>
public class MathCalculateRequest : IRequestOption
{
    public MathCalculateRequest(FileParameter spreadsheet, string operation, string value)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(operation)) throw new ArgumentException("operation is required", nameof(operation));
        Operation = operation;
        if (string.IsNullOrEmpty(value)) throw new ArgumentException("value is required", nameof(value));
        Value = value;
    }

    public FileParameter Spreadsheet { get; }
    public string Operation { get; }
    public string Value { get; }
    public string? Worksheet { get; set; }
    public string? Range { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/calculate/math";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["operation"] = Operation;
        query["value"] = Value;
        if (!string.IsNullOrEmpty(Worksheet)) query["worksheet"] = Worksheet;
        if (!string.IsNullOrEmpty(Range)) query["range"] = Range;
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
