using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ImportDataTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ImportDataTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void ImportDataIntoSpreadsheet()
    {
        var request = new ImportDataIntoSpreadsheetRequest("TestData/BookCsvDuplicateData.csv", "TestData/Book1.xlsx", "Sheet1", "E3");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
