# Opdex.Client.Model.VaultProposalVoteEvent
Indicates a vote was made on a vault proposal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProposalId** | **decimal** | Identifier for the proposal | [optional] 
**Voter** | **string** | An address on the Cirrus network | [optional] 
**InFavor** | **bool** | Whether the vote is in favor or against the proposal | [optional] 
**VoteAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**VoterAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**ProposalYesAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**ProposalNoAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

