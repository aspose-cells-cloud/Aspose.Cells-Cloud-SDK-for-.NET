using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class DataProcessingControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public DataProcessingControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostWorkbookDataCleansing()
    {
        _client.Do(new UploadFileRequest("testdata/BookCsvDuplicateData.csv", "TestData/In/BookCsvDuplicateData.csv"));
        var request = new PostWorkbookDataCleansingRequest("BookCsvDuplicateData.csv", new DataCleansing { NeedFillData = true, DataFill = new DataFill { DataFillDefaultValue = new DataFillValue { DefaultDate = "2024-01-01", DefaultNumber = 0, DefaultBoolean = false } } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostWorkbookDataDeduplication()
    {
        _client.Do(new UploadFileRequest("testdata/BookCsvDuplicateData.csv", "TestData/In/BookCsvDuplicateData.csv"));
        var request = new PostWorkbookDataDeduplicationRequest("BookCsvDuplicateData.csv", new DeduplicationRegion { Ranges = new List<Aspose.Cells.Cloud.Model.Range>() })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostWorkbookDataFill()
    {
        _client.Do(new UploadFileRequest("testdata/BookCsvDuplicateData.csv", "TestData/In/BookCsvDuplicateData.csv"));
        var request = new PostWorkbookDataFillRequest("BookCsvDuplicateData.csv", new DataFill { DataFillDefaultValue = new DataFillValue { DefaultDate = "2024-01-01", DefaultNumber = 0, DefaultBoolean = false } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostDataTransformation()
    {
        _client.Do(new UploadFileRequest("testdata/BookTableL2W.xlsx", "TestData/In/BookTableL2W.xlsx"));
        var request = new PostDataTransformationRequest(new DataTransformationRequest { LoadData = new LoadData { LoadTo = new LoadTo { BeginColumnIndex = 2, BeginRowIndex = 3, Worksheet = "L2W" }, DataQuery = new DataQuery { Name = "DataQuery", DataItem = new DataItem { DataItemType = "Table", Value = "Table1" }, DataSource = new DataSource { DataSourceType = "CloudFileSystem", DataPath = "TestData/In/BookTableL2W.xlsx" }, DataSourceDataType = "ListObject" } }, AppliedSteps = new List<AppliedStep>() });
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
