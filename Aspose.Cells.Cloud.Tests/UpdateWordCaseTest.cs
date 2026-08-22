using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class UpdateWordCaseTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public UpdateWordCaseTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void UpdateWordCase()
    {
        var request = new UpdateWordCaseRequest("TestData/BookText.xlsx", "ProperCase")
        {
            Worksheet = "Bikes",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void UpdateWordCaseInRange()
    {
        var request = new UpdateWordCaseRequest("TestData/BookText.xlsx", "ProperCase")
        {
            Worksheet = "Bikes",
            Range = "A1:B15",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void UpdateWordCaseInSpreadsheet()
    {
        var request = new UpdateWordCaseRequest("TestData/BookText.xlsx", "ProperCase");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
