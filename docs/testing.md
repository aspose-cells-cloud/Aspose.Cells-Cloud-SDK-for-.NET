# Testing Guide

## Overview

The test suite contains **495 test methods across 49 test classes**: JSON-driven integration tests
(generated into `Aspose.Cells.Cloud.Tests/` from `TestingData/` by `generate_tests.py`) plus hand-written
tests in `Aspose.Cells.Cloud.Tests/Manual/` (client behaviour, request building, and `FileParameter`).
Hand-written tests never touch the network; integration tests call the live API and need credentials.

## Test Structure

```
Aspose.Cells.Cloud.Tests/
├── CellsControllerTest.cs               # 40 tests for CellsController
├── ConversionTest.cs                    # 32 tests for ConversionController
├── WorkbookControllerTest.cs            # 32 tests for WorkbookController
├── WorksheetControllerTest.cs           # 39 tests for WorksheetsController
├── LightCellsTest.cs                    # 19 tests for LightCellsController
├── PivotTablesControllerTest.cs         # 19 tests for PivotTablesController
├── ChartsControllerTest.cs              # 14 tests for ChartsController
├── Manual/                              # hand-written tests (survives regeneration)
│   ├── ClientBehaviorTest.cs            # offline: token cache, retries, timeout, batch
│   ├── RequestBuildingTest.cs           # offline: GetPath / GetQueryParameters / GetMultipartForm
│   └── FileParameterTest.cs             # live: upload via stream / bytes / path
└── ...                                  # more generated test files
```

`generate_tests.py` wipes only **top-level** `*.cs` in the test project; the `Manual/` subfolder is left
untouched. `[assembly: CollectionBehavior(DisableTestParallelization = true)]`
([AssemblyInfo.cs](../Aspose.Cells.Cloud.Tests/AssemblyInfo.cs)) runs the suite sequentially, mirroring
the Go SDK and avoiding races on shared remote test files.

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
3. Test data files in `testdata/`.

### Setup

```bash
export CellsCloudClientId="your-client-id"
export CellsCloudClientSecret="your-client-secret"
export CellsCloudApiBaseUrl="https://api.aspose.cloud"
```

Tests and scripts read credentials from these environment variables and never hardcode secrets. The
offline `Manual/` tests (client behaviour, request building) run without them.

### Execute

```bash
# Run the full suite (live integration tests; requires credentials)
dotnet test

# Run only the offline unit tests (no credentials / network needed)
dotnet test --filter "FullyQualifiedName~ClientBehaviorTest|FullyQualifiedName~RequestBuildingTest"

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
| Required, FormData, File | `"testdata/file.xlsx"` | `new XRequest("testdata/file.xlsx", ...)` (implicit `FileParameter`) |
| Optional, Query, Integer | `0` | `{ Offset = 0 }` |
| Optional, Query, String | `"value"` | `{ Folder = "value" }` |
| Required, Body, Class | `{...}` | `new XRequest(..., new Model { ... })` |

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
5. For hand-written (offline) tests, add files under `Aspose.Cells.Cloud.Tests/Manual/` so they survive
   regeneration.

## Continuous Integration

Integration tests require credentials and network access. They are designed for local development, CI
(service principal credentials), and smoke runs (a subset of critical-path tests). In CI, set the three
environment variables and run `dotnet test`. The offline `Manual/` tests run without credentials and are
suitable for the fast feedback loop.
