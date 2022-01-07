# Opdex.Client.Api.TransactionsApi

All URIs are relative to *https://test-api.opdex.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TransactionHashGet**](TransactionsApi.md#transactionhashget) | **GET** /transaction/{hash} | Get Transaction
[**TransactionReplayQuotePost**](TransactionsApi.md#transactionreplayquotepost) | **POST** /transaction/replay-quote | Replay Transaction Quote
[**TransactionsGet**](TransactionsApi.md#transactionsget) | **GET** /transactions | Get Transactions
[**TransactionsPost**](TransactionsApi.md#transactionspost) | **POST** /transactions | Notify Broadcast


<a name="transactionhashget"></a>
# **TransactionHashGet**
> TransactionResponse TransactionHashGet (string hash)

Get Transaction

Retrieves details for a tracked Opdex transaction with the supplied hash.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TransactionHashGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new TransactionsApi(config);
            var hash = 0132da001ca719cc8d98610fbd8493e92c7943c6e0c0844a819f4c90531fd3a6;  // string | The SHA256 hash of the transaction to look up

            try
            {
                // Get Transaction
                TransactionResponse result = apiInstance.TransactionHashGet(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionHashGet: " + e.Message );
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
 **hash** | **string**| The SHA256 hash of the transaction to look up | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Transaction not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionreplayquotepost"></a>
# **TransactionReplayQuotePost**
> TransactionQuoteResponse TransactionReplayQuotePost (ReplayQuoteRequest replayQuoteRequest)

Replay Transaction Quote

Replays a previous transaction quote at the current point in time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TransactionReplayQuotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var replayQuoteRequest = new ReplayQuoteRequest(); // ReplayQuoteRequest | 

            try
            {
                // Replay Transaction Quote
                TransactionQuoteResponse result = apiInstance.TransactionReplayQuotePost(replayQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionReplayQuotePost: " + e.Message );
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
 **replayQuoteRequest** | [**ReplayQuoteRequest**](ReplayQuoteRequest.md)|  | 

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
| **200** | Transaction quote replayed |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionsget"></a>
# **TransactionsGet**
> TransactionsResponse TransactionsGet (string wallet = null, List<string> contracts = null, List<TransactionEventType> eventTypes = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Transactions

Retrieves details for tracked Opdex transactions. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new TransactionsApi(config);
            var wallet = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Filter transactions by wallet address (optional) 
            var contracts = new List<string>(); // List<string> | Smart contract addresses to include (optional) 
            var eventTypes = new List<TransactionEventType>(); // List<TransactionEventType> | Filter to include transactions with event types (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Transactions
                TransactionsResponse result = apiInstance.TransactionsGet(wallet, contracts, eventTypes, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsGet: " + e.Message );
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
 **wallet** | **string**| Filter transactions by wallet address | [optional] 
 **contracts** | [**List&lt;string&gt;**](string.md)| Smart contract addresses to include | [optional] 
 **eventTypes** | [**List&lt;TransactionEventType&gt;**](TransactionEventType.md)| Filter to include transactions with event types | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction results found |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionspost"></a>
# **TransactionsPost**
> void TransactionsPost (NotifyBroadcastRequest notifyBroadcastRequest)

Notify Broadcast

Sends notifications to a user about broadcast transactions. This endpoint is intended to be called by a Stratis Transaction Handoff Broadcastor, as a way to notify a user that their transaction has been broadcast. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class TransactionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new TransactionsApi(config);
            var notifyBroadcastRequest = new NotifyBroadcastRequest(); // NotifyBroadcastRequest | 

            try
            {
                // Notify Broadcast
                apiInstance.TransactionsPost(notifyBroadcastRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.TransactionsPost: " + e.Message );
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
 **notifyBroadcastRequest** | [**NotifyBroadcastRequest**](NotifyBroadcastRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The broadcast notification was sent |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

