// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AcceptAllRevisionsInRemoteSpreadsheetRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.AcceptAllRevisionsInRemoteSpreadsheet" /> operation.
    /// </summary>
    public class AcceptAllRevisionsInRemoteSpreadsheetRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptAllRevisionsInRemoteSpreadsheetRequest"/> class.
        /// </summary>
        public AcceptAllRevisionsInRemoteSpreadsheetRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="AcceptAllRevisionsInRemoteSpreadsheetRequest"/> class.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="folder"></param>
            /// <param name="storageName">(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.</param>
            /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
            /// <param name="outStorageName">Output file Storage Name.</param>
            /// <param name="fontsLocation">Use Custom fonts.</param>
            /// <param name="region">The spreadsheet region setting.</param>
            /// <param name="password">The password for opening spreadsheet file.</param>
            public AcceptAllRevisionsInRemoteSpreadsheetRequest(string  name, string  folder = null, string  storageName = null, string  outPath = null, string  outStorageName = null, string  fontsLocation = null, string  region = null, string  password = null)
            {
                this.name = name;
                this.folder = folder;
                this.storageName = storageName;
                this.outPath = outPath;
                this.outStorageName = outStorageName;
                this.fontsLocation = fontsLocation;
                this.region = region;
                this.password = password;
            }
        
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        public string folder { get; set; }


        /// <summary>
        /// (Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.
        /// </summary>
        public string storageName { get; set; }


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
        /// The spreadsheet region setting.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling AcceptAllRevisionsInRemoteSpreadsheet");
            }

            var path = baseUri + "/cells/{name}/accept-all-revisions";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
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


            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
