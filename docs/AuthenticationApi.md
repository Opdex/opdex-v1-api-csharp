# Opdex.Client.Api.AuthenticationApi

All URIs are relative to *https://test-api.opdex.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Authenticate**](AuthenticationApi.md#authenticate) | **POST** /auth | Stratis Signature Auth


<a name="authenticate"></a>
# **Authenticate**
> void Authenticate (string uid, StratisSignatureAuthRequest stratisSignatureAuthRequest, long? exp = null)

Stratis Signature Auth

Responds to a request from a Stratis Signature Auth Signer. See the [specification](https://github.com/Opdex/SSAS) for futher detail. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new AuthenticationApi(config);
            var uid = Lf5t5J-oAn3CZ9YY27JnK5XtpbjIOD3BxyvHhd80AQ4fsJ7o0J8i5uSjzHZ9jeS3;  // string | Unique identifier for the Stratis ID
            var stratisSignatureAuthRequest = new StratisSignatureAuthRequest(); // StratisSignatureAuthRequest | The Stratis Signature Auth body
            var exp = 1641220000;  // long? | Unix timestamp indicating when the signature expires (optional) 

            try
            {
                // Stratis Signature Auth
                apiInstance.Authenticate(uid, stratisSignatureAuthRequest, exp);
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
 **stratisSignatureAuthRequest** | [**StratisSignatureAuthRequest**](StratisSignatureAuthRequest.md)| The Stratis Signature Auth body | 
 **exp** | **long?**| Unix timestamp indicating when the signature expires | [optional] 

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

