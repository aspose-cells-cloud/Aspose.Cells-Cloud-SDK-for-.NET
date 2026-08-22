using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Split a spreadsheet in cloud storage into the specified format, multi-file.</summary>
public class SplitRemoteSpreadsheetRequest : IRequestOption
{
    public SplitRemoteSpreadsheetRequest(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
    }

    public string Name { get; }
    public string? Folder { get; set; }
    public int? From { get; set; }
    public int? To { get; set; }
    public string? OutFormat { get; set; }
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
            "/split/spreadsheet";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (From.HasValue) query["from"] = From.Value.ToString();
        if (To.HasValue) query["to"] = To.Value.ToString();
        if (!string.IsNullOrEmpty(OutFormat)) query["outFormat"] = OutFormat;
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
