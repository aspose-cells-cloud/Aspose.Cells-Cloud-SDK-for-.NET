using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>PostCharacterCount operation.</summary>
public class PostCharacterCountRequest : IRequestOption
{
    public PostCharacterCountRequest(CharacterCountOptions characterCountOptions)
    {
        if (characterCountOptions is null) throw new ArgumentNullException(nameof(characterCountOptions));
        CharacterCountOptions = characterCountOptions;
    }

    public CharacterCountOptions CharacterCountOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/charactercount";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => CharacterCountOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
