# **Spreadsheet Cloud API: unpivotRange**

Unpivots data from the specified range, converting columns to rows. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/unpivot/range
```

### **Function Description**
This API performs an unpivot operation on the specified range, transforming column-based data into row-based data.The first row is treated as column headers, and the first column is treated as row identifiers.The result is a three-column table: Row Header, Column Header, and Value.The unpivoted data is placed in a new worksheet with "_UnpivotTable" suffix.            ## **Error Handling**            - **400 Bad Request**: Invalid worksheet name or cell area.- **401 Unauthorized**: Authentication has failed, or no credentials were provided.- **404 Not Found**: Source file not accessible.- **500 Server Error** The spreadsheet has encountered an anomaly in obtaining data.

### The request parameters of **unpivotRange** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|worksheet|String|Query|The worksheet name containing the data to unpivot.|
|cellArea|String|Query|The cell range to unpivot (e.g., "A1:D10").|
|skipEmptyValue|Boolean|Query|If true, empty cells are skipped in the output. Default is true.|
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

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/TransformController/UnpivotRange) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)