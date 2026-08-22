using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Removes dual-layer password protection from Excel spreadsheets, supporting both open and modify passwords with encryption.</summary>
public class UnprotectSpreadsheetRequest : IRequestOption
{
    public UnprotectSpreadsheetRequest(FileParameter spreadsheet, string password, string modifyPassword)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(password)) throw new ArgumentException("password is required", nameof(password));
        Password = password;
        if (string.IsNullOrEmpty(modifyPassword)) throw new ArgumentException("modifyPassword is required", nameof(modifyPassword));
        ModifyPassword = modifyPassword;
    }

    public FileParameter Spreadsheet { get; }
    public string Password { get; }
    public string ModifyPassword { get; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? Region { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/unprotection/spreadsheet";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["password"] = Password;
        query["modifyPassword"] = ModifyPassword;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + Spreadsheet.FileName] = Spreadsheet,
        };
}
