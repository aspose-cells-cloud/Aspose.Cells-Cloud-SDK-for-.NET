using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Converts a worksheet of spreadsheet in cloud storage to the specified format.</summary>
public class ExportWorksheetAsFormatRequest : IRequestOption
{
    public ExportWorksheetAsFormatRequest(string name, string worksheet, string format)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(worksheet)) throw new ArgumentException("worksheet is required", nameof(worksheet));
        Worksheet = worksheet;
        if (string.IsNullOrEmpty(format)) throw new ArgumentException("format is required", nameof(format));
        Format = format;
    }

    public string Name { get; }
    public string Worksheet { get; }
    public string Format { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public string? FontsLocation { get; set; }
    public bool? AutoRowsFit { get; set; }
    public bool? AutoColumnsFit { get; set; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(Worksheet);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["format"] = Format;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
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

    public Dictionary<string, object>? GetMultipartForm() => null;
}
