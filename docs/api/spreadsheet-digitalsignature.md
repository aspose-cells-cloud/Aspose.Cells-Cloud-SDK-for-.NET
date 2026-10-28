# **Spreadsheet Cloud API: spreadsheetDigitalsignature**

Adds digital signatures to Excel spreadsheets using X.509 certificates (.pfx files) for document authentication and integrity verification. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/digitalsignature/spreadsheet
```

### **Function Description**
This endpoint applies digital signatures to Excel workbooks using provided certificate files. Digital signatures provide cryptographic proof of document authenticity and ensure content integrity by detecting any unauthorized modifications.            ## **Processing Pipeline**            1. **Certificate Upload**: Accepts .pfx certificate file with password protection2. **Workbook Processing**: Loads uploaded Excel files3. **Signature Application**: Applies digital signature using the certificate4. **File Output**: Returns signed spreadsheet file            ## **Error Handling**            - **400 Bad Request**: Invalid certificate format or incorrect password- **401 Unauthorized**: Authentication failed- **500 Server Error**: Digital signature application failed            ## **Key Features and Benefits**            - **Document Authentication**: Cryptographically proves document origin- **Integrity Verification**: Detects unauthorized modifications- **Multiple File Support**: Can sign multiple workbooks in single request

### The request parameters of **spreadsheetDigitalsignature** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|password|String|Query|The password for the digital certificate (.pfx file).|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|region|String|Query|Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.|


### **Response Description**
```json
{
File
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ProtectionController/SpreadsheetDigitalsignature) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)