# Opdex.Client.Model.TransactionQuoteResponse
Quote for submitting a smart contract transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **Object** | Value which is returned by the quoted smart contract call | [optional] 
**Error** | **string** | Smart contract call error details | [optional] 
**GasUsed** | **int** | Total amount of gas consumed in the quoted smart contract call | [optional] 
**Events** | [**List&lt;TransactionEvent&gt;**](TransactionEvent.md) |  | [optional] 
**Request** | **string** | Encoded transaction request, which can be used to replay or broadcast the transaction | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

