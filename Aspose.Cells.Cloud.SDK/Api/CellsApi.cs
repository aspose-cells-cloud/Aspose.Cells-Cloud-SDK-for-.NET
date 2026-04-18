// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CellsApi.cs">
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

namespace Aspose.Cells.Cloud.SDK.Api
{
    using Aspose.Cells.Cloud.SDK.Model;
    using Aspose.Cells.Cloud.SDK.Request;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    using FileInfo = Aspose.Cells.Cloud.SDK.Model.FileInfo;

    /// <summary>
    /// Aspose.Cells Cloud API.
    /// </summary>
    public class CellsApi
    {
        private readonly Invoker.ApiInvoker invoker;
        private readonly string BaseUri;
        private readonly string ClientId;
        private readonly string ClientSecrent;  
        private readonly List<Invoker.IRequestHandler> requestHandlers;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecrent"></param>
        /// <param name="baseUrl"></param>
        /// <param name="version"></param>
        public CellsApi(string clientId, string clientSecrent,string baseUrl = "https://api.aspose.cloud")
        {
            this.ClientSecrent = clientSecrent;
            this.ClientId = clientId;
            this.BaseUri = baseUrl;
            this.requestHandlers = new List<Invoker.IRequestHandler>();
            this.requestHandlers.Add(new Invoker.ApiExceptionRequestHandler());
            this.requestHandlers.Add(new Invoker.JwtTokenRequestHandler(baseUrl, clientId, clientSecrent));
            invoker = new Invoker.ApiInvoker(requestHandlers);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        public void DecomposeUserTask(DecomposeUserTaskRequest request, string LocalOutPath){
            var result = DecomposeUserTask(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// AI task decomposition: Convert user objectives to sequential action plans with formatted file export.
        /// </summary>
        /// <param name="request">Request. <see cref="DecomposeUserTaskRequest" /></param>
        public   Stream  DecomposeUserTask(DecomposeUserTaskRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > DecomposeUserTaskAsync(DecomposeUserTaskRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void TranslateSpreadsheet(TranslateSpreadsheetRequest request, string LocalOutPath){
            var result = TranslateSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Translates the entire spreadsheet to the specified target language.
        /// </summary>
        /// <param name="request">Request. <see cref="TranslateSpreadsheetRequest" /></param>
        public   Stream  TranslateSpreadsheet(TranslateSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > TranslateSpreadsheetAsync(TranslateSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Translates text file content to the specified target language.
        /// </summary>
        /// <param name="request">Request. <see cref="TranslateTextFileRequest" /></param>
        public  void  TranslateTextFile(TranslateTextFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task TranslateTextFileAsync(TranslateTextFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// The Aggregate by Color API provides a convenient way to perform calculations on cells that share the same fill or font color. This API supports a range of aggregate operations, including count, sum, maximum value, minimum value, and average value, enabling you to analyze and summarize data based on color distinctions.
        /// </summary>
        /// <param name="request">Request. <see cref="AggregateCellsByColorRequest" /></param>
        public   AggregateResultByColorResponse  AggregateCellsByColor(AggregateCellsByColorRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AggregateResultByColorResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AggregateResultByColorResponse  > AggregateCellsByColorAsync(AggregateCellsByColorRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AggregateResultByColorResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void MathCalculate(MathCalculateRequest request, string LocalOutPath){
            var result = MathCalculate(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="MathCalculateRequest" /></param>
        public   Stream  MathCalculate(MathCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > MathCalculateAsync(MathCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get Access Token Result: The Cells Cloud Get Token API acts as a proxy service,
        /// forwarding user requests to the Aspose Cloud authentication server and returning the resulting access token to the client.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAccessTokenRequest" /></param>
        public   string  PostAccessToken(PostAccessTokenRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > PostAccessTokenAsync(PostAccessTokenRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Check the Health Status of Aspose.Cells Cloud Service.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAsposeCellsCloudStatusRequest" /></param>
        public   string  GetAsposeCellsCloudStatus(GetAsposeCellsCloudStatusRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > GetAsposeCellsCloudStatusAsync(GetAsposeCellsCloudStatusRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Check the Health Status of Aspose.Cells Cloud Service.
        /// </summary>
        /// <param name="request">Request. <see cref="CheckCloudServiceHealthRequest" /></param>
        public   string  CheckCloudServiceHealth(CheckCloudServiceHealthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > CheckCloudServiceHealthAsync(CheckCloudServiceHealthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ExportSpreadsheetAsFormat(ExportSpreadsheetAsFormatRequest request, string LocalOutPath){
            var result = ExportSpreadsheetAsFormat(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a spreadsheet in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ExportSpreadsheetAsFormatRequest" /></param>
        public   Stream  ExportSpreadsheetAsFormat(ExportSpreadsheetAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ExportSpreadsheetAsFormatAsync(ExportSpreadsheetAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ExportWorksheetAsFormat(ExportWorksheetAsFormatRequest request, string LocalOutPath){
            var result = ExportWorksheetAsFormat(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ExportWorksheetAsFormatRequest" /></param>
        public   Stream  ExportWorksheetAsFormat(ExportWorksheetAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ExportWorksheetAsFormatAsync(ExportWorksheetAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ExportChartAsFormat(ExportChartAsFormatRequest request, string LocalOutPath){
            var result = ExportChartAsFormat(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a chart of spreadsheet in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ExportChartAsFormatRequest" /></param>
        public   Stream  ExportChartAsFormat(ExportChartAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ExportChartAsFormatAsync(ExportChartAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ExportTableAsFormat(ExportTableAsFormatRequest request, string LocalOutPath){
            var result = ExportTableAsFormat(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a table of spreadsheet in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ExportTableAsFormatRequest" /></param>
        public   Stream  ExportTableAsFormat(ExportTableAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ExportTableAsFormatAsync(ExportTableAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ExportRangeAsFormat(ExportRangeAsFormatRequest request, string LocalOutPath){
            var result = ExportRangeAsFormat(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts the range of spreadsheet in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ExportRangeAsFormatRequest" /></param>
        public   Stream  ExportRangeAsFormat(ExportRangeAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ExportRangeAsFormatAsync(ExportRangeAsFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertSpreadsheet(ConvertSpreadsheetRequest request, string LocalOutPath){
            var result = ConvertSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a spreadsheet on a local drive to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertSpreadsheetRequest" /></param>
        public   Stream  ConvertSpreadsheet(ConvertSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertSpreadsheetAsync(ConvertSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertSpreadsheetToPdf(ConvertSpreadsheetToPdfRequest request, string LocalOutPath){
            var result = ConvertSpreadsheetToPdf(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a spreadsheet on a local drive to the pdf file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertSpreadsheetToPdfRequest" /></param>
        public   Stream  ConvertSpreadsheetToPdf(ConvertSpreadsheetToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertSpreadsheetToPdfAsync(ConvertSpreadsheetToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertSpreadsheetToJson(ConvertSpreadsheetToJsonRequest request, string LocalOutPath){
            var result = ConvertSpreadsheetToJson(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a spreadsheet on a local drive to the JSON file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertSpreadsheetToJsonRequest" /></param>
        public   Stream  ConvertSpreadsheetToJson(ConvertSpreadsheetToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertSpreadsheetToJsonAsync(ConvertSpreadsheetToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertSpreadsheetToCsv(ConvertSpreadsheetToCsvRequest request, string LocalOutPath){
            var result = ConvertSpreadsheetToCsv(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a spreadsheet on a local drive to the csv file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertSpreadsheetToCsvRequest" /></param>
        public   Stream  ConvertSpreadsheetToCsv(ConvertSpreadsheetToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertSpreadsheetToCsvAsync(ConvertSpreadsheetToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertWorksheetToImage(ConvertWorksheetToImageRequest request, string LocalOutPath){
            var result = ConvertWorksheetToImage(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet on a local drive to the image format.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertWorksheetToImageRequest" /></param>
        public   Stream  ConvertWorksheetToImage(ConvertWorksheetToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertWorksheetToImageAsync(ConvertWorksheetToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertWorksheetToPdf(ConvertWorksheetToPdfRequest request, string LocalOutPath){
            var result = ConvertWorksheetToPdf(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet on a local drive to the pdf file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertWorksheetToPdfRequest" /></param>
        public   Stream  ConvertWorksheetToPdf(ConvertWorksheetToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertWorksheetToPdfAsync(ConvertWorksheetToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertWorksheetToJson(ConvertWorksheetToJsonRequest request, string LocalOutPath){
            var result = ConvertWorksheetToJson(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet on a local drive to the JSON file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertWorksheetToJsonRequest" /></param>
        public   Stream  ConvertWorksheetToJson(ConvertWorksheetToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertWorksheetToJsonAsync(ConvertWorksheetToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertWorksheetToCsv(ConvertWorksheetToCsvRequest request, string LocalOutPath){
            var result = ConvertWorksheetToCsv(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet on a local drive to the CSV file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertWorksheetToCsvRequest" /></param>
        public   Stream  ConvertWorksheetToCsv(ConvertWorksheetToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertWorksheetToCsvAsync(ConvertWorksheetToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertWorksheetToHtml(ConvertWorksheetToHtmlRequest request, string LocalOutPath){
            var result = ConvertWorksheetToHtml(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet on a local drive to the html file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertWorksheetToHtmlRequest" /></param>
        public   Stream  ConvertWorksheetToHtml(ConvertWorksheetToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertWorksheetToHtmlAsync(ConvertWorksheetToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertWorksheetToHtmlTable(ConvertWorksheetToHtmlTableRequest request, string LocalOutPath){
            var result = ConvertWorksheetToHtmlTable(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a worksheet of spreadsheet on a local drive to the HTML table file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertWorksheetToHtmlTableRequest" /></param>
        public   Stream  ConvertWorksheetToHtmlTable(ConvertWorksheetToHtmlTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertWorksheetToHtmlTableAsync(ConvertWorksheetToHtmlTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertTableToImage(ConvertTableToImageRequest request, string LocalOutPath){
            var result = ConvertTableToImage(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a table of spreadsheet on a local drive to the image file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertTableToImageRequest" /></param>
        public   Stream  ConvertTableToImage(ConvertTableToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertTableToImageAsync(ConvertTableToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertTableToPdf(ConvertTableToPdfRequest request, string LocalOutPath){
            var result = ConvertTableToPdf(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a table of spreadsheet on a local drive to the pdf file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertTableToPdfRequest" /></param>
        public   Stream  ConvertTableToPdf(ConvertTableToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertTableToPdfAsync(ConvertTableToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertTableToCsv(ConvertTableToCsvRequest request, string LocalOutPath){
            var result = ConvertTableToCsv(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a table of spreadsheet on a local drive to the csv file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertTableToCsvRequest" /></param>
        public   Stream  ConvertTableToCsv(ConvertTableToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertTableToCsvAsync(ConvertTableToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertTableToHtml(ConvertTableToHtmlRequest request, string LocalOutPath){
            var result = ConvertTableToHtml(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a table of spreadsheet on a local drive to the html file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertTableToHtmlRequest" /></param>
        public   Stream  ConvertTableToHtml(ConvertTableToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertTableToHtmlAsync(ConvertTableToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertTableToJson(ConvertTableToJsonRequest request, string LocalOutPath){
            var result = ConvertTableToJson(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a table of spreadsheet on a local drive to the json file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertTableToJsonRequest" /></param>
        public   Stream  ConvertTableToJson(ConvertTableToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertTableToJsonAsync(ConvertTableToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertRangeToImage(ConvertRangeToImageRequest request, string LocalOutPath){
            var result = ConvertRangeToImage(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a range of spreadsheet on a local drive to the image file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertRangeToImageRequest" /></param>
        public   Stream  ConvertRangeToImage(ConvertRangeToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertRangeToImageAsync(ConvertRangeToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertRangeToPdf(ConvertRangeToPdfRequest request, string LocalOutPath){
            var result = ConvertRangeToPdf(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a range of spreadsheet on a local drive to the pdf file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertRangeToPdfRequest" /></param>
        public   Stream  ConvertRangeToPdf(ConvertRangeToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertRangeToPdfAsync(ConvertRangeToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertRangeToCsv(ConvertRangeToCsvRequest request, string LocalOutPath){
            var result = ConvertRangeToCsv(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a range of spreadsheet on a local drive to the csv file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertRangeToCsvRequest" /></param>
        public   Stream  ConvertRangeToCsv(ConvertRangeToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertRangeToCsvAsync(ConvertRangeToCsvRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertRangeToHtml(ConvertRangeToHtmlRequest request, string LocalOutPath){
            var result = ConvertRangeToHtml(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a range of spreadsheet on a local drive to the html file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertRangeToHtmlRequest" /></param>
        public   Stream  ConvertRangeToHtml(ConvertRangeToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertRangeToHtmlAsync(ConvertRangeToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertRangeToJson(ConvertRangeToJsonRequest request, string LocalOutPath){
            var result = ConvertRangeToJson(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a range of spreadsheet on a local drive to the json file.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertRangeToJsonRequest" /></param>
        public   Stream  ConvertRangeToJson(ConvertRangeToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertRangeToJsonAsync(ConvertRangeToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertChartToImage(ConvertChartToImageRequest request, string LocalOutPath){
            var result = ConvertChartToImage(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a chart of spreadsheet on a local drive to image.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertChartToImageRequest" /></param>
        public   Stream  ConvertChartToImage(ConvertChartToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertChartToImageAsync(ConvertChartToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertChartToPdf(ConvertChartToPdfRequest request, string LocalOutPath){
            var result = ConvertChartToPdf(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Converts a chart of spreadsheet on a local drive to pdf.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertChartToPdfRequest" /></param>
        public   Stream  ConvertChartToPdf(ConvertChartToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertChartToPdfAsync(ConvertChartToPdfRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Converts a spreadsheet in cloud storage to the specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="SaveSpreadsheetAsRequest" /></param>
        public   CellsCloudResponse  SaveSpreadsheetAs(SaveSpreadsheetAsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > SaveSpreadsheetAsAsync(SaveSpreadsheetAsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void MergeSpreadsheets(MergeSpreadsheetsRequest request, string LocalOutPath){
            var result = MergeSpreadsheets(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Merge local spreadsheet files into a specified format file.
        /// </summary>
        /// <param name="request">Request. <see cref="MergeSpreadsheetsRequest" /></param>
        public   Stream  MergeSpreadsheets(MergeSpreadsheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > MergeSpreadsheetsAsync(MergeSpreadsheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void MergeSpreadsheetsInRemoteFolder(MergeSpreadsheetsInRemoteFolderRequest request, string LocalOutPath){
            var result = MergeSpreadsheetsInRemoteFolder(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Merge spreadsheet files in folder of cloud storage into a specified format file.
        /// </summary>
        /// <param name="request">Request. <see cref="MergeSpreadsheetsInRemoteFolderRequest" /></param>
        public   Stream  MergeSpreadsheetsInRemoteFolder(MergeSpreadsheetsInRemoteFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > MergeSpreadsheetsInRemoteFolderAsync(MergeSpreadsheetsInRemoteFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void MergeRemoteSpreadsheet(MergeRemoteSpreadsheetRequest request, string LocalOutPath){
            var result = MergeRemoteSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Merge a spreadsheet file into other spreadsheet in cloud storage, and output a specified format file.
        /// </summary>
        /// <param name="request">Request. <see cref="MergeRemoteSpreadsheetRequest" /></param>
        public   Stream  MergeRemoteSpreadsheet(MergeRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > MergeRemoteSpreadsheetAsync(MergeRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void SplitSpreadsheet(SplitSpreadsheetRequest request, string LocalOutPath){
            var result = SplitSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Split a local spreadsheet into the specified format, multi-file.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitSpreadsheetRequest" /></param>
        public   Stream  SplitSpreadsheet(SplitSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > SplitSpreadsheetAsync(SplitSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void SplitTable(SplitTableRequest request, string LocalOutPath){
            var result = SplitTable(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Split an Excel worksheet tale into multiple sheets by column value.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitTableRequest" /></param>
        public   Stream  SplitTable(SplitTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > SplitTableAsync(SplitTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void SplitRemoteSpreadsheet(SplitRemoteSpreadsheetRequest request, string LocalOutPath){
            var result = SplitRemoteSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Split a spreadsheet in cloud storage into the specified format, multi-file.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitRemoteSpreadsheetRequest" /></param>
        public   Stream  SplitRemoteSpreadsheet(SplitRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > SplitRemoteSpreadsheetAsync(SplitRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ImportDataIntoSpreadsheet(ImportDataIntoSpreadsheetRequest request, string LocalOutPath){
            var result = ImportDataIntoSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Import data into a spreadsheet from a supported data file format.
        /// </summary>
        /// <param name="request">Request. <see cref="ImportDataIntoSpreadsheetRequest" /></param>
        public   Stream  ImportDataIntoSpreadsheet(ImportDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ImportDataIntoSpreadsheetAsync(ImportDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ImportJSONDataIntoSpreadsheet(ImportJSONDataIntoSpreadsheetRequest request, string LocalOutPath){
            var result = ImportJSONDataIntoSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Import JSON data file into the local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ImportJSONDataIntoSpreadsheetRequest" /></param>
        public   Stream  ImportJSONDataIntoSpreadsheet(ImportJSONDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ImportJSONDataIntoSpreadsheetAsync(ImportJSONDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ImportXMLDataIntoSpreadsheet(ImportXMLDataIntoSpreadsheetRequest request, string LocalOutPath){
            var result = ImportXMLDataIntoSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Import XML data file into the local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ImportXMLDataIntoSpreadsheetRequest" /></param>
        public   Stream  ImportXMLDataIntoSpreadsheet(ImportXMLDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ImportXMLDataIntoSpreadsheetAsync(ImportXMLDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ImportCSVDataIntoSpreadsheet(ImportCSVDataIntoSpreadsheetRequest request, string LocalOutPath){
            var result = ImportCSVDataIntoSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Import CSV data file into the local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ImportCSVDataIntoSpreadsheetRequest" /></param>
        public   Stream  ImportCSVDataIntoSpreadsheet(ImportCSVDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ImportCSVDataIntoSpreadsheetAsync(ImportCSVDataIntoSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get an asymmetric public key.
        /// </summary>
        /// <param name="request">Request. <see cref="GetPublicKeyRequest" /></param>
        public   CellsCloudPublicKeyResponse  GetPublicKey(GetPublicKeyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudPublicKeyResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudPublicKeyResponse  > GetPublicKeyAsync(GetPublicKeyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudPublicKeyResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void CreateSpreadsheet(CreateSpreadsheetRequest request, string LocalOutPath){
            var result = CreateSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API allows users to create a new spreadsheet with a specified name. Optionally, a template can be provided to initialize the spreadsheet with predefined content or formatting.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateSpreadsheetRequest" /></param>
        public   Stream  CreateSpreadsheet(CreateSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > CreateSpreadsheetAsync(CreateSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Fetches a complete list of worksheets from the currently active local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetsWithLocalSpreadsheetRequest" /></param>
        public   string  GetWorksheetsWithLocalSpreadsheet(GetWorksheetsWithLocalSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > GetWorksheetsWithLocalSpreadsheetAsync(GetWorksheetsWithLocalSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void AddWorksheetToSpreadsheet(AddWorksheetToSpreadsheetRequest request, string LocalOutPath){
            var result = AddWorksheetToSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API enables users to add a new worksheet to a workbook, specifying the worksheet's type, position, and name. This function provides flexibility in managing workbook structure by allowing detailed control over worksheet addition.
        /// </summary>
        /// <param name="request">Request. <see cref="AddWorksheetToSpreadsheetRequest" /></param>
        public   Stream  AddWorksheetToSpreadsheet(AddWorksheetToSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > AddWorksheetToSpreadsheetAsync(AddWorksheetToSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void DeleteWorksheetFromSpreadsheet(DeleteWorksheetFromSpreadsheetRequest request, string LocalOutPath){
            var result = DeleteWorksheetFromSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API endpoint allows users to delete a specified worksheet from a workbook. This function provides a straightforward way to manage workbook structure by removing unnecessary or redundant worksheets.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetFromSpreadsheetRequest" /></param>
        public   Stream  DeleteWorksheetFromSpreadsheet(DeleteWorksheetFromSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > DeleteWorksheetFromSpreadsheetAsync(DeleteWorksheetFromSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RenameWorksheetInSpreadsheet(RenameWorksheetInSpreadsheetRequest request, string LocalOutPath){
            var result = RenameWorksheetInSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API endpoint allows users to rename a specified worksheet within a workbook. This function provides a straightforward way to update worksheet names, enhancing workbook organization and readability.
        /// </summary>
        /// <param name="request">Request. <see cref="RenameWorksheetInSpreadsheetRequest" /></param>
        public   Stream  RenameWorksheetInSpreadsheet(RenameWorksheetInSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RenameWorksheetInSpreadsheetAsync(RenameWorksheetInSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void MoveWorksheetInSpreadsheet(MoveWorksheetInSpreadsheetRequest request, string LocalOutPath){
            var result = MoveWorksheetInSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API endpoint allows users to move a specified worksheet within a workbook. This function provides a straightforward way to move a worksheet, enhancing workbook organization.
        /// </summary>
        /// <param name="request">Request. <see cref="MoveWorksheetInSpreadsheetRequest" /></param>
        public   Stream  MoveWorksheetInSpreadsheet(MoveWorksheetInSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > MoveWorksheetInSpreadsheetAsync(MoveWorksheetInSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void CompressSpreadsheet(CompressSpreadsheetRequest request, string LocalOutPath){
            var result = CompressSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API endpoint allows users to compress a spreadsheet to reduce its file size. This function provides a straightforward way to optimize the storage and performance of spreadsheets by applying a specified compression level.
        /// </summary>
        /// <param name="request">Request. <see cref="CompressSpreadsheetRequest" /></param>
        public   Stream  CompressSpreadsheet(CompressSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > CompressSpreadsheetAsync(CompressSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RepairSpreadsheet(RepairSpreadsheetRequest request, string LocalOutPath){
            var result = RepairSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Web API endpoint allows users to repair a spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="RepairSpreadsheetRequest" /></param>
        public   Stream  RepairSpreadsheet(RepairSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RepairSpreadsheetAsync(RepairSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get all merged cell area form a remote spreadsheet worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetMergedCellsInRemotedWorksheetRequest" /></param>
        public   List<CellArea>  GetMergedCellsInRemotedWorksheet(GetMergedCellsInRemotedWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    List<CellArea>  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   List<CellArea>  > GetMergedCellsInRemotedWorksheetAsync(GetMergedCellsInRemotedWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    List<CellArea>  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get all merged cell area form a local spreadsheet worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetMergedCellsInWorksheetRequest" /></param>
        public   List<CellArea>  GetMergedCellsInWorksheet(GetMergedCellsInWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    List<CellArea>  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   List<CellArea>  > GetMergedCellsInWorksheetAsync(GetMergedCellsInWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    List<CellArea>  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void AcceptAllRevisions(AcceptAllRevisionsRequest request, string LocalOutPath){
            var result = AcceptAllRevisions(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsRequest" /></param>
        public   Stream  AcceptAllRevisions(AcceptAllRevisionsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > AcceptAllRevisionsAsync(AcceptAllRevisionsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void AcceptAllRevisionsInRemoteSpreadsheet(AcceptAllRevisionsInRemoteSpreadsheetRequest request, string LocalOutPath){
            var result = AcceptAllRevisionsInRemoteSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="AcceptAllRevisionsInRemoteSpreadsheetRequest" /></param>
        public   Stream  AcceptAllRevisionsInRemoteSpreadsheet(AcceptAllRevisionsInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > AcceptAllRevisionsInRemoteSpreadsheetAsync(AcceptAllRevisionsInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ProtectSpreadsheet(ProtectSpreadsheetRequest request, string LocalOutPath){
            var result = ProtectSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Applies dual-layer password protection to Excel spreadsheets, supporting both open and modify passwords with encryption.
        /// </summary>
        /// <param name="request">Request. <see cref="ProtectSpreadsheetRequest" /></param>
        public   Stream  ProtectSpreadsheet(ProtectSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ProtectSpreadsheetAsync(ProtectSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void UnprotectSpreadsheet(UnprotectSpreadsheetRequest request, string LocalOutPath){
            var result = UnprotectSpreadsheet(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Removes dual-layer password protection from Excel spreadsheets, supporting both open and modify passwords with encryption.
        /// </summary>
        /// <param name="request">Request. <see cref="UnprotectSpreadsheetRequest" /></param>
        public   Stream  UnprotectSpreadsheet(UnprotectSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > UnprotectSpreadsheetAsync(UnprotectSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void SpreadsheetDigitalsignature(SpreadsheetDigitalsignatureRequest request, string LocalOutPath){
            var result = SpreadsheetDigitalsignature(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="SpreadsheetDigitalsignatureRequest" /></param>
        public   Stream  SpreadsheetDigitalsignature(SpreadsheetDigitalsignatureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > SpreadsheetDigitalsignatureAsync(SpreadsheetDigitalsignatureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get all text items in the remote spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchAllTextItemsInRemoteSpreadsheetRequest" /></param>
        public   SearchResponse  SearchAllTextItemsInRemoteSpreadsheet(SearchAllTextItemsInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SearchResponse  > SearchAllTextItemsInRemoteSpreadsheetAsync(SearchAllTextItemsInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get all text items in the remote spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchSpreadsheetAllTextItemsRequest" /></param>
        public   SearchResponse  SearchSpreadsheetAllTextItems(SearchSpreadsheetAllTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SearchResponse  > SearchSpreadsheetAllTextItemsAsync(SearchSpreadsheetAllTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search text in the local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchSpreadsheetContentRequest" /></param>
        public   SearchResponse  SearchSpreadsheetContent(SearchSpreadsheetContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SearchResponse  > SearchSpreadsheetContentAsync(SearchSpreadsheetContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search text in the remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchContentInRemoteSpreadsheetRequest" /></param>
        public   SearchResponse  SearchContentInRemoteSpreadsheet(SearchContentInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SearchResponse  > SearchContentInRemoteSpreadsheetAsync(SearchContentInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search text in the worksheet of remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchContentInRemoteWorksheetRequest" /></param>
        public   SearchResponse  SearchContentInRemoteWorksheet(SearchContentInRemoteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SearchResponse  > SearchContentInRemoteWorksheetAsync(SearchContentInRemoteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search text in the range of remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchContentInRemoteRangeRequest" /></param>
        public   SearchResponse  SearchContentInRemoteRange(SearchContentInRemoteRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SearchResponse  > SearchContentInRemoteRangeAsync(SearchContentInRemoteRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SearchResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ReplaceSpreadsheetContent(ReplaceSpreadsheetContentRequest request, string LocalOutPath){
            var result = ReplaceSpreadsheetContent(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Replace text in the local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceSpreadsheetContentRequest" /></param>
        public   Stream  ReplaceSpreadsheetContent(ReplaceSpreadsheetContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ReplaceSpreadsheetContentAsync(ReplaceSpreadsheetContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Replace text in the remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceContentInRemoteSpreadsheetRequest" /></param>
        public   CellsCloudResponse  ReplaceContentInRemoteSpreadsheet(ReplaceContentInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > ReplaceContentInRemoteSpreadsheetAsync(ReplaceContentInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Replace text in the worksheet of remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceContentInRemoteWorksheetRequest" /></param>
        public   CellsCloudResponse  ReplaceContentInRemoteWorksheet(ReplaceContentInRemoteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > ReplaceContentInRemoteWorksheetAsync(ReplaceContentInRemoteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Replace text in the range of remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="ReplaceContentInRemoteRangeRequest" /></param>
        public   CellsCloudResponse  ReplaceContentInRemoteRange(ReplaceContentInRemoteRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > ReplaceContentInRemoteRangeAsync(ReplaceContentInRemoteRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search broken links in the local spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchSpreadsheetBrokenLinksRequest" /></param>
        public   BrokenLinksResponse  SearchSpreadsheetBrokenLinks(SearchSpreadsheetBrokenLinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   BrokenLinksResponse  > SearchSpreadsheetBrokenLinksAsync(SearchSpreadsheetBrokenLinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search broken links in the remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchBrokenLinksInRemoteSpreadsheetRequest" /></param>
        public   BrokenLinksResponse  SearchBrokenLinksInRemoteSpreadsheet(SearchBrokenLinksInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   BrokenLinksResponse  > SearchBrokenLinksInRemoteSpreadsheetAsync(SearchBrokenLinksInRemoteSpreadsheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search broken links in the worksheet of remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchBrokenLinksInRemoteWorksheetRequest" /></param>
        public   BrokenLinksResponse  SearchBrokenLinksInRemoteWorksheet(SearchBrokenLinksInRemoteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   BrokenLinksResponse  > SearchBrokenLinksInRemoteWorksheetAsync(SearchBrokenLinksInRemoteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search broken links in the range of remoted spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="SearchBrokenLinksInRemoteRangeRequest" /></param>
        public   BrokenLinksResponse  SearchBrokenLinksInRemoteRange(SearchBrokenLinksInRemoteRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   BrokenLinksResponse  > SearchBrokenLinksInRemoteRangeAsync(SearchBrokenLinksInRemoteRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    BrokenLinksResponse  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get the specifications
        /// </summary>
        /// <param name="request">Request. <see cref="SpecRequest" /></param>
        public  void  Spec(SpecRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task SpecAsync(SpecRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CodegenSpecRequest" /></param>
        public  void  CodegenSpec(CodegenSpecRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task CodegenSpecAsync(CodegenSpecRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }




        public void TrimCharacter(TrimCharacterRequest request, string LocalOutPath){
            var result = TrimCharacter(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The TrimSpreadsheetContent API is designed to process and trim content within a spreadsheet. This API allows users to remove extra spaces, line breaks, or other unnecessary characters from the content of selected cells. It is particularly useful for cleaning up data entries and ensuring consistency in spreadsheet formatting
        /// </summary>
        /// <param name="request">Request. <see cref="TrimCharacterRequest" /></param>
        public   Stream  TrimCharacter(TrimCharacterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > TrimCharacterAsync(TrimCharacterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void UpdateWordCase(UpdateWordCaseRequest request, string LocalOutPath){
            var result = UpdateWordCase(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Specify changing the text case in a spreadsheet to switch between uppercase, lowercase, capitalizing the first letter of each word, or capitalizing the first letter of a sentence, and adjust the text according to specific needs.
        /// </summary>
        /// <param name="request">Request. <see cref="UpdateWordCaseRequest" /></param>
        public   Stream  UpdateWordCase(UpdateWordCaseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > UpdateWordCaseAsync(UpdateWordCaseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveCharacters(RemoveCharactersRequest request, string LocalOutPath){
            var result = RemoveCharacters(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Deletes user-defined characters, predefined symbol sets, or any substring from every cell in the chosen range while preserving formulas, formatting and data-validation.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveCharactersRequest" /></param>
        public   Stream  RemoveCharacters(RemoveCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveCharactersAsync(RemoveCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveCharactersByPosition(RemoveCharactersByPositionRequest request, string LocalOutPath){
            var result = RemoveCharactersByPosition(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Deletes characters from every cell in the target range by position (first/last N, before/after a substring, or between two delimiters) while preserving formulas, formatting and data-validation.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveCharactersByPositionRequest" /></param>
        public   Stream  RemoveCharactersByPosition(RemoveCharactersByPositionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveCharactersByPositionAsync(RemoveCharactersByPositionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveDuplicateSubstrings(RemoveDuplicateSubstringsRequest request, string LocalOutPath){
            var result = RemoveDuplicateSubstrings(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Finds and removes repeated substrings inside every cell of the chosen range, using user-defined or preset delimiters, while preserving formulas, formatting and data-validation.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveDuplicateSubstringsRequest" /></param>
        public   Stream  RemoveDuplicateSubstrings(RemoveDuplicateSubstringsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveDuplicateSubstringsAsync(RemoveDuplicateSubstringsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void AddText(AddTextRequest request, string LocalOutPath){
            var result = AddText(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Specify appending text to multiple cells at once, allowing you to add prefixes, suffixes, labels, or any specific characters. You can choose the exact position of the text—in the beginning, at the end, or before or after certain characters in the cell.
        /// </summary>
        /// <param name="request">Request. <see cref="AddTextRequest" /></param>
        public   Stream  AddText(AddTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > AddTextAsync(AddTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ConvertText(ConvertTextRequest request, string LocalOutPath){
            var result = ConvertText(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Indicates converting the numbers stored as text into the correct number format, replacing unwanted characters and line breaks with the desired characters, and converting accented characters to their equivalent characters without accents.
        /// </summary>
        /// <param name="request">Request. <see cref="ConvertTextRequest" /></param>
        public   Stream  ConvertText(ConvertTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ConvertTextAsync(ConvertTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void ExtractText(ExtractTextRequest request, string LocalOutPath){
            var result = ExtractText(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Indicates extracting substrings, text characters, and numbers from a spreadsheet cell into another cell without having to use complex FIND, MIN, LEFT, or RIGHT formulas.
        /// </summary>
        /// <param name="request">Request. <see cref="ExtractTextRequest" /></param>
        public   Stream  ExtractText(ExtractTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > ExtractTextAsync(ExtractTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void SplitText(SplitTextRequest request, string LocalOutPath){
            var result = SplitText(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Indicates performing text segmentation on the specified area according to the segmentation method, and outputting to the designated interval.
        /// </summary>
        /// <param name="request">Request. <see cref="SplitTextRequest" /></param>
        public   Stream  SplitText(SplitTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > SplitTextAsync(SplitTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveSpreadsheetBlankRows(RemoveSpreadsheetBlankRowsRequest request, string LocalOutPath){
            var result = RemoveSpreadsheetBlankRows(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Delete all blank rows that do not contain any data or other objects.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveSpreadsheetBlankRowsRequest" /></param>
        public   Stream  RemoveSpreadsheetBlankRows(RemoveSpreadsheetBlankRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveSpreadsheetBlankRowsAsync(RemoveSpreadsheetBlankRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveSpreadsheetBlankColumns(RemoveSpreadsheetBlankColumnsRequest request, string LocalOutPath){
            var result = RemoveSpreadsheetBlankColumns(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Delete all blank rows that do not contain any data or other objects.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveSpreadsheetBlankColumnsRequest" /></param>
        public   Stream  RemoveSpreadsheetBlankColumns(RemoveSpreadsheetBlankColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveSpreadsheetBlankColumnsAsync(RemoveSpreadsheetBlankColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveSpreadsheetBlankWorksheets(RemoveSpreadsheetBlankWorksheetsRequest request, string LocalOutPath){
            var result = RemoveSpreadsheetBlankWorksheets(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Delete all blank rows that do not contain any data or other objects.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveSpreadsheetBlankWorksheetsRequest" /></param>
        public   Stream  RemoveSpreadsheetBlankWorksheets(RemoveSpreadsheetBlankWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveSpreadsheetBlankWorksheetsAsync(RemoveSpreadsheetBlankWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void RemoveDuplicates(RemoveDuplicatesRequest request, string LocalOutPath){
            var result = RemoveDuplicates(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Removes duplicate values in the worksheet/range/table.
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveDuplicatesRequest" /></param>
        public   Stream  RemoveDuplicates(RemoveDuplicatesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > RemoveDuplicatesAsync(RemoveDuplicatesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void SwapRange(SwapRangeRequest request, string LocalOutPath){
            var result = SwapRange(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// The Swap Ranges for Excel API provides a powerful tool to move any two columns, rows, ranges, or individual cells within an Excel file. This API allows users to re-arrange their tables quickly and efficiently, ensuring that the original data formatting is preserved and all existing formulas continue to function correctly. By leveraging this API, users can streamline their data manipulation tasks and maintain the integrity of their spreadsheets.
        /// </summary>
        /// <param name="request">Request. <see cref="SwapRangeRequest" /></param>
        public   Stream  SwapRange(SwapRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > SwapRangeAsync(SwapRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void FlipData(FlipDataRequest request, string LocalOutPath){
            var result = FlipData(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Transposes a specified data range (rows become columns, columns become rows).
        /// </summary>
        /// <param name="request">Request. <see cref="FlipDataRequest" /></param>
        public   Stream  FlipData(FlipDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > FlipDataAsync(FlipDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void TransposeData(TransposeDataRequest request, string LocalOutPath){
            var result = TransposeData(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Switch rows and columns in the spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="TransposeDataRequest" /></param>
        public   Stream  TransposeData(TransposeDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > TransposeDataAsync(TransposeDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void UnpivotRange(UnpivotRangeRequest request, string LocalOutPath){
            var result = UnpivotRange(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Switch rows and columns in the spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="UnpivotRangeRequest" /></param>
        public   Stream  UnpivotRange(UnpivotRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > UnpivotRangeAsync(UnpivotRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void UnpivotTable(UnpivotTableRequest request, string LocalOutPath){
            var result = UnpivotTable(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// Switch rows and columns in the spreadsheet.
        /// </summary>
        /// <param name="request">Request. <see cref="UnpivotTableRequest" /></param>
        public   Stream  UnpivotTable(UnpivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > UnpivotTableAsync(UnpivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }



        public void DownloadFile(DownloadFileRequest request, string LocalOutPath){
            var result = DownloadFile(request);
            using (Stream stream = File.OpenWrite(LocalOutPath))
            { 
                result.CopyTo(stream);
                result.Close();
                stream.Close();
            }
        }/// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        public   Stream  DownloadFile(DownloadFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > DownloadFileAsync(DownloadFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        public   FilesUploadResult  UploadFile(UploadFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesUploadResult  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesUploadResult  > UploadFileAsync(UploadFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesUploadResult  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        public  void  CopyFile(CopyFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task CopyFileAsync(CopyFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        public  void  MoveFile(MoveFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task MoveFileAsync(MoveFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        public  void  DeleteFile(DeleteFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task DeleteFileAsync(DeleteFileRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        public   FilesList  GetFilesList(GetFilesListRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesList  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesList  > GetFilesListAsync(GetFilesListRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesList  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        public  void  CreateFolder(CreateFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task CreateFolderAsync(CreateFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        public  void  CopyFolder(CopyFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task CopyFolderAsync(CopyFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        public  void  MoveFolder(MoveFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task MoveFolderAsync(MoveFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        public  void  DeleteFolder(DeleteFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return ;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>
        public async Task DeleteFolderAsync(DeleteFolderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers));
            return ;
        }



        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        public   StorageExist  StorageExists(StorageExistsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StorageExist  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   StorageExist  > StorageExistsAsync(StorageExistsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    StorageExist  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        public   ObjectExist  ObjectExists(ObjectExistsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ObjectExist  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ObjectExist  > ObjectExistsAsync(ObjectExistsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ObjectExist  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        public   DiscUsage  GetDiscUsage(GetDiscUsageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    DiscUsage  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   DiscUsage  > GetDiscUsageAsync(GetDiscUsageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    DiscUsage  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        public   FileVersions  GetFileVersions(GetFileVersionsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileVersions  >(request.CreateHttpRequest(BaseUri +"/v4.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileVersions  > GetFileVersionsAsync(GetFileVersionsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileVersions  >(request.CreateHttpRequest(BaseUri +"/v4.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Perform business analysis of data in Excel files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAnalyzeExcelRequest" /></param>
        public   IList<AnalyzedResult>  PostAnalyzeExcel(PostAnalyzeExcelRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    IList<AnalyzedResult>  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   IList<AnalyzedResult>  > PostAnalyzeExcelAsync(PostAnalyzeExcelRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    IList<AnalyzedResult>  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the description of auto filters from a worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetAutoFilterRequest" /></param>
        public   AutoFilterResponse  GetWorksheetAutoFilter(GetWorksheetAutoFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AutoFilterResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AutoFilterResponse  > GetWorksheetAutoFilterAsync(GetWorksheetAutoFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AutoFilterResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Apply a date filter in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetDateFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetDateFilter(PutWorksheetDateFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetDateFilterAsync(PutWorksheetDateFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a filter for a column in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFilter(PutWorksheetFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetFilterAsync(PutWorksheetFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add an icon filter in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetIconFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetIconFilter(PutWorksheetIconFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetIconFilterAsync(PutWorksheetIconFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Filter a list with custom criteria in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetCustomFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetCustomFilter(PutWorksheetCustomFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetCustomFilterAsync(PutWorksheetCustomFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a dynamic filter in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetDynamicFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetDynamicFilter(PutWorksheetDynamicFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetDynamicFilterAsync(PutWorksheetDynamicFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Filter the top 10 items in the list in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFilterTop10Request" /></param>
        public   CellsCloudResponse  PutWorksheetFilterTop10(PutWorksheetFilterTop10Request request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetFilterTop10Async(PutWorksheetFilterTop10Request request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a color filter in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetColorFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetColorFilter(PutWorksheetColorFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetColorFilterAsync(PutWorksheetColorFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Match all blank cells in the list.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetMatchBlanksRequest" /></param>
        public   CellsCloudResponse  PostWorksheetMatchBlanks(PostWorksheetMatchBlanksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetMatchBlanksAsync(PostWorksheetMatchBlanksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Match all not blank cells in the list.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetMatchNonBlanksRequest" /></param>
        public   CellsCloudResponse  PostWorksheetMatchNonBlanks(PostWorksheetMatchNonBlanksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetMatchNonBlanksAsync(PostWorksheetMatchNonBlanksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Refresh auto filters in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetAutoFilterRefreshRequest" /></param>
        public   CellsCloudResponse  PostWorksheetAutoFilterRefresh(PostWorksheetAutoFilterRefreshRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetAutoFilterRefreshAsync(PostWorksheetAutoFilterRefreshRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Remove a date filter in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetDateFilterRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetDateFilter(DeleteWorksheetDateFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetDateFilterAsync(DeleteWorksheetDateFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a filter for a column in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetFilterRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetFilter(DeleteWorksheetFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetFilterAsync(DeleteWorksheetFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get autoshapes description in worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetAutoshapesRequest" /></param>
        public   AutoShapesResponse  GetWorksheetAutoshapes(GetWorksheetAutoshapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AutoShapesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AutoShapesResponse  > GetWorksheetAutoshapesAsync(GetWorksheetAutoshapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AutoShapesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get autoshape description in some format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetAutoshapeWithFormatRequest" /></param>
        public   Stream  GetWorksheetAutoshapeWithFormat(GetWorksheetAutoshapeWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorksheetAutoshapeWithFormatAsync(GetWorksheetAutoshapeWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Batch converting files that meet specific matching conditions.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchConvertRequest" /></param>
        public   Stream  PostBatchConvert(PostBatchConvertRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostBatchConvertAsync(PostBatchConvertRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Batch protecting files that meet specific matching conditions.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchProtectRequest" /></param>
        public   Stream  PostBatchProtect(PostBatchProtectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostBatchProtectAsync(PostBatchProtectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Batch locking files that meet specific matching conditions.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchLockRequest" /></param>
        public   Stream  PostBatchLock(PostBatchLockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostBatchLockAsync(PostBatchLockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Batch unlocking files that meet specific matching conditions.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchUnlockRequest" /></param>
        public   Stream  PostBatchUnlock(PostBatchUnlockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostBatchUnlockAsync(PostBatchUnlockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Batch splitting files that meet specific matching conditions.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBatchSplitRequest" /></param>
        public   Stream  PostBatchSplit(PostBatchSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostBatchSplitAsync(PostBatchSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Clear cell area contents in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostClearContentsRequest" /></param>
        public   CellsCloudResponse  PostClearContents(PostClearContentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostClearContentsAsync(PostClearContentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Clear cell formats in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostClearFormatsRequest" /></param>
        public   CellsCloudResponse  PostClearFormats(PostClearFormatsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostClearFormatsAsync(PostClearFormatsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update cell range styles in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetRangeStyleRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetRangeStyle(PostUpdateWorksheetRangeStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUpdateWorksheetRangeStyleAsync(PostUpdateWorksheetRangeStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Merge cells in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetMergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetMerge(PostWorksheetMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetMergeAsync(PostWorksheetMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unmerge cells in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetUnmergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetUnmerge(PostWorksheetUnmergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetUnmergeAsync(PostWorksheetUnmergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve cell descriptions in a specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellsRequest" /></param>
        public   CellsResponse  GetWorksheetCells(GetWorksheetCellsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsResponse  > GetWorksheetCellsAsync(GetWorksheetCellsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve cell data using either cell reference or method name in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellRequest" /></param>
        public   string  GetWorksheetCell(GetWorksheetCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > GetWorksheetCellAsync(GetWorksheetCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve cell style descriptions in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellStyleRequest" /></param>
        public   StyleResponse  GetWorksheetCellStyle(GetWorksheetCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StyleResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   StyleResponse  > GetWorksheetCellStyleAsync(GetWorksheetCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    StyleResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set cell value using cell name in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellSetValueRequest" /></param>
        public   CellResponse  PostWorksheetCellSetValue(PostWorksheetCellSetValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellResponse  > PostWorksheetCellSetValueAsync(PostWorksheetCellSetValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set cell style using cell name in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetCellStyleRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetCellStyle(PostUpdateWorksheetCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUpdateWorksheetCellStyleAsync(PostUpdateWorksheetCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set the value of the range in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostSetCellRangeValueRequest" /></param>
        public   CellsCloudResponse  PostSetCellRangeValue(PostSetCellRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostSetCellRangeValueAsync(PostSetCellRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Copy data from a source cell to a destination cell in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyCellIntoCellRequest" /></param>
        public   CellsCloudResponse  PostCopyCellIntoCell(PostCopyCellIntoCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostCopyCellIntoCellAsync(PostCopyCellIntoCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the HTML string containing data and specific formats in this cell.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCellHtmlStringRequest" /></param>
        public   string  GetCellHtmlString(GetCellHtmlStringRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > GetCellHtmlStringAsync(GetCellHtmlStringRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set the HTML string containing data and specific formats in this cell.
        /// </summary>
        /// <param name="request">Request. <see cref="PostSetCellHtmlStringRequest" /></param>
        public   CellsCloudResponse  PostSetCellHtmlString(PostSetCellHtmlStringRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostSetCellHtmlStringAsync(PostSetCellHtmlStringRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Calculate cell formula in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCellCalculateRequest" /></param>
        public   CellsCloudResponse  PostCellCalculate(PostCellCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostCellCalculateAsync(PostCellCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set cell characters in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCellCharactersRequest" /></param>
        public   CellsCloudResponse  PostCellCharacters(PostCellCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostCellCharactersAsync(PostCellCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of worksheet columns.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetColumnsRequest" /></param>
        public   ColumnsResponse  GetWorksheetColumns(GetWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ColumnsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ColumnsResponse  > GetWorksheetColumnsAsync(GetWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ColumnsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set worksheet column width.
        /// </summary>
        /// <param name="request">Request. <see cref="PostSetWorksheetColumnWidthRequest" /></param>
        public   CellsCloudResponse  PostSetWorksheetColumnWidth(PostSetWorksheetColumnWidthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostSetWorksheetColumnWidthAsync(PostSetWorksheetColumnWidthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve worksheet column data by column index.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetColumnRequest" /></param>
        public   ColumnResponse  GetWorksheetColumn(GetWorksheetColumnRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ColumnResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ColumnResponse  > GetWorksheetColumnAsync(GetWorksheetColumnRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ColumnResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Insert worksheet columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PutInsertWorksheetColumns(PutInsertWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutInsertWorksheetColumnsAsync(PutInsertWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete worksheet columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetColumns(DeleteWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetColumnsAsync(DeleteWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Hide worksheet columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostHideWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostHideWorksheetColumns(PostHideWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostHideWorksheetColumnsAsync(PostHideWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unhide worksheet columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUnhideWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostUnhideWorksheetColumns(PostUnhideWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUnhideWorksheetColumnsAsync(PostUnhideWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Group worksheet columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostGroupWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostGroupWorksheetColumns(PostGroupWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostGroupWorksheetColumnsAsync(PostGroupWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Ungroup worksheet columns.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUngroupWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostUngroupWorksheetColumns(PostUngroupWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUngroupWorksheetColumnsAsync(PostUngroupWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Copy data from source columns to destination columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostCopyWorksheetColumns(PostCopyWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostCopyWorksheetColumnsAsync(PostCopyWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set column style in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostColumnStyleRequest" /></param>
        public   CellsCloudResponse  PostColumnStyle(PostColumnStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostColumnStyleAsync(PostColumnStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetRowsRequest" /></param>
        public   RowsResponse  GetWorksheetRows(GetWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RowsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   RowsResponse  > GetWorksheetRowsAsync(GetWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    RowsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve row data by the row's index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetRowRequest" /></param>
        public   RowResponse  GetWorksheetRow(GetWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RowResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   RowResponse  > GetWorksheetRowAsync(GetWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    RowResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a row in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetRowRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetRow(DeleteWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetRowAsync(DeleteWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete several rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetRows(DeleteWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetRowsAsync(DeleteWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Insert several new rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PutInsertWorksheetRows(PutInsertWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutInsertWorksheetRowsAsync(PutInsertWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Insert a new row in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertWorksheetRowRequest" /></param>
        public   CellsCloudResponse  PutInsertWorksheetRow(PutInsertWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutInsertWorksheetRowAsync(PutInsertWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update height of rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetRowRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetRow(PostUpdateWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUpdateWorksheetRowAsync(PostUpdateWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Hide rows in worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostHideWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostHideWorksheetRows(PostHideWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostHideWorksheetRowsAsync(PostHideWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unhide rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUnhideWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostUnhideWorksheetRows(PostUnhideWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUnhideWorksheetRowsAsync(PostUnhideWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Group rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostGroupWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostGroupWorksheetRows(PostGroupWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostGroupWorksheetRowsAsync(PostGroupWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Ungroup rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUngroupWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostUngroupWorksheetRows(PostUngroupWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUngroupWorksheetRowsAsync(PostUngroupWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Copy data and formats from specific entire rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostCopyWorksheetRows(PostCopyWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostCopyWorksheetRowsAsync(PostCopyWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Apply formats to an entire row in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRowStyleRequest" /></param>
        public   CellsCloudResponse  PostRowStyle(PostRowStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostRowStyleAsync(PostRowStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve cell descriptions in a specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCellsCloudServicesHealthCheckRequest" /></param>
        public   string  GetCellsCloudServicesHealthCheck(GetCellsCloudServicesHealthCheckRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > GetCellsCloudServicesHealthCheckAsync(GetCellsCloudServicesHealthCheckRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Aspose.Cells Cloud service health status check.
        /// </summary>
        /// <param name="request">Request. <see cref="GetCellsCloudServiceStatusRequest" /></param>
        public   string  GetCellsCloudServiceStatus(GetCellsCloudServiceStatusRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > GetCellsCloudServiceStatusAsync(GetCellsCloudServiceStatusRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart area description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartAreaRequest" /></param>
        public   ChartAreaResponse  GetChartArea(GetChartAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ChartAreaResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ChartAreaResponse  > GetChartAreaAsync(GetChartAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ChartAreaResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart area fill format description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartAreaFillFormatRequest" /></param>
        public   FillFormatResponse  GetChartAreaFillFormat(GetChartAreaFillFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FillFormatResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FillFormatResponse  > GetChartAreaFillFormatAsync(GetChartAreaFillFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FillFormatResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart area border description.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartAreaBorderRequest" /></param>
        public   LineResponse  GetChartAreaBorder(GetChartAreaBorderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    LineResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   LineResponse  > GetChartAreaBorderAsync(GetChartAreaBorderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    LineResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of charts in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartsRequest" /></param>
        public   ChartsResponse  GetWorksheetCharts(GetWorksheetChartsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ChartsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ChartsResponse  > GetWorksheetChartsAsync(GetWorksheetChartsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ChartsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the chart in a specified format.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartRequest" /></param>
        public   Stream  GetWorksheetChart(GetWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorksheetChartAsync(GetWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a new chart in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetChartRequest" /></param>
        public   CellsCloudResponse  PutWorksheetChart(PutWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetChartAsync(PutWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a chart by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetChartRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetChart(DeleteWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetChartAsync(DeleteWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart properties in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetChartRequest" /></param>
        public   CellsCloudResponse  PostWorksheetChart(PostWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetChartAsync(PostWorksheetChartRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart legend description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartLegendRequest" /></param>
        public   LegendResponse  GetWorksheetChartLegend(GetWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    LegendResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   LegendResponse  > GetWorksheetChartLegendAsync(GetWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    LegendResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart legend in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetChartLegendRequest" /></param>
        public   CellsCloudResponse  PostWorksheetChartLegend(PostWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetChartLegendAsync(PostWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Show chart legend in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetChartLegendRequest" /></param>
        public   CellsCloudResponse  PutWorksheetChartLegend(PutWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetChartLegendAsync(PutWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Hides chart legend in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetChartLegendRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetChartLegend(DeleteWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetChartLegendAsync(DeleteWorksheetChartLegendRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Clear the charts in the worksheets.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetChartsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetCharts(DeleteWorksheetChartsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetChartsAsync(DeleteWorksheetChartsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart title description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetChartTitleRequest" /></param>
        public   TitleResponse  GetWorksheetChartTitle(GetWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TitleResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   TitleResponse  > GetWorksheetChartTitleAsync(GetWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    TitleResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart title in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetChartTitleRequest" /></param>
        public   CellsCloudResponse  PostWorksheetChartTitle(PostWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetChartTitleAsync(PostWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set chart title in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetChartTitleRequest" /></param>
        public   CellsCloudResponse  PutWorksheetChartTitle(PutWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetChartTitleAsync(PutWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Hide chart title in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetChartTitleRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetChartTitle(DeleteWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetChartTitleAsync(DeleteWorksheetChartTitleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of chart seriesaxis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartSeriesAxisRequest" /></param>
        public   AxisResponse  GetChartSeriesAxis(GetChartSeriesAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AxisResponse  > GetChartSeriesAxisAsync(GetChartSeriesAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of chart series axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartCategoryAxisRequest" /></param>
        public   AxisResponse  GetChartCategoryAxis(GetChartCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AxisResponse  > GetChartCategoryAxisAsync(GetChartCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart value axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartValueAxisRequest" /></param>
        public   AxisResponse  GetChartValueAxis(GetChartValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AxisResponse  > GetChartValueAxisAsync(GetChartValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart second category axis in the chart
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartSecondCategoryAxisRequest" /></param>
        public   AxisResponse  GetChartSecondCategoryAxis(GetChartSecondCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AxisResponse  > GetChartSecondCategoryAxisAsync(GetChartSecondCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve chart second value axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="GetChartSecondValueAxisRequest" /></param>
        public   AxisResponse  GetChartSecondValueAxis(GetChartSecondValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   AxisResponse  > GetChartSecondValueAxisAsync(GetChartSecondValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    AxisResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart series axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSeriesAxisRequest" /></param>
        public   CellsCloudResponse  PostChartSeriesAxis(PostChartSeriesAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostChartSeriesAxisAsync(PostChartSeriesAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart category axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartCategoryAxisRequest" /></param>
        public   CellsCloudResponse  PostChartCategoryAxis(PostChartCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostChartCategoryAxisAsync(PostChartCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart value axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartValueAxisRequest" /></param>
        public   CellsCloudResponse  PostChartValueAxis(PostChartValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostChartValueAxisAsync(PostChartValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart sencond category axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSecondCategoryAxisRequest" /></param>
        public   CellsCloudResponse  PostChartSecondCategoryAxis(PostChartSecondCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostChartSecondCategoryAxisAsync(PostChartSecondCategoryAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update chart sencond value axis in the chart.
        /// </summary>
        /// <param name="request">Request. <see cref="PostChartSecondValueAxisRequest" /></param>
        public   CellsCloudResponse  PostChartSecondValueAxis(PostChartSecondValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostChartSecondValueAxisAsync(PostChartSecondValueAxisRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of conditional formattings in a worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetConditionalFormattingsRequest" /></param>
        public   ConditionalFormattingsResponse  GetWorksheetConditionalFormattings(GetWorksheetConditionalFormattingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ConditionalFormattingsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ConditionalFormattingsResponse  > GetWorksheetConditionalFormattingsAsync(GetWorksheetConditionalFormattingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ConditionalFormattingsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve conditional formatting descriptions in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetConditionalFormattingRequest" /></param>
        public   ConditionalFormattingResponse  GetWorksheetConditionalFormatting(GetWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ConditionalFormattingResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ConditionalFormattingResponse  > GetWorksheetConditionalFormattingAsync(GetWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ConditionalFormattingResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add conditional formatting in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetConditionalFormattingRequest" /></param>
        public   CellsCloudResponse  PutWorksheetConditionalFormatting(PutWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetConditionalFormattingAsync(PutWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a format condition in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFormatConditionRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFormatCondition(PutWorksheetFormatConditionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetFormatConditionAsync(PutWorksheetFormatConditionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a cell area for the format condition in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFormatConditionAreaRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFormatConditionArea(PutWorksheetFormatConditionAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetFormatConditionAreaAsync(PutWorksheetFormatConditionAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a condition for the format condition in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFormatConditionConditionRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFormatConditionCondition(PutWorksheetFormatConditionConditionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetFormatConditionConditionAsync(PutWorksheetFormatConditionConditionRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Clear all conditional formattings in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetConditionalFormattingsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetConditionalFormattings(DeleteWorksheetConditionalFormattingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetConditionalFormattingsAsync(DeleteWorksheetConditionalFormattingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Remove a conditional formatting.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetConditionalFormattingRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetConditionalFormatting(DeleteWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetConditionalFormattingAsync(DeleteWorksheetConditionalFormattingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Remove cell area from conditional formatting.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetConditionalFormattingAreaRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetConditionalFormattingArea(DeleteWorksheetConditionalFormattingAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetConditionalFormattingAreaAsync(DeleteWorksheetConditionalFormattingAreaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve workbooks in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookRequest" /></param>
        public   Stream  GetWorkbook(GetWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorkbookAsync(GetWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert the workbook from the requested content into files in different formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PutConvertWorkbookRequest" /></param>
        public   Stream  PutConvertWorkbook(PutConvertWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PutConvertWorkbookAsync(PutConvertWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Save an Excel file in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookSaveAsRequest" /></param>
        public   SaveResponse  PostWorkbookSaveAs(PostWorkbookSaveAsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SaveResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SaveResponse  > PostWorkbookSaveAsAsync(PostWorkbookSaveAsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SaveResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to PDF files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToPDFRequest" /></param>
        public   FileInfo  PostConvertWorkbookToPDF(PostConvertWorkbookToPDFRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToPDFAsync(PostConvertWorkbookToPDFRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to PNG files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToPNGRequest" /></param>
        public   FileInfo  PostConvertWorkbookToPNG(PostConvertWorkbookToPNGRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToPNGAsync(PostConvertWorkbookToPNGRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to Docx files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToDocxRequest" /></param>
        public   FileInfo  PostConvertWorkbookToDocx(PostConvertWorkbookToDocxRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToDocxAsync(PostConvertWorkbookToDocxRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to Pptx files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToPptxRequest" /></param>
        public   FileInfo  PostConvertWorkbookToPptx(PostConvertWorkbookToPptxRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToPptxAsync(PostConvertWorkbookToPptxRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to HTML files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToHtmlRequest" /></param>
        public   FileInfo  PostConvertWorkbookToHtml(PostConvertWorkbookToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToHtmlAsync(PostConvertWorkbookToHtmlRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to Markdown files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToMarkdownRequest" /></param>
        public   FileInfo  PostConvertWorkbookToMarkdown(PostConvertWorkbookToMarkdownRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToMarkdownAsync(PostConvertWorkbookToMarkdownRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to Json files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToJsonRequest" /></param>
        public   FileInfo  PostConvertWorkbookToJson(PostConvertWorkbookToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToJsonAsync(PostConvertWorkbookToJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to SQL Script files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToSQLRequest" /></param>
        public   FileInfo  PostConvertWorkbookToSQL(PostConvertWorkbookToSQLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToSQLAsync(PostConvertWorkbookToSQLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert Excel file to Csv files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookToCSVRequest" /></param>
        public   FileInfo  PostConvertWorkbookToCSV(PostConvertWorkbookToCSVRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookToCSVAsync(PostConvertWorkbookToCSVRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorksheetToImageRequest" /></param>
        public   FileInfo  PostConvertWorksheetToImage(PostConvertWorksheetToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorksheetToImageAsync(PostConvertWorksheetToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertWorkbookRequest" /></param>
        public   FileInfo  PostConvertWorkbook(PostConvertWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertWorkbookAsync(PostConvertWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Export Excel internal elements or the workbook itself to various format files.
        /// </summary>
        /// <param name="request">Request. <see cref="CheckWrokbookExternalReferenceRequest" /></param>
        public   CheckedExternalReferenceResponse  CheckWrokbookExternalReference(CheckWrokbookExternalReferenceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CheckedExternalReferenceResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CheckedExternalReferenceResponse  > CheckWrokbookExternalReferenceAsync(CheckWrokbookExternalReferenceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CheckedExternalReferenceResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="CheckWorkbookFormulaErrorsRequest" /></param>
        public   CheckedFormulaErrorsResponse  CheckWorkbookFormulaErrors(CheckWorkbookFormulaErrorsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CheckedFormulaErrorsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CheckedFormulaErrorsResponse  > CheckWorkbookFormulaErrorsAsync(CheckWorkbookFormulaErrorsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CheckedFormulaErrorsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Export Excel internal elements or the workbook itself to various format files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostExportRequest" /></param>
        public   FilesResult  PostExport(PostExportRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostExportAsync(PostExportRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Export XML data from an Excel file.
        /// When there are XML Maps in an Excel file, export XML data. When there is no XML map in the Excel file, convert the Excel file to an XML file.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookExportXMLRequest" /></param>
        public   Stream  PostWorkbookExportXML(PostWorkbookExportXMLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostWorkbookExportXMLAsync(PostWorkbookExportXMLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Import a JSON data file into the workbook. The JSON data file can either be a cloud file or data from an HTTP URI.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookImportJsonRequest" /></param>
        public   Stream  PostWorkbookImportJson(PostWorkbookImportJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostWorkbookImportJsonAsync(PostWorkbookImportJsonRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Import an XML data file into an Excel file. The XML data file can either be a cloud file or data from an HTTP URI.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookImportXMLRequest" /></param>
        public   Stream  PostWorkbookImportXML(PostWorkbookImportXMLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostWorkbookImportXMLAsync(PostWorkbookImportXMLRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Import data into the Excel file.
        /// </summary>
        /// <param name="request">Request. <see cref="PostImportDataRequest" /></param>
        public   CellsCloudResponse  PostImportData(PostImportDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostImportDataAsync(PostImportDataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Data cleaning of spreadsheet files is a data management process used to identify, correct, and remove errors, incompleteness, duplicates, or inaccuracies in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookDataCleansingRequest" /></param>
        public   FileInfo  PostWorkbookDataCleansing(PostWorkbookDataCleansingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostWorkbookDataCleansingAsync(PostWorkbookDataCleansingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Data cleansing of spreadsheet files is a data management process used to identify, correct, and remove errors, incompleteness, duplicates, or inaccuracies in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostDataCleansingRequest" /></param>
        public   FileInfo  PostDataCleansing(PostDataCleansingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostDataCleansingAsync(PostDataCleansingRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Data deduplication of spreadsheet files is mainly used to eliminate duplicate data in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookDataDeduplicationRequest" /></param>
        public   FileInfo  PostWorkbookDataDeduplication(PostWorkbookDataDeduplicationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostWorkbookDataDeduplicationAsync(PostWorkbookDataDeduplicationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Data deduplication of spreadsheet files is mainly used to eliminate duplicate data in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostDataDeduplicationRequest" /></param>
        public   FileInfo  PostDataDeduplication(PostDataDeduplicationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostDataDeduplicationAsync(PostDataDeduplicationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Data filling for spreadsheet files is primarily used to fill empty data in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookDataFillRequest" /></param>
        public   FileInfo  PostWorkbookDataFill(PostWorkbookDataFillRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostWorkbookDataFillAsync(PostWorkbookDataFillRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Data filling for spreadsheet files is primarily used to fill empty data in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostDataFillRequest" /></param>
        public   FileInfo  PostDataFill(PostDataFillRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostDataFillAsync(PostDataFillRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Deleting incomplete rows of spreadsheet files is mainly used to eliminate incomplete rows in tables and ranges.
        /// </summary>
        /// <param name="request">Request. <see cref="PostDeleteIncompleteRowsRequest" /></param>
        public   FileInfo  PostDeleteIncompleteRows(PostDeleteIncompleteRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostDeleteIncompleteRowsAsync(PostDeleteIncompleteRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Transform spreadsheet data is mainly used to pivot columns, unpivot columns.
        /// </summary>
        /// <param name="request">Request. <see cref="PostDataTransformationRequest" /></param>
        public   FileInfo  PostDataTransformation(PostDataTransformationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostDataTransformationAsync(PostDataTransformationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of hyperlinks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetHyperlinksRequest" /></param>
        public   HyperlinksResponse  GetWorksheetHyperlinks(GetWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HyperlinksResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   HyperlinksResponse  > GetWorksheetHyperlinksAsync(GetWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    HyperlinksResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve hyperlink description by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetHyperlinkRequest" /></param>
        public   HyperlinkResponse  GetWorksheetHyperlink(GetWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HyperlinkResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   HyperlinkResponse  > GetWorksheetHyperlinkAsync(GetWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    HyperlinkResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete hyperlink by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetHyperlinkRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetHyperlink(DeleteWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetHyperlinkAsync(DeleteWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update hyperlink by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetHyperlinkRequest" /></param>
        public   CellsCloudResponse  PostWorksheetHyperlink(PostWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetHyperlinkAsync(PostWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add hyperlink in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetHyperlinkRequest" /></param>
        public   CellsCloudResponse  PutWorksheetHyperlink(PutWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetHyperlinkAsync(PutWorksheetHyperlinkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all hyperlinks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetHyperlinksRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetHyperlinks(DeleteWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetHyperlinksAsync(DeleteWorksheetHyperlinksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Assemble data files with template files to generate files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAssembleRequest" /></param>
        public   FilesResult  PostAssemble(PostAssembleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostAssembleAsync(PostAssembleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Compress files and generate target files in various formats, supported file formats are include Xls, Xlsx, Xlsm, Xlsb, Ods and more.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCompressRequest" /></param>
        public   FilesResult  PostCompress(PostCompressRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostCompressAsync(PostCompressRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Merge cells in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostMergeRequest" /></param>
        public   FileInfo  PostMerge(PostMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostMergeAsync(PostMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Split Excel spreadsheet files based on worksheets and create output files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostSplitRequest" /></param>
        public   FilesResult  PostSplit(PostSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostSplitAsync(PostSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search for specified text within Excel files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostSearchRequest" /></param>
        public   IList<TextItem>  PostSearch(PostSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    IList<TextItem>  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   IList<TextItem>  > PostSearchAsync(PostSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    IList<TextItem>  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Replace specified text with new text in Excel files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostReplaceRequest" /></param>
        public   FilesResult  PostReplace(PostReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostReplaceAsync(PostReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Import data into an Excel file and generate output files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostImportRequest" /></param>
        public   FilesResult  PostImport(PostImportRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostImportAsync(PostImportRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add Text Watermark to Excel files and generate output files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWatermarkRequest" /></param>
        public   FilesResult  PostWatermark(PostWatermarkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostWatermarkAsync(PostWatermarkRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Clear internal elements in Excel files and generate output files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostClearObjectsRequest" /></param>
        public   FilesResult  PostClearObjects(PostClearObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostClearObjectsAsync(PostClearObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Reverse rows or columns in Excel files and create output files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostReverseRequest" /></param>
        public   FilesResult  PostReverse(PostReverseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostReverseAsync(PostReverseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Repair abnormal files and generate files in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRepairRequest" /></param>
        public   FilesResult  PostRepair(PostRepairRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostRepairAsync(PostRepairRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Rotate rows, columns, or other objects in Excel files and save them in various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRotateRequest" /></param>
        public   FilesResult  PostRotate(PostRotateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostRotateAsync(PostRotateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update document properties in Excel file, and save them is various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="PostMetadataRequest" /></param>
        public   FilesResult  PostMetadata(PostMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostMetadataAsync(PostMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get cells document properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetMetadataRequest" /></param>
        public   IList<CellsDocumentProperty>  GetMetadata(GetMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    IList<CellsDocumentProperty>  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   IList<CellsDocumentProperty>  > GetMetadataAsync(GetMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    IList<CellsDocumentProperty>  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete cells document properties in Excel file, and save them is various formats.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteMetadataRequest" /></param>
        public   FilesResult  DeleteMetadata(DeleteMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > DeleteMetadataAsync(DeleteMetadataRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of ListObjects in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetListObjectsRequest" /></param>
        public   ListObjectsResponse  GetWorksheetListObjects(GetWorksheetListObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ListObjectsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ListObjectsResponse  > GetWorksheetListObjectsAsync(GetWorksheetListObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ListObjectsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve list object description by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetListObjectRequest" /></param>
        public   Stream  GetWorksheetListObject(GetWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorksheetListObjectAsync(GetWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a ListObject in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetListObjectRequest" /></param>
        public   CellsCloudResponse  PutWorksheetListObject(PutWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetListObjectAsync(PutWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete ListObjects in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetListObjectsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetListObjects(DeleteWorksheetListObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetListObjectsAsync(DeleteWorksheetListObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete list object by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetListObjectRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetListObject(DeleteWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetListObjectAsync(DeleteWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update list object by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObject(PostWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListObjectAsync(PostWorksheetListObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Convert list object to range in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectConvertToRangeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectConvertToRange(PostWorksheetListObjectConvertToRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListObjectConvertToRangeAsync(PostWorksheetListObjectConvertToRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Create a pivot table with a list object in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectSummarizeWithPivotTableRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectSummarizeWithPivotTable(PostWorksheetListObjectSummarizeWithPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListObjectSummarizeWithPivotTableAsync(PostWorksheetListObjectSummarizeWithPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Sort list object in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectSortTableRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectSortTable(PostWorksheetListObjectSortTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListObjectSortTableAsync(PostWorksheetListObjectSortTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Remove duplicates in list object.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectRemoveDuplicatesRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectRemoveDuplicates(PostWorksheetListObjectRemoveDuplicatesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListObjectRemoveDuplicatesAsync(PostWorksheetListObjectRemoveDuplicatesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Insert slicer for list object.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListObjectInsertSlicerRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListObjectInsertSlicer(PostWorksheetListObjectInsertSlicerRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListObjectInsertSlicerAsync(PostWorksheetListObjectInsertSlicerRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update list column in list object.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListColumnRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListColumn(PostWorksheetListColumnRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListColumnAsync(PostWorksheetListColumnRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update total of list columns in the table.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetListColumnsTotalRequest" /></param>
        public   CellsCloudResponse  PostWorksheetListColumnsTotal(PostWorksheetListColumnsTotalRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetListColumnsTotalAsync(PostWorksheetListColumnsTotalRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of OLE objects in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetOleObjectsRequest" /></param>
        public   OleObjectsResponse  GetWorksheetOleObjects(GetWorksheetOleObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    OleObjectsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   OleObjectsResponse  > GetWorksheetOleObjectsAsync(GetWorksheetOleObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    OleObjectsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the OLE object in a specified format in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetOleObjectRequest" /></param>
        public   Stream  GetWorksheetOleObject(GetWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorksheetOleObjectAsync(GetWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all OLE objects in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetOleObjectsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetOleObjects(DeleteWorksheetOleObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetOleObjectsAsync(DeleteWorksheetOleObjectsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete an OLE object in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetOleObjectRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetOleObject(DeleteWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetOleObjectAsync(DeleteWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update an OLE object in worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetOleObjectRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetOleObject(PostUpdateWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUpdateWorksheetOleObjectAsync(PostUpdateWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add an OLE object in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetOleObjectRequest" /></param>
        public   CellsCloudResponse  PutWorksheetOleObject(PutWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetOleObjectAsync(PutWorksheetOleObjectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of vertical page breaks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetVerticalPageBreaksRequest" /></param>
        public   VerticalPageBreaksResponse  GetVerticalPageBreaks(GetVerticalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    VerticalPageBreaksResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   VerticalPageBreaksResponse  > GetVerticalPageBreaksAsync(GetVerticalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    VerticalPageBreaksResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of horizontal page breaks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHorizontalPageBreaksRequest" /></param>
        public   HorizontalPageBreaksResponse  GetHorizontalPageBreaks(GetHorizontalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HorizontalPageBreaksResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   HorizontalPageBreaksResponse  > GetHorizontalPageBreaksAsync(GetHorizontalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    HorizontalPageBreaksResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve a vertical page break description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetVerticalPageBreakRequest" /></param>
        public   VerticalPageBreakResponse  GetVerticalPageBreak(GetVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    VerticalPageBreakResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   VerticalPageBreakResponse  > GetVerticalPageBreakAsync(GetVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    VerticalPageBreakResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve a horizontal page break descripton in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHorizontalPageBreakRequest" /></param>
        public   HorizontalPageBreakResponse  GetHorizontalPageBreak(GetHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    HorizontalPageBreakResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   HorizontalPageBreakResponse  > GetHorizontalPageBreakAsync(GetHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    HorizontalPageBreakResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a vertical page break in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutVerticalPageBreakRequest" /></param>
        public   CellsCloudResponse  PutVerticalPageBreak(PutVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutVerticalPageBreakAsync(PutVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a horizontal page breaks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutHorizontalPageBreakRequest" /></param>
        public   CellsCloudResponse  PutHorizontalPageBreak(PutHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutHorizontalPageBreakAsync(PutHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete vertical page breaks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteVerticalPageBreaksRequest" /></param>
        public   CellsCloudResponse  DeleteVerticalPageBreaks(DeleteVerticalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteVerticalPageBreaksAsync(DeleteVerticalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete horizontal page breaks in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHorizontalPageBreaksRequest" /></param>
        public   CellsCloudResponse  DeleteHorizontalPageBreaks(DeleteHorizontalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteHorizontalPageBreaksAsync(DeleteHorizontalPageBreaksRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a vertical page break in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteVerticalPageBreakRequest" /></param>
        public   CellsCloudResponse  DeleteVerticalPageBreak(DeleteVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteVerticalPageBreakAsync(DeleteVerticalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a horizontal page break in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHorizontalPageBreakRequest" /></param>
        public   CellsCloudResponse  DeleteHorizontalPageBreak(DeleteHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteHorizontalPageBreakAsync(DeleteHorizontalPageBreakRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve page setup description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetPageSetupRequest" /></param>
        public   PageSetupResponse  GetPageSetup(GetPageSetupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PageSetupResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PageSetupResponse  > GetPageSetupAsync(GetPageSetupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PageSetupResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update page setup in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPageSetupRequest" /></param>
        public   CellsCloudResponse  PostPageSetup(PostPageSetupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPageSetupAsync(PostPageSetupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Clear header and footer in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteHeaderFooterRequest" /></param>
        public   CellsCloudResponse  DeleteHeaderFooter(DeleteHeaderFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteHeaderFooterAsync(DeleteHeaderFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve page header description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetHeaderRequest" /></param>
        public   PageSectionsResponse  GetHeader(GetHeaderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PageSectionsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PageSectionsResponse  > GetHeaderAsync(GetHeaderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PageSectionsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update page header in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostHeaderRequest" /></param>
        public   CellsCloudResponse  PostHeader(PostHeaderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostHeaderAsync(PostHeaderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve page footer description in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetFooterRequest" /></param>
        public   PageSectionsResponse  GetFooter(GetFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PageSectionsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PageSectionsResponse  > GetFooterAsync(GetFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PageSectionsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update page footer in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostFooterRequest" /></param>
        public   CellsCloudResponse  PostFooter(PostFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostFooterAsync(PostFooterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set the scale at which the page will fit wide when printed on the sheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostFitWideToPagesRequest" /></param>
        public   CellsCloudResponse  PostFitWideToPages(PostFitWideToPagesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostFitWideToPagesAsync(PostFitWideToPagesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set the scale at which the page will fit tall when printed on the sheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostFitTallToPagesRequest" /></param>
        public   CellsCloudResponse  PostFitTallToPages(PostFitTallToPagesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostFitTallToPagesAsync(PostFitTallToPagesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of pictures in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPicturesRequest" /></param>
        public   PicturesResponse  GetWorksheetPictures(GetWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PicturesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PicturesResponse  > GetWorksheetPicturesAsync(GetWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PicturesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve a picture by number in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPictureWithFormatRequest" /></param>
        public   Stream  GetWorksheetPictureWithFormat(GetWorksheetPictureWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorksheetPictureWithFormatAsync(GetWorksheetPictureWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a new picture in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetAddPictureRequest" /></param>
        public   CellsCloudResponse  PutWorksheetAddPicture(PutWorksheetAddPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetAddPictureAsync(PutWorksheetAddPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// add new picture in the cells.
        /// </summary>
        /// <param name="request">Request. <see cref="AddPictureInCellRequest" /></param>
        public   CellsCloudResponse  AddPictureInCell(AddPictureInCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > AddPictureInCellAsync(AddPictureInCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update a picture by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetPictureRequest" /></param>
        public   CellsCloudResponse  PostWorksheetPicture(PostWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetPictureAsync(PostWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a picture object by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPictureRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPicture(DeleteWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetPictureAsync(DeleteWorksheetPictureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all pictures in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPicturesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPictures(DeleteWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetPicturesAsync(DeleteWorksheetPicturesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of pivottables  in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTablesRequest" /></param>
        public   PivotTablesResponse  GetWorksheetPivotTables(GetWorksheetPivotTablesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotTablesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PivotTablesResponse  > GetWorksheetPivotTablesAsync(GetWorksheetPivotTablesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PivotTablesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve PivotTable information by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTableRequest" /></param>
        public   PivotTableResponse  GetWorksheetPivotTable(GetWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotTableResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PivotTableResponse  > GetWorksheetPivotTableAsync(GetWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PivotTableResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of pivot fields in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="GetPivotTableFieldRequest" /></param>
        public   PivotFieldResponse  GetPivotTableField(GetPivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotFieldResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PivotFieldResponse  > GetPivotTableFieldAsync(GetPivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PivotFieldResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Gets PivotTable filters in worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTableFiltersRequest" /></param>
        public   PivotFiltersResponse  GetWorksheetPivotTableFilters(GetWorksheetPivotTableFiltersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotFiltersResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PivotFiltersResponse  > GetWorksheetPivotTableFiltersAsync(GetWorksheetPivotTableFiltersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PivotFiltersResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve PivotTable filters in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPivotTableFilterRequest" /></param>
        public   PivotFilterResponse  GetWorksheetPivotTableFilter(GetWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    PivotFilterResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   PivotFilterResponse  > GetWorksheetPivotTableFilterAsync(GetWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    PivotFilterResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a PivotTable in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetPivotTableRequest" /></param>
        public   CellsCloudResponse  PutWorksheetPivotTable(PutWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetPivotTableAsync(PutWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a pivot field in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PutPivotTableFieldRequest" /></param>
        public   CellsCloudResponse  PutPivotTableField(PutPivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutPivotTableFieldAsync(PutPivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a pivot filter to the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetPivotTableFilterRequest" /></param>
        public   CellsCloudResponse  PutWorksheetPivotTableFilter(PutWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetPivotTableFilterAsync(PutWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Hide a pivot field item in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableFieldHideItemRequest" /></param>
        public   CellsCloudResponse  PostPivotTableFieldHideItem(PostPivotTableFieldHideItemRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPivotTableFieldHideItemAsync(PostPivotTableFieldHideItemRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Move a pivot field in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableFieldMoveToRequest" /></param>
        public   CellsCloudResponse  PostPivotTableFieldMoveTo(PostPivotTableFieldMoveToRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPivotTableFieldMoveToAsync(PostPivotTableFieldMoveToRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update cell style in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableCellStyleRequest" /></param>
        public   CellsCloudResponse  PostPivotTableCellStyle(PostPivotTableCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPivotTableCellStyleAsync(PostPivotTableCellStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update style in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableStyleRequest" /></param>
        public   CellsCloudResponse  PostPivotTableStyle(PostPivotTableStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPivotTableStyleAsync(PostPivotTableStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update pivot fields in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableUpdatePivotFieldsRequest" /></param>
        public   CellsCloudResponse  PostPivotTableUpdatePivotFields(PostPivotTableUpdatePivotFieldsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPivotTableUpdatePivotFieldsAsync(PostPivotTableUpdatePivotFieldsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update pivot field in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="PostPivotTableUpdatePivotFieldRequest" /></param>
        public   CellsCloudResponse  PostPivotTableUpdatePivotField(PostPivotTableUpdatePivotFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostPivotTableUpdatePivotFieldAsync(PostPivotTableUpdatePivotFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Calculate pivottable's data to cells.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetPivotTableCalculateRequest" /></param>
        public   CellsCloudResponse  PostWorksheetPivotTableCalculate(PostWorksheetPivotTableCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetPivotTableCalculateAsync(PostWorksheetPivotTableCalculateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Move PivotTable in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetPivotTableMoveRequest" /></param>
        public   CellsCloudResponse  PostWorksheetPivotTableMove(PostWorksheetPivotTableMoveRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetPivotTableMoveAsync(PostWorksheetPivotTableMoveRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete PivotTables in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTablesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTables(DeleteWorksheetPivotTablesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetPivotTablesAsync(DeleteWorksheetPivotTablesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete PivotTable by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTableRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTable(DeleteWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetPivotTableAsync(DeleteWorksheetPivotTableRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a pivot field in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePivotTableFieldRequest" /></param>
        public   CellsCloudResponse  DeletePivotTableField(DeletePivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeletePivotTableFieldAsync(DeletePivotTableFieldRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all pivot filters in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTableFiltersRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTableFilters(DeleteWorksheetPivotTableFiltersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetPivotTableFiltersAsync(DeleteWorksheetPivotTableFiltersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a pivot filter in the PivotTable.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetPivotTableFilterRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetPivotTableFilter(DeleteWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetPivotTableFilterAsync(DeleteWorksheetPivotTableFilterRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of Excel file properties.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param>
        public   CellsDocumentPropertiesResponse  GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsDocumentPropertiesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsDocumentPropertiesResponse  > GetDocumentPropertiesAsync(GetDocumentPropertiesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsDocumentPropertiesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set or add an Excel property.
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentPropertyRequest" /></param>
        public   CellsCloudResponse  PutDocumentProperty(PutDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutDocumentPropertyAsync(PutDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get Excel property by name.
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param>
        public   CellsDocumentPropertyResponse  GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsDocumentPropertyResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsDocumentPropertyResponse  > GetDocumentPropertyAsync(GetDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsDocumentPropertyResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete an Excel property.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertyRequest" /></param>
        public   CellsCloudResponse  DeleteDocumentProperty(DeleteDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteDocumentPropertyAsync(DeleteDocumentPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all custom document properties and reset built-in ones.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentPropertiesRequest" /></param>
        public   CellsCloudResponse  DeleteDocumentProperties(DeleteDocumentPropertiesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteDocumentPropertiesAsync(DeleteDocumentPropertiesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel file digital signature.
        /// </summary>
        /// <param name="request">Request. <see cref="PostDigitalSignatureRequest" /></param>
        public   CellsCloudResponse  PostDigitalSignature(PostDigitalSignatureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostDigitalSignatureAsync(PostDigitalSignatureRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel Encryption.
        /// </summary>
        /// <param name="request">Request. <see cref="PostEncryptWorkbookRequest" /></param>
        public   CellsCloudResponse  PostEncryptWorkbook(PostEncryptWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostEncryptWorkbookAsync(PostEncryptWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel files decryption.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDecryptWorkbookRequest" /></param>
        public   CellsCloudResponse  DeleteDecryptWorkbook(DeleteDecryptWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteDecryptWorkbookAsync(DeleteDecryptWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel protection.
        /// </summary>
        /// <param name="request">Request. <see cref="PostProtectWorkbookRequest" /></param>
        public   CellsCloudResponse  PostProtectWorkbook(PostProtectWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostProtectWorkbookAsync(PostProtectWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel unprotection.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteUnProtectWorkbookRequest" /></param>
        public   CellsCloudResponse  DeleteUnProtectWorkbook(DeleteUnProtectWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteUnProtectWorkbookAsync(DeleteUnProtectWorkbookRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel file write protection.
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentProtectFromChangesRequest" /></param>
        public   CellsCloudResponse  PutDocumentProtectFromChanges(PutDocumentProtectFromChangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutDocumentProtectFromChangesAsync(PutDocumentProtectFromChangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel file cancel write protection.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteDocumentUnProtectFromChangesRequest" /></param>
        public   CellsCloudResponse  DeleteDocumentUnProtectFromChanges(DeleteDocumentUnProtectFromChangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteDocumentUnProtectFromChangesAsync(DeleteDocumentUnProtectFromChangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unlock Excel files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUnlockRequest" /></param>
        public   FilesResult  PostUnlock(PostUnlockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostUnlockAsync(PostUnlockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Lock Excel files.
        /// </summary>
        /// <param name="request">Request. <see cref="PostLockRequest" /></param>
        public   FilesResult  PostLock(PostLockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostLockAsync(PostLockRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Excel files encryption.
        /// </summary>
        /// <param name="request">Request. <see cref="PostProtectRequest" /></param>
        public   FilesResult  PostProtect(PostProtectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FilesResult  > PostProtectAsync(PostProtectRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FilesResult  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Copy content from the source range to the destination range in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangesCopyRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangesCopy(PostWorksheetCellsRangesCopyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangesCopyAsync(PostWorksheetCellsRangesCopyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Merge a range of cells into a single cell.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeMergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeMerge(PostWorksheetCellsRangeMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeMergeAsync(PostWorksheetCellsRangeMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unmerge merged cells within this range.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeUnMergeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeUnMerge(PostWorksheetCellsRangeUnMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeUnMergeAsync(PostWorksheetCellsRangeUnMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set the style for the specified range.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeStyleRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeStyle(PostWorksheetCellsRangeStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeStyleAsync(PostWorksheetCellsRangeStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the values of cells within the specified range.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCellsRangeValueRequest" /></param>
        public   RangeValueResponse  GetWorksheetCellsRangeValue(GetWorksheetCellsRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   RangeValueResponse  > GetWorksheetCellsRangeValueAsync(GetWorksheetCellsRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Assign a value to the range; if necessary, the value will be converted to another data type, and the cell's number format will be reset.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeValueRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeValue(PostWorksheetCellsRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeValueAsync(PostWorksheetCellsRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Move the current range to the destination range.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeMoveToRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeMoveTo(PostWorksheetCellsRangeMoveToRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeMoveToAsync(PostWorksheetCellsRangeMoveToRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Perform data sorting around a range of cells.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeSortRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeSort(PostWorksheetCellsRangeSortRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeSortAsync(PostWorksheetCellsRangeSortRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Apply an outline border around a range of cells.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeOutlineBorderRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeOutlineBorder(PostWorksheetCellsRangeOutlineBorderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeOutlineBorderAsync(PostWorksheetCellsRangeOutlineBorderRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set the column width of the specified range.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeColumnWidthRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeColumnWidth(PostWorksheetCellsRangeColumnWidthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeColumnWidthAsync(PostWorksheetCellsRangeColumnWidthRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Sets row height of range.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeRowHeightRequest" /></param>
        public   CellsCloudResponse  PostWorksheetCellsRangeRowHeight(PostWorksheetCellsRangeRowHeightRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCellsRangeRowHeightAsync(PostWorksheetCellsRangeRowHeightRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCellsRangeToImageRequest" /></param>
        public   Stream  PostWorksheetCellsRangeToImage(PostWorksheetCellsRangeToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostWorksheetCellsRangeToImageAsync(PostWorksheetCellsRangeToImageRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Insert a range of cells and shift existing cells based on the specified shift option.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetCellsRangeRequest" /></param>
        public   CellsCloudResponse  PutWorksheetCellsRange(PutWorksheetCellsRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetCellsRangeAsync(PutWorksheetCellsRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a range of cells and shift existing cells based on the specified shift option.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetCellsRangeRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetCellsRange(DeleteWorksheetCellsRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetCellsRangeAsync(DeleteWorksheetCellsRangeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of shapes in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetShapesRequest" /></param>
        public   ShapesResponse  GetWorksheetShapes(GetWorksheetShapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ShapesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ShapesResponse  > GetWorksheetShapesAsync(GetWorksheetShapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ShapesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve description of shape in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetShapeRequest" /></param>
        public   ShapeResponse  GetWorksheetShape(GetWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ShapeResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ShapeResponse  > GetWorksheetShapeAsync(GetWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ShapeResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a shape in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetShapeRequest" /></param>
        public   CellsCloudResponse  PutWorksheetShape(PutWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetShapeAsync(PutWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all shapes in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetShapesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetShapes(DeleteWorksheetShapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetShapesAsync(DeleteWorksheetShapesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a shape in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetShapeRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetShape(DeleteWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetShapeAsync(DeleteWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update a shape in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetShapeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetShape(PostWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetShapeAsync(PostWorksheetShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Group shapes in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetGroupShapeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetGroupShape(PostWorksheetGroupShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetGroupShapeAsync(PostWorksheetGroupShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Ungroup shapes in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetUngroupShapeRequest" /></param>
        public   CellsCloudResponse  PostWorksheetUngroupShape(PostWorksheetUngroupShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetUngroupShapeAsync(PostWorksheetUngroupShapeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of sparkline groups in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetSparklineGroupsRequest" /></param>
        public   SparklineGroupsResponse  GetWorksheetSparklineGroups(GetWorksheetSparklineGroupsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SparklineGroupsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SparklineGroupsResponse  > GetWorksheetSparklineGroupsAsync(GetWorksheetSparklineGroupsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SparklineGroupsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve description of a sparkline group in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetSparklineGroupRequest" /></param>
        public   SparklineGroupResponse  GetWorksheetSparklineGroup(GetWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SparklineGroupResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SparklineGroupResponse  > GetWorksheetSparklineGroupAsync(GetWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SparklineGroupResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete sparkline groups in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetSparklineGroupsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetSparklineGroups(DeleteWorksheetSparklineGroupsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetSparklineGroupsAsync(DeleteWorksheetSparklineGroupsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a sparkline group in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetSparklineGroupRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetSparklineGroup(DeleteWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetSparklineGroupAsync(DeleteWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a sparkline group in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetSparklineGroupRequest" /></param>
        public   CellsCloudResponse  PutWorksheetSparklineGroup(PutWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetSparklineGroupAsync(PutWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update a sparkline group in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetSparklineGroupRequest" /></param>
        public   CellsCloudResponse  PostWorksheetSparklineGroup(PostWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetSparklineGroupAsync(PostWorksheetSparklineGroupRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostCharacterCountRequest" /></param>
        public   string  PostCharacterCount(PostCharacterCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > PostCharacterCountAsync(PostCharacterCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostWordsCountRequest" /></param>
        public   string  PostWordsCount(PostWordsCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > PostWordsCountAsync(PostWordsCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// </summary>
        /// <param name="request">Request. <see cref="PostSpecifyWordsCountRequest" /></param>
        public   string  PostSpecifyWordsCount(PostSpecifyWordsCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   string  > PostSpecifyWordsCountAsync(PostSpecifyWordsCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Run tasks.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRunTaskRequest" /></param>
        public   Stream  PostRunTask(PostRunTaskRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostRunTaskAsync(PostRunTaskRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Adds text content to a specified location within a document. It requires an object that defines the text to be added and the insertion location.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAddTextContentRequest" /></param>
        public   FileInfo  PostAddTextContent(PostAddTextContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostAddTextContentAsync(PostAddTextContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// The PostTrimContent API is designed to process and trim content within a specified range in a spreadsheet. This API allows users to remove extra spaces, line breaks, or other unnecessary characters from the content of selected cells. It is particularly useful for cleaning up data entries and ensuring consistency in spreadsheet formatting
        /// </summary>
        /// <param name="request">Request. <see cref="PostTrimContentRequest" /></param>
        public   FileInfo  PostTrimContent(PostTrimContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostTrimContentAsync(PostTrimContentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Managing inconsistent text case in spreadsheets (Excel, Google Sheets, CSV) can be frustrating, especially with large datasets. The PostUpdateWordCase WEB API solves this by automating text case conversions, ensuring clean and standardized data.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWordCaseRequest" /></param>
        public   FileInfo  PostUpdateWordCase(PostUpdateWordCaseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostUpdateWordCaseAsync(PostUpdateWordCaseRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// A comprehensive set of tools for cleaning text content within selected cells. It allows users to remove specific characters, character sets, and substrings, ensuring that the text is standardized and free from unwanted symbols or sequences.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRemoveCharactersRequest" /></param>
        public   FileInfo  PostRemoveCharacters(PostRemoveCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostRemoveCharactersAsync(PostRemoveCharactersRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Enhance Excel data through essential text conversions: convert text to numbers, replace characters and line breaks, and remove accents.
        /// </summary>
        /// <param name="request">Request. <see cref="PostConvertTextRequest" /></param>
        public   FileInfo  PostConvertText(PostConvertTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostConvertTextAsync(PostConvertTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Efficiently remove duplicate substrings from Excel cells. Select a range, specify delimiters, and apply options to eliminate repeated text segments.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRemoveDuplicatesRequest" /></param>
        public   FileInfo  PostRemoveDuplicates(PostRemoveDuplicatesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostRemoveDuplicatesAsync(PostRemoveDuplicatesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Effortlessly extract text and numbers from Excel cells with precise options. This API allows extraction of first/last characters, text between delimiters, and numbers from strings, with output as static values or formulas.
        /// </summary>
        /// <param name="request">Request. <see cref="PostExtractTextRequest" /></param>
        public   FileInfo  PostExtractText(PostExtractTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostExtractTextAsync(PostExtractTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Efficiently divides Excel cell content into columns or rows based on specified delimiters or patterns. Supports Character-based splitting, Custom string splitting, Mask and wildcard splitting for pattern-based division, Line break division, Column or row splitting, Delimiter removal or retention.
        /// </summary>
        /// <param name="request">Request. <see cref="PostSplitTextRequest" /></param>
        public   FileInfo  PostSplitText(PostSplitTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   FileInfo  > PostSplitTextAsync(PostSplitTextRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    FileInfo  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the description of the default style for the workbook .
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookDefaultStyleRequest" /></param>
        public   StyleResponse  GetWorkbookDefaultStyle(GetWorkbookDefaultStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StyleResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   StyleResponse  > GetWorkbookDefaultStyleAsync(GetWorkbookDefaultStyleRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    StyleResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve text items in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookTextItemsRequest" /></param>
        public   TextItemsResponse  GetWorkbookTextItems(GetWorkbookTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   TextItemsResponse  > GetWorkbookTextItemsAsync(GetWorkbookTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve named ranges in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookNamesRequest" /></param>
        public   NamesResponse  GetWorkbookNames(GetWorkbookNamesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    NamesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   NamesResponse  > GetWorkbookNamesAsync(GetWorkbookNamesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    NamesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Define a new name in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookNameRequest" /></param>
        public   CellsCloudResponse  PutWorkbookName(PutWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorkbookNameAsync(PutWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve description of a named range in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookNameRequest" /></param>
        public   NameResponse  GetWorkbookName(GetWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    NameResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   NameResponse  > GetWorkbookNameAsync(GetWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    NameResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update a named range in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookNameRequest" /></param>
        public   CellsCloudResponse  PostWorkbookName(PostWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorkbookNameAsync(PostWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the value of a named range in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookNameValueRequest" /></param>
        public   RangeValueResponse  GetWorkbookNameValue(GetWorkbookNameValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   RangeValueResponse  > GetWorkbookNameValueAsync(GetWorkbookNameValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all named ranges in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorkbookNamesRequest" /></param>
        public   CellsCloudResponse  DeleteWorkbookNames(DeleteWorkbookNamesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorkbookNamesAsync(DeleteWorkbookNamesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a named range in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorkbookNameRequest" /></param>
        public   CellsCloudResponse  DeleteWorkbookName(DeleteWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorkbookNameAsync(DeleteWorkbookNameRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Merge a workbook into the existing workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbooksMergeRequest" /></param>
        public   WorkbookResponse  PostWorkbooksMerge(PostWorkbooksMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorkbookResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   WorkbookResponse  > PostWorkbooksMergeAsync(PostWorkbooksMergeRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    WorkbookResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search for text in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbooksTextSearchRequest" /></param>
        public   TextItemsResponse  PostWorkbooksTextSearch(PostWorkbooksTextSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   TextItemsResponse  > PostWorkbooksTextSearchAsync(PostWorkbooksTextSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Replace text in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookTextReplaceRequest" /></param>
        public   WorkbookReplaceResponse  PostWorkbookTextReplace(PostWorkbookTextReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorkbookReplaceResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   WorkbookReplaceResponse  > PostWorkbookTextReplaceAsync(PostWorkbookTextReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    WorkbookReplaceResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Smart marker processing.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookGetSmartMarkerResultRequest" /></param>
        public   Stream  PostWorkbookGetSmartMarkerResult(PostWorkbookGetSmartMarkerResultRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > PostWorkbookGetSmartMarkerResultAsync(PostWorkbookGetSmartMarkerResultRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Create a new workbook using different methods.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookCreateRequest" /></param>
        public   CellsCloudResponse  PutWorkbookCreate(PutWorkbookCreateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorkbookCreateAsync(PutWorkbookCreateRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Split the workbook with a specific format.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookSplitRequest" /></param>
        public   SplitResultResponse  PostWorkbookSplit(PostWorkbookSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SplitResultResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SplitResultResponse  > PostWorkbookSplitAsync(PostWorkbookSplitRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SplitResultResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Calculate all formulas in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookCalculateFormulaRequest" /></param>
        public   CellsCloudResponse  PostWorkbookCalculateFormula(PostWorkbookCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorkbookCalculateFormulaAsync(PostWorkbookCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Autofit rows in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorkbookRowsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorkbookRows(PostAutofitWorkbookRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostAutofitWorkbookRowsAsync(PostAutofitWorkbookRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Autofit columns in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorkbookColumnsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorkbookColumns(PostAutofitWorkbookColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostAutofitWorkbookColumnsAsync(PostAutofitWorkbookColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of workbook settings.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorkbookSettingsRequest" /></param>
        public   WorkbookSettingsResponse  GetWorkbookSettings(GetWorkbookSettingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorkbookSettingsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   WorkbookSettingsResponse  > GetWorkbookSettingsAsync(GetWorkbookSettingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    WorkbookSettingsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update setting in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorkbookSettingsRequest" /></param>
        public   CellsCloudResponse  PostWorkbookSettings(PostWorkbookSettingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorkbookSettingsAsync(PostWorkbookSettingsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set background in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookBackgroundRequest" /></param>
        public   CellsCloudResponse  PutWorkbookBackground(PutWorkbookBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorkbookBackgroundAsync(PutWorkbookBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete background in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorkbookBackgroundRequest" /></param>
        public   CellsCloudResponse  DeleteWorkbookBackground(DeleteWorkbookBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorkbookBackgroundAsync(DeleteWorkbookBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set water marker in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorkbookWaterMarkerRequest" /></param>
        public   CellsCloudResponse  PutWorkbookWaterMarker(PutWorkbookWaterMarkerRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorkbookWaterMarkerAsync(PutWorkbookWaterMarkerRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get page count in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetPageCountRequest" /></param>
        public   int?  GetPageCount(GetPageCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return System.Convert.ToInt32( result); 
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   int?  > GetPageCountAsync(GetPageCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return System.Convert.ToInt32( result); 
        }


        /// <summary>
        /// Get all style in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetAllStylesRequest" /></param>
        public   StylesResponse  GetAllStyles(GetAllStylesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    StylesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   StylesResponse  > GetAllStylesAsync(GetAllStylesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    StylesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the description of worksheets from a workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetsRequest" /></param>
        public   WorksheetsResponse  GetWorksheets(GetWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorksheetsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   WorksheetsResponse  > GetWorksheetsAsync(GetWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    WorksheetsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the worksheet in a specified format from the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetWithFormatRequest" /></param>
        public   Stream  GetWorksheetWithFormat(GetWorksheetWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   Stream  > GetWorksheetWithFormatAsync(GetWorksheetWithFormatRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    Stream  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Change worksheet visibility in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutChangeVisibilityWorksheetRequest" /></param>
        public   CellsCloudResponse  PutChangeVisibilityWorksheet(PutChangeVisibilityWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutChangeVisibilityWorksheetAsync(PutChangeVisibilityWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set active worksheet index in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutActiveWorksheetRequest" /></param>
        public   CellsCloudResponse  PutActiveWorksheet(PutActiveWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutActiveWorksheetAsync(PutActiveWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Insert a new worksheet in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutInsertNewWorksheetRequest" /></param>
        public   CellsCloudResponse  PutInsertNewWorksheet(PutInsertNewWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutInsertNewWorksheetAsync(PutInsertNewWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a new worksheet in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PutAddNewWorksheetRequest" /></param>
        public   CellsCloudResponse  PutAddNewWorksheet(PutAddNewWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutAddNewWorksheetAsync(PutAddNewWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a worksheet in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheet(DeleteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetAsync(DeleteWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete matched worksheets in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheets(DeleteWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetsAsync(DeleteWorksheetsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Move worksheet in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostMoveWorksheetRequest" /></param>
        public   CellsCloudResponse  PostMoveWorksheet(PostMoveWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostMoveWorksheetAsync(PostMoveWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Protect worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutProtectWorksheetRequest" /></param>
        public   CellsCloudResponse  PutProtectWorksheet(PutProtectWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutProtectWorksheetAsync(PutProtectWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unprotect worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteUnprotectWorksheetRequest" /></param>
        public   CellsCloudResponse  DeleteUnprotectWorksheet(DeleteUnprotectWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteUnprotectWorksheetAsync(DeleteUnprotectWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve text items in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetTextItemsRequest" /></param>
        public   TextItemsResponse  GetWorksheetTextItems(GetWorksheetTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   TextItemsResponse  > GetWorksheetTextItemsAsync(GetWorksheetTextItemsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the description of comments in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCommentsRequest" /></param>
        public   CommentsResponse  GetWorksheetComments(GetWorksheetCommentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CommentsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CommentsResponse  > GetWorksheetCommentsAsync(GetWorksheetCommentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CommentsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve the description of comment in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCommentRequest" /></param>
        public   CommentResponse  GetWorksheetComment(GetWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CommentResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CommentResponse  > GetWorksheetCommentAsync(GetWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CommentResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add cell comment in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetCommentRequest" /></param>
        public   CommentResponse  PutWorksheetComment(PutWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CommentResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CommentResponse  > PutWorksheetCommentAsync(PutWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CommentResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update cell comment in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCommentRequest" /></param>
        public   CellsCloudResponse  PostWorksheetComment(PostWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetCommentAsync(PostWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete cell comment in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetCommentRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetComment(DeleteWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetCommentAsync(DeleteWorksheetCommentRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all comments in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetCommentsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetComments(DeleteWorksheetCommentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetCommentsAsync(DeleteWorksheetCommentsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get worksheet merged cells.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetMergedCellsRequest" /></param>
        public   MergedCellsResponse  GetWorksheetMergedCells(GetWorksheetMergedCellsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    MergedCellsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   MergedCellsResponse  > GetWorksheetMergedCellsAsync(GetWorksheetMergedCellsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    MergedCellsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve description of a merged cell by its index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetMergedCellRequest" /></param>
        public   MergedCellResponse  GetWorksheetMergedCell(GetWorksheetMergedCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    MergedCellResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   MergedCellResponse  > GetWorksheetMergedCellAsync(GetWorksheetMergedCellRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    MergedCellResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Calculate formula in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetCalculateFormulaRequest" /></param>
        public   SingleValueResponse  GetWorksheetCalculateFormula(GetWorksheetCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SingleValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SingleValueResponse  > GetWorksheetCalculateFormulaAsync(GetWorksheetCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SingleValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Calculate formula in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetCalculateFormulaRequest" /></param>
        public   SingleValueResponse  PostWorksheetCalculateFormula(PostWorksheetCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    SingleValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   SingleValueResponse  > PostWorksheetCalculateFormulaAsync(PostWorksheetCalculateFormulaRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    SingleValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Search for text in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetTextSearchRequest" /></param>
        public   TextItemsResponse  PostWorksheetTextSearch(PostWorksheetTextSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   TextItemsResponse  > PostWorksheetTextSearchAsync(PostWorksheetTextSearchRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    TextItemsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Replace old text with new text in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetTextReplaceRequest" /></param>
        public   WorksheetReplaceResponse  PostWorksheetTextReplace(PostWorksheetTextReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    WorksheetReplaceResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   WorksheetReplaceResponse  > PostWorksheetTextReplaceAsync(PostWorksheetTextReplaceRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    WorksheetReplaceResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Sort a range in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetRangeSortRequest" /></param>
        public   CellsCloudResponse  PostWorksheetRangeSort(PostWorksheetRangeSortRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetRangeSortAsync(PostWorksheetRangeSortRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Autofit a row in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorksheetRowRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorksheetRow(PostAutofitWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostAutofitWorksheetRowAsync(PostAutofitWorksheetRowRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Autofit rows in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorksheetRowsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorksheetRows(PostAutofitWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostAutofitWorksheetRowsAsync(PostAutofitWorksheetRowsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Autofit columns in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostAutofitWorksheetColumnsRequest" /></param>
        public   CellsCloudResponse  PostAutofitWorksheetColumns(PostAutofitWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostAutofitWorksheetColumnsAsync(PostAutofitWorksheetColumnsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set background image in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetBackgroundRequest" /></param>
        public   CellsCloudResponse  PutWorksheetBackground(PutWorksheetBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetBackgroundAsync(PutWorksheetBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete background image in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetBackgroundRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetBackground(DeleteWorksheetBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetBackgroundAsync(DeleteWorksheetBackgroundRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Set freeze panes in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetFreezePanesRequest" /></param>
        public   CellsCloudResponse  PutWorksheetFreezePanes(PutWorksheetFreezePanesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetFreezePanesAsync(PutWorksheetFreezePanesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Unfreeze panes in worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetFreezePanesRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetFreezePanes(DeleteWorksheetFreezePanesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetFreezePanesAsync(DeleteWorksheetFreezePanesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Copy contents and formats from another worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostCopyWorksheetRequest" /></param>
        public   CellsCloudResponse  PostCopyWorksheet(PostCopyWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostCopyWorksheetAsync(PostCopyWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Rename worksheet in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostRenameWorksheetRequest" /></param>
        public   CellsCloudResponse  PostRenameWorksheet(PostRenameWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostRenameWorksheetAsync(PostRenameWorksheetRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update worksheet properties in the workbook.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetPropertyRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetProperty(PostUpdateWorksheetPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUpdateWorksheetPropertyAsync(PostUpdateWorksheetPropertyRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve descriptions of ranges in the worksheets.
        /// </summary>
        /// <param name="request">Request. <see cref="GetNamedRangesRequest" /></param>
        public   RangesResponse  GetNamedRanges(GetNamedRangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   RangesResponse  > GetNamedRangesAsync(GetNamedRangesRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    RangesResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve values in range.
        /// </summary>
        /// <param name="request">Request. <see cref="GetNamedRangeValueRequest" /></param>
        public   RangeValueResponse  GetNamedRangeValue(GetNamedRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   RangeValueResponse  > GetNamedRangeValueAsync(GetNamedRangeValueRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    RangeValueResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update the scaling percentage in the worksheet. It should be between 10 and 400.
        /// </summary>
        /// <param name="request">Request. <see cref="PostUpdateWorksheetZoomRequest" /></param>
        public   CellsCloudResponse  PostUpdateWorksheetZoom(PostUpdateWorksheetZoomRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostUpdateWorksheetZoomAsync(PostUpdateWorksheetZoomRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Get page count in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetPageCountRequest" /></param>
        public   int?  GetWorksheetPageCount(GetWorksheetPageCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return System.Convert.ToInt32( result); 
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   int?  > GetWorksheetPageCountAsync(GetWorksheetPageCountRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<  string  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return System.Convert.ToInt32( result); 
        }


        /// <summary>
        /// Retrieve descriptions of validations in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetValidationsRequest" /></param>
        public   ValidationsResponse  GetWorksheetValidations(GetWorksheetValidationsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ValidationsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ValidationsResponse  > GetWorksheetValidationsAsync(GetWorksheetValidationsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ValidationsResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Retrieve a validation by its index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="GetWorksheetValidationRequest" /></param>
        public   ValidationResponse  GetWorksheetValidation(GetWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    ValidationResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   ValidationResponse  > GetWorksheetValidationAsync(GetWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    ValidationResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Add a validation at index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PutWorksheetValidationRequest" /></param>
        public   CellsCloudResponse  PutWorksheetValidation(PutWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PutWorksheetValidationAsync(PutWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Update a validation by index in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="PostWorksheetValidationRequest" /></param>
        public   CellsCloudResponse  PostWorksheetValidation(PostWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > PostWorksheetValidationAsync(PostWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete a validation by index in worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetValidationRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetValidation(DeleteWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetValidationAsync(DeleteWorksheetValidationRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


        /// <summary>
        /// Delete all validations in the worksheet.
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteWorksheetValidationsRequest" /></param>
        public   CellsCloudResponse  DeleteWorksheetValidations(DeleteWorksheetValidationsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0" , this.invoker.DefaultHeaderMap, this.requestHandlers)).Result;
            return result;
        }

        /// <summary>
        /// async/await syntax calling method
        /// </summary>

        public async Task<   CellsCloudResponse  > DeleteWorksheetValidationsAsync(DeleteWorksheetValidationsRequest request)
        {
            requestHandlers.ForEach(p => p.ProcessUrl(""));
            var result = await invoker.InvokeApiAsync<    CellsCloudResponse  >(request.CreateHttpRequest(BaseUri +"/v3.0", this.invoker.DefaultHeaderMap, this.requestHandlers));
            return result;
        }


    }
}
