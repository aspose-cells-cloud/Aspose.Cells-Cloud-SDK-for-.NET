# **Spreadsheet Cloud API: getSpreadsheetStructure**

Extracts the structural information of a local spreadsheet as a JSON object. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/spreadsheet/structure
```

### **Function Description**
This API converts the core metadata, worksheets, tables, pivot tables, charts, shapes, and other structural informationof an Excel workbook into a JSON object. Useful for data export, API responses, and log recording.            ## **Error Handling**            - **400 Bad Request**: Invalid spreadsheet format.- **401 Unauthorized**: Authentication has failed, or no credentials were provided.- **500 Server Error** The spreadsheet has encountered an anomaly in extracting structure.

### The request parameters of **getSpreadsheetStructure** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|region|String|Query|Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.|
|password|String|Query|The password for opening spreadsheet file.|


### **Response Description**
```json
{
String
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ManagementController/GetSpreadsheetStructure) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)