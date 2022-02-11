# Opdex.Client.Model.QuotedTransaction
Quoted transaction that can be handed off to a wallet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | An address on the Cirrus network | 
**To** | **string** | An address on the Cirrus network | 
**Amount** | **string** | Decimal value with uncapped precision and size | 
**Method** | **string** | Name of smart contract method to call | 
**Parameters** | [**List&lt;LabelledSmartContractParameter&gt;**](LabelledSmartContractParameter.md) | An array of labelled parameters to pass to the method | [optional] 
**Callback** | **string** | An endpoint that the broadcaster can call back to | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

