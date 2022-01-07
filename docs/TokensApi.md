# Opdex.Client.Api.TokensApi

All URIs are relative to *https://test-api.opdex.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TokensGet**](TokensApi.md#tokensget) | **GET** /tokens | Get Tokens
[**TokensPost**](TokensApi.md#tokenspost) | **POST** /tokens | Add Token
[**TokensTokenApprovePost**](TokensApi.md#tokenstokenapprovepost) | **POST** /tokens/{token}/approve | Build Approve Allowance Transaction Quote
[**TokensTokenDistributePost**](TokensApi.md#tokenstokendistributepost) | **POST** /tokens/{token}/distribute | Build Distribute Tokens Transaction Quote
[**TokensTokenGet**](TokensApi.md#tokenstokenget) | **GET** /tokens/{token} | Get Token
[**TokensTokenHistoryGet**](TokensApi.md#tokenstokenhistoryget) | **GET** /tokens/{token}/history | Get Token History


<a name="tokensget"></a>
# **TokensGet**
> TokensResponse TokensGet (TokenType? tokenType = null, List<string> tokens = null, string keyword = null, TokenOrderByType? orderBy = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Tokens

Retrieves details of all tracked tokens across markets. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TokensGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new TokensApi(config);
            var tokenType = Provisional;  // TokenType? | Token type filter (optional) 
            var tokens = new List<string>(); // List<string> | Specific tokens to include (optional) 
            var keyword = keyword_example;  // string | Keyword search against token address, name and ticker symbol (optional) 
            var orderBy = ;  // TokenOrderByType? | Property by which to sort results (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Tokens
                TokensResponse result = apiInstance.TokensGet(tokenType, tokens, keyword, orderBy, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensGet: " + e.Message );
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
 **tokenType** | **TokenType?**| Token type filter | [optional] 
 **tokens** | [**List&lt;string&gt;**](string.md)| Specific tokens to include | [optional] 
 **keyword** | **string**| Keyword search against token address, name and ticker symbol | [optional] 
 **orderBy** | **TokenOrderByType?**| Property by which to sort results | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
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
| **200** | Token results found |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenspost"></a>
# **TokensPost**
> TokenResponse TokensPost (AddTokenRequest addTokenRequest)

Add Token

Adds an SRC token to the Opdex indexer, so that it can be tracked and used within markets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TokensPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TokensApi(config);
            var addTokenRequest = new AddTokenRequest(); // AddTokenRequest | 

            try
            {
                // Add Token
                TokenResponse result = apiInstance.TokensPost(addTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensPost: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenstokenapprovepost"></a>
# **TokensTokenApprovePost**
> TransactionQuoteResponse TokensTokenApprovePost (string token)

Build Approve Allowance Transaction Quote

Builds a quote for an allowance approval transaction. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TokensTokenApprovePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TokensApi(config);
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token

            try
            {
                // Build Approve Allowance Transaction Quote
                TransactionQuoteResponse result = apiInstance.TokensTokenApprovePost(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensTokenApprovePost: " + e.Message );
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

[**TransactionQuoteResponse**](TransactionQuoteResponse.md)

### Authorization

[opdexAuth](../README.md#opdexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Built approve allowance transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenstokendistributepost"></a>
# **TokensTokenDistributePost**
> TransactionQuoteResponse TokensTokenDistributePost (string token)

Build Distribute Tokens Transaction Quote

Builds a quote for a transaction to distribute governance tokens, to the mining governance and vault. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TokensTokenDistributePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TokensApi(config);
            var token = tBeY2UAVsbHoS9jwEnT2kMmRsJwUHK1j1L;  // string | Address of the governance token

            try
            {
                // Build Distribute Tokens Transaction Quote
                TransactionQuoteResponse result = apiInstance.TokensTokenDistributePost(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensTokenDistributePost: " + e.Message );
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
| **200** | Built distribute tokens transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenstokenget"></a>
# **TokensTokenGet**
> TokenResponse TokensTokenGet (string token)

Get Token

Retrieves details of a token tracked by the Opdex indexer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TokensTokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new TokensApi(config);
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token

            try
            {
                // Get Token
                TokenResponse result = apiInstance.TokensTokenGet(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensTokenGet: " + e.Message );
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
| **200** | Token details found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tokenstokenhistoryget"></a>
# **TokensTokenHistoryGet**
> TokenSnapshotsResponse TokensTokenHistoryGet (string token, DateTime startDateTime, DateTime endDateTime, Interval? interval = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Token History

Retrieves historical pricing data for a token tracked by the Opdex indexer. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TokensTokenHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new TokensApi(config);
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the token
            var startDateTime = 2022-01-01T00:00:00Z;  // DateTime | Start time for which to retrieve snapshots
            var endDateTime = 2022-12-31T23:59:59;  // DateTime | End time for which to retrieve snapshots
            var interval = 1D;  // Interval? | Time range between each snapshot (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 100;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Token History
                TokenSnapshotsResponse result = apiInstance.TokensTokenHistoryGet(token, startDateTime, endDateTime, interval, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.TokensTokenHistoryGet: " + e.Message );
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
 **startDateTime** | **DateTime**| Start time for which to retrieve snapshots | 
 **endDateTime** | **DateTime**| End time for which to retrieve snapshots | 
 **interval** | **Interval?**| Time range between each snapshot | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
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
| **200** | Token results found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

