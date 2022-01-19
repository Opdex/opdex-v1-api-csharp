# Opdex.Client.Model.IndexerStatusResponse
Status of the Opdex transaction indexer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LatestBlock** | [**BlockResponse**](BlockResponse.md) |  | [optional] 
**Available** | **bool** | True if the indexer process is active, otherwise false | [optional] 
**Locked** | **bool** | True if the indexer process is currently running, otherwise false | [optional] 
**InstanceId** | **string** | Unique identifier for the API instance that locked the indexer | [optional] 
**Reason** | **string** | Reason that the indexer process is currently running | [optional] 
**ModifiedDate** | **DateTime** | When the indexer status last changed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

