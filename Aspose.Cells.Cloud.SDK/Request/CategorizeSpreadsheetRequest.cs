// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CategorizeSpreadsheetRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.CategorizeSpreadsheet" /> operation.
    /// </summary>
    public class CategorizeSpreadsheetRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CategorizeSpreadsheetRequest"/> class.
        /// </summary>
        public CategorizeSpreadsheetRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategorizeSpreadsheetRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="targetColumn">The column name to categorize (e.g., "Expense Item", "Product Name"). Required.</param>
        /// <param name="sheetName">Optional: The worksheet name to process. If not specified, all worksheets will be processed.</param>
        /// <param name="newColumnName">Optional: Name for the new categorization column (default: "AI Category").</param>
        /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public CategorizeSpreadsheetRequest(string  spreadsheet, string  targetColumn, string  sheetName = null, string  newColumnName = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.targetColumn = targetColumn;
            this.sheetName = sheetName;
            this.newColumnName = newColumnName;
            this.region = region;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// The column name to categorize (e.g., "Expense Item", "Product Name"). Required.
        /// </summary>
        public string targetColumn { get; set; }


        /// <summary>
        /// Optional: The worksheet name to process. If not specified, all worksheets will be processed.
        /// </summary>
        public string sheetName { get; set; }


        /// <summary>
        /// Optional: Name for the new categorization column (default: "AI Category").
        /// </summary>
        public string newColumnName { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling CategorizeSpreadsheet");
            }

            // verify the required parameter 'targetColumn' is set
            if (string.IsNullOrEmpty (this.targetColumn ))
            {
                throw new ApiException(400, "Missing required parameter 'targetColumn' when calling CategorizeSpreadsheet");
            }

            var path = baseUri + "/cells/ai/categorize/spreadsheet";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "targetColumn", this.targetColumn);
            if (!string.IsNullOrEmpty(this.sheetName))  path = UrlHelper.AddQueryParameterToUrl(path, "sheetName", this.sheetName);
            if (!string.IsNullOrEmpty(this.newColumnName))  path = UrlHelper.AddQueryParameterToUrl(path, "newColumnName", this.newColumnName);
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
