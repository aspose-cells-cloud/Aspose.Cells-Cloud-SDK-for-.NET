using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class CellsStatusControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public CellsStatusControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetCellsCloudServiceStatus()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetCellsCloudServiceStatusRequest();
        RichResponse response = _client.Do(request);
        Assert.Equal("OK", response.ToString());
    }

    public void Dispose() { }
}
