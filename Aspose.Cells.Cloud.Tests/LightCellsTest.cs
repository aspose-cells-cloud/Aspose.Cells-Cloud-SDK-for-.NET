using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class LightCellsTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public LightCellsTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostSplit_1()
    {
        var request = new PostSplitRequest("testdata/Book1.xlsx", "pdf");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostSplit_2()
    {
        var request = new PostSplitRequest("testdata/Book1.xlsx", "xps");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostAssemble()
    {
        var request = new PostAssembleRequest("testdata/datasource.xlsx", "ds")
        {
            OutFormat = "html",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostExport_1()
    {
        var request = new PostExportRequest("testdata/Book1.xlsx")
        {
            ObjectType = "listobject",
            Format = "pdf",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostExport_2()
    {
        var request = new PostExportRequest("testdata/Book1.xlsx")
        {
            ObjectType = "listobject",
            Format = "md",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostCompress_1()
    {
        var request = new PostCompressRequest("testdata/datasource.xlsx")
        {
            CompressLevel = 0,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostCompress_2()
    {
        var request = new PostCompressRequest("testdata/datasource.xlsx")
        {
            CompressLevel = 0,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostMerge_1()
    {
        var request = new PostMergeRequest("testdata/datasource.xlsx")
        {
            OutFormat = "html",
            MergeToOneSheet = false,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostMerge_2()
    {
        var request = new PostMergeRequest("testdata/datasource.xlsx")
        {
            OutFormat = "pdf",
            MergeToOneSheet = false,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostMerge_3()
    {
        var request = new PostMergeRequest("testdata/datasource.xlsx")
        {
            OutFormat = "xlsx",
            MergeToOneSheet = false,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostMerge_4()
    {
        var request = new PostMergeRequest("testdata/datasource.xlsx")
        {
            OutFormat = "json",
            MergeToOneSheet = false,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostUnlock()
    {
        var request = new PostUnlockRequest("testdata/needUnlock.xlsx", "123456");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostLock()
    {
        var request = new PostLockRequest("testdata/needlock.xlsx", "123456");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostProtect()
    {
        var request = new PostProtectRequest("testdata/assemblytest.xlsx", new ProtectWorkbookRequest { AwaysOpenReadOnly = true, EncryptWithPassword = "123456" })
        {
            Password = "123456",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostProtect_ProtectWorkbookRequest()
    {
        var request = new PostProtectRequest("testdata/datasource.xlsx", new ProtectWorkbookRequest { AwaysOpenReadOnly = true, EncryptWithPassword = "123456" });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostSearch()
    {
        var request = new PostSearchRequest("testdata/datasource.xlsx", "12");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostReplace()
    {
        var request = new PostReplaceRequest("testdata/datasource.xlsx", "12", "newtext");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostReplaceOnlySheetname()
    {
        var request = new PostReplaceRequest("testdata/datasource.xlsx", "12", "newtext")
        {
            Sheetname = "Sheet1",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostWatermark()
    {
        var request = new PostWatermarkRequest("testdata/datasource.xlsx", "aspose.cells cloud sdk", "#773322");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_1()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "chart");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_2()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "comment");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_3()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "picture");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_4()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "shape");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_5()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "listobject");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_6()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "hyperlink");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_7()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "oleobject");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_8()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "pivottable");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_9()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "validation");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostClearObjects_10()
    {
        var request = new PostClearObjectsRequest("testdata/Book1.xlsx", "Background");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostRepair_1()
    {
        var request = new PostRepairRequest("testdata/Book1.xlsx")
        {
            OutFormat = "xlsx",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostRepair_2()
    {
        var request = new PostRepairRequest("testdata/Book1.xlsx")
        {
            OutFormat = "pdf",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostReverse_1()
    {
        var request = new PostReverseRequest("testdata/Book1.xlsx", "rows")
        {
            OutFormat = "pdf",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostReverse_2()
    {
        var request = new PostReverseRequest("testdata/Book1.xlsx", "cols")
        {
            OutFormat = "pdf",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetMetadata()
    {
        var request = new GetMetadataRequest("testdata/Book1.xlsx")
        {
            Type = "all",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void DeleteMetadata()
    {
        var request = new DeleteMetadataRequest("testdata/Book1.xlsx")
        {
            Type = "all",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostMetadata()
    {
        var request = new PostMetadataRequest("testdata/Book1.xlsx", new List<CellsDocumentProperty>());
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
