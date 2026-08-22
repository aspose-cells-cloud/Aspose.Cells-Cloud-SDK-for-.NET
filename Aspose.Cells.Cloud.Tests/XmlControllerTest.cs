using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class XmlControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public XmlControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostWorkbookExportXML()
    {
        _client.Do(new UploadFileRequest("testdata/Template.xlsx", "TestData/In/Template.xlsx"));
        var request = new PostWorkbookExportXMLRequest("Template.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PostWorkbookImportXML()
    {
        _client.Do(new UploadFileRequest("testdata/Template.xlsx", "TestData/In/Template.xlsx"));
        _client.Do(new UploadFileRequest("testdata/data.xml", "TestData/In/data.xml"));
        var request = new PostWorkbookImportXMLRequest("Template.xlsx", new ImportXMLRequest { XMLFileSource = new DataSource { DataSourceType = "CloudFileSystem", DataPath = "TestData/In/data.xml" }, ImportPosition = new ImportPosition { SheetName = "Sheet1", RowIndex = 3, ColumnIndex = 4 } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
