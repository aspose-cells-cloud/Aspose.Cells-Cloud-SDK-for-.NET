using Xunit;

// The integration tests share remote storage state (each controller uploads and mutates files under
// TestData/In), so running test classes in parallel causes races (e.g. a pivot-table mutation from one
// class corrupting another class's freshly-uploaded workbook). The Go SDK runs tests sequentially;
// disable parallelization here to match and keep the suite deterministic.
[assembly: CollectionBehavior(DisableTestParallelization = true)]
