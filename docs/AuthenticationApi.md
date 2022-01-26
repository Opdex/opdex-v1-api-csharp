# Opdex.Client.Api.AuthenticationApi

All URIs are relative to *https://v1-test-api.opdex.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Authenticate**](AuthenticationApi.md#authenticate) | **POST** /auth | Stratis Signature Auth
[**AuthenticateCallback**](AuthenticationApi.md#authenticatecallback) | **POST** /auth/callback | Stratis Signature Auth Callback
[**GetStratisId**](AuthenticationApi.md#getstratisid) | **GET** /auth | Get Stratis Id


<a name="authenticate"></a>
# **Authenticate**
> string Authenticate (string uid, long exp, StratisSignatureAuthRequest stratisSignatureAuthRequest)

Stratis Signature Auth

Responds to a request from a Stratis Signature Auth signer directly. See the [specification](https://github.com/Opdex/SSAS) for further detail. 

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
    public class AuthenticateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var uid = Lf5t5J-oAn3CZ9YY27JnK5XtpbjIOD3BxyvHhd80AQ4fsJ7o0J8i5uSjzHZ9jeS3;  // string | Unique identifier for the Stratis ID
            var exp = 1641220000;  // long | Unix timestamp indicating when the signature expires
            var stratisSignatureAuthRequest = new StratisSignatureAuthRequest(); // StratisSignatureAuthRequest | The Stratis Signature Auth body

            try
            {
                // Stratis Signature Auth
                string result = apiInstance.Authenticate(uid, exp, stratisSignatureAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Authenticate: " + e.Message );
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
 **uid** | **string**| Unique identifier for the Stratis ID | 
 **exp** | **long**| Unix timestamp indicating when the signature expires | 
 **stratisSignatureAuthRequest** | [**StratisSignatureAuthRequest**](StratisSignatureAuthRequest.md)| The Stratis Signature Auth body | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Signature was validated successfully |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticatecallback"></a>
# **AuthenticateCallback**
> void AuthenticateCallback (string uid, long exp, StratisSignatureAuthRequest stratisSignatureAuthRequest)

Stratis Signature Auth Callback

Responds to a request from a Stratis Signature Auth signer's wallet. See the [specification](https://github.com/Opdex/SSAS) for further detail. 

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
    public class AuthenticateCallbackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var uid = Lf5t5J-oAn3CZ9YY27JnK5XtpbjIOD3BxyvHhd80AQ4fsJ7o0J8i5uSjzHZ9jeS3;  // string | Unique identifier for the Stratis ID
            var exp = 1641220000;  // long | Unix timestamp indicating when the signature expires
            var stratisSignatureAuthRequest = new StratisSignatureAuthRequest(); // StratisSignatureAuthRequest | The Stratis Signature Auth body

            try
            {
                // Stratis Signature Auth Callback
                apiInstance.AuthenticateCallback(uid, exp, stratisSignatureAuthRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticateCallback: " + e.Message );
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
 **uid** | **string**| Unique identifier for the Stratis ID | 
 **exp** | **long**| Unix timestamp indicating when the signature expires | 
 **stratisSignatureAuthRequest** | [**StratisSignatureAuthRequest**](StratisSignatureAuthRequest.md)| The Stratis Signature Auth body | 

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
| **204** | Signature was validated successfully |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstratisid"></a>
# **GetStratisId**
> string GetStratisId ()

Get Stratis Id

Returns a new Stratis Id to sign and authenticate. See the [specification](https://github.com/Opdex/SSAS) for further detail. 

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
    public class GetStratisIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://v1-test-api.opdex.com/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);

            try
            {
                // Get Stratis Id
                string result = apiInstance.GetStratisId();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetStratisId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Stratis Id was created |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

