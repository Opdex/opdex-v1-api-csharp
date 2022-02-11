# Opdex.Client.Api.TransactionsApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /transactions/{hash} | Get Transaction
[**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /transactions | Get Transactions
[**NotifyTransactionBroadcast**](TransactionsApi.md#notifytransactionbroadcast) | **POST** /transactions | Notify Broadcast
[**ReplayQuote**](TransactionsApi.md#replayquote) | **POST** /transactions/replay-quote | Replay Transaction Quote


<a name="gettransaction"></a>
# **GetTransaction**
> TransactionResponse GetTransaction (string hash)

Get Transaction

Retrieves details for a tracked Opdex transaction with the supplied hash.

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
    public class GetTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var hash = 0132da001ca719cc8d98610fbd8493e92c7943c6e0c0844a819f4c90531fd3a6;  // string | The SHA256 hash of the transaction to look up

            try
            {
                // Get Transaction
                TransactionResponse result = apiInstance.GetTransaction(hash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message );
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
| **200** | Transaction found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **404** | Transaction not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> TransactionsResponse GetTransactions (string sender = null, List<string> contracts = null, List<TransactionEventType> eventTypes = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Transactions

Retrieves details for tracked Opdex transactions. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

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
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var sender = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Filter transactions by sender address (optional) 
            var contracts = new List<string>(); // List<string> | Smart contract addresses to include (optional) 
            var eventTypes = new List<TransactionEventType>(); // List<TransactionEventType> | Filter to include transactions with event types (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional)  (default to 10)
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Transactions
                TransactionsResponse result = apiInstance.GetTransactions(sender, contracts, eventTypes, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message );
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
 **sender** | **string**| Filter transactions by sender address | [optional] 
 **contracts** | [**List&lt;string&gt;**](string.md)| Smart contract addresses to include | [optional] 
 **eventTypes** | [**List&lt;TransactionEventType&gt;**](TransactionEventType.md)| Filter to include transactions with event types | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] [default to 10]
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
| **200** | Transaction results found |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notifytransactionbroadcast"></a>
# **NotifyTransactionBroadcast**
> void NotifyTransactionBroadcast (NotifyBroadcastRequest notifyBroadcastRequest)

Notify Broadcast

Sends notifications to a user about broadcast transactions. This endpoint is intended to be called by a Stratis Transaction Handoff Broadcastor, as a way to notify a user that their transaction has been broadcast. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class NotifyTransactionBroadcastExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var notifyBroadcastRequest = new NotifyBroadcastRequest(); // NotifyBroadcastRequest | 

            try
            {
                // Notify Broadcast
                apiInstance.NotifyTransactionBroadcast(notifyBroadcastRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.NotifyTransactionBroadcast: " + e.Message );
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
| **404** | Raw transaction not found. |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replayquote"></a>
# **ReplayQuote**
> TransactionQuoteResponse ReplayQuote (QuotedTransaction quotedTransaction)

Replay Transaction Quote

Replays a previous transaction quote at the current point in time. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

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
    public class ReplayQuoteExample
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
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var quotedTransaction = new QuotedTransaction(); // QuotedTransaction | Contents of the `request` property from a previously quoted transaction.

            try
            {
                // Replay Transaction Quote
                TransactionQuoteResponse result = apiInstance.ReplayQuote(quotedTransaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ReplayQuote: " + e.Message );
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
 **quotedTransaction** | [**QuotedTransaction**](QuotedTransaction.md)| Contents of the &#x60;request&#x60; property from a previously quoted transaction. | 

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
| **200** | Transaction quote replayed |  * Cache-Control - Holds directives that control caching <br>  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

