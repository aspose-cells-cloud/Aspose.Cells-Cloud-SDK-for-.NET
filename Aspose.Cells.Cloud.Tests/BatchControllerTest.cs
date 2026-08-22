using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class BatchControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public BatchControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostBatchConvert()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/myDocument.xlsx", "TestData/In/myDocument.xlsx"));
        var request = new PostBatchConvertRequest(new BatchConvertRequest { SourceFolder = "TestData/In", Format = "pdf", OutFolder = "OutResult", MatchCondition = new MatchConditionRequest { RegexPattern = "(^Book)(.+)(xlsx$)" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostBatchProtect()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/myDocument.xlsx", "TestData/In/myDocument.xlsx"));
        var request = new PostBatchProtectRequest(new BatchProtectRequest { SourceFolder = "TestData/In", ProtectionType = "All", Password = "123456", OutFolder = "OutResult", MatchCondition = new MatchConditionRequest { RegexPattern = "(^Book)(.+)(xlsx$)" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostBatchLock()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/myDocument.xlsx", "TestData/In/myDocument.xlsx"));
        var request = new PostBatchLockRequest(new BatchLockRequest { SourceFolder = "TestData/In", Password = "123456", OutFolder = "OutResult", MatchCondition = new MatchConditionRequest { RegexPattern = "(^Book)(.+)(xlsx$)" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostBatchUnlock()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/myDocument.xlsx", "TestData/In/myDocument.xlsx"));
        var request = new PostBatchUnlockRequest(new BatchLockRequest { SourceFolder = "TestData/In", Password = "123456", OutFolder = "OutResult", MatchCondition = new MatchConditionRequest { RegexPattern = "(^Book)(.+)(xlsx$)" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostBatchSplit()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/myDocument.xlsx", "TestData/In/myDocument.xlsx"));
        var request = new PostBatchSplitRequest(new BatchSplitRequest { SourceFolder = "TestData/In", Format = "Pdf", OutFolder = "OutResult", MatchCondition = new MatchConditionRequest { RegexPattern = "(^Book)(.+)(xlsx$)" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
