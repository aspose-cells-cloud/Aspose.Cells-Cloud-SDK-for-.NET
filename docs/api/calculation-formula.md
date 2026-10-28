# **Spreadsheet Cloud API: calculationFormula**

Calculates a formula expression and returns the result. 

## **Quick Start**

- **Base URL**: `http://api.aspose.cloud/v4.0`
- **Authentication Method**: `JWT (OAuth2, application)`  **Token URL**: `https://api.aspose.cloud/connect/token`
## **Interface Details**

### **Endpoint** 

```
PUT http://api.aspose.cloud/v4.0/cells/calculate/formula
```

### **Function Description**
This API evaluates a formula expression within the context of a specified worksheet and returns the calculated result.The formula is evaluated using the current data in the worksheet, allowing you to preview formula results without modifying the spreadsheet.            ## **Error Handling**            - **400 Bad Request**: Invalid formula syntax or missing parameters.- **401 Unauthorized**: Authentication has failed, or no credentials were provided.- **404 Not Found**: Worksheet not found.- **500 Server Error**: Formula calculation failed.            ## **Key Features and Benefits**            - **Formula Preview**: Calculate formula results without modifying the spreadsheet.- **Worksheet Context**: Formulas are evaluated in the context of the specified worksheet.- **Automatic Formula Prefix**: Automatically adds '=' prefix if not present.

### The request parameters of **calculationFormula** API are: 

| Parameter Name | Type | Path/Query String/HTTPBody | Description | 
| :- | :- | :- |:- | 
|Spreadsheet|File|FormData|Upload spreadsheet file.|
|worksheet|String|Query|The worksheet name where the formula will be evaluated.|
|formula|String|Query|The formula expression to calculate (e.g., "SUM(A1:A10)" or "=A1+B1").|
|region|String|Query|Spreadsheet region/language setting (e.g., `en-US`, `fr-FR`). Influences number formatting, date parsing, and locale‑specific behavior.|
|password|String|Query|The password for opening spreadsheet file.|


### **Response Description**
```json
{
File
}
```

## OpenAPI Specification

The [OpenAPI Specification](https://reference.aspose.cloud/cells/#/CalculateController/CalculationFormula) defines a publicly accessible programming interface and lets you carry out REST interactions directly from a web browser.

[[Back to API list]](../DeveloperGuide.md#api-reference)  
[[Back to README]](../../README.md)