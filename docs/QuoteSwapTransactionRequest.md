# Opdex.Client.Model.QuoteSwapTransactionRequest
Request to retrieve a token swap call quote

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenOut** | [**TokenAddress**](TokenAddress.md) |  | 
**TokenInAmount** | **string** | Decimal value with uncapped precision and size | 
**TokenOutAmount** | **string** | Decimal value with uncapped precision and size | 
**TokenInExactAmount** | **bool** | Token in amount is exact when true, otherwise token out amount is exact | 
**TokenInMaximumAmount** | **string** | Decimal value with uncapped precision and size | 
**TokenOutMinimumAmount** | **string** | Decimal value with uncapped precision and size | 
**Recipient** | **string** | An address on the Cirrus network | 
**Deadline** | **decimal** | Block height the transaction should be mined at, which if not met causes the transaction to fail | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

