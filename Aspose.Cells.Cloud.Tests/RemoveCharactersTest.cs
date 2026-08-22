using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class RemoveCharactersTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public RemoveCharactersTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void RemoveCharacters()
    {
        var request = new RemoveCharactersRequest("TestData/BookText.xlsx")
        {
            RemoveTextMethod = "RemoveCharacterSets",
            CharacterSets = "NonPrintingCharacters",
            Worksheet = "Text",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RemoveDuplicateSubstrings()
    {
        var request = new RemoveDuplicateSubstringsRequest("TestData/BookText.xlsx", "Space")
        {
            Worksheet = "Text",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RemoveCharactersWithFirstNCharacters()
    {
        var request = new RemoveCharactersByPositionRequest("TestData/BookText.xlsx")
        {
            TheFirstNCharacters = 5,
            TheLastNCharacters = 3,
            Worksheet = "Text",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RemoveCharactersWithAllCharactersBeforeText()
    {
        var request = new RemoveCharactersByPositionRequest("TestData/BookText.xlsx")
        {
            TheFirstNCharacters = 0,
            TheLastNCharacters = 0,
            AllCharactersBeforeText = "Designed",
            AllCharactersAfterText = "distance",
            Worksheet = "Text",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RemoveCharactersByPosition()
    {
        var request = new RemoveCharactersByPositionRequest("TestData/BookText.xlsx")
        {
            TheFirstNCharacters = 5,
            TheLastNCharacters = 3,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
