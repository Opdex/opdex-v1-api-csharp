# Opdex.Client.Api.VaultsApi

All URIs are relative to *https://test-api.opdex.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuildCompleteProposalQuote**](VaultsApi.md#buildcompleteproposalquote) | **POST** /vault-governances/{vault}/proposals/{proposalId}/complete | Build Complete Proposal Transaction Quote
[**BuildPledgeQuote**](VaultsApi.md#buildpledgequote) | **POST** /vault-governances/{vault}/proposals/{proposalId}/pledges | Build Make Pledge Transaction Quote
[**BuildProposeChangeMinimumPledgeQuote**](VaultsApi.md#buildproposechangeminimumpledgequote) | **POST** /vault-governances/{vault}/proposals/minimum-pledge | Build Propose Change Minimum Pledge Transaction Quote
[**BuildProposeChangeMinimumVoteQuote**](VaultsApi.md#buildproposechangeminimumvotequote) | **POST** /vault-governances/{vault}/proposals/minimum-vote | Build Propose Change Minimum Vote Transaction Quote
[**BuildProposeCreateCertificateQuote**](VaultsApi.md#buildproposecreatecertificatequote) | **POST** /vault-governances/{vault}/proposals/create-certificate | Build Propose Create Certificate Transaction Quote
[**BuildProposeRevokeCertificateQuote**](VaultsApi.md#buildproposerevokecertificatequote) | **POST** /vault-governances/{vault}/proposals/revoke-certificate | Build Propose Revoke Certificate Transaction Quote
[**BuildRedeemCertificateQuote**](VaultsApi.md#buildredeemcertificatequote) | **POST** /vault-governances/{vault}/certificates/redeem | Build Redeem Vault Certificate Transaction Quote
[**BuildVoteQuote**](VaultsApi.md#buildvotequote) | **POST** /vault-governances/{vault}/proposals/{proposalId}/votes | Build Cast Vote Transaction Quote
[**BuildWithdrawPledgeQuote**](VaultsApi.md#buildwithdrawpledgequote) | **POST** /vault-governances/{vault}/proposals/{proposalId}/pledges/withdraw | Build Withdraw Pledge Transaction Quote
[**BuildWithdrawVoteQuote**](VaultsApi.md#buildwithdrawvotequote) | **POST** /vault-governances/{vault}/proposals/{proposalId}/votes/withdraw | Build Withdraw Vote Transaction Quote
[**GetCertificates**](VaultsApi.md#getcertificates) | **GET** /vault-governances/{vault}/certificates | Get Vault Certificates
[**GetPledgePosition**](VaultsApi.md#getpledgeposition) | **GET** /vault-governances/{vault}/proposals/{proposalId}/pledges/{pledger} | Get Vault Proposal Pledge Position
[**GetPledges**](VaultsApi.md#getpledges) | **GET** /vault-governances/{vault}/pledges | Get Vault Proposal Pledges
[**GetProposals**](VaultsApi.md#getproposals) | **GET** /vault-governances/{vault}/proposals | Get Vault Proposals
[**GetVault**](VaultsApi.md#getvault) | **GET** /vault-governances/{vault} | Get Vault
[**GetVaultProposal**](VaultsApi.md#getvaultproposal) | **GET** /vault-governances/{vault}/proposals/{proposalId} | Get Vault Proposal
[**GetVaults**](VaultsApi.md#getvaults) | **GET** /vault-governances | Get Vaults
[**GetVotePosition**](VaultsApi.md#getvoteposition) | **GET** /vault-governances/{vault}/proposals/{proposalId}/votes/{voter} | Get Vault Proposal Vote Position
[**GetVotes**](VaultsApi.md#getvotes) | **GET** /vault-governances/{vault}/votes | Get Vault Proposal Votes


<a name="buildcompleteproposalquote"></a>
# **BuildCompleteProposalQuote**
> TransactionQuoteResponse BuildCompleteProposalQuote (string vault, int proposalId)

Build Complete Proposal Transaction Quote

Builds a quote for a transaction to complete a vault proposal. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildCompleteProposalQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal

            try
            {
                // Build Complete Proposal Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildCompleteProposalQuote(vault, proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildCompleteProposalQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 

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
| **200** | Built complete proposal transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault or proposal not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildpledgequote"></a>
# **BuildPledgeQuote**
> TransactionQuoteResponse BuildPledgeQuote (string vault, int proposalId)

Build Make Pledge Transaction Quote

Builds a quote for a transaction to make a pledge to a vault proposal. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildPledgeQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal

            try
            {
                // Build Make Pledge Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildPledgeQuote(vault, proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildPledgeQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 

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
| **200** | Built pledge transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault or proposal not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildproposechangeminimumpledgequote"></a>
# **BuildProposeChangeMinimumPledgeQuote**
> TransactionQuoteResponse BuildProposeChangeMinimumPledgeQuote (string vault)

Build Propose Change Minimum Pledge Transaction Quote

Builds a quote for a transaction to create a proposal for changing the minimum pledge amount. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildProposeChangeMinimumPledgeQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault

            try
            {
                // Build Propose Change Minimum Pledge Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildProposeChangeMinimumPledgeQuote(vault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildProposeChangeMinimumPledgeQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 

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
| **200** | Built propose change minimum pledge transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildproposechangeminimumvotequote"></a>
# **BuildProposeChangeMinimumVoteQuote**
> TransactionQuoteResponse BuildProposeChangeMinimumVoteQuote (string vault)

Build Propose Change Minimum Vote Transaction Quote

Builds a quote for a transaction to create a proposal for changing the minimum vote threshold. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildProposeChangeMinimumVoteQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault

            try
            {
                // Build Propose Change Minimum Vote Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildProposeChangeMinimumVoteQuote(vault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildProposeChangeMinimumVoteQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 

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
| **200** | Built propose change minimum vote transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildproposecreatecertificatequote"></a>
# **BuildProposeCreateCertificateQuote**
> TransactionQuoteResponse BuildProposeCreateCertificateQuote (string vault)

Build Propose Create Certificate Transaction Quote

Builds a quote for a transaction to create a proposal for creating a vault certificate. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildProposeCreateCertificateQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault

            try
            {
                // Build Propose Create Certificate Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildProposeCreateCertificateQuote(vault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildProposeCreateCertificateQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 

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
| **200** | Built propose create certificate transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildproposerevokecertificatequote"></a>
# **BuildProposeRevokeCertificateQuote**
> TransactionQuoteResponse BuildProposeRevokeCertificateQuote (string vault)

Build Propose Revoke Certificate Transaction Quote

Builds a quote for a transaction to create a proposal for revoking a vault certificate. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildProposeRevokeCertificateQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault

            try
            {
                // Build Propose Revoke Certificate Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildProposeRevokeCertificateQuote(vault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildProposeRevokeCertificateQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 

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
| **200** | Built propose revoke certificate transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildredeemcertificatequote"></a>
# **BuildRedeemCertificateQuote**
> TransactionQuoteResponse BuildRedeemCertificateQuote (string vault)

Build Redeem Vault Certificate Transaction Quote

Builds a quote for a transaction to redeem a vault certificate. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildRedeemCertificateQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault

            try
            {
                // Build Redeem Vault Certificate Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildRedeemCertificateQuote(vault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildRedeemCertificateQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 

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
| **200** | Built redeem certificate transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildvotequote"></a>
# **BuildVoteQuote**
> TransactionQuoteResponse BuildVoteQuote (string vault, int proposalId)

Build Cast Vote Transaction Quote

Builds a quote for a transaction to make a vote on a vault proposal. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildVoteQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal

            try
            {
                // Build Cast Vote Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildVoteQuote(vault, proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildVoteQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 

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
| **200** | Built vote transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault or proposal not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildwithdrawpledgequote"></a>
# **BuildWithdrawPledgeQuote**
> TransactionQuoteResponse BuildWithdrawPledgeQuote (string vault, int proposalId)

Build Withdraw Pledge Transaction Quote

Builds a quote for a transaction to withdraw a pledge from a vault proposal. If the proposal is expired or the minimum pledge threshold is met, this will not affect the proposal. Otherwise, the pledge will be negated from the total pledge amount. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildWithdrawPledgeQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal

            try
            {
                // Build Withdraw Pledge Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildWithdrawPledgeQuote(vault, proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildWithdrawPledgeQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 

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
| **200** | Built withdraw pledge transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault or proposal not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildwithdrawvotequote"></a>
# **BuildWithdrawVoteQuote**
> TransactionQuoteResponse BuildWithdrawVoteQuote (string vault, int proposalId)

Build Withdraw Vote Transaction Quote

Builds a quote for a transaction to withdraw a vote from a vault proposal. If the proposal is completed or expired, this will not affect the proposal. Otherwise, the vote will be negated from the current voting weights. The quote can be broadcast by a Stratis Transaction Handoff Broadcastor. See the [specification](https://github.com/Opdex/STHS) for further details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class BuildWithdrawVoteQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            // Configure Bearer token for authorization: opdexAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal

            try
            {
                // Build Withdraw Vote Transaction Quote
                TransactionQuoteResponse result = apiInstance.BuildWithdrawVoteQuote(vault, proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.BuildWithdrawVoteQuote: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 

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
| **200** | Built withdraw vote transaction quote |  -  |
| **400** | The request is not valid |  -  |
| **401** | Unauthorized |  -  |
| **404** | Vault or proposal not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcertificates"></a>
# **GetCertificates**
> CertificatesResponse GetCertificates (string vault, string holder = null, CertificateStatus? status = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Vault Certificates

Retrieves details for certificates existing within tracked Opdex vaults. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var holder = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address of the certificate holder (optional) 
            var status = Vesting;  // CertificateStatus? | Status of the certificates (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Vault Certificates
                CertificatesResponse result = apiInstance.GetCertificates(vault, holder, status, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetCertificates: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **holder** | **string**| Address of the certificate holder | [optional] 
 **status** | **CertificateStatus?**| Status of the certificates | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**CertificatesResponse**](CertificatesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Certificate results found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpledgeposition"></a>
# **GetPledgePosition**
> PledgeResponse GetPledgePosition (string vault, int proposalId, string pledger)

Get Vault Proposal Pledge Position

Retrieves details for a pledgers position on a vault proposal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetPledgePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal
            var pledger = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address of the pledger

            try
            {
                // Get Vault Proposal Pledge Position
                PledgeResponse result = apiInstance.GetPledgePosition(vault, proposalId, pledger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetPledgePosition: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 
 **pledger** | **string**| Address of the pledger | 

### Return type

[**PledgeResponse**](PledgeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pledge position found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault, proposal or pledger not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpledges"></a>
# **GetPledges**
> PledgesResponse GetPledges (string vault, int? proposalId = null, string pledger = null, bool? includeZeroBalances = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Vault Proposal Pledges

Retrieves details for pledges that have been made to proposals within tracked Opdex vaults. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetPledgesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int? | Id of the proposal in the vault (optional) 
            var pledger = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address of the pledger (optional) 
            var includeZeroBalances = true;  // bool? | Includes zero balances if true, otherwise filters out zero balances if false (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Vault Proposal Pledges
                PledgesResponse result = apiInstance.GetPledges(vault, proposalId, pledger, includeZeroBalances, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetPledges: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int?**| Id of the proposal in the vault | [optional] 
 **pledger** | **string**| Address of the pledger | [optional] 
 **includeZeroBalances** | **bool?**| Includes zero balances if true, otherwise filters out zero balances if false | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**PledgesResponse**](PledgesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pledge results found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproposals"></a>
# **GetProposals**
> ProposalsResponse GetProposals (string vault, ProposalStatus? status = null, ProposalType? type = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Vault Proposals

Retrieves details for proposals existing within tracked Opdex vaults. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetProposalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var status = Complete;  // ProposalStatus? | Status of the proposal (optional) 
            var type = Create;  // ProposalType? | Type of proposal (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Vault Proposals
                ProposalsResponse result = apiInstance.GetProposals(vault, status, type, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetProposals: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **status** | **ProposalStatus?**| Status of the proposal | [optional] 
 **type** | **ProposalType?**| Type of proposal | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**ProposalsResponse**](ProposalsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Proposal results found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvault"></a>
# **GetVault**
> VaultResponse GetVault (string vault)

Get Vault

Retrieves details of a vault tracked by the Opdex indexer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetVaultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault

            try
            {
                // Get Vault
                VaultResponse result = apiInstance.GetVault(vault);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVault: " + e.Message );
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
 **vault** | **string**| Address of the vault | 

### Return type

[**VaultResponse**](VaultResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vault found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvaultproposal"></a>
# **GetVaultProposal**
> ProposalResponse GetVaultProposal (string vault, int proposalId)

Get Vault Proposal

Retrieves a proposal that exists in a tracked Opdex vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetVaultProposalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal

            try
            {
                // Get Vault Proposal
                ProposalResponse result = apiInstance.GetVaultProposal(vault, proposalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVaultProposal: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 

### Return type

[**ProposalResponse**](ProposalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Proposal found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault or proposal not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvaults"></a>
# **GetVaults**
> VaultsResponse GetVaults (string lockedToken = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Vaults

Retrieves details for tracked Opdex vaults. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetVaultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var lockedToken = tBeY2UAVsbHoS9jwEnT2kMmRsJwUHK1j1L;  // string | Address of the token locked in the vault (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Vaults
                VaultsResponse result = apiInstance.GetVaults(lockedToken, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVaults: " + e.Message );
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
 **lockedToken** | **string**| Address of the token locked in the vault | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**VaultsResponse**](VaultsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vault results found |  -  |
| **400** | The request is not valid |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoteposition"></a>
# **GetVotePosition**
> VoteResponse GetVotePosition (string vault, int proposalId, string voter)

Get Vault Proposal Vote Position

Retrieves details for a voters position on a vault proposal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetVotePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int | Id of the proposal
            var voter = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address of the voter

            try
            {
                // Get Vault Proposal Vote Position
                VoteResponse result = apiInstance.GetVotePosition(vault, proposalId, voter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVotePosition: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int**| Id of the proposal | 
 **voter** | **string**| Address of the voter | 

### Return type

[**VoteResponse**](VoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vote position found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault, proposal or voter not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvotes"></a>
# **GetVotes**
> VotesResponse GetVotes (string vault, int? proposalId = null, string voter = null, bool? includeZeroBalances = null, SortDirection? direction = null, int? limit = null, string cursor = null)

Get Vault Proposal Votes

Retrieves details for votes that have been made against proposals within tracked Opdex vaults. This is a [paginated endpoint](https://docs.opdex.com/reference/using-the-opdex-platform-api#paginated-endpoints), so a request will retrieve a single page of results. It is recommended to supply filters to your query, to reduce the total number of requests that you may have to make.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class GetVotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com";
            var apiInstance = new VaultsApi(config);
            var vault = tS1PEGC4VsovkDgib1MD3eYNv5BL2FAC3i;  // string | Address of the vault
            var proposalId = 1;  // int? | Id of the proposal in the vault (optional) 
            var voter = tQ9RukZsB6bBsenHnGSo1q69CJzWGnxohm;  // string | Address of the voter (optional) 
            var includeZeroBalances = true;  // bool? | Includes zero balances if true, otherwise filters out zero balances if false (optional) 
            var direction = DESC;  // SortDirection? | Order direction of the results (optional) 
            var limit = 10;  // int? | Number of results per page (optional) 
            var cursor = cursor_example;  // string | Reference of the requested page, returned by a previous call (optional) 

            try
            {
                // Get Vault Proposal Votes
                VotesResponse result = apiInstance.GetVotes(vault, proposalId, voter, includeZeroBalances, direction, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VaultsApi.GetVotes: " + e.Message );
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
 **vault** | **string**| Address of the vault | 
 **proposalId** | **int?**| Id of the proposal in the vault | [optional] 
 **voter** | **string**| Address of the voter | [optional] 
 **includeZeroBalances** | **bool?**| Includes zero balances if true, otherwise filters out zero balances if false | [optional] 
 **direction** | **SortDirection?**| Order direction of the results | [optional] 
 **limit** | **int?**| Number of results per page | [optional] 
 **cursor** | **string**| Reference of the requested page, returned by a previous call | [optional] 

### Return type

[**VotesResponse**](VotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/problem+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Vote results found |  -  |
| **400** | The request is not valid |  -  |
| **404** | Vault not found |  -  |
| **429** | Too many requests |  * Retry-After - Indicates how many seconds to wait before making a follow-up request <br>  |
| **500** | Unexpected error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

