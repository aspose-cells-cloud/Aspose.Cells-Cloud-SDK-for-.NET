# **Spreadsheet Cloud API: acceptAllRevisions**

Accepts all tracked changes (revisions) in the local spreadsheet. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/spreadsheet/accept-all-revisions
```

### **Function Description**
This API accepts all pending revisions in the spreadsheet, finalizing all tracked changes.After accepting revisions, the document will no longer show tracked changes markup.            ## **Error Handling**            - **400 Bad Request**: Invalid spreadsheet format.- **401 Unauthorized**: Authentication has failed, or no credentials were provided.- **500 Server Error** The spreadsheet has encountered an anomaly in processing revisions.

### The request parameters of **acceptAllRevisions** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|outPath|String|Query|(Optional) The folder path where the workbook is stored. The default is null.|
|outStorageName|String|Query|Output file Storage Name.|
|fontsLocation|String|Query|Use Custom fonts.|
|region|String|Query|Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.|
|password|String|Query|The password for opening spreadsheet file.|


### **Response Description**
```json
{
File
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/ManagementController/AcceptAllRevisions) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)