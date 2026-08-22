using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Switch rows and columns in the spreadsheet.</summary>
public class UnpivotTableRequest : IRequestOption
{
    public UnpivotTableRequest(FileParameter spreadsheet, string worksheet, int index)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        Index = index;
    }

    public FileParameter Spreadsheet { get; }
    public string Worksheet { get; }
    public int Index { get; }
    public bool? SkipEmptyValue { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/unpivot/table";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["worksheet"] = Worksheet;
        query["index"] = Index.ToString();
        if (SkipEmptyValue.HasValue) query["skipEmptyValue"] = SkipEmptyValue.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
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
