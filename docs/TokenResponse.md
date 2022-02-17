# Opdex.Client.Model.TokenResponse
Details of a token

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | An address on the Cirrus network | [optional] 
**Name** | **string** | Name of the token | [optional] 
**Symbol** | **string** | Token ticker symbol | [optional] 
**Decimals** | **int** | Number of decimals of precision for token values | [optional] 
**Sats** | **string** | Number of parts which make up one whole token | [optional] 
**TotalSupply** | **string** | Decimal value with uncapped precision and size | [optional] 
**Attributes** | [**List&lt;TokenAttribute&gt;**](TokenAttribute.md) | Attributes applied to the token | [optional] 
**WrappedToken** | [**WrappedTokenDetails**](WrappedTokenDetails.md) |  | [optional] 
**Distribution** | [**MinedTokenDistributionDetails**](MinedTokenDistributionDetails.md) |  | [optional] 
**CreatedBlock** | **int** | Block number at which the entity was created | [optional] 
**ModifiedBlock** | **int** | Block number at which the entity state was last modified | [optional] 
**Summary** | [**TokenSummary**](TokenSummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

