// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="EbookSaveOptions.cs">
//   Copyright (c) 2026 Aspose.Cells Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Cloud.SDK.Model
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Drawing;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// EbookSaveOptions.
    /// </summary>
    public class EbookSaveOptions : HtmlSaveOptions
    {
        /// <summary>
        /// Gets or sets ExportPageHeaders.
        /// </summary>
        public override bool? ExportPageHeaders { get; set; }

        /// <summary>
        /// Gets or sets ExportPageFooters.
        /// </summary>
        public override bool? ExportPageFooters { get; set; }

        /// <summary>
        /// Gets or sets ExportRowColumnHeadings.
        /// </summary>
        public override bool? ExportRowColumnHeadings { get; set; }

        /// <summary>
        /// Gets or sets ShowAllSheets.
        /// </summary>
        public override bool? ShowAllSheets { get; set; }

        /// <summary>
        /// Gets or sets ImageOptions.
        /// </summary>
        public override ImageOrPrintOptions ImageOptions { get; set; }

        /// <summary>
        /// Gets or sets SaveAsSingleFile.
        /// </summary>
        public override bool? SaveAsSingleFile { get; set; }

        /// <summary>
        /// Gets or sets ExportHiddenWorksheet.
        /// </summary>
        public override bool? ExportHiddenWorksheet { get; set; }

        /// <summary>
        /// Gets or sets ExportGridLines.
        /// </summary>
        public override bool? ExportGridLines { get; set; }

        /// <summary>
        /// Gets or sets PresentationPreference.
        /// </summary>
        public override bool? PresentationPreference { get; set; }

        /// <summary>
        /// Gets or sets CellCssPrefix.
        /// </summary>
        public override string CellCssPrefix { get; set; }

        /// <summary>
        /// Gets or sets TableCssId.
        /// </summary>
        public override string TableCssId { get; set; }

        /// <summary>
        /// Gets or sets IsFullPathLink.
        /// </summary>
        public override bool? IsFullPathLink { get; set; }

        /// <summary>
        /// Gets or sets ExportWorksheetCSSSeparately.
        /// </summary>
        public override bool? ExportWorksheetCSSSeparately { get; set; }

        /// <summary>
        /// Gets or sets ExportSimilarBorderStyle.
        /// </summary>
        public override bool? ExportSimilarBorderStyle { get; set; }

        /// <summary>
        /// Gets or sets MergeEmptyTdForcely.
        /// </summary>
        public override bool? MergeEmptyTdForcely { get; set; }

        /// <summary>
        /// Gets or sets ExportCellCoordinate.
        /// </summary>
        public override bool? ExportCellCoordinate { get; set; }

        /// <summary>
        /// Gets or sets ExportExtraHeadings.
        /// </summary>
        public override bool? ExportExtraHeadings { get; set; }

        /// <summary>
        /// Gets or sets ExportHeadings.
        /// </summary>
        public override bool? ExportHeadings { get; set; }

        /// <summary>
        /// Gets or sets ExportFormula.
        /// </summary>
        public override bool? ExportFormula { get; set; }

        /// <summary>
        /// Gets or sets AddTooltipText.
        /// </summary>
        public override bool? AddTooltipText { get; set; }

        /// <summary>
        /// Gets or sets ExportBogusRowData.
        /// </summary>
        public override bool? ExportBogusRowData { get; set; }

        /// <summary>
        /// Gets or sets ExcludeUnusedStyles.
        /// </summary>
        public override bool? ExcludeUnusedStyles { get; set; }

        /// <summary>
        /// Gets or sets ExportDocumentProperties.
        /// </summary>
        public override bool? ExportDocumentProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportWorksheetProperties.
        /// </summary>
        public override bool? ExportWorksheetProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportWorkbookProperties.
        /// </summary>
        public override bool? ExportWorkbookProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportFrameScriptsAndProperties.
        /// </summary>
        public override bool? ExportFrameScriptsAndProperties { get; set; }

        /// <summary>
        /// Gets or sets AttachedFilesDirectory.
        /// </summary>
        public override string AttachedFilesDirectory { get; set; }

        /// <summary>
        /// Gets or sets AttachedFilesUrlPrefix.
        /// </summary>
        public override string AttachedFilesUrlPrefix { get; set; }

        /// <summary>
        /// Gets or sets Encoding.
        /// </summary>
        public override string Encoding { get; set; }

        /// <summary>
        /// Gets or sets ExportActiveWorksheetOnly.
        /// </summary>
        public override bool? ExportActiveWorksheetOnly { get; set; }

        /// <summary>
        /// Gets or sets ExportChartImageFormat.
        /// </summary>
        public override string ExportChartImageFormat { get; set; }

        /// <summary>
        /// Gets or sets ExportImagesAsBase64.
        /// </summary>
        public override bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Gets or sets HiddenColDisplayType.
        /// </summary>
        public override string HiddenColDisplayType { get; set; }

        /// <summary>
        /// Gets or sets HiddenRowDisplayType.
        /// </summary>
        public override string HiddenRowDisplayType { get; set; }

        /// <summary>
        /// Gets or sets HtmlCrossStringType.
        /// </summary>
        public override string HtmlCrossStringType { get; set; }

        /// <summary>
        /// Gets or sets IsExpImageToTempDir.
        /// </summary>
        public override bool? IsExpImageToTempDir { get; set; }

        /// <summary>
        /// Gets or sets PageTitle.
        /// </summary>
        public override string PageTitle { get; set; }

        /// <summary>
        /// Gets or sets ParseHtmlTagInCell.
        /// </summary>
        public override bool? ParseHtmlTagInCell { get; set; }

        /// <summary>
        /// Gets or sets CellNameAttribute.
        /// </summary>
        public override string CellNameAttribute { get; set; }

        /// <summary>
        /// Gets or sets SaveFormat.
        /// </summary>
        public override string SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets CachedFileFolder.
        /// </summary>
        public override string CachedFileFolder { get; set; }

        /// <summary>
        /// Gets or sets ClearData.
        /// </summary>
        public override bool? ClearData { get; set; }

        /// <summary>
        /// Gets or sets CreateDirectory.
        /// </summary>
        public override bool? CreateDirectory { get; set; }

        /// <summary>
        /// Gets or sets EnableHTTPCompression.
        /// </summary>
        public override bool? EnableHTTPCompression { get; set; }

        /// <summary>
        /// Gets or sets RefreshChartCache.
        /// </summary>
        public override bool? RefreshChartCache { get; set; }

        /// <summary>
        /// Gets or sets SortNames.
        /// </summary>
        public override bool? SortNames { get; set; }

        /// <summary>
        /// Gets or sets ValidateMergedAreas.
        /// </summary>
        public override bool? ValidateMergedAreas { get; set; }

        /// <summary>
        /// Gets or sets MergeAreas.
        /// </summary>
        public override bool? MergeAreas { get; set; }

        /// <summary>
        /// Gets or sets SortExternalNames.
        /// </summary>
        public override bool? SortExternalNames { get; set; }

        /// <summary>
        /// Gets or sets CheckExcelRestriction.
        /// </summary>
        public override bool? CheckExcelRestriction { get; set; }

        /// <summary>
        /// Gets or sets UpdateSmartArt.
        /// </summary>
        public override bool? UpdateSmartArt { get; set; }

        /// <summary>
        /// Gets or sets EncryptDocumentProperties.
        /// </summary>
        public override bool? EncryptDocumentProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EbookSaveOptions {\n");
            sb.Append("  ExportPageHeaders: ").Append(this.ExportPageHeaders).Append("\n");
            sb.Append("  ExportPageFooters: ").Append(this.ExportPageFooters).Append("\n");
            sb.Append("  ExportRowColumnHeadings: ").Append(this.ExportRowColumnHeadings).Append("\n");
            sb.Append("  ShowAllSheets: ").Append(this.ShowAllSheets).Append("\n");
            sb.Append("  ImageOptions: ").Append(this.ImageOptions).Append("\n");
            sb.Append("  SaveAsSingleFile: ").Append(this.SaveAsSingleFile).Append("\n");
            sb.Append("  ExportHiddenWorksheet: ").Append(this.ExportHiddenWorksheet).Append("\n");
            sb.Append("  ExportGridLines: ").Append(this.ExportGridLines).Append("\n");
            sb.Append("  PresentationPreference: ").Append(this.PresentationPreference).Append("\n");
            sb.Append("  CellCssPrefix: ").Append(this.CellCssPrefix).Append("\n");
            sb.Append("  TableCssId: ").Append(this.TableCssId).Append("\n");
            sb.Append("  IsFullPathLink: ").Append(this.IsFullPathLink).Append("\n");
            sb.Append("  ExportWorksheetCSSSeparately: ").Append(this.ExportWorksheetCSSSeparately).Append("\n");
            sb.Append("  ExportSimilarBorderStyle: ").Append(this.ExportSimilarBorderStyle).Append("\n");
            sb.Append("  MergeEmptyTdForcely: ").Append(this.MergeEmptyTdForcely).Append("\n");
            sb.Append("  ExportCellCoordinate: ").Append(this.ExportCellCoordinate).Append("\n");
            sb.Append("  ExportExtraHeadings: ").Append(this.ExportExtraHeadings).Append("\n");
            sb.Append("  ExportHeadings: ").Append(this.ExportHeadings).Append("\n");
            sb.Append("  ExportFormula: ").Append(this.ExportFormula).Append("\n");
            sb.Append("  AddTooltipText: ").Append(this.AddTooltipText).Append("\n");
            sb.Append("  ExportBogusRowData: ").Append(this.ExportBogusRowData).Append("\n");
            sb.Append("  ExcludeUnusedStyles: ").Append(this.ExcludeUnusedStyles).Append("\n");
            sb.Append("  ExportDocumentProperties: ").Append(this.ExportDocumentProperties).Append("\n");
            sb.Append("  ExportWorksheetProperties: ").Append(this.ExportWorksheetProperties).Append("\n");
            sb.Append("  ExportWorkbookProperties: ").Append(this.ExportWorkbookProperties).Append("\n");
            sb.Append("  ExportFrameScriptsAndProperties: ").Append(this.ExportFrameScriptsAndProperties).Append("\n");
            sb.Append("  AttachedFilesDirectory: ").Append(this.AttachedFilesDirectory).Append("\n");
            sb.Append("  AttachedFilesUrlPrefix: ").Append(this.AttachedFilesUrlPrefix).Append("\n");
            sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
            sb.Append("  ExportActiveWorksheetOnly: ").Append(this.ExportActiveWorksheetOnly).Append("\n");
            sb.Append("  ExportChartImageFormat: ").Append(this.ExportChartImageFormat).Append("\n");
            sb.Append("  ExportImagesAsBase64: ").Append(this.ExportImagesAsBase64).Append("\n");
            sb.Append("  HiddenColDisplayType: ").Append(this.HiddenColDisplayType).Append("\n");
            sb.Append("  HiddenRowDisplayType: ").Append(this.HiddenRowDisplayType).Append("\n");
            sb.Append("  HtmlCrossStringType: ").Append(this.HtmlCrossStringType).Append("\n");
            sb.Append("  IsExpImageToTempDir: ").Append(this.IsExpImageToTempDir).Append("\n");
            sb.Append("  PageTitle: ").Append(this.PageTitle).Append("\n");
            sb.Append("  ParseHtmlTagInCell: ").Append(this.ParseHtmlTagInCell).Append("\n");
            sb.Append("  CellNameAttribute: ").Append(this.CellNameAttribute).Append("\n");
            sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
            sb.Append("  CachedFileFolder: ").Append(this.CachedFileFolder).Append("\n");
            sb.Append("  ClearData: ").Append(this.ClearData).Append("\n");
            sb.Append("  CreateDirectory: ").Append(this.CreateDirectory).Append("\n");
            sb.Append("  EnableHTTPCompression: ").Append(this.EnableHTTPCompression).Append("\n");
            sb.Append("  RefreshChartCache: ").Append(this.RefreshChartCache).Append("\n");
            sb.Append("  SortNames: ").Append(this.SortNames).Append("\n");
            sb.Append("  ValidateMergedAreas: ").Append(this.ValidateMergedAreas).Append("\n");
            sb.Append("  MergeAreas: ").Append(this.MergeAreas).Append("\n");
            sb.Append("  SortExternalNames: ").Append(this.SortExternalNames).Append("\n");
            sb.Append("  CheckExcelRestriction: ").Append(this.CheckExcelRestriction).Append("\n");
            sb.Append("  UpdateSmartArt: ").Append(this.UpdateSmartArt).Append("\n");
            sb.Append("  EncryptDocumentProperties: ").Append(this.EncryptDocumentProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
