# Opdex.Client.Model.CreateMarketEvent
Indicates a market was created

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Market** | **string** | An address on the Cirrus network | [optional] 
**Owner** | **string** | An address on the Cirrus network | [optional] 
**Router** | **string** | An address on the Cirrus network | [optional] 
**AuthPoolCreators** | **bool** | Whether the market requires authorization to create a pool | [optional] 
**AuthProviders** | **bool** | Whether the market requires authorization to provide liquidity | [optional] 
**AuthTraders** | **bool** | Whether the market requires authorization to swap | [optional] 
**TransactionFeePercent** | **decimal** | Swap fee percentage amount | [optional] 
**StakingToken** | **string** | An address on the Cirrus network | [optional] 
**EnableMarketFee** | **bool** | Whether the market fee is enabled | [optional] 
**EventType** | [**TransactionEventType**](TransactionEventType.md) |  | [optional] 
**Contract** | **string** | An address on the Cirrus network | [optional] 
**SortOrder** | **int** | Index to sort event order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

