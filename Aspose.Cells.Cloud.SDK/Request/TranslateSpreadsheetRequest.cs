// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TranslateSpreadsheetRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.TranslateSpreadsheet" /> operation.
    /// </summary>
    public class TranslateSpreadsheetRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateSpreadsheetRequest"/> class.
        /// </summary>
        public TranslateSpreadsheetRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateSpreadsheetRequest"/> class.
        /// </summary>
        /// <param name="spreadsheet">Upload spreadsheet file.</param>
        /// <param name="targetLanguage">The target language code for translation (e.g., "es", "fr", "de").</param>
        /// <param name="customEndpoint">Optional. Full Chat Completions endpoint URL.</param>
        /// <param name="customApiKey">Optional. API key for the custom AI service.</param>
        /// <param name="customModel">Optional. Model name to use.</param>
        /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public TranslateSpreadsheetRequest(string  spreadsheet, string  targetLanguage, string  customEndpoint = null, string  customApiKey = null, string  customModel = null, string  region = null, string  password = null)
        {
            this.Spreadsheet = spreadsheet;
            this.targetLanguage = targetLanguage;
            this.customEndpoint = customEndpoint;
            this.customApiKey = customApiKey;
            this.customModel = customModel;
            this.region = region;
            this.password = password;
        }
        
        /// <summary>
        /// Upload spreadsheet file.
        /// </summary>
            public string Spreadsheet { get; set; }


        /// <summary>
        /// The target language code for translation (e.g., "es", "fr", "de").
        /// </summary>
        public string targetLanguage { get; set; }


        /// <summary>
        /// Optional. Full Chat Completions endpoint URL.
        /// </summary>
        public string customEndpoint { get; set; }


        /// <summary>
        /// Optional. API key for the custom AI service.
        /// </summary>
        public string customApiKey { get; set; }


        /// <summary>
        /// Optional. Model name to use.
        /// </summary>
        public string customModel { get; set; }


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
                throw new ApiException(400, "Missing required parameter 'spreadsheet' when calling TranslateSpreadsheet");
            }

            // verify the required parameter 'targetLanguage' is set
            if (string.IsNullOrEmpty (this.targetLanguage ))
            {
                throw new ApiException(400, "Missing required parameter 'targetLanguage' when calling TranslateSpreadsheet");
            }

            var path = baseUri + "/cells/ai/translate/spreadsheet";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            path = UrlHelper.AddQueryParameterToUrl(path, "targetLanguage", this.targetLanguage);
            if (!string.IsNullOrEmpty(this.customEndpoint))  path = UrlHelper.AddQueryParameterToUrl(path, "customEndpoint", this.customEndpoint);
            if (!string.IsNullOrEmpty(this.customApiKey))  path = UrlHelper.AddQueryParameterToUrl(path, "customApiKey", this.customApiKey);
            if (!string.IsNullOrEmpty(this.customModel))  path = UrlHelper.AddQueryParameterToUrl(path, "customModel", this.customModel);
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
