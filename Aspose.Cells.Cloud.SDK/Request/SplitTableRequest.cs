// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitTableRequest.cs">
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

namespace Aspose.Cells.Cloud.SDK.Request
{
    using Aspose.Cells.Cloud.SDK.Model;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SplitTable" /> operation.
    /// </summary>
    public class SplitTableRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTableRequest"/> class.
        /// </summary>
        public SplitTableRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTableRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="worksheet">Worksheet containing the table.</param>
        /// <param name="tableName">Data table that needs to be split.</param>
        /// <param name="splitColumnName">Column name to split by.</param>
        /// <param name="saveSplitColumn">Whether to keep the data in the split column.</param>
        /// <param name="splitRowNumber"></param>
        /// <param name="toNewWorkbook">Export destination control: true - Creates new workbook files containing the split data; false - Adds a new worksheet to the current workbook.</param>
        /// <param name="toMultipleFiles">true - Exports table data as **multiple separate files** (returned as ZIP archive);false - Stores all data in a **single file** with multiple sheets. Default: false.</param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="fontsLocation">Use Custom fonts.</param>
        /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public SplitTableRequest(string  spreadsheet, string  worksheet, string  tableName, string  splitColumnName, bool?  saveSplitColumn, int?  splitRowNumber, bool?  toNewWorkbook, bool?  toMultipleFiles, string  outPath = null, string  outStorageName = null, string  fontsLocation = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.worksheet = worksheet;
            this.tableName = tableName;
            this.splitColumnName = splitColumnName;
            this.saveSplitColumn = saveSplitColumn;
            this.splitRowNumber = splitRowNumber;
            this.toNewWorkbook = toNewWorkbook;
            this.toMultipleFiles = toMultipleFiles;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.fontsLocation = fontsLocation;
            this.region = region;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Worksheet containing the table.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Data table that needs to be split.
        /// </summary>
        public string tableName { get; set; }


        /// <summary>
        /// Column name to split by.
        /// </summary>
        public string splitColumnName { get; set; }


        /// <summary>
        /// Whether to keep the data in the split column.
        /// </summary>
        public bool? saveSplitColumn { get; set; }


        /// <summary>
        /// Gets or sets splitRowNumber.
        /// </summary>
        public int? splitRowNumber { get; set; }


        /// <summary>
        /// Export destination control: true - Creates new workbook files containing the split data; false - Adds a new worksheet to the current workbook.
        /// </summary>
        public bool? toNewWorkbook { get; set; }


        /// <summary>
        /// true - Exports table data as **multiple separate files** (returned as ZIP archive);false - Stores all data in a **single file** with multiple sheets. Default: false.
        /// </summary>
        public bool? toMultipleFiles { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
        /// </summary>
        public string outPath { get; set; }


        /// <summary>
        /// Output file Storage Name.
        /// </summary>
        public string outStorageName { get; set; }


        /// <summary>
        /// Use Custom fonts.
        /// </summary>
        public string fontsLocation { get; set; }


        /// <summary>
        /// Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.
        /// </summary>
        public string region { get; set; }


        /// <summary>
        /// The password for opening spreadsheet file.
        /// </summary>
        public string password { get; set; }
        

        /// <summary>
        /// Gets or sets extendQueryParameterMap.
        /// </summary>
        public IDictionary<string, string> extendQueryParameterMap = new Dictionary<string, string>{};

        public void AddExtendQueryParameter(string name ,string value)
        {
            extendQueryParameterMap.Add(name,value);
        }
        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="baseUri">Api base uri.</param>
        /// <returns>The http request instance.</returns>
        public HttpWebRequest CreateHttpRequest(string baseUri,IDictionary<string, string> defaultHeaderMap, List<Invoker.IRequestHandler> requestHandlers)
        {
            var localVarHeaderParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, object>();
            string localVarPostBody ="";
            string localVarHttpContentType = "application/json";
            // verify the required parameter 'spreadsheet' is set
            if (    string.IsNullOrEmpty(this.Spreadsheet)    )
            {
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling SplitTable");
            }

            // verify the required parameter 'worksheet' is set
            if (string.IsNullOrEmpty (this.worksheet ))
            {
                throw new ApiException(400, "Missing required parameter 'worksheet' when calling SplitTable");
            }

            // verify the required parameter 'tableName' is set
            if (string.IsNullOrEmpty (this.tableName ))
            {
                throw new ApiException(400, "Missing required parameter 'tableName' when calling SplitTable");
            }

            // verify the required parameter 'splitColumnName' is set
            if (string.IsNullOrEmpty (this.splitColumnName ))
            {
                throw new ApiException(400, "Missing required parameter 'splitColumnName' when calling SplitTable");
            }

            // verify the required parameter 'saveSplitColumn' is set
            if ( this.saveSplitColumn == null)
            {
                throw new ApiException(400, "Missing required parameter 'saveSplitColumn' when calling SplitTable");
            }

            // verify the required parameter 'splitRowNumber' is set
            if ( this.splitRowNumber == null)
            {
                throw new ApiException(400, "Missing required parameter 'splitRowNumber' when calling SplitTable");
            }

            // verify the required parameter 'toNewWorkbook' is set
            if ( this.toNewWorkbook == null)
            {
                throw new ApiException(400, "Missing required parameter 'toNewWorkbook' when calling SplitTable");
            }

            // verify the required parameter 'toMultipleFiles' is set
            if ( this.toMultipleFiles == null)
            {
                throw new ApiException(400, "Missing required parameter 'toMultipleFiles' when calling SplitTable");
            }

            var path = baseUri + "/cells/split/table";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            path = UrlHelper.AddQueryParameterToUrl(path, "tableName", this.tableName);
            path = UrlHelper.AddQueryParameterToUrl(path, "splitColumnName", this.splitColumnName);
            path = UrlHelper.AddQueryParameterToUrl(path, "saveSplitColumn", this.saveSplitColumn);
            path = UrlHelper.AddQueryParameterToUrl(path, "splitRowNumber", this.splitRowNumber);
            path = UrlHelper.AddQueryParameterToUrl(path, "toNewWorkbook", this.toNewWorkbook);
            path = UrlHelper.AddQueryParameterToUrl(path, "toMultipleFiles", this.toMultipleFiles);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if (!string.IsNullOrEmpty(this.fontsLocation))  path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.fontsLocation);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

             if (!string.IsNullOrEmpty(Spreadsheet ) && System.IO.File.Exists(Spreadsheet )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(Spreadsheet);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(Spreadsheet), fileInfo.Name));
             } 



            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
