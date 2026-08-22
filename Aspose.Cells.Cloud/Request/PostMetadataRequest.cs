using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Update document properties in Excel file, and save them is various formats.</summary>
public class PostMetadataRequest : IRequestOption
{
    public PostMetadataRequest(FileParameter file, List<CellsDocumentProperty> cellsDocuments)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
        if (cellsDocuments is null) throw new ArgumentNullException(nameof(cellsDocuments));
        CellsDocuments = cellsDocuments;
    }

    public FileParameter File { get; }
    public List<CellsDocumentProperty> CellsDocuments { get; }
    public string? Password { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? OutFormat { get; set; }
    public string? Region { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/metadata/update";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(OutFormat)) query["outFormat"] = OutFormat;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        return query;
    }

    public object? GetJsonBody() => CellsDocuments;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
