// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SmartMarkerTemplateRequest.cs">
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
    /// Request model for <see cref="Aspose.Cells.Cloud.SDK.Api.CellsApi.SmartMarkerTemplate" /> operation.
    /// </summary>
    public class SmartMarkerTemplateRequest : IRequestModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartMarkerTemplateRequest"/> class.
        /// </summary>
        public SmartMarkerTemplateRequest()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartMarkerTemplateRequest"/> class.
        /// </summary>
        /// <param name="datafile">Upload smartmarker template json data file.</param>
        /// <param name="templatefile">Upload smartmarker template file.</param>
        /// <param name="region">Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.</param>
        /// <param name="password">The password for opening spreadsheet file.</param>
        public SmartMarkerTemplateRequest(string  datafile, string  templatefile, string  region = null, string  password = null)
        {
            this.datafile = datafile;
            this.templatefile = templatefile;
            this.region = region;
            this.password = password;
        }
        
        /// <summary>
        /// Upload smartmarker template json data file.
        /// </summary>
            public string datafile { get; set; }


        /// <summary>
        /// Upload smartmarker template file.
        /// </summary>
            public string templatefile { get; set; }


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
            // verify the required parameter 'datafile' is set
            if (    string.IsNullOrEmpty(this.datafile)    )
            {
                throw new ApiException(400, "Missing required parameter 'datafile' when calling SmartMarkerTemplate");
            }

            // verify the required parameter 'templatefile' is set
            if (    string.IsNullOrEmpty(this.templatefile)    )
            {
                throw new ApiException(400, "Missing required parameter 'templatefile' when calling SmartMarkerTemplate");
            }

            var path = baseUri + "/cells/report/smart/template";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");

            if (!string.IsNullOrEmpty(this.region))  path = UrlHelper.AddQueryParameterToUrl(path, "region", this.region);
            if (!string.IsNullOrEmpty(this.password))  path = UrlHelper.AddQueryParameterToUrl(path, "password", this.password);
            if (this.extendQueryParameterMap != null)
            {
                foreach (KeyValuePair<string, string> kvp in extendQueryParameterMap)
                {
                    path = UrlHelper.AddQueryParameterToUrl(path, kvp.Key, kvp.Value);
                }
            }

             if (!string.IsNullOrEmpty(datafile ) && System.IO.File.Exists(datafile )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(datafile);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(datafile), fileInfo.Name));
             } 
             if (!string.IsNullOrEmpty(templatefile ) && System.IO.File.Exists(templatefile )) {
                 System.IO.FileInfo fileInfo = new System.IO.FileInfo(templatefile);
                 localVarFileParams.Add(fileInfo.Name, UrlHelper.ToFileInfo(System.IO.File.OpenRead(templatefile), fileInfo.Name));
             } 



            return UrlHelper.PrepareRequest(path, "PUT", localVarFileParams, localVarHeaderParams, localVarPostBody, localVarHttpContentType, defaultHeaderMap, requestHandlers);
        }
    }
}
