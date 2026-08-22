using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Merge a spreadsheet file into other spreadsheet in cloud storage, and output a specified format file.</summary>
public class MergeRemoteSpreadsheetRequest : IRequestOption
{
    public MergeRemoteSpreadsheetRequest(string name, string mergedSpreadsheet)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(mergedSpreadsheet)) throw new ArgumentException("mergedSpreadsheet is required", nameof(mergedSpreadsheet));
        MergedSpreadsheet = mergedSpreadsheet;
    }

    public string Name { get; }
    public string MergedSpreadsheet { get; }
    public string? Folder { get; set; }
    public string? OutFormat { get; set; }
    public bool? MergeInOneSheet { get; set; }
    public string? StorageName { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? FontsLocation { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/merge/spreadsheet";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["mergedSpreadsheet"] = MergedSpreadsheet;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(OutFormat)) query["outFormat"] = OutFormat;
        if (MergeInOneSheet.HasValue) query["mergeInOneSheet"] = MergeInOneSheet.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (!string.IsNullOrEmpty(FontsLocation)) query["fontsLocation"] = FontsLocation;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
