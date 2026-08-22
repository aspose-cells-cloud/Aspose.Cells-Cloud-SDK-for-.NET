using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Set water marker in the workbook.</summary>
public class PutWorkbookWaterMarkerRequest : IRequestOption
{
    public PutWorkbookWaterMarkerRequest(string name, TextWaterMarkerRequest textWaterMarkerRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (textWaterMarkerRequest is null) throw new ArgumentNullException(nameof(textWaterMarkerRequest));
        TextWaterMarkerRequest = textWaterMarkerRequest;
    }

    public string Name { get; }
    public TextWaterMarkerRequest TextWaterMarkerRequest { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/watermarker";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => TextWaterMarkerRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
