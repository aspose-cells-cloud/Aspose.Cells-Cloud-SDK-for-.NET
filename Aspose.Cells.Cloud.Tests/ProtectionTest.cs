using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ProtectionTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ProtectionTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void ProtectSpreadsheet()
    {
        var request = new ProtectSpreadsheetRequest("TestData/EmployeeSalesSummary.xlsx", "123456", "123456");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void UnprotectSpreadsheet()
    {
        var request = new UnprotectSpreadsheetRequest("TestData/EmployeeSalesSummary_Locked.xlsx", "123456", "123456");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
