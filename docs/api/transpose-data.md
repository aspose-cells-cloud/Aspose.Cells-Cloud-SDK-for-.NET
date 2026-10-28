# **Spreadsheet Cloud API: transposeData**

Transposes data in the specified range, switching rows and columns. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/transpose
```

### **Function Description**
This API transposes the data in the specified range, converting rows to columns and columns to rows.For example, a 3x2 range (3 rows, 2 columns) will become a 2x3 range (2 rows, 3 columns) in the output.The transposed data is placed in a new worksheet with "_Transpose" suffix.            ## **Error Handling**            - **400 Bad Request**: Invalid worksheet name or cell area.- **401 Unauthorized**: Authentication has failed, or no credentials were provided.- **404 Not Found**: Source file not accessible.- **500 Server Error** The spreadsheet has encountered an anomaly in obtaining data.

### The request parameters of **transposeData** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|worksheet|String|Query|The worksheet name containing the data to transpose.|
|cellArea|String|Query|The cell range to transpose (e.g., "A1:C10").|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|region|String|Query|Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.|
|password|String|Query|The password for opening spreadsheet file.|


### **Response Description**
```json
{
File
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/TransformController/TransposeData) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)