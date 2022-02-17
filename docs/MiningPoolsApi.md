# Opdex.Client.Api.MiningPoolsApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuildCollectMiningRewardsQuote**](MiningPoolsApi.md#buildcollectminingrewardsquote) | **POST** /mining-pools/{pool}/collect | Build Collect Mining Rewards Transaction Quote
[**BuildStartMiningQuote**](MiningPoolsApi.md#buildstartminingquote) | **POST** /mining-pools/{pool}/start | Build Start Mining Transaction Quote
[**BuildStopMiningQuote**](MiningPoolsApi.md#buildstopminingquote) | **POST** /mining-pools/{pool}/stop | Build Stop Mining Transaction Quote
[**GetMiningPool**](MiningPoolsApi.md#getminingpool) | **GET** /mining-pools/{pool} | Get Mining Pool
[**GetMiningPools**](MiningPoolsApi.md#getminingpools) | **GET** /mining-pools | Get Mining Pools


<a name="buildcollectminingrewardsquote"></a>
# **BuildCollectMiningRewardsQuote**
> TransactionQuoteResponse BuildCollectMiningRewardsQuote (string pool)

Build Collect Mining Rewards Transaction Quote

Builds a quote for a collect mining rewards transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildCollectMiningRewardsQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MiningPoolsApi(httpClient, config, httpClientHandler);
            var pool = tRs6rXfHuLhKZhWuWpycLASzAyn4kXo6bT;  // string | Address of a mining pool

            try
            {
                // Build Collect Mining Rewards Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCollectMiningRewardsQuote(pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningPoolsApi.BuildCollectMiningRewardsQuote: " + e.Message );
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
 **pool** | **string**| Address of a mining pool | 

### Return type

[**TransactionQuoteResponse**](TransactionQuoteResponse.md)

### Authorization

[opdexAuth](../README.md#opdexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Built collect mining rewards quote |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Mining pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildstartminingquote"></a>
# **BuildStartMiningQuote**
> TransactionQuoteResponse BuildStartMiningQuote (string pool, QuoteStartMiningRequest quoteStartMiningRequest)

Build Start Mining Transaction Quote

Builds a quote for a start mining transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildStartMiningQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MiningPoolsApi(httpClient, config, httpClientHandler);
            var pool = tRs6rXfHuLhKZhWuWpycLASzAyn4kXo6bT;  // string | Address of a mining pool
            var quoteStartMiningRequest = new QuoteStartMiningRequest(); // QuoteStartMiningRequest | Details for a start mining transaction request

            try
            {
                // Build Start Mining Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildStartMiningQuote(pool, quoteStartMiningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningPoolsApi.BuildStartMiningQuote: " + e.Message );
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
 **pool** | **string**| Address of a mining pool | 
 **quoteStartMiningRequest** | [**QuoteStartMiningRequest**](QuoteStartMiningRequest.md)| Details for a start mining transaction request | 

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
| **200** | Built start mining quote |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Mining pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildstopminingquote"></a>
# **BuildStopMiningQuote**
> TransactionQuoteResponse BuildStopMiningQuote (string pool, QuoteStopMiningRequest quoteStopMiningRequest)

Build Stop Mining Transaction Quote

Builds a quote for a stop mining transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildStopMiningQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MiningPoolsApi(httpClient, config, httpClientHandler);
            var pool = tRs6rXfHuLhKZhWuWpycLASzAyn4kXo6bT;  // string | Address of a mining pool
            var quoteStopMiningRequest = new QuoteStopMiningRequest(); // QuoteStopMiningRequest | Details for a stop mining transaction request

            try
            {
                // Build Stop Mining Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildStopMiningQuote(pool, quoteStopMiningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningPoolsApi.BuildStopMiningQuote: " + e.Message );
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
 **pool** | **string**| Address of a mining pool | 
 **quoteStopMiningRequest** | [**QuoteStopMiningRequest**](QuoteStopMiningRequest.md)| Details for a stop mining transaction request | 

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
| **200** | Built stop mining quote |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Mining pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getminingpool"></a>
# **GetMiningPool**
> MiningPoolResponse GetMiningPool (string pool)

Get Mining Pool

Retrieves details of a tracked mining pool by its contract address.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMiningPoolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MiningPoolsApi(httpClient, config, httpClientHandler);
            var pool = tRs6rXfHuLhKZhWuWpycLASzAyn4kXo6bT;  // string | Address of a mining pool

            try
            {
                // Get Mining Pool
                MiningPoolResponse result = apiInstance.GetMiningPool(pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningPoolsApi.GetMiningPool: " + e.Message );
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
 **pool** | **string**| Address of a mining pool | 

### Return type

[**MiningPoolResponse**](MiningPoolResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mining pool details found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Mining pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getminingpools"></a>
# **GetMiningPools**
> MiningPoolsResponse GetMiningPools (List<string> liquidityPools = null, MiningActivityStatus? miningStatus = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Mining Pools

Retrieves details of all tracked mining pools across staking markets. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetMiningPoolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MiningPoolsApi(httpClient, config, httpClientHandler);
            var liquidityPools = new List<string>(); // List<string> | Liquidity pools used for mining (optional) 
            var miningStatus = Inactive;  // MiningActivityStatus? | Mining pool activity status (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Mining Pools
                MiningPoolsResponse result = apiInstance.GetMiningPools(liquidityPools, miningStatus, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningPoolsApi.GetMiningPools: " + e.Message );
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
 **liquidityPools** | [**List&lt;string&gt;**](string.md)| Liquidity pools used for mining | [optional] 
 **miningStatus** | **MiningActivityStatus?**| Mining pool activity status | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MiningPoolsResponse**](MiningPoolsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mining pool results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

