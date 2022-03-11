# Opdex.Client.Api.WalletsApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApprovedAllowance**](WalletsApi.md#getapprovedallowance) | **GET** /wallets/{address}/allowance/{token}/approved/{spender} | Get Approved Allowance
[**GetBalance**](WalletsApi.md#getbalance) | **GET** /wallets/{address}/balance/{token} | Get Balance
[**GetBalances**](WalletsApi.md#getbalances) | **GET** /wallets/{address}/balance | Get Balances
[**GetMiningPosition**](WalletsApi.md#getminingposition) | **GET** /wallets/{address}/mining/{pool} | Get Mining Position
[**GetMiningPositions**](WalletsApi.md#getminingpositions) | **GET** /wallets/{address}/mining | Get Mining Positions
[**GetStakingPosition**](WalletsApi.md#getstakingposition) | **GET** /wallets/{address}/staking/{pool} | Get Staking Position
[**GetStakingPositions**](WalletsApi.md#getstakingpositions) | **GET** /wallets/{address}/staking | Get Staking Positions
[**RefreshBalance**](WalletsApi.md#refreshbalance) | **POST** /wallets/{address}/balance/{token} | Refresh Balance


<a name="getapprovedallowance"></a>
# **GetApprovedAllowance**
> ApprovedAllowanceResponse GetApprovedAllowance (string address, string token, string spender)

Get Approved Allowance

Retrieves the allowance of a spender for SRC tokens owned by another address.

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
    public class GetApprovedAllowanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the SRC token
            var spender = tAFxpxRdcV9foADqD6gK3c8sY5MeANzFp5;  // string | Address approved to spend the token

            try
            {
                // Get Approved Allowance
                ApprovedAllowanceResponse result = apiInstance.GetApprovedAllowance(address, token, spender);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetApprovedAllowance: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **token** | **string**| Address of the SRC token | 
 **spender** | **string**| Address approved to spend the token | 

### Return type

[**ApprovedAllowanceResponse**](ApprovedAllowanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Found approved allowance |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalance"></a>
# **GetBalance**
> AddressBalanceResponse GetBalance (string address, string token)

Get Balance

Retrieves the indexed balance of a tracked SRC token for an address. If you are retrieving the balance of an SRC token for a new address, or want to forcefully reload a balance, use `POST /wallets/{address}/balance/{token}` instead.

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
    public class GetBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the SRC token

            try
            {
                // Get Balance
                AddressBalanceResponse result = apiInstance.GetBalance(address, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetBalance: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **token** | **string**| Address of the SRC token | 

### Return type

[**AddressBalanceResponse**](AddressBalanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Address balance details found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalances"></a>
# **GetBalances**
> AddressBalancesResponse GetBalances (string address, List<string> tokens = null, List<TokenAttributeFilter> tokenAttributes = null, bool? includeZeroBalances = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Balances

Retrieves details of all indexed token balances for an address. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var tokens = new List<string>(); // List<string> | Tokens to retrieve balances for (optional) 
            var tokenAttributes = new List<TokenAttributeFilter>(); // List<TokenAttributeFilter> | Types of tokens to retrieve balances for (optional) 
            var includeZeroBalances = true;  // bool? | Include zero balances if true, otherwise zero balances are excluded if false (optional)  (default to false)
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Balances
                AddressBalancesResponse result = apiInstance.GetBalances(address, tokens, tokenAttributes, includeZeroBalances, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetBalances: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **tokens** | [**List&lt;string&gt;**](string.md)| Tokens to retrieve balances for | [optional] 
 **tokenAttributes** | [**List&lt;TokenAttributeFilter&gt;**](TokenAttributeFilter.md)| Types of tokens to retrieve balances for | [optional] 
 **includeZeroBalances** | **bool?**| Include zero balances if true, otherwise zero balances are excluded if false | [optional] [default to false]
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**AddressBalancesResponse**](AddressBalancesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Address balance results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getminingposition"></a>
# **GetMiningPosition**
> MiningPositionsResponse GetMiningPosition (string address, string pool)

Get Mining Position

Retrieves details of an Opdex mining position that has been indexed.

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
    public class GetMiningPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var pool = tRs6rXfHuLhKZhWuWpycLASzAyn4kXo6bT;  // string | Address of the mining pool

            try
            {
                // Get Mining Position
                MiningPositionsResponse result = apiInstance.GetMiningPosition(address, pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetMiningPosition: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **pool** | **string**| Address of the mining pool | 

### Return type

[**MiningPositionsResponse**](MiningPositionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mining position details retrieved |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Mining pool or mining position not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getminingpositions"></a>
# **GetMiningPositions**
> MiningPositionsResponse GetMiningPositions (string address, List<string> miningPools = null, List<string> liquidityPools = null, bool? includeZeroAmounts = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Mining Positions

Retrieves details of all indexed Opdex mining positions for an address. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetMiningPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var miningPools = new List<string>(); // List<string> | Mining pools to retrieve positions for (optional) 
            var liquidityPools = new List<string>(); // List<string> | Related liquidity pools to retrieve positions for (optional) 
            var includeZeroAmounts = true;  // bool? | Include zero amounts if true, otherwise zero amounts are excluded (optional)  (default to false)
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Mining Positions
                MiningPositionsResponse result = apiInstance.GetMiningPositions(address, miningPools, liquidityPools, includeZeroAmounts, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetMiningPositions: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **miningPools** | [**List&lt;string&gt;**](string.md)| Mining pools to retrieve positions for | [optional] 
 **liquidityPools** | [**List&lt;string&gt;**](string.md)| Related liquidity pools to retrieve positions for | [optional] 
 **includeZeroAmounts** | **bool?**| Include zero amounts if true, otherwise zero amounts are excluded | [optional] [default to false]
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MiningPositionsResponse**](MiningPositionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mining position results retrieved |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstakingposition"></a>
# **GetStakingPosition**
> MiningPositionsResponse GetStakingPosition (string address, string pool)

Get Staking Position

Retrieves details of an Opdex staking position that has been indexed.

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
    public class GetStakingPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var pool = tVFhXcS3gVb49MSTsaDFoqkxLrAUiNEN7n;  // string | Address of the liquidity pool

            try
            {
                // Get Staking Position
                MiningPositionsResponse result = apiInstance.GetStakingPosition(address, pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetStakingPosition: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **pool** | **string**| Address of the liquidity pool | 

### Return type

[**MiningPositionsResponse**](MiningPositionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Staking position details retrieved |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Liquidity pool or staking position not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstakingpositions"></a>
# **GetStakingPositions**
> MiningPositionsResponse GetStakingPositions (string address, List<string> liquidityPools = null, bool? includeZeroAmounts = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Staking Positions

Retrieves details of all indexed Opdex staking positions for an address. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetStakingPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var liquidityPools = new List<string>(); // List<string> | Liquidity pools to retrieve positions for (optional) 
            var includeZeroAmounts = true;  // bool? | Include zero amounts if true, otherwise zero amounts are excluded if false (optional)  (default to false)
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = "cursor_example";  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Staking Positions
                MiningPositionsResponse result = apiInstance.GetStakingPositions(address, liquidityPools, includeZeroAmounts, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.GetStakingPositions: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **liquidityPools** | [**List&lt;string&gt;**](string.md)| Liquidity pools to retrieve positions for | [optional] 
 **includeZeroAmounts** | **bool?**| Include zero amounts if true, otherwise zero amounts are excluded if false | [optional] [default to false]
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**MiningPositionsResponse**](MiningPositionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Staking position results retrieved |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshbalance"></a>
# **RefreshBalance**
> AddressBalanceResponse RefreshBalance (string address, string token)

Refresh Balance

Retrieves and indexes the latest balance of a tracked SRC token for an address.

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
    public class RefreshBalanceExample
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
            var apiInstance = new WalletsApi(httpClient, config, httpClientHandler);
            var address = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address holding the position
            var token = tGSk2dVENuqAQ2rNXbui37XHuurFCTqadD;  // string | Address of the SRC token

            try
            {
                // Refresh Balance
                AddressBalanceResponse result = apiInstance.RefreshBalance(address, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletsApi.RefreshBalance: " + e.Message );
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
 **address** | **string**| Address holding the position | 
 **token** | **string**| Address of the SRC token | 

### Return type

[**AddressBalanceResponse**](AddressBalanceResponse.md)

### Authorization

[opdexAuth](../README.md#opdexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Address balance refreshed |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Token not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |
| **503** | Under maintenance |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

