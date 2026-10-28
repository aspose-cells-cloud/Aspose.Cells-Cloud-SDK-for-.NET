# **Spreadsheet Cloud API: smartMarkerTemplate**

Generates reports using Smart Marker template technology with JSON data. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/report/smart/template
```

### **Function Description**
This API processes an Excel template file containing Smart Markers and merges it with JSON data to generate reports.It supports three output modes controlled by the OutputConfig.Model property:            - **SingleSheet**: All report data is merged into a single worksheet- **MultiSheets**: Each data record creates a new worksheet in the same workbook- **MultiFiles**: Each data record generates a separate Excel file (returned as ZIP)            ## **Input Requirements**            - **Template File**: Excel file (.xlsx) with Smart Markers (e.g., &amp;=DataSource.FieldName)- **JSON Data File**: Contains ReportDatas array and OutputConfig object            ## **JSON Data Structure**            ```json{  "ReportObjectName": "Data",  "ReportDatas": [ { "Name": "John", "Amount": 1000 }, ... ],  "OutputConfig": {    "Model": "SingleSheet|MultiSheets|MultiFiles",    "SheetName": "Optional naming template",    "Filename": "Optional filename template"  }}```            ## **Error Handling**            - **400 Bad Request**: Missing template or JSON data file.- **401 Unauthorized**: Authentication has failed, or no credentials were provided.- **500 Server Error**: Template processing or data merging failed.            ## **Key Features and Benefits**            - **Smart Marker Technology**: Leverages Aspose.Cells powerful template engine.- **Flexible Output Modes**: Choose the best output format for your needs.- **Batch Processing**: Generate multiple reports from a single template.- **Dynamic Naming**: Use templates for sheet names and filenames.

### The request parameters of **smartMarkerTemplate** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|datafile|File|FormData|Upload smartmarker template json data file.|
|templatefile|File|FormData|Upload smartmarker template file.|
|region|String|Query|Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.|
|password|String|Query|The password for opening spreadsheet file.|


### **Response Description**
```json
{
File
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ReportController/SmartMarkerTemplate) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)