// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveSpreadsheetAsRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SaveSpreadsheetAs" /> operation.
    /// </summary>
    public class SaveSpreadsheetAsRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveSpreadsheetAsRequest"/> class.
        /// </summary>
        public SaveSpreadsheetAsRequest()
        {

        }
            /// <summary>
            /// Initializes a new instance of the <see cref="SaveSpreadsheetAsRequest"/> class.
            /// </summary>
            /// <param name="name">(Required) The name of the workbook file to be converted.</param>
            /// <param name="format">(Required) The desired output format (e.g., "Xlsx", "Pdf", "Csv").</param>
            /// <param name="saveOptionsData">(Optional) Save options data. The default is null.</param>
            /// <param name="folder">(Optional) The folder path where the workbook is stored. The default is null.</param>
            /// <param name="storageName">(Optional) The name of the storage if using custom cloud storage. Use default storage if omitted.</param>
            /// <param name="outPath">(Optional) The folder path where the workbook is stored. The default is null.</param>
            /// <param name="outStorageName">Output file Storage Name.</param>
            /// <param name="fontsLocation">Use Custom fonts.</param>
            /// <param name="autoRowsFit">(Optional) Autofits all rows in worksheets.</param>
            /// <param name="autoColumnsFit">(Optional) Autofits all columns in worksheets.</param>
            /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
            /// <param name="password">The password for opening spreadsheet file.</param>
            public SaveSpreadsheetAsRequest(string  name, string  format, SaveOptionsData  saveOptionsData = null, string  folder = null, string  storageName = null, string  outPath = null, string  outStorageName = null, string  fontsLocation = null, bool?  autoRowsFit = null, bool?  autoColumnsFit = null, string  region = null, string  password = null)
            {
                this.name = name;
                this.format = format;
                this.saveOptionsData = saveOptionsData;
                this.folder = folder;
                this.storageName = storageName;
                this.outPath = outPath;
                this.outStorageName = outStorageName;
                this.fontsLocation = fontsLocation;
                this.AutoRowsFit = autoRowsFit;
                this.AutoColumnsFit = autoColumnsFit;
                this.region = region;
                this.password = password;
            }
        
        /// <summary>
        /// (Required) The name of the workbook file to be converted.
        /// </summary>
        public string name { get; set; }


        /// <summary>
        /// (Required) The desired output format (e.g., "Xlsx", "Pdf", "Csv").
        /// </summary>
        public string format { get; set; }


        /// <summary>
        /// (Optional) Save options data. The default is null.
        /// </summary>
        public SaveOptionsData saveOptionsData { get; set; }


        /// <summary>
        /// (Optional) The folder path where the workbook is stored. The default is null.
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
        /// (Optional) Autofits all rows in worksheets.
        /// </summary>
        public bool? AutoRowsFit { get; set; }


        /// <summary>
        /// (Optional) Autofits all columns in worksheets.
        /// </summary>
        public bool? AutoColumnsFit { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveSpreadsheetAs");
            }

            // verify the required parameter 'format' is set
            if (string.IsNullOrEmpty (this.format ))
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling SaveSpreadsheetAs");
            }

            var path = baseUri + "/cells/{name}/saveas";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddPathParameter(path, "name", this.name);
            path = UrlHelper.AddQueryParameterToUrl(path, "format", this.format);
            if (!string.IsNullOrEmpty(this.folder))  path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.folder);
            if (!string.IsNullOrEmpty(this.storageName))  path = UrlHelper.AddQueryParameterToUrl(path, "storageName", this.storageName);
            if (!string.IsNullOrEmpty(this.outPath))  path = UrlHelper.AddQueryParameterToUrl(path, "outPath", this.outPath);
            if (!string.IsNullOrEmpty(this.outStorageName))  path = UrlHelper.AddQueryParameterToUrl(path, "outStorageName", this.outStorageName);
            if (!string.IsNullOrEmpty(this.fontsLocation))  path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.fontsLocation);
            if(this.AutoRowsFit != null)  path = UrlHelper.AddQueryParameterToUrl(path, "autoRowsFit", this.AutoRowsFit);
            if(this.AutoColumnsFit != null)  path = UrlHelper.AddQueryParameterToUrl(path, "autoColumnsFit", this.AutoColumnsFit);
            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

            localVarPostBody = ( this.saveOptionsData != null ? JsonConvert.SerializeObject(this.saveOptionsData) : null);


            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
