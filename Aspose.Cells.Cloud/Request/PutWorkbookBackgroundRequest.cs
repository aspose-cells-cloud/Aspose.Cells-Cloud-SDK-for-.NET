using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Set background in the workbook.</summary>
public class PutWorkbookBackgroundRequest : IRequestOption
{
    public PutWorkbookBackgroundRequest(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
    }

    public string Name { get; }
    public string? PicPath { get; set; }
    public string? ImageAdaptOption { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public FileParameter? File { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/background";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(PicPath)) query["picPath"] = PicPath;
        if (!string.IsNullOrEmpty(ImageAdaptOption)) query["imageAdaptOption"] = ImageAdaptOption;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        File is null
            ? null
            : new Dictionary<string, object>
            {
                ["@" + File.FileName] = File,
            };
}
