using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class SparklineGroupsControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public SparklineGroupsControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetSparklineGroups()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new GetWorksheetSparklineGroupsRequest("TestCase.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetSparklineGroup()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new GetWorksheetSparklineGroupRequest("TestCase.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetSparklineGroups()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeleteWorksheetSparklineGroupsRequest("TestCase.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetSparklineGroup()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeleteWorksheetSparklineGroupRequest("TestCase.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetSparklineGroup()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PutWorksheetSparklineGroupRequest("TestCase.xlsx", "Sheet1", "Line", "C6:E13", false, "G6:G13")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetSparklineGroup()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostWorksheetSparklineGroupRequest("TestCase.xlsx", "Sheet1", 0, new SparklineGroup { DisplayHidden = true, PlotRightToLeft = true })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
