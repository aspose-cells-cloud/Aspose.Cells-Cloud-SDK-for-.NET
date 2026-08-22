using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Split an Excel worksheet tale into multiple sheets by column value.</summary>
public class SplitTableRequest : IRequestOption
{
    public SplitTableRequest(FileParameter spreadsheet, string worksheet, string tableName, string splitColumnName, bool saveSplitColumn, int splitRowNumber, bool toNewWorkbook, bool toMultipleFiles)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(tableName)) throw new ArgumentException("tableName is required", nameof(tableName));
        TableName = tableName;
        if (string.IsNullOrEmpty(splitColumnName)) throw new ArgumentException("splitColumnName is required", nameof(splitColumnName));
        SplitColumnName = splitColumnName;
        SaveSplitColumn = saveSplitColumn;
        SplitRowNumber = splitRowNumber;
        ToNewWorkbook = toNewWorkbook;
        ToMultipleFiles = toMultipleFiles;
    }

    public FileParameter Spreadsheet { get; }
    public string Worksheet { get; }
    public string TableName { get; }
    public string SplitColumnName { get; }
    public bool SaveSplitColumn { get; }
    public int SplitRowNumber { get; }
    public bool ToNewWorkbook { get; }
    public bool ToMultipleFiles { get; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? FontsLocation { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/split/table";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["worksheet"] = Worksheet;
        query["tableName"] = TableName;
        query["splitColumnName"] = SplitColumnName;
        query["saveSplitColumn"] = SaveSplitColumn ? "true" : "false";
        query["splitRowNumber"] = SplitRowNumber.ToString();
        query["toNewWorkbook"] = ToNewWorkbook ? "true" : "false";
        query["toMultipleFiles"] = ToMultipleFiles ? "true" : "false";
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (!string.IsNullOrEmpty(FontsLocation)) query["fontsLocation"] = FontsLocation;
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
