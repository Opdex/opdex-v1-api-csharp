# Opdex.Client.Model.DistributionEvent
Indicates governance token distribution took place

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VaultAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**MiningGovernanceAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**PeriodIndex** | **decimal** | Distribution number | [optional] 
**TotalSupply** | **string** | Decimal value with uncapped precision and size | [optional] 
**NextDistributionBlock** | **decimal** | Block number of the next distribution | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

