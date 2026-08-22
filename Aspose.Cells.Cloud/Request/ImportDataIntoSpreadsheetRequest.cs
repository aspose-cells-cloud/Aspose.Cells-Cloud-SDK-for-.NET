using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Import data into a spreadsheet from a supported data file format.</summary>
public class ImportDataIntoSpreadsheetRequest : IRequestOption
{
    public ImportDataIntoSpreadsheetRequest(FileParameter datafile, FileParameter spreadsheet, string worksheet, string startcell)
    {
        if (datafile is null) throw new ArgumentNullException(nameof(datafile));
        Datafile = datafile;
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(startcell)) throw new ArgumentException("startcell is required", nameof(startcell));
        Startcell = startcell;
    }

    public FileParameter Datafile { get; }
    public FileParameter Spreadsheet { get; }
    public string Worksheet { get; }
    public string Startcell { get; }
    public bool? Insert { get; set; }
    public bool? ConvertNumericData { get; set; }
    public string? Splitter { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? FontsLocation { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/import/data";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["worksheet"] = Worksheet;
        query["startcell"] = Startcell;
        if (Insert.HasValue) query["insert"] = Insert.Value ? "true" : "false";
        if (ConvertNumericData.HasValue) query["convertNumericData"] = ConvertNumericData.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Splitter)) query["splitter"] = Splitter;
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
            ["@" + Datafile.FileName] = Datafile,
            ["@" + Spreadsheet.FileName] = Spreadsheet,
        };
}
