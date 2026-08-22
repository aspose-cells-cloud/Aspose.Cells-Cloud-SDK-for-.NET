using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class CalculateTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public CalculateTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void AggregateCellsByColor()
    {
        var request = new AggregateCellsByColorRequest("TestData/AggregateCellsByColor.xlsx")
        {
            Worksheet = "Sheet1",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void MathCalculate()
    {
        var request = new MathCalculateRequest("TestData/EmployeeSalesSummary-BlankWorksheet.xlsx", "add", "12.3");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
