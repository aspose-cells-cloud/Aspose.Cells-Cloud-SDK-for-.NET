# Testing Guide

## Overview

The integration test suite contains **484 test methods across 47 test classes**: 481 generated from JSON
configuration files in `TestingData/` plus 3 hand-written tests in `Aspose.Cells.Cloud.Tests/Manual/`
(these are not regenerated). Tests are executed with xUnit. The generated classes live directly in
the `Aspose.Cells.Cloud.Tests` project (which replaced the former `integrationtests/` directory).

## Test Structure

```
Aspose.Cells.Cloud.Tests/
├── Aspose.Cells.Cloud.Tests.csproj      # xUnit test project (references the SDK library)
├── CellsControllerTest.cs               # CellsController operations
├── ConversionTest.cs                    # ConversionController operations
├── WorkbookControllerTest.cs            # WorkbookController operations
├── WorksheetControllerTest.cs           # WorksheetController operations
├── LightCellsTest.cs                    # LightCellsController operations
├── PivotTablesControllerTest.cs         # PivotTablesController operations
├── ChartsControllerTest.cs              # ChartsController operations
├── Manual/                              # hand-written tests (not regenerated)
│   └── FileParameterTest.cs             # Stream / byte[] file uploads
└── ...                                  # 47 test classes total (46 generated + 1 manual)
```

## Test Configuration Format

Tests are defined in JSON files under `TestingData/` (same schema as the Go SDK):

```json
{
  "Name": "CellsController",
  "Folder": "CellsCloud30",
  "Variables": { "RemoteFolder": "TestData/In" },
  "Cases": [
    {
      "Name": "PostClearContents",
      "ApiMethod": "PostClearContents",
      "Description": ["Test for PostClearContents."],
      "Variables": { "LocalName": "Book1.xlsx", "RemoteName": "Book1.xlsx" },
      "Files": [
        { "LocalPath": "%LocalName%", "RemotePath": "%RemoteFolder%/%RemoteName%", "StorageName": "" }
      ],
      "Parameters": [
        { "Name": "name", "DataType": { "Identifier": "String" }, "Value": "%RemoteName%" }
      ],
      "Assertions": [
        { "Type": "EqualsInteger", "Expression": "Code", "Value": "200" }
      ]
    }
  ]
}
```

## Running Tests

### Prerequisites

1. Valid Aspose Cloud credentials.
2. .NET 8 SDK.
3. Sample files in `testdata/` — these are copied to the test output directory automatically on build,
   so the relative `testdata/...` paths used by the generated tests resolve at run time.

### Setup

```bash
export CellsCloudClientId="your-client-id"
export CellsCloudClientSecret="your-client-secret"
export CellsCloudApiBaseUrl="https://api.aspose.cloud"
```

### Execute

```bash
# Run all integration tests
dotnet test

# Run a single controller's tests
dotnet test --filter FullyQualifiedName~CellsControllerTest

# Run a single test method
dotnet test --filter PostClearContents
```

## Generated Test Pattern

Each test case follows this structure:

```csharp
using System;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class CellsControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public CellsControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId"),
            Environment.GetEnvironmentVariable("CellsCloudClientSecret"),
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostClearContents()
    {
        var request = new PostClearContentsRequest("Book1.xlsx", "Sheet1")
        {
            Range = "A1:C10",
            Folder = "TestData/In",
        };

        RichResponse response = _client.Do(request);   // throws SDKException on failure

        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
```

## Test Parameter Mapping

| Spec Parameter | Test Data Value | Constructor / Initializer |
|---------------|----------------|---------------------------|
| Required, Path, String | `"Book1.xlsx"` | `new XRequest("Book1.xlsx", ...)` |
| Required, FormData, File | `"testdata/file.xlsx"` | `new XRequest(..., "testdata/file.xlsx")` |
| Optional, Query, Integer | `0` | `{ Offset = 0 }` |
| Optional, Query, String | `"value"` | `{ Folder = "value" }` |
| Required, Body, Class | `{...}` | `{ Options = new Model() }` (placeholder) |

## Variable Resolution

Test data uses `%VariableName%` placeholders resolved against group-level and case-level `Variables`.

## Known Limitations

1. **Complex object initialization**: Class/Container parameters are initialized with empty models;
   manual adjustment may be needed for tests requiring specific field values.
2. **Unresolved variables**: undefined variables produce empty strings.
3. **Unmatched APIs**: test cases referencing APIs not in the spec are skipped with a warning.
4. **File uploads**: tests requiring pre-uploaded files need manual upload before execution.

## Adding New Tests

1. Create or update a JSON file in `TestingData/`.
2. Run `python generate_tests.py`.
3. Run `dotnet test`.
4. Add any required sample files to `testdata/`.

Hand-written tests that cannot be expressed in the JSON schema (e.g. `FileParameter` stream uploads)
go in `Aspose.Cells.Cloud.Tests/Manual/` — `generate_tests.py` wipes top-level `*.cs` files but leaves
subfolders intact.

## Continuous Integration

Tests require credentials and network access. They are designed for local development, CI (service
principal credentials), and smoke runs (a subset of critical-path tests). In CI, set the three
environment variables and run `dotnet test`.
