# Opdex.Client.Model.CreateVaultProposalEvent
Indicates a vault proposal was created

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProposalId** | **int** | Identifier for the proposal | [optional] 
**Wallet** | **string** | An address on the Cirrus network | [optional] 
**Amount** | **string** | Decimal value with uncapped precision and size | [optional] 
**Description** | **string** | Description of the proposal | [optional] 
**Type** | [**ProposalType**](ProposalType.md) |  | [optional] 
**Status** | [**ProposalStatus**](ProposalStatus.md) |  | [optional] 
**Expiration** | **int** | Block number that the proposal expires | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

