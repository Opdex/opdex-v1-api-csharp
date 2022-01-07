# Opdex.Client.Api.MarketsApi

All URIs are relative to *https://test-api.opdex.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarkets**](MarketsApi.md#getmarkets) | **GET** /markets | Get Markets


<a name="getmarkets"></a>
# **GetMarkets**
> MarketsResponse GetMarkets (MarketType? marketType = null, MarketOrderByType? orderBy = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Markets

Retrieves details for the tracked markets. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new MarketsApi(config);
            var marketType = Staking;  // MarketType? | Market type filter (optional) 
            var orderBy = DailyLiquidityUsdChangePercent;  // MarketOrderByType? | Property by which to sort results (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
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
 **marketType** | **MarketType?**| Market type filter | [optional] 
 **orderBy** | **MarketOrderByType?**| Property by which to sort results | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
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

