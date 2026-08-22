using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class SplitTextTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public SplitTextTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void SplitText()
    {
        var request = new SplitTextRequest("TestData/BookText.xlsx", "Comma")
        {
            KeepDelimitersInResultingCells = true,
            KeepDelimitersPosition = "BeforeText",
            HowToSplit = "SplitToColumns",
            Worksheet = "Bikes",
            Range = "A1:A10",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
