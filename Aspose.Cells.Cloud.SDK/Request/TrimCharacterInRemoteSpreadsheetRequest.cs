// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TrimCharacterInRemoteSpreadsheetRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.TrimCharacterInRemoteSpreadsheet" /> operation.
    /// </summary>
    public class TrimCharacterInRemoteSpreadsheetRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TrimCharacterInRemoteSpreadsheetRequest"/> class.
        /// </summary>
        public TrimCharacterInRemoteSpreadsheetRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="TrimCharacterInRemoteSpreadsheetRequest"/> class.
            /// </summary>
            /// <param name="name">Specify the spreadsheet name on remote server.</param>
            /// <param name="worksheet">Specify the worksheet of spreadsheet.</param>
            /// <param name="range">Specify the worksheet range of spreadsheet.</param>
            /// <param name="trimContent">Specify the trim content.</param>
            /// <param name="trimLeading">Specify to trim content from the beginning.</param>
            /// <param name="trimTrailing">Specify to trim content from the end.</param>
            /// <param name="trimSpaceBetweenWordTo1">Remove excess spaces between words within a cell.</param>
            /// <param name="trimNonBreakingSpaces">Remove non-breaking spaces.</param>
            /// <param name="removeExtraLineBreaks">Remove extra line breaks.</param>
            /// <param name="removeAllLineBreaks">Remove all line breaks.</param>
            /// <param name="folder">Specify the spreadsheet storage position on remote server</param>
            /// <param name="storageName">(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.</param>
            /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
            /// <param name="password">The password for opening spreadsheet file.</param>
            public TrimCharacterInRemoteSpreadsheetRequest(string  name, string  worksheet, string  range, string  trimContent = null, bool?  trimLeading = null, bool?  trimTrailing = null, bool?  trimSpaceBetweenWordTo1 = null, bool?  trimNonBreakingSpaces = null, bool?  removeExtraLineBreaks = null, bool?  removeAllLineBreaks = null, string  folder = null, string  storageName = null, string  region = null, string  password = null)
            {
                this.name = name;
                this.worksheet = worksheet;
                this.range = range;
                this.trimContent = trimContent;
                this.trimLeading = trimLeading;
                this.trimTrailing = trimTrailing;
                this.trimSpaceBetweenWordTo1 = trimSpaceBetweenWordTo1;
                this.trimNonBreakingSpaces = trimNonBreakingSpaces;
                this.removeExtraLineBreaks = removeExtraLineBreaks;
                this.removeAllLineBreaks = removeAllLineBreaks;
                this.folder = folder;
                this.storageName = storageName;
                this.region = region;
                this.password = password;
            }
        
        /// <summary>
        /// Specify the spreadsheet name on remote server.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Specify the worksheet of spreadsheet.
        /// </summary>
        public string worksheet { get; set; }


        /// <summary>
        /// Specify the worksheet range of spreadsheet.
        /// </summary>
        public string range { get; set; }


        /// <summary>
        /// Specify the trim content.
        /// </summary>
        public string trimContent { get; set; }


        /// <summary>
        /// Specify to trim content from the beginning.
        /// </summary>
        public bool? trimLeading { get; set; }


        /// <summary>
        /// Specify to trim content from the end.
        /// </summary>
        public bool? trimTrailing { get; set; }


        /// <summary>
        /// Remove excess spaces between words within a cell.
        /// </summary>
        public bool? trimSpaceBetweenWordTo1 { get; set; }


        /// <summary>
        /// Remove non-breaking spaces.
        /// </summary>
        public bool? trimNonBreakingSpaces { get; set; }


        /// <summary>
        /// Remove extra line breaks.
        /// </summary>
        public bool? removeExtraLineBreaks { get; set; }


        /// <summary>
        /// Remove all line breaks.
        /// </summary>
        public bool? removeAllLineBreaks { get; set; }


        /// <summary>
        /// Specify the spreadsheet storage position on remote server
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// (Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.
        /// </summary>
        public string storageName { get; set; }


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
            // verify the required parameter 'name' is set
            if (string.IsNullOrEmpty (this.name ))
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling TrimCharacterInRemoteSpreadsheet");
            }

            // verify the required parameter 'worksheet' is set
            if (string.IsNullOrEmpty (this.worksheet ))
            {
                throw new ApiException(400, "Missing required parameter 'worksheet' when calling TrimCharacterInRemoteSpreadsheet");
            }

            // verify the required parameter 'range' is set
            if (string.IsNullOrEmpty (this.range ))
            {
                throw new ApiException(400, "Missing required parameter 'range' when calling TrimCharacterInRemoteSpreadsheet");
            }

            var path = baseUri + "/cells/{name}/worksheets/{worksheet}/range/{range}/content/trim";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddPathParameter(path, "worksheet", this.worksheet);
            path = UrlHelper.AddPathParameter(path, "range", this.range);
            if (!string.IsNullOrEmpty(this.trimContent))  path = UrlHelper.AddQueryParameterToUrl(path, "trimContent", this.trimContent);
            if(this.trimLeading != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimLeading", this.trimLeading);
            if(this.trimTrailing != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimTrailing", this.trimTrailing);
            if(this.trimSpaceBetweenWordTo1 != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimSpaceBetweenWordTo1", this.trimSpaceBetweenWordTo1);
            if(this.trimNonBreakingSpaces != null)  path = UrlHelper.AddQueryParameterToUrl(path, "trimNonBreakingSpaces", this.trimNonBreakingSpaces);
            if(this.removeExtraLineBreaks != null)  path = UrlHelper.AddQueryParameterToUrl(path, "removeExtraLineBreaks", this.removeExtraLineBreaks);
            if(this.removeAllLineBreaks != null)  path = UrlHelper.AddQueryParameterToUrl(path, "removeAllLineBreaks", this.removeAllLineBreaks);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }


            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
