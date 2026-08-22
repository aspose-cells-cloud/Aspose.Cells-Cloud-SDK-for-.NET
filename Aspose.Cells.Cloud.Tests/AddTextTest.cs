using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class AddTextTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public AddTextTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void AddText()
    {
        var request = new AddTextRequest("TestData/BookText.xlsx", "New", "AtTheBeginning")
        {
            SelectText = "text",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void AddTextSkipEmptyCells()
    {
        var request = new AddTextRequest("TestData/BookText.xlsx", "New", "AtTheBeginning")
        {
            SkipEmptyCells = true,
            Worksheet = "Bikes",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void AddTextInRange()
    {
        var request = new AddTextRequest("TestData/BookText.xlsx", "New", "AtTheBeginning")
        {
            SkipEmptyCells = true,
            Worksheet = "Bikes",
            Range = "A1:B15",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void AddTextBeforeText()
    {
        var request = new AddTextRequest("TestData/BookText.xlsx", "New", "BeforeText")
        {
            SelectText = "bike",
            Worksheet = "Bikes",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
