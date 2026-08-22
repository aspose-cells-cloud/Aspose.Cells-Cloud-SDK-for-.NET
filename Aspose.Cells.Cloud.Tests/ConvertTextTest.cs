using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ConvertTextTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ConvertTextTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void ConvertText()
    {
        var request = new ConvertTextRequest("TestData/BookText.xlsx", "ConvertNumberToText");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTextWithConvertCharacters()
    {
        var request = new ConvertTextRequest("TestData/BookText.xlsx", "ConvertCharacters")
        {
            SourceCharacters = "Bikes",
            TargetCharacters = "MOTO",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTextWithConvertWriteSpace()
    {
        var request = new ConvertTextRequest("TestData/BookText.xlsx", "ConvertWriteSpace")
        {
            TargetCharacters = "MOTO",
            Worksheet = "Bikes",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
