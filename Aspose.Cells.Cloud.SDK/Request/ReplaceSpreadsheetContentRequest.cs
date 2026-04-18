// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ReplaceSpreadsheetContentRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.ReplaceSpreadsheetContent" /> operation.
    /// </summary>
    public class ReplaceSpreadsheetContentRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceSpreadsheetContentRequest"/> class.
        /// </summary>
        public ReplaceSpreadsheetContentRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceSpreadsheetContentRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="searchText">Specify the search content.</param>
        /// <param name="replaceText">Specify the replace content.</param>
        /// <param name="worksheet">Specify the worksheet for the replace.</param>
        /// <param name="cellArea">Specify the cell area for the replace.</param>
        /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public ReplaceSpreadsheetContentRequest(string  spreadsheet, string  searchText, string  replaceText, string  worksheet = null, string  cellArea = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.searchText = searchText;
            this.replaceText = replaceText;
            this.worksheet = worksheet;
            this.cellArea = cellArea;
            this.region = region;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Specify the search content.
        /// </summary>
        public string searchText { get; set; }


        /// <summary>
        /// Specify the replace content.
        /// </summary>
        public string replaceText { get; set; }


        /// <summary>
        /// Specify the worksheet for the replace.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Specify the cell area for the replace.
        /// </summary>
        public string cellArea { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling ReplaceSpreadsheetContent");
            }

            // verify the required parameter 'searchText' is set
            if (string.IsNullOrEmpty (this.searchText ))
            {
                throw new ApiException(400, "Missing required parameter 'searchText' when calling ReplaceSpreadsheetContent");
            }

            // verify the required parameter 'replaceText' is set
            if (string.IsNullOrEmpty (this.replaceText ))
            {
                throw new ApiException(400, "Missing required parameter 'replaceText' when calling ReplaceSpreadsheetContent");
            }

            var path = baseUri + "/cells/replace/content";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "searchText", this.searchText);
            path = UrlHelper.AddQueryParameterToUrl(path, "replaceText", this.replaceText);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.cellArea))  path = UrlHelper.AddQueryParameterToUrl(path, "cellArea", this.cellArea);
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
