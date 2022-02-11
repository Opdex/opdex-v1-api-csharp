# Opdex.Client.Model.WrappedTokenDetails
Details for an external token that is wrapped

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Custodian** | **string** | An address on the Cirrus network | [optional] 
**Chain** | [**ExternalChain**](ExternalChain.md) |  | [optional] 
**Address** | **string** | Address of the token on the native chain, or unset if the base token of the external chain is wrapped | [optional] 
**Trusted** | **bool** | True if the custodian is configured as trusted; otherwise false | [optional] 
**Validated** | **bool** | True if the native token it points to is valid; otherwise false | [optional] 
**CreatedBlock** | **int** | Block number at which the entity state was created | [optional] 
**ModifiedBlock** | **int** | Block number at which the entity state was last modified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

