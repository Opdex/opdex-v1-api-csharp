# Opdex.Client.Model.TransactionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | Whether the transaction succeeded | [optional] 
**Hash** | **string** | SHA256 hash value | [optional] 
**NewContractAddress** | **string** | An address on the Cirrus network | [optional] 
**Block** | [**BlockResponse**](BlockResponse.md) |  | [optional] 
**GasUsed** | **int** | Quantity of gas consumed | [optional] 
**From** | **string** | An address on the Cirrus network | [optional] 
**To** | **string** | An address on the Cirrus network | [optional] 
**Events** | [**List&lt;TransactionEvent&gt;**](TransactionEvent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

