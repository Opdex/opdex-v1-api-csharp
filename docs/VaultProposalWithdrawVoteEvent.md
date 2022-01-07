# Opdex.Client.Model.VaultProposalWithdrawVoteEvent
Indicates a vote was withdrawn from a vault proposal

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProposalId** | **decimal** | Identifier for the proposal | [optional] 
**Voter** | **string** | An address on the Cirrus network | [optional] 
**WithdrawAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**VoterAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**ProposalYesAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**ProposalNoAmount** | **string** | Decimal value with uncapped precision and size | [optional] 
**VoteWithdrawn** | **bool** | Whether the proposal is active and not completed | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

