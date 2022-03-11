# Opdex.Client.Api.TokensApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToken**](TokensApi.md#addtoken) | **POST** /tokens | Add Token
[**BuildApproveAllowanceQuote**](TokensApi.md#buildapproveallowancequote) | **POST** /tokens/{token}/approve | Build Approve Allowance Transaction Quote
[**BuildDistributeTokensQuote**](TokensApi.md#builddistributetokensquote) | **POST** /tokens/{token}/distribute | Build Distribute Tokens Transaction Quote
[**GetToken**](TokensApi.md#gettoken) | **GET** /tokens/{token} | Get Token
[**GetTokenHistory**](TokensApi.md#gettokenhistory) | **GET** /tokens/{token}/history | Get Token History
[**GetTokens**](TokensApi.md#gettokens) | **GET** /tokens | Get Tokens


<a name="addtoken"></a>
# **AddToken**
> TokenResponse AddToken (AddTokenRequest addTokenRequest)

Add Token

Adds an SRC token to the Opdex indexer, so that it can be tracked and used within markets.

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
    public class AddTokenExample
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
            var apiInstance = new TokensApi(httpClient, config, httpClientHandler);
            var addTokenRequest = new AddTokenRequest(); // AddTokenRequest | 

            try
            {
                // Add Token
                TokenResponse result = apiInstance.AddToken(addTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.AddToken: " + e.Message );
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
 **addTokenRequest** | [**AddTokenRequest**](AddTokenRequest.md)|  | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

[opdexAuth](../README.md#opdexAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Token was added to the indexer |  * Location - Request location to retrieve details of the added token <br>  |
| **303** | Token is already indexed |  * Location - Request location to retrieve details of the added token <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildapproveallowancequote"></a>
# **BuildApproveAllowanceQuote**
> TransactionQuoteResponse BuildApproveAllowanceQuote (string token, QuoteApproveAllowanceRequest quoteApproveAllowanceRequest)

Build Approve Allowance Transaction Quote

Builds a quote for an allowance approval transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildApproveAllowanceQuoteExample
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
            var apiInstance = new TokensApi(httpClient, config, httpClientHandler);
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token
            var quoteApproveAllowanceRequest = new QuoteApproveAllowanceRequest(); // QuoteApproveAllowanceRequest | Parameters used for the approval of a token allowance

            try
            {
                // Build Approve Allowance Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildApproveAllowanceQuote(token, quoteApproveAllowanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.BuildApproveAllowanceQuote: " + e.Message );
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
 **token** | **string**| Address of the token | 
 **quoteApproveAllowanceRequest** | [**QuoteApproveAllowanceRequest**](QuoteApproveAllowanceRequest.md)| Parameters used for the approval of a token allowance | 

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
| **200** | Built approve allowance transaction quote |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="builddistributetokensquote"></a>
# **BuildDistributeTokensQuote**
> TransactionQuoteResponse BuildDistributeTokensQuote (string token)

Build Distribute Tokens Transaction Quote

Builds a quote for a transaction to distribute governance tokens, to the mining governance and vault. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class BuildDistributeTokensQuoteExample
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
            var apiInstance = new TokensApi(httpClient, config, httpClientHandler);
            var token = tTTuKbCR2UnsEByXBp1ynBz91J2yz63h1c;  // string | Address of the governance token

            try
            {
                // Build Distribute Tokens Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildDistributeTokensQuote(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.BuildDistributeTokensQuote: " + e.Message );
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
 **token** | **string**| Address of the governance token | 

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
| **200** | Built distribute tokens transaction quote |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettoken"></a>
# **GetToken**
> TokenResponse GetToken (string token)

Get Token

Retrieves details of a token tracked by the Opdex indexer.

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
    public class GetTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TokensApi(httpClient, config, httpClientHandler);
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token

            try
            {
                // Get Token
                TokenResponse result = apiInstance.GetToken(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.GetToken: " + e.Message );
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
 **token** | **string**| Address of the token | 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token details found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokenhistory"></a>
# **GetTokenHistory**
> TokenSnapshotsResponse GetTokenHistory (string token, Interval? interval = null, DateTime? startDateTime = null, DateTime? endDateTime = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Token History

Retrieves historical pricing data for a token tracked by the Opdex indexer. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetTokenHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TokensApi(httpClient, config, httpClientHandler);
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token
            var interval = 1D;  // Interval? | Time range between each snapshot (optional) 
            var startDateTime = 2022-01-01T00:00:00Z;  // DateTime? | Start time for which to retrieve snapshots (optional) 
            var endDateTime = 2022-12-31T23:59:59;  // DateTime? | End time for which to retrieve snapshots (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 100;  // int? | Number of results per page; defaults to 168 for hourly snapshots (1 week), or 28 for daily snapshots (4 weeks) (optional)  (default to 168)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Token History
                TokenSnapshotsResponse result = apiInstance.GetTokenHistory(token, interval, startDateTime, endDateTime, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.GetTokenHistory: " + e.Message );
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
 **token** | **string**| Address of the token | 
 **interval** | **Interval?**| Time range between each snapshot | [optional] 
 **startDateTime** | **DateTime?**| Start time for which to retrieve snapshots | [optional] 
 **endDateTime** | **DateTime?**| End time for which to retrieve snapshots | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page; defaults to 168 for hourly snapshots (1 week), or 28 for daily snapshots (4 weeks) | [optional] [default to 168]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**TokenSnapshotsResponse**](TokenSnapshotsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token snapshot results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettokens"></a>
# **GetTokens**
> TokensResponse GetTokens (List<TokenAttributeFilter> tokenAttributes = null, List<ChainFilter> nativeChains = null, List<string> tokens = null, string keyword = null, TokenOrderByType? orderBy = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Tokens

Retrieves details of all tracked tokens across markets. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TokensApi(httpClient, config, httpClientHandler);
            var tokenAttributes = new List<TokenAttributeFilter>(); // List<TokenAttributeFilter> | Token attributes filter (optional) 
            var nativeChains = new List<ChainFilter>(); // List<ChainFilter> | Native chain filter (optional) 
            var tokens = new List<string>(); // List<string> | Specific tokens to include (optional) 
            var keyword = "keyword_example";  // string | Keyword search against token address, name and ticker symbol (optional) 
            var orderBy = (TokenOrderByType) "CreatedBlock";  // TokenOrderByType? | Property by which to sort results (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Tokens
                TokensResponse result = apiInstance.GetTokens(tokenAttributes, nativeChains, tokens, keyword, orderBy, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.GetTokens: " + e.Message );
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
 **tokenAttributes** | [**List&lt;TokenAttributeFilter&gt;**](TokenAttributeFilter.md)| Token attributes filter | [optional] 
 **nativeChains** | [**List&lt;ChainFilter&gt;**](ChainFilter.md)| Native chain filter | [optional] 
 **tokens** | [**List&lt;string&gt;**](string.md)| Specific tokens to include | [optional] 
 **keyword** | **string**| Keyword search against token address, name and ticker symbol | [optional] 
 **orderBy** | **TokenOrderByType?**| Property by which to sort results | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**TokensResponse**](TokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Token results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

