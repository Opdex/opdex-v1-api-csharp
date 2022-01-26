# Opdex.Client.Api.MarketsApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuildClaimMarketOwnershipQuote**](MarketsApi.md#buildclaimmarketownershipquote) | **POST** /markets/{market}/standard/claim-ownership | Build Claim Market Ownership Transaction Quote
[**BuildCollectMarketFeesQuote**](MarketsApi.md#buildcollectmarketfeesquote) | **POST** /markets/{market}/standard/collect-fees | Build Collect Market Fees Transaction Quote
[**BuildCreateStakingMarketQuote**](MarketsApi.md#buildcreatestakingmarketquote) | **POST** /markets/staking | Build Create Staking Market Transaction Quote
[**BuildCreateStandardMarketQuote**](MarketsApi.md#buildcreatestandardmarketquote) | **POST** /markets/standard | Build Create Standard Market Transaction Quote
[**BuildSetMarketOwnershipQuote**](MarketsApi.md#buildsetmarketownershipquote) | **POST** /markets/{market}/standard/set-ownership | Build Set Market Ownership Transaction Quote
[**BuildSetMarketPermissionsQuote**](MarketsApi.md#buildsetmarketpermissionsquote) | **POST** /markets/{market}/standard/permissions/{address} | Build Set Market Permissions Transaction Quote
[**GetMarket**](MarketsApi.md#getmarket) | **GET** /markets/{market} | Get Market
[**GetMarketHistory**](MarketsApi.md#getmarkethistory) | **GET** /markets/{market}/history | Get Market History
[**GetMarketPermissions**](MarketsApi.md#getmarketpermissions) | **GET** /markets/{market}/standard/permissions/{address} | Get Market Permissions
[**GetMarkets**](MarketsApi.md#getmarkets) | **GET** /markets | Get Markets


<a name="buildclaimmarketownershipquote"></a>
# **BuildClaimMarketOwnershipQuote**
> TransactionQuoteResponse BuildClaimMarketOwnershipQuote (string market)

Build Claim Market Ownership Transaction Quote

Builds a quote for a claim market ownership transaction. Only the pending owner of the market deployer can successfully execute this call. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildClaimMarketOwnershipQuoteExample
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
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market

            try
            {
                // Build Claim Market Ownership Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildClaimMarketOwnershipQuote(market);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.BuildClaimMarketOwnershipQuote: " + e.Message );
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
 **market** | **string**| Address of a market | 

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
| **200** | Built claim market ownership quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildcollectmarketfeesquote"></a>
# **BuildCollectMarketFeesQuote**
> TransactionQuoteResponse BuildCollectMarketFeesQuote (string market, QuoteCollectMarketFeesRequest quoteCollectMarketFeesRequest)

Build Collect Market Fees Transaction Quote

Builds a quote for a collect market fees transaction. Only the owner of the market can successfully execute this call. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildCollectMarketFeesQuoteExample
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
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market
            var quoteCollectMarketFeesRequest = new QuoteCollectMarketFeesRequest(); // QuoteCollectMarketFeesRequest | Parameters used to determine fees to collect

            try
            {
                // Build Collect Market Fees Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCollectMarketFeesQuote(market, quoteCollectMarketFeesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.BuildCollectMarketFeesQuote: " + e.Message );
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
 **market** | **string**| Address of a market | 
 **quoteCollectMarketFeesRequest** | [**QuoteCollectMarketFeesRequest**](QuoteCollectMarketFeesRequest.md)| Parameters used to determine fees to collect | 

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
| **200** | Built collect market fees quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildcreatestakingmarketquote"></a>
# **BuildCreateStakingMarketQuote**
> TransactionQuoteResponse BuildCreateStakingMarketQuote (QuoteCreateStakingMarketRequest quoteCreateStakingMarketRequest)

Build Create Staking Market Transaction Quote

Builds a quote for a create staking market transaction. Only the owner of the market deployer can successfully execute this call. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildCreateStakingMarketQuoteExample
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
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var quoteCreateStakingMarketRequest = new QuoteCreateStakingMarketRequest(); // QuoteCreateStakingMarketRequest | Parameters used for the creation of the staking market

            try
            {
                // Build Create Staking Market Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCreateStakingMarketQuote(quoteCreateStakingMarketRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.BuildCreateStakingMarketQuote: " + e.Message );
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
 **quoteCreateStakingMarketRequest** | [**QuoteCreateStakingMarketRequest**](QuoteCreateStakingMarketRequest.md)| Parameters used for the creation of the staking market | 

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
| **200** | Built create staking market quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildcreatestandardmarketquote"></a>
# **BuildCreateStandardMarketQuote**
> TransactionQuoteResponse BuildCreateStandardMarketQuote (QuoteCreateStandardMarketRequest quoteCreateStandardMarketRequest)

Build Create Standard Market Transaction Quote

Builds a quote for a create standard market transaction. Only the owner of the market deployer can successfully execute this call. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildCreateStandardMarketQuoteExample
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
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var quoteCreateStandardMarketRequest = new QuoteCreateStandardMarketRequest(); // QuoteCreateStandardMarketRequest | Parameters used for the creation of the standard market

            try
            {
                // Build Create Standard Market Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCreateStandardMarketQuote(quoteCreateStandardMarketRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.BuildCreateStandardMarketQuote: " + e.Message );
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
 **quoteCreateStandardMarketRequest** | [**QuoteCreateStandardMarketRequest**](QuoteCreateStandardMarketRequest.md)| Parameters used for the creation of the standard market | 

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
| **200** | Built create staking market quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsetmarketownershipquote"></a>
# **BuildSetMarketOwnershipQuote**
> TransactionQuoteResponse BuildSetMarketOwnershipQuote (string market, QuoteSetMarketOwnerRequest quoteSetMarketOwnerRequest)

Build Set Market Ownership Transaction Quote

Builds a quote for a set market ownership transaction. Only the owner of the market can successfully execute this call. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildSetMarketOwnershipQuoteExample
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
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market
            var quoteSetMarketOwnerRequest = new QuoteSetMarketOwnerRequest(); // QuoteSetMarketOwnerRequest | Parameters used for setting the market owner

            try
            {
                // Build Set Market Ownership Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildSetMarketOwnershipQuote(market, quoteSetMarketOwnerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.BuildSetMarketOwnershipQuote: " + e.Message );
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
 **market** | **string**| Address of a market | 
 **quoteSetMarketOwnerRequest** | [**QuoteSetMarketOwnerRequest**](QuoteSetMarketOwnerRequest.md)| Parameters used for setting the market owner | 

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
| **200** | Built set market ownership quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildsetmarketpermissionsquote"></a>
# **BuildSetMarketPermissionsQuote**
> TransactionQuoteResponse BuildSetMarketPermissionsQuote (string market, string address, QuoteSetMarketPermissionsRequest quoteSetMarketPermissionsRequest)

Build Set Market Permissions Transaction Quote

Builds a quote for a set market permissions transaction. This call can only successfully be executed if done by the market owner, or an address which has been assigned this permission. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildSetMarketPermissionsQuoteExample
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
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address subject to the permissions
            var quoteSetMarketPermissionsRequest = new QuoteSetMarketPermissionsRequest(); // QuoteSetMarketPermissionsRequest | Parameters used for assigning a market permission

            try
            {
                // Build Set Market Permissions Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildSetMarketPermissionsQuote(market, address, quoteSetMarketPermissionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.BuildSetMarketPermissionsQuote: " + e.Message );
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
 **market** | **string**| Address of a market | 
 **address** | **string**| Address subject to the permissions | 
 **quoteSetMarketPermissionsRequest** | [**QuoteSetMarketPermissionsRequest**](QuoteSetMarketPermissionsRequest.md)| Parameters used for assigning a market permission | 

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
| **200** | Built set market permissions quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarket"></a>
# **GetMarket**
> MarketResponse GetMarket (string market)

Get Market

Retrieves details for an Opdex market.

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
    public class GetMarketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market

            try
            {
                // Get Market
                MarketResponse result = apiInstance.GetMarket(market);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.GetMarket: " + e.Message );
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
 **market** | **string**| Address of a market | 

### Return type

[**MarketResponse**](MarketResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Market details found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarkethistory"></a>
# **GetMarketHistory**
> MarketSnapshotsResponse GetMarketHistory (string market, DateTime startDateTime, DateTime endDateTime, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Market History

Retrieves historical liquidity, rewards, volume and staking data for an Opdex market. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetMarketHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market
            var startDateTime = 2022-01-01T00:00:00Z;  // DateTime | Start time for which to retrieve snapshots
            var endDateTime = 2022-12-31T23:59:59;  // DateTime | End time for which to retrieve snapshots
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page; defaults to 28 (4 weeks) (optional)  (default to 28)
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Market History
                MarketSnapshotsResponse result = apiInstance.GetMarketHistory(market, startDateTime, endDateTime, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.GetMarketHistory: " + e.Message );
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
 **market** | **string**| Address of a market | 
 **startDateTime** | **DateTime**| Start time for which to retrieve snapshots | 
 **endDateTime** | **DateTime**| End time for which to retrieve snapshots | 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page; defaults to 28 (4 weeks) | [optional] [default to 28]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MarketSnapshotsResponse**](MarketSnapshotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Market details found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketpermissions"></a>
# **GetMarketPermissions**
> List&lt;MarketPermission&gt; GetMarketPermissions (string market, string address)

Get Market Permissions

Retrieves permissions within a market that are assigned to an address.

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
    public class GetMarketPermissionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var market = t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb;  // string | Address of a market
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address subject to the permissions

            try
            {
                // Get Market Permissions
                List<MarketPermission> result = apiInstance.GetMarketPermissions(market, address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.GetMarketPermissions: " + e.Message );
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
 **market** | **string**| Address of a market | 
 **address** | **string**| Address subject to the permissions | 

### Return type

[**List&lt;MarketPermission&gt;**](MarketPermission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved assigned market permissions |  -  |
| **400** | The request is not valid |  -  |
| **404** | Market not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarkets"></a>
# **GetMarkets**
> MarketsResponse GetMarkets (MarketTypeFilter? marketType = null, MarketOrderByType? orderBy = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Markets

Retrieves details for the tracked markets. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetMarketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MarketsApi(httpClient, config, httpClientHandler);
            var marketType = Staking;  // MarketTypeFilter? | Market type filter (optional) 
            var orderBy = DailyLiquidityUsdChangePercent;  // MarketOrderByType? | Property by which to sort results (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Markets
                MarketsResponse result = apiInstance.GetMarkets(marketType, orderBy, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketsApi.GetMarkets: " + e.Message );
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
 **marketType** | **MarketTypeFilter?**| Market type filter | [optional] 
 **orderBy** | **MarketOrderByType?**| Property by which to sort results | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MarketsResponse**](MarketsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Market results found |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

