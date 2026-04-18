// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExtractTextRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.ExtractText" /> operation.
    /// </summary>
    public class ExtractTextRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractTextRequest"/> class.
        /// </summary>
        public ExtractTextRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractTextRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="extractTextType">Indicates extract text type.</param>
        /// <param name="outPositionRange">Indicates the output location for the extracted text.</param>
        /// <param name="beforeText">Indicates extracting the text before the specified characters or substrings.</param>
        /// <param name="afterText">Indicates extracting the text after the specified characters or substrings.</param>
        /// <param name="beforePosition">Indicates retrieving the first character or a specified number of characters from the left side of the selected cell.</param>
        /// <param name="afterPosition">Indicates retrieving the first character or a specified number of characters from the right side of the selected cell.</param>
        /// <param name="worksheet">Specify the worksheet of spreadsheet.</param>
        /// <param name="range">Specify the worksheet range of spreadsheet.</param>
        /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
        /// <param name="outStorageName">Output file Storage Name.</param>
        /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public ExtractTextRequest(string  spreadsheet, string  extractTextType, string  outPositionRange, string  beforeText = null, string  afterText = null, int?  beforePosition = null, int?  afterPosition = null, string  worksheet = null, string  range = null, string  outPath = null, string  outStorageName = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.extractTextType = extractTextType;
            this.outPositionRange = outPositionRange;
            this.beforeText = beforeText;
            this.afterText = afterText;
            this.beforePosition = beforePosition;
            this.afterPosition = afterPosition;
            this.worksheet = worksheet;
            this.range = range;
            this.outPath = outPath;
            this.outStorageName = outStorageName;
            this.region = region;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// Indicates extract text type.
        /// </summary>
        public string extractTextType { get; set; }


        /// <summary>
        /// Indicates the output location for the extracted text.
        /// </summary>
        public string outPositionRange { get; set; }


        /// <summary>
        /// Indicates extracting the text before the specified characters or substrings.
        /// </summary>
        public string beforeText { get; set; }


        /// <summary>
        /// Indicates extracting the text after the specified characters or substrings.
        /// </summary>
        public string afterText { get; set; }


        /// <summary>
        /// Indicates retrieving the first character or a specified number of characters from the left side of the selected cell.
        /// </summary>
        public int? beforePosition { get; set; }


        /// <summary>
        /// Indicates retrieving the first character or a specified number of characters from the right side of the selected cell.
        /// </summary>
        public int? afterPosition { get; set; }


        /// <summary>
        /// Specify the worksheet of spreadsheet.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Specify the worksheet range of spreadsheet.
        /// </summary>
        public string range { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
        /// </summary>
        public string outPath { get; set; }


        /// <summary>
        /// Output file Storage Name.
        /// </summary>
        public string outStorageName { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling ExtractText");
            }

            // verify the required parameter 'extractTextType' is set
            if (string.IsNullOrEmpty (this.extractTextType ))
            {
                throw new ApiException(400, "Missing required parameter 'extractTextType' when calling ExtractText");
            }

            // verify the required parameter 'outPositionRange' is set
            if (string.IsNullOrEmpty (this.outPositionRange ))
            {
                throw new ApiException(400, "Missing required parameter 'outPositionRange' when calling ExtractText");
            }

            var path = baseUri + "/cells/content/extract/text";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "extractTextType", this.extractTextType);
            path = UrlHelper.AddQueryParameterToUrl(path, "outPositionRange", this.outPositionRange);
            if (!string.IsNullOrEmpty(this.beforeText))  path = UrlHelper.AddQueryParameterToUrl(path, "beforeText", this.beforeText);
            if (!string.IsNullOrEmpty(this.afterText))  path = UrlHelper.AddQueryParameterToUrl(path, "afterText", this.afterText);
            if(this.beforePosition != null)  path = UrlHelper.AddQueryParameterToUrl(path, "beforePosition", this.beforePosition);
            if(this.afterPosition != null)  path = UrlHelper.AddQueryParameterToUrl(path, "afterPosition", this.afterPosition);
            if (!string.IsNullOrEmpty(this.worksheet))  path = UrlHelper.AddQueryParameterToUrl(path, "worksheet", this.worksheet);
            if (!string.IsNullOrEmpty(this.range))  path = UrlHelper.AddQueryParameterToUrl(path, "range", this.range);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
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
