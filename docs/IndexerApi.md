# Opdex.Client.Api.IndexerApi

All URIs are relative to *https://test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIndexerStatus**](IndexerApi.md#getindexerstatus) | **GET** /indexer | Get Indexer Status


<a name="getindexerstatus"></a>
# **GetIndexerStatus**
> IndexerStatusResponse GetIndexerStatus ()

Get Indexer Status

Retrieves status details for the Opdex transaction indexer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetIndexerStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            var apiInstance = new IndexerApi(config);

            try
            {
                // Get Indexer Status
                IndexerStatusResponse result = apiInstance.GetIndexerStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexerApi.GetIndexerStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IndexerStatusResponse**](IndexerStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Indexer status retrieved |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

