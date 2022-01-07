# Opdex.Client.Model.VaultProposalWithdrawPledgeEvent
Indicates a pledge was withdrawn from a vault proposal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProposalId** | **int** | Identifier for the proposal | [optional] 
**Pledger** | **string** | An address on the Cirrus network | [optional] 
**WithdrawAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**PledgerAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**ProposalPledgeAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**PledgeWithdrawn** | **bool** | Whether the proposal is active and status is pledge | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

