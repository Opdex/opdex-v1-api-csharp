# Opdex.Client.Api.LiquidityPoolsApi

All URIs are relative to *https://test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuildAddLiquidityQuote**](LiquidityPoolsApi.md#buildaddliquidityquote) | **POST** /liquidity-pools/{pool}/add | Build Add Liquidity Transaction Quote
[**BuildCollectStakingRewardsQuote**](LiquidityPoolsApi.md#buildcollectstakingrewardsquote) | **POST** /liquidity-pools/{pool}/staking/collect | Build Collect Staking Rewards Transaction Quote
[**BuildCreateLiquidityPoolQuote**](LiquidityPoolsApi.md#buildcreateliquiditypoolquote) | **POST** /liquidity-pools | Build Create Liquidity Pool Transaction Quote
[**BuildRemoveLiquidityQuote**](LiquidityPoolsApi.md#buildremoveliquidityquote) | **POST** /liquidity-pools/{pool}/remove | Build Remove Liquidity Transaction Quote
[**BuildSkimQuote**](LiquidityPoolsApi.md#buildskimquote) | **POST** /liquidity-pools/{pool}/skim | Build Skim Transaction Quote
[**BuildStartStakingQuote**](LiquidityPoolsApi.md#buildstartstakingquote) | **POST** /liquidity-pools/{pool}/staking/start | Build Start Staking Transaction Quote
[**BuildStopStakingQuote**](LiquidityPoolsApi.md#buildstopstakingquote) | **POST** /liquidity-pools/{pool}/staking/stop | Build Stop Staking Transaction Quote
[**BuildSyncQuote**](LiquidityPoolsApi.md#buildsyncquote) | **POST** /liquidity-pools/{pool}/sync | Build Sync Transaction Quote
[**GetLiquidityAmountInQuote**](LiquidityPoolsApi.md#getliquidityamountinquote) | **POST** /liquidity-pools/{pool}/add/amount-in | Add Liquidity Amount In Quote
[**GetLiquidityPool**](LiquidityPoolsApi.md#getliquiditypool) | **GET** /liquidity-pools/{pool} | Get Liquidity Pool
[**GetLiquidityPoolHistory**](LiquidityPoolsApi.md#getliquiditypoolhistory) | **GET** /liquidity-pools/{pool}/history | Get Liquidity Pool History
[**GetLiquidityPools**](LiquidityPoolsApi.md#getliquiditypools) | **GET** /liquidity-pools | Get Liquidity Pools


<a name="buildaddliquidityquote"></a>
# **BuildAddLiquidityQuote**
> TransactionQuoteResponse BuildAddLiquidityQuote (string pool, QuoteAddLiquidityRequest quoteAddLiquidityRequest)

Build Add Liquidity Transaction Quote

Builds a quote for a transaction to add liquidity to an Opdex liquidity pool. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildAddLiquidityQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var quoteAddLiquidityRequest = new QuoteAddLiquidityRequest(); // QuoteAddLiquidityRequest | 

            try
            {
                // Build Add Liquidity Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildAddLiquidityQuote(pool, quoteAddLiquidityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildAddLiquidityQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **quoteAddLiquidityRequest** | [**QuoteAddLiquidityRequest**](QuoteAddLiquidityRequest.md)|  | 

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
| **200** | Built add liquidity quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildcollectstakingrewardsquote"></a>
# **BuildCollectStakingRewardsQuote**
> TransactionQuoteResponse BuildCollectStakingRewardsQuote (string pool, QuoteCollectStakingRewardsRequest quoteCollectStakingRewardsRequest)

Build Collect Staking Rewards Transaction Quote

Builds a quote for a transaction to collect staking rewards from an Opdex liquidity pool. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildCollectStakingRewardsQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var quoteCollectStakingRewardsRequest = new QuoteCollectStakingRewardsRequest(); // QuoteCollectStakingRewardsRequest | 

            try
            {
                // Build Collect Staking Rewards Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCollectStakingRewardsQuote(pool, quoteCollectStakingRewardsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildCollectStakingRewardsQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **quoteCollectStakingRewardsRequest** | [**QuoteCollectStakingRewardsRequest**](QuoteCollectStakingRewardsRequest.md)|  | 

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
| **200** | Built collect staking rewards quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildcreateliquiditypoolquote"></a>
# **BuildCreateLiquidityPoolQuote**
> TransactionQuoteResponse BuildCreateLiquidityPoolQuote (QuoteCreateLiquidityPoolRequest quoteCreateLiquidityPoolRequest = null)

Build Create Liquidity Pool Transaction Quote

Builds a quote for a transaction to create an Opdex liquidity pool. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildCreateLiquidityPoolQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var quoteCreateLiquidityPoolRequest = new QuoteCreateLiquidityPoolRequest(); // QuoteCreateLiquidityPoolRequest |  (optional) 

            try
            {
                // Build Create Liquidity Pool Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCreateLiquidityPoolQuote(quoteCreateLiquidityPoolRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildCreateLiquidityPoolQuote: " + e.Message );
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
 **quoteCreateLiquidityPoolRequest** | [**QuoteCreateLiquidityPoolRequest**](QuoteCreateLiquidityPoolRequest.md)|  | [optional] 

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
| **200** | Built create liquidity pool quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildremoveliquidityquote"></a>
# **BuildRemoveLiquidityQuote**
> TransactionQuoteResponse BuildRemoveLiquidityQuote (string pool, QuoteRemoveLiquidityRequest quoteRemoveLiquidityRequest)

Build Remove Liquidity Transaction Quote

Builds a quote for a transaction to remove liquidity from an Opdex liquidity pool. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildRemoveLiquidityQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var quoteRemoveLiquidityRequest = new QuoteRemoveLiquidityRequest(); // QuoteRemoveLiquidityRequest | 

            try
            {
                // Build Remove Liquidity Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildRemoveLiquidityQuote(pool, quoteRemoveLiquidityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildRemoveLiquidityQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **quoteRemoveLiquidityRequest** | [**QuoteRemoveLiquidityRequest**](QuoteRemoveLiquidityRequest.md)|  | 

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
| **200** | Built remove liquidity quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildskimquote"></a>
# **BuildSkimQuote**
> TransactionQuoteResponse BuildSkimQuote (string pool, QuoteSkimRequest quoteSkimRequest)

Build Skim Transaction Quote

Builds a quote for a transaction to skim an Opdex liquidity pool. This transaction forces the token balances to equal the current reserves. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildSkimQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var quoteSkimRequest = new QuoteSkimRequest(); // QuoteSkimRequest | 

            try
            {
                // Build Skim Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildSkimQuote(pool, quoteSkimRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildSkimQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **quoteSkimRequest** | [**QuoteSkimRequest**](QuoteSkimRequest.md)|  | 

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
| **200** | Built skim quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildstartstakingquote"></a>
# **BuildStartStakingQuote**
> TransactionQuoteResponse BuildStartStakingQuote (string pool, QuoteStartStakingRequest quoteStartStakingRequest)

Build Start Staking Transaction Quote

Builds a quote for a transaction to begin staking in an Opdex liquidity pool. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildStartStakingQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var quoteStartStakingRequest = new QuoteStartStakingRequest(); // QuoteStartStakingRequest | 

            try
            {
                // Build Start Staking Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildStartStakingQuote(pool, quoteStartStakingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildStartStakingQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **quoteStartStakingRequest** | [**QuoteStartStakingRequest**](QuoteStartStakingRequest.md)|  | 

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
| **200** | Built start staking quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildstopstakingquote"></a>
# **BuildStopStakingQuote**
> TransactionQuoteResponse BuildStopStakingQuote (string pool, QuoteStopStakingRequest quoteStopStakingRequest)

Build Stop Staking Transaction Quote

Builds a quote for a transaction to stop staking in an Opdex liquidity pool. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildStopStakingQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var quoteStopStakingRequest = new QuoteStopStakingRequest(); // QuoteStopStakingRequest | 

            try
            {
                // Build Stop Staking Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildStopStakingQuote(pool, quoteStopStakingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildStopStakingQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **quoteStopStakingRequest** | [**QuoteStopStakingRequest**](QuoteStopStakingRequest.md)|  | 

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
| **200** | Built stop staking quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsyncquote"></a>
# **BuildSyncQuote**
> TransactionQuoteResponse BuildSyncQuote (string pool)

Build Sync Transaction Quote

Builds a quote for a transaction to sync an Opdex liquidity pool. This transaction forces the reserves to equal the current token balances. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildSyncQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool

            try
            {
                // Build Sync Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildSyncQuote(pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.BuildSyncQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 

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
| **200** | Built sync quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getliquidityamountinquote"></a>
# **GetLiquidityAmountInQuote**
> LiquidityAmountInQuoteResponse GetLiquidityAmountInQuote (string pool, LiquidityAmountInQuoteRequest liquidityAmountInQuoteRequest)

Add Liquidity Amount In Quote

Retrieves an estimate for the amount of a token required to be added, give an input amount of the other token in the pair.

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
    public class GetLiquidityAmountInQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var liquidityAmountInQuoteRequest = new LiquidityAmountInQuoteRequest(); // LiquidityAmountInQuoteRequest | 

            try
            {
                // Add Liquidity Amount In Quote
                LiquidityAmountInQuoteResponse result = apiInstance.GetLiquidityAmountInQuote(pool, liquidityAmountInQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.GetLiquidityAmountInQuote: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **liquidityAmountInQuoteRequest** | [**LiquidityAmountInQuoteRequest**](LiquidityAmountInQuoteRequest.md)|  | 

### Return type

[**LiquidityAmountInQuoteResponse**](LiquidityAmountInQuoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Add liquidity amount in quote retrieved |  -  |
| **400** | The request is not valid |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getliquiditypool"></a>
# **GetLiquidityPool**
> LiquidityPoolResponse GetLiquidityPool (string pool)

Get Liquidity Pool

Retrieve details for an Opdex liquidity pool.

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
    public class GetLiquidityPoolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool

            try
            {
                // Get Liquidity Pool
                LiquidityPoolResponse result = apiInstance.GetLiquidityPool(pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.GetLiquidityPool: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 

### Return type

[**LiquidityPoolResponse**](LiquidityPoolResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liquidity pool found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getliquiditypoolhistory"></a>
# **GetLiquidityPoolHistory**
> LiquidityPoolSnapshotsResponse GetLiquidityPoolHistory (string pool, DateTime startDateTime, DateTime endDateTime, Interval? interval = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Liquidity Pool History

Retrieves historical transactions, reserves, rewards, volume, cost and staking data for an Opdex liquidity pool. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetLiquidityPoolHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var pool = tMdZ2UfwJorAyErDvqNdVU8kmiLaykuE5L;  // string | Address of a liquidity pool
            var startDateTime = 2022-01-01T00:00:00Z;  // DateTime | Start time for which to retrieve snapshots
            var endDateTime = 2022-12-31T23:59:59;  // DateTime | End time for which to retrieve snapshots
            var interval = 1D;  // Interval? | Time range between each snapshot (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 100;  // int? | Number of results per page; defaults to 168 for hourly snapshots (1 week), or 28 for daily snapshots (4 weeks) (optional)  (default to 168)
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Liquidity Pool History
                LiquidityPoolSnapshotsResponse result = apiInstance.GetLiquidityPoolHistory(pool, startDateTime, endDateTime, interval, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.GetLiquidityPoolHistory: " + e.Message );
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
 **pool** | **string**| Address of a liquidity pool | 
 **startDateTime** | **DateTime**| Start time for which to retrieve snapshots | 
 **endDateTime** | **DateTime**| End time for which to retrieve snapshots | 
 **interval** | **Interval?**| Time range between each snapshot | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page; defaults to 168 for hourly snapshots (1 week), or 28 for daily snapshots (4 weeks) | [optional] [default to 168]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**LiquidityPoolSnapshotsResponse**](LiquidityPoolSnapshotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liquidity pool snapshots found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Liquidity pool not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getliquiditypools"></a>
# **GetLiquidityPools**
> LiquidityPoolsResponse GetLiquidityPools (string keyword = null, List<string> markets = null, List<string> liquidityPools = null, List<string> tokens = null, StakingStatus? stakingStatus = null, NominationStatus? nominationStatus = null, MiningStatus? miningStatus = null, LiquidityPoolOrderByType? orderBy = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Liquidity Pools

Retrieves details for Opdex liquidity pools across one or many markets. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetLiquidityPoolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LiquidityPoolsApi(httpClient, config, httpClientHandler);
            var keyword = BTC;  // string | Keyword search against liquidity pool addresses and names (optional) 
            var markets = new List<string>(); // List<string> | Addresses of markets to search within (optional) 
            var liquidityPools = new List<string>(); // List<string> | Addresses of liquidity pools to fetch (optional) 
            var tokens = new List<string>(); // List<string> | Addresses of SRC tokens paired in pools (optional) 
            var stakingStatus = Enabled;  // StakingStatus? | Staking status filter; default is not to filter (optional) 
            var nominationStatus = Nominated;  // NominationStatus? | Nomination status filter; default is not to filter (optional) 
            var miningStatus = Enabled;  // MiningStatus? | Mining status filter; default is not to filter (optional) 
            var orderBy = Volume;  // LiquidityPoolOrderByType? | Property by which to sort results (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Liquidity Pools
                LiquidityPoolsResponse result = apiInstance.GetLiquidityPools(keyword, markets, liquidityPools, tokens, stakingStatus, nominationStatus, miningStatus, orderBy, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LiquidityPoolsApi.GetLiquidityPools: " + e.Message );
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
 **keyword** | **string**| Keyword search against liquidity pool addresses and names | [optional] 
 **markets** | [**List&lt;string&gt;**](string.md)| Addresses of markets to search within | [optional] 
 **liquidityPools** | [**List&lt;string&gt;**](string.md)| Addresses of liquidity pools to fetch | [optional] 
 **tokens** | [**List&lt;string&gt;**](string.md)| Addresses of SRC tokens paired in pools | [optional] 
 **stakingStatus** | **StakingStatus?**| Staking status filter; default is not to filter | [optional] 
 **nominationStatus** | **NominationStatus?**| Nomination status filter; default is not to filter | [optional] 
 **miningStatus** | **MiningStatus?**| Mining status filter; default is not to filter | [optional] 
 **orderBy** | **LiquidityPoolOrderByType?**| Property by which to sort results | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**LiquidityPoolsResponse**](LiquidityPoolsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liqudidity pool results found |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

