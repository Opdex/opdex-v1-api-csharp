# Opdex.Client.Model.VaultProposalPledgeEvent
Indicates a pledge was made to a vault proposal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProposalId** | **decimal** | Identifier for the proposal | [optional] 
**Pledger** | **string** | An address on the Cirrus network | [optional] 
**PledgeAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**PledgerAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**ProposalPledgeAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**TotalPledgeMinimumMet** | **bool** | Whether the proposal has met the minimum pledge requirement | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

