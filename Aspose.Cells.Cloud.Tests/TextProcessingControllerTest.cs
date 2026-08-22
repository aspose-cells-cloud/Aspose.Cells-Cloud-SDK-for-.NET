using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class TextProcessingControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public TextProcessingControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostAddTextContent()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        var request = new PostAddTextContentRequest(new AddTextOptions { DataSource = new DataSource { DataSourceType = "CloudFileSystem", DataPath = "TestData/In/BookText.xlsx" }, Text = "Aspose.Cells Cloud is an excellent product.", ScopeOptions = new ScopeOptions { Scope = "Workbook" }, SelectPoistion = "AtTheBeginning", SkipEmptyCells = true });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostTrimContent()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        var request = new PostTrimContentRequest(new TrimContentOptions { DataSource = new DataSource { DataSourceType = "CloudFileSystem", DataPath = "TestData/In/BookText.xlsx" }, TrimLeading = true, TrimTrailing = true, TrimSpaceBetweenWordTo1 = true, RemoveAllLineBreaks = true, ScopeOptions = new ScopeOptions { Scope = "EntireWorkbook" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostUpdateWordCase()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        var request = new PostUpdateWordCaseRequest(new WordCaseOptions { DataSource = new DataSource { DataSourceType = "CloudFileSystem", DataPath = "TestData/In/BookText.xlsx" }, WordCaseType = "None", ScopeOptions = new ScopeOptions { Scope = "EntireWorkbook" } });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
