using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class FolderControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public FolderControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetFilesList()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetFilesListRequest()
        {
            Path = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void CreateFolder()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new CreateFolderRequest("OutResult/NewFolder");
        RichResponse response = _client.Do(request);
    }

    [Fact]
    public void CopyFolder()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new CopyFolderRequest("TestData/In", "OutResult/Create");
        RichResponse response = _client.Do(request);
    }

    [Fact]
    public void MoveFolder()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new MoveFolderRequest("OutResult/Create", "OutResult/Move");
        RichResponse response = _client.Do(request);
    }

    [Fact]
    public void DeleteFolder()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteFolderRequest("OutResult/Create")
        {
            Recursive = true,
        };
        RichResponse response = _client.Do(request);
    }

    public void Dispose() { }
}
