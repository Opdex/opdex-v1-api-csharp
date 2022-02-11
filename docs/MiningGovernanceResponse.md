# Opdex.Client.Model.MiningGovernanceResponse
Details state of liquidity mining governance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | An address on the Cirrus network | [optional] 
**PeriodEndBlock** | **int** | Block number at which the current mining period ends | [optional] 
**PeriodRemainingBlocks** | **int** | Number of blocks left for the current mining period | [optional] 
**PeriodBlockDuration** | **int** | Number of blocks in a full mining period | [optional] 
**PeriodsUntilRewardReset** | **int** | Number of mining periods before reward amounts change | [optional] 
**MiningPoolRewardPerPeriod** | **string** | Decimal value with uncapped precision and size | [optional] 
**TotalRewardsPerPeriod** | **string** | Decimal value with uncapped precision and size | [optional] 
**MinedToken** | **string** | An address on the Cirrus network | [optional] 
**CreatedBlock** | **int** | Block number at which the entity was created | [optional] 
**ModifiedBlock** | **int** | Block number at which the entity state was last modified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

