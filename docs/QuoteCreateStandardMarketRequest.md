# Opdex.Client.Model.QuoteCreateStandardMarketRequest
Request to retrieve a create standard market call quote

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketOwner** | **string** | An address on the Cirrus network | 
**TransactionFee** | **int** | Swap fee amount equivalent to the percentage fee multiplied by 10 | 
**AuthPoolCreators** | **bool** | If true, requires permissions to be assigned to create liquidity pools; or if false anyone can create a liquidity pool | 
**AuthLiquidityProviders** | **bool** | If true, requires permissions to be assigned to provide liquidity; or if false anyone can provide liquidity | 
**AuthTraders** | **bool** | If true, requires permissions to be assigned to swap; or if false anyone can swap | 
**EnableMarketFee** | **bool** | If true, enables the market fee; note this must be false if transaction fee is zero | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

