using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a condition for the format condition in the worksheet.</summary>
public class PutWorksheetFormatConditionConditionRequest : IRequestOption
{
    public PutWorksheetFormatConditionConditionRequest(string name, string sheetName, int index, string type, string operatorType, string formula1, string formula2)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        Index = index;
        if (string.IsNullOrEmpty(type)) throw new ArgumentException("type is required", nameof(type));
        Type = type;
        if (string.IsNullOrEmpty(operatorType)) throw new ArgumentException("operatorType is required", nameof(operatorType));
        OperatorType = operatorType;
        if (string.IsNullOrEmpty(formula1)) throw new ArgumentException("formula1 is required", nameof(formula1));
        Formula1 = formula1;
        if (string.IsNullOrEmpty(formula2)) throw new ArgumentException("formula2 is required", nameof(formula2));
        Formula2 = formula2;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int Index { get; }
    public string Type { get; }
    public string OperatorType { get; }
    public string Formula1 { get; }
    public string Formula2 { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/conditionalFormattings/" +
            Uri.EscapeDataString(Index.ToString()) +
            "/condition";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["type"] = Type;
        query["operatorType"] = OperatorType;
        query["formula1"] = Formula1;
        query["formula2"] = Formula2;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
