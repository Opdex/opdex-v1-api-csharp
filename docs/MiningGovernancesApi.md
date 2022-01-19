# Opdex.Client.Api.MiningGovernancesApi

All URIs are relative to *https://test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuildRewardMiningPoolsQuote**](MiningGovernancesApi.md#buildrewardminingpoolsquote) | **POST** /mining-governances/{governance}/reward-mining-pools | Build Reward Mining Pools Transaction Quote
[**GetMiningGovernance**](MiningGovernancesApi.md#getmininggovernance) | **GET** /mining-governances/{governance} | Get Mining Governance
[**GetMiningGovernances**](MiningGovernancesApi.md#getmininggovernances) | **GET** /mining-governances | Get Mining Governances


<a name="buildrewardminingpoolsquote"></a>
# **BuildRewardMiningPoolsQuote**
> TransactionQuoteResponse BuildRewardMiningPoolsQuote (string governance, QuoteRewardMiningPoolsRequest quoteRewardMiningPoolsRequest)

Build Reward Mining Pools Transaction Quote

Builds a quote for a reward mining pools transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildRewardMiningPoolsQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MiningGovernancesApi(config);
            var governance = tVfGTqrToiTU9bfnvD5UDC5ZQVY4oj4jrc;  // string | Address of the mining governance contract
            var quoteRewardMiningPoolsRequest = new QuoteRewardMiningPoolsRequest(); // QuoteRewardMiningPoolsRequest | 

            try
            {
                // Build Reward Mining Pools Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildRewardMiningPoolsQuote(governance, quoteRewardMiningPoolsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningGovernancesApi.BuildRewardMiningPoolsQuote: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **governance** | **string**| Address of the mining governance contract | 
 **quoteRewardMiningPoolsRequest** | [**QuoteRewardMiningPoolsRequest**](QuoteRewardMiningPoolsRequest.md)|  | 

### Return type

[**TransactionQuoteResponse**](TransactionQuoteResponse.md)

### Authorization

[opdexAuth](../README.md#opdexAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Built reward mining pools quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Mining governance not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmininggovernance"></a>
# **GetMiningGovernance**
> MiningGovernanceResponse GetMiningGovernance (string governance)

Get Mining Governance

Retrieves details for a tracked mining governance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMiningGovernanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            var apiInstance = new MiningGovernancesApi(config);
            var governance = tVfGTqrToiTU9bfnvD5UDC5ZQVY4oj4jrc;  // string | Address of the mining governance contract

            try
            {
                // Get Mining Governance
                MiningGovernanceResponse result = apiInstance.GetMiningGovernance(governance);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningGovernancesApi.GetMiningGovernance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **governance** | **string**| Address of the mining governance contract | 

### Return type

[**MiningGovernanceResponse**](MiningGovernanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mining governance details found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Mining governance not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmininggovernances"></a>
# **GetMiningGovernances**
> MiningGovernancesResponse GetMiningGovernances (string minedToken = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Mining Governances

Retrieves details for all tracked mining governances.  This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMiningGovernancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            var apiInstance = new MiningGovernancesApi(config);
            var minedToken = tTTuKbCR2UnsEByXBp1ynBz91J2yz63h1c;  // string | Address of the mined token (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Mining Governances
                MiningGovernancesResponse result = apiInstance.GetMiningGovernances(minedToken, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningGovernancesApi.GetMiningGovernances: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **minedToken** | **string**| Address of the mined token | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MiningGovernancesResponse**](MiningGovernancesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mining governance results found |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

