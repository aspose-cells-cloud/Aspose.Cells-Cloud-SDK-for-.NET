using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Converts a table of spreadsheet on a local drive to the csv file.</summary>
public class ConvertTableToCsvRequest : IRequestOption
{
    public ConvertTableToCsvRequest(FileParameter spreadsheet, string worksheet, string tableName)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(tableName)) throw new ArgumentException("tableName is required", nameof(tableName));
        TableName = tableName;
    }

    public FileParameter Spreadsheet { get; }
    public string Worksheet { get; }
    public string TableName { get; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? FontsLocation { get; set; }
    public bool? AutoRowsFit { get; set; }
    public bool? AutoColumnsFit { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/convert/table/csv";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["worksheet"] = Worksheet;
        query["tableName"] = TableName;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (!string.IsNullOrEmpty(FontsLocation)) query["fontsLocation"] = FontsLocation;
        if (AutoRowsFit.HasValue) query["AutoRowsFit"] = AutoRowsFit.Value ? "true" : "false";
        if (AutoColumnsFit.HasValue) query["AutoColumnsFit"] = AutoColumnsFit.Value ? "true" : "false";
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
