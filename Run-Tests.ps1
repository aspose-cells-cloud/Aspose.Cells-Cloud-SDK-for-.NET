<#
.SYNOPSIS
    Runs the Aspose.Cells Cloud SDK integration tests, checks the results, and generates a test report.

.DESCRIPTION
    Runs `dotnet test` against Aspose.Cells.Cloud.sln, captures the results in TRX format, parses the
    outcome, prints a console summary and writes a self-contained HTML report (test-report.html) plus the
    raw TRX file under the results directory.

    Exit codes:
        0 - every test passed
        1 - one or more tests failed (or the test run itself reported failure)
        2 - the run could not be completed (missing dotnet/solution, or no TRX produced)

.PARAMETER Configuration
    Build configuration to test. Default: Debug.

.PARAMETER Filter
    Optional `dotnet test --filter` expression to run a subset of tests.

.PARAMETER ResultsDirectory
    Directory for the TRX results file and generated report. Default: TestResults.

.PARAMETER NoBuild
    Skip the build step and reuse existing binaries.

.PARAMETER Detailed
    Use normal (per-test) console logging instead of minimal.

.PARAMETER ClientId
    Optional Aspose Cloud client id. Prefer the CellsCloudClientId environment variable.

.PARAMETER ClientSecret
    Optional Aspose Cloud client secret. Prefer the CellsCloudClientSecret environment variable.

.PARAMETER BaseUrl
    Optional API base URL. Prefer the CellsCloudApiBaseUrl environment variable.

.EXAMPLE
    .\Run-Tests.ps1

.EXAMPLE
    .\Run-Tests.ps1 -Filter "FullyQualifiedName~CellsControllerTest"

.EXAMPLE
    .\Run-Tests.ps1 -ClientId $env:ID -ClientSecret $env:SECRET
#>
[CmdletBinding()]
param(
    [string]$Configuration = "Debug",
    [string]$Filter,
    [string]$ResultsDirectory = "TestResults",
    [switch]$NoBuild,
    [switch]$Detailed,
    [string]$ClientId,
    [string]$ClientSecret,
    [string]$BaseUrl
)

$ErrorActionPreference = "Stop"

# Resolve paths relative to this script's location.
$root       = $PSScriptRoot
$solution   = Join-Path $root "Aspose.Cells.Cloud.sln"
$resultsDir = Join-Path $root $ResultsDirectory

function ConvertTo-HtmlEscaped {
    param([AllowNull()][string]$Value)
    if ([string]::IsNullOrEmpty($Value)) { return "" }
    return [System.Net.WebUtility]::HtmlEncode($Value)
}

# ---- credentials (parameters override for this run; env vars take precedence otherwise) ----
if ($ClientId)     { $env:CellsCloudClientId = $ClientId }
if ($ClientSecret) { $env:CellsCloudClientSecret = $ClientSecret }
if ($BaseUrl)      { $env:CellsCloudApiBaseUrl = $BaseUrl }

$missing = @()
if (-not $env:CellsCloudClientId)     { $missing += "CellsCloudClientId" }
if (-not $env:CellsCloudClientSecret) { $missing += "CellsCloudClientSecret" }
if ($missing.Count -gt 0) {
    Write-Warning "Missing credentials: $($missing -join ', '). Tests will fail unless you set them (or pass -ClientId / -ClientSecret)."
}

if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    Write-Error "`dotnet` was not found on PATH."
    exit 2
}

if (-not (Test-Path $solution)) {
    Write-Error "Solution file not found: $solution"
    exit 2
}

# ---- prepare results directory ----
if (-not (Test-Path $resultsDir)) {
    New-Item -ItemType Directory -Path $resultsDir -Force | Out-Null
}

$stamp    = Get-Date -Format "yyyyMMdd-HHmmss"
$trxName  = "integration-$stamp.trx"
$trxPath  = Join-Path $resultsDir $trxName
$verbosity = if ($Detailed) { "normal" } else { "minimal" }

# ---- run dotnet test ----
$dotnetArgs = @(
    "test", $solution,
    "--configuration", $Configuration,
    "--logger", "trx;LogFileName=$trxName",
    "--logger", "console;verbosity=$verbosity",
    "--results-directory", $resultsDir
)
if ($NoBuild) { $dotnetArgs += "--no-build" }
if ($Filter)  { $dotnetArgs += "--filter"; $dotnetArgs += $Filter }

Write-Host ""
Write-Host ">>> dotnet $($dotnetArgs -join ' ')" -ForegroundColor Cyan
Write-Host ""

$sw = [System.Diagnostics.Stopwatch]::StartNew()
& dotnet @dotnetArgs
$testExitCode = $LASTEXITCODE
$sw.Stop()

# ---- locate the TRX file ----
if (-not (Test-Path $trxPath)) {
    $trxPath = Get-ChildItem -Path $resultsDir -Filter "*.trx" -ErrorAction SilentlyContinue |
        Sort-Object LastWriteTime -Descending |
        Select-Object -First 1 -ExpandProperty FullName
}

if (-not $trxPath -or -not (Test-Path $trxPath)) {
    Write-Error "No TRX result file was produced (dotnet test exit code: $testExitCode)."
    exit 2
}

# ---- parse the TRX ----
$xml = New-Object System.Xml.XmlDocument
$xml.Load($trxPath)
$ns = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
$ns.AddNamespace("t", "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")

function Get-Counter([System.Xml.XmlNode]$node, [string]$name) {
    $v = $node.GetAttribute($name)
    if ([string]::IsNullOrEmpty($v)) { return 0 }
    return [int]$v
}

$countersNode = $xml.SelectSingleNode("//t:Counters", $ns)
$total        = Get-Counter $countersNode "total"
$passed       = Get-Counter $countersNode "passed"
$failed       = Get-Counter $countersNode "failed"
$notExecuted  = Get-Counter $countersNode "notExecuted"
$errorCount   = Get-Counter $countersNode "error"
$aborted      = Get-Counter $countersNode "aborted"
$skipped      = $notExecuted + $errorCount + $aborted

# Collect per-test failures (with message + stack trace) from the TRX.
$failedTests = @()
foreach ($r in $xml.SelectNodes("//t:Results/t:UnitTestResult", $ns)) {
    if ($r.GetAttribute("outcome") -ne "Failed") { continue }

    $msgNode   = $r.SelectSingleNode("t:Output/t:ErrorInfo/t:Message", $ns)
    $stackNode = $r.SelectSingleNode("t:Output/t:ErrorInfo/t:StackTrace", $ns)

    $failedTests += [PSCustomObject]@{
        Name       = $r.GetAttribute("testName")
        Duration   = $r.GetAttribute("duration")
        Message    = $(if ($msgNode) { $msgNode.InnerText } else { "" })
        StackTrace = $(if ($stackNode) { $stackNode.InnerText } else { "" })
    }
}

$ts = $sw.Elapsed
$hours = [int][math]::Floor($ts.TotalHours)
$durationText = "{0:D2}:{1:D2}:{2:D2}" -f $hours, $ts.Minutes, $ts.Seconds
$allPassed    = ($failed -eq 0 -and $testExitCode -eq 0)
$resultLabel  = if ($allPassed) { "PASSED" } else { "FAILED" }
$passRate     = if ($total -gt 0) { [math]::Round(($passed / $total) * 100, 1) } else { 0 }

# ---- console summary ----
Write-Host ""
Write-Host "================ TEST SUMMARY ================" -ForegroundColor Cyan
Write-Host ("  Total     : {0}" -f $total)
Write-Host ("  Passed    : {0}" -f $passed)
Write-Host ("  Failed    : {0}" -f $failed)
Write-Host ("  Skipped   : {0}" -f $skipped)
Write-Host ("  Pass rate : {0}%" -f $passRate)
Write-Host ("  Duration  : {0}" -f $durationText)
Write-Host ("  Result    : {0}" -f $resultLabel)
Write-Host "============================================="
Write-Host ("  Report    : {0}" -f (Join-Path $resultsDir "test-report.html"))
Write-Host ("  TRX       : {0}" -f $trxPath)
Write-Host ""

# ---- build the HTML report ----
$reportTimestamp = (Get-Date).ToString("yyyy-MM-dd HH:mm:ss")
$escResultLabel  = ConvertTo-HtmlEscaped $resultLabel
$escConfiguration = ConvertTo-HtmlEscaped $Configuration
$escTrxName       = ConvertTo-HtmlEscaped $trxName

$summaryCards = @"
<div class="cards">
  <div class="card"><div class="num">$total</div><div class="lbl">Total</div></div>
  <div class="card pass"><div class="num">$passed</div><div class="lbl">Passed</div></div>
  <div class="card fail"><div class="num">$failed</div><div class="lbl">Failed</div></div>
  <div class="card skip"><div class="num">$skipped</div><div class="lbl">Skipped</div></div>
  <div class="card"><div class="num">$passRate%</div><div class="lbl">Pass rate</div></div>
  <div class="card"><div class="num">$durationText</div><div class="lbl">Duration</div></div>
</div>
"@

if ($failedTests.Count -gt 0) {
    $rows = @()
    foreach ($f in $failedTests) {
        $name = ConvertTo-HtmlEscaped $f.Name
        $msg  = ConvertTo-HtmlEscaped $f.Message
        $stk  = ConvertTo-HtmlEscaped $f.StackTrace
        $rows += "<tr><td class='mono'>$name</td><td>$($f.Duration)</td><td>$msg</td></tr>"
        if ($stk) {
            $rows += "<tr class='stack'><td colspan='3'><details><summary>Stack trace</summary><pre>$stk</pre></details></td></tr>"
        }
    }
    $failureSection = @"
<h2>Failed Tests ($($failedTests.Count))</h2>
<table class="tests">
  <thead><tr><th>Test</th><th>Duration</th><th>Message</th></tr></thead>
  <tbody>
$($rows -join "`n")
  </tbody>
</table>
"@
}
else {
    $failureSection = "<h2>Result</h2><p class='ok'>All tests passed.</p>"
}

$bannerClass = if ($allPassed) { "passed" } else { "failed" }

$html = @"
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1" />
<title>Aspose.Cells Cloud SDK — Test Report</title>
<style>
  body { font-family: -apple-system, 'Segoe UI', Roboto, sans-serif; margin: 0; background: #f5f6f8; color: #1f2933; }
  header { background: #1f2933; color: #fff; padding: 24px 32px; }
  header h1 { margin: 0; font-size: 22px; }
  header .meta { margin-top: 6px; font-size: 13px; color: #cbd2d9; }
  main { max-width: 1000px; margin: 24px auto; padding: 0 24px; }
  .banner { padding: 14px 20px; border-radius: 8px; font-weight: 600; margin-bottom: 20px; }
  .banner.passed { background: #e3f6ec; color: #0b6e3a; }
  .banner.failed { background: #fdeaea; color: #b3261e; }
  .cards { display: flex; flex-wrap: wrap; gap: 16px; margin-bottom: 24px; }
  .card { background: #fff; border-radius: 8px; padding: 18px 24px; min-width: 120px; text-align: center; box-shadow: 0 1px 2px rgba(0,0,0,.08); }
  .card .num { font-size: 28px; font-weight: 700; }
  .card .lbl { font-size: 12px; color: #6b7280; text-transform: uppercase; letter-spacing: .5px; margin-top: 4px; }
  .card.pass .num { color: #0b6e3a; }
  .card.fail .num { color: #b3261e; }
  .card.skip .num { color: #b7791f; }
  h2 { font-size: 18px; margin-top: 8px; }
  table.tests { width: 100%; border-collapse: collapse; background: #fff; border-radius: 8px; overflow: hidden; box-shadow: 0 1px 2px rgba(0,0,0,.08); }
  table.tests th, table.tests td { text-align: left; padding: 10px 14px; border-bottom: 1px solid #e5e7eb; vertical-align: top; }
  table.tests th { background: #f3f4f6; font-size: 12px; text-transform: uppercase; letter-spacing: .5px; color: #6b7280; }
  .mono { font-family: 'Consolas', 'Menlo', monospace; font-size: 13px; }
  .ok { color: #0b6e3a; font-weight: 600; }
  tr.stack td { background: #fafafa; padding-top: 0; }
  details summary { cursor: pointer; color: #3b82f6; }
  pre { white-space: pre-wrap; word-break: break-word; font-size: 12px; color: #b3261e; }
  footer { text-align: center; color: #9aa0a6; font-size: 12px; margin: 32px 0; }
</style>
</head>
<body>
<header>
  <h1>Aspose.Cells Cloud SDK for .NET — Integration Test Report</h1>
  <div class="meta">Generated: $reportTimestamp &nbsp;·&nbsp; Configuration: $escConfiguration &nbsp;·&nbsp; TRX: $escTrxName</div>
</header>
<main>
  <div class="banner $bannerClass">Result: $escResultLabel</div>
  $summaryCards
  $failureSection
</main>
<footer>Generated by Run-Tests.ps1</footer>
</body>
</html>
"@

$reportPath = Join-Path $resultsDir "test-report.html"
[System.IO.File]::WriteAllText($reportPath, $html, (New-Object System.Text.UTF8Encoding($false)))
Write-Host "Test report written to: $reportPath" -ForegroundColor Green

# ---- exit code ----
if ($allPassed) { exit 0 } else { exit 1 }
