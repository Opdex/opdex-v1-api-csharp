# Opdex.Client.Model.ProposalResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vault** | **string** | An address on the Cirrus network | [optional] 
**Token** | **string** | An address on the Cirrus network | [optional] 
**ProposalId** | **int** | Id of the proposal stored by the vault | [optional] 
**Creator** | **string** | An address on the Cirrus network | [optional] 
**Wallet** | **string** | An address on the Cirrus network | [optional] 
**Amount** | **string** | Decimal value with uncapped precision and size | [optional] 
**Description** | **string** | Description for the proposal | [optional] 
**Type** | [**ProposalType**](ProposalType.md) |  | [optional] 
**Status** | [**ProposalStatus**](ProposalStatus.md) |  | [optional] 
**Expiration** | **int** | Block number that the proposal status expires, for an active proposal | [optional] 
**YesAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**NoAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**PledgeAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**Approved** | **bool** | Whether the proposal has been approved | [optional] 
**CreatedBlock** | **int** | Block number at which the entity was created | [optional] 
**ModifiedBlock** | **int** | Block number at which the entity state was last modified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

