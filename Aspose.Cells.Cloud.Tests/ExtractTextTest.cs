using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ExtractTextTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ExtractTextTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void ExtractText()
    {
        var request = new ExtractTextRequest("TestData/BookText.xlsx", "ExtractFirstCharacter", "F1:F10")
        {
            BeforePosition = 10,
            AfterPosition = 0,
            Worksheet = "Bikes",
            Range = "A1:A10",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExtractTextWithExtractLastCharacter()
    {
        var request = new ExtractTextRequest("TestData/BookText.xlsx", "ExtractLastCharacter", "F1:F10")
        {
            BeforePosition = 0,
            AfterPosition = 10,
            Worksheet = "Bikes",
            Range = "A1:A10",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExtractTextWithExtractTextAfter()
    {
        var request = new ExtractTextRequest("TestData/BookText.xlsx", "ExtractTextAfter", "F1:F10")
        {
            AfterText = "bikes",
            BeforePosition = 0,
            AfterPosition = 0,
            Worksheet = "Bikes",
            Range = "A1:A10",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
