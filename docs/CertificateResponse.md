# Opdex.Client.Model.CertificateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Owner** | **string** | An address on the Cirrus network | [optional] 
**Amount** | **string** | Decimal value with uncapped precision and size | [optional] 
**VestingStartBlock** | **int** | Block that the vesting period starts | [optional] 
**VestingEndBlock** | **int** | Block that the vesting period ends | [optional] 
**Redeemed** | **bool** | Whether the certificate has been redeemed by the certificate owner | [optional] 
**Revoked** | **bool** | Whether the certificate was revoked by the vault owner | [optional] 
**Proposals** | **List&lt;int&gt;** | Create and revoke proposal ids relating to the certificate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

