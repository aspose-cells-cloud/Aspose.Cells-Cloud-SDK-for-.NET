using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RemoveCharactersOptions model.</summary>
public class RemoveCharactersOptions : BaseOperateOptions
{
    /// <summary>Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents file information. Include of filename, filesize, and file content(base64String).</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.</summary>
    [JsonPropertyName("ScopeOptions")]
    public ScopeOptions? ScopeOptions { get; set; }

    /// <summary>Gets or sets the RemoveCharactersByCharacter.</summary>
    [JsonPropertyName("RemoveCharactersByCharacter")]
    public RemoveCharactersByCharacter? RemoveCharactersByCharacter { get; set; }

    /// <summary>Gets or sets the RemoveCharactersByPosition.</summary>
    [JsonPropertyName("RemoveCharactersByPosition")]
    public RemoveCharactersByPosition? RemoveCharactersByPosition { get; set; }

}
