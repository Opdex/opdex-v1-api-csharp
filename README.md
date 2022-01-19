# Opdex.Client - the C# library for the Opdex Platform API

The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0-alpha1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://github.com/Opdex/opdex-v1-api](https://github.com/Opdex/opdex-v1-api)

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Opdex.Client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Opdex.Client.Api;
using Opdex.Client.Client;
using Opdex.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://test-api.opdex.com/v1";
            var apiInstance = new AuthenticationApi(config);
            var uid = Lf5t5J-oAn3CZ9YY27JnK5XtpbjIOD3BxyvHhd80AQ4fsJ7o0J8i5uSjzHZ9jeS3;  // string | Unique identifier for the Stratis ID
            var stratisSignatureAuthRequest = new StratisSignatureAuthRequest(); // StratisSignatureAuthRequest | The Stratis Signature Auth body
            var exp = 1641220000;  // long? | Unix timestamp indicating when the signature expires (optional) 

            try
            {
                // Stratis Signature Auth
                apiInstance.Authenticate(uid, stratisSignatureAuthRequest, exp);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Authenticate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://test-api.opdex.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**Authenticate**](docs/AuthenticationApi.md#authenticate) | **POST** /auth | Stratis Signature Auth
*IndexerApi* | [**GetIndexerStatus**](docs/IndexerApi.md#getindexerstatus) | **GET** /indexer | Get Indexer Status
*LiquidityPoolsApi* | [**BuildAddLiquidityQuote**](docs/LiquidityPoolsApi.md#buildaddliquidityquote) | **POST** /liquidity-pools/{pool}/add | Build Add Liquidity Transaction Quote
*LiquidityPoolsApi* | [**BuildCollectStakingRewardsQuote**](docs/LiquidityPoolsApi.md#buildcollectstakingrewardsquote) | **POST** /liquidity-pools/{pool}/staking/collect | Build Collect Staking Rewards Transaction Quote
*LiquidityPoolsApi* | [**BuildCreateLiquidityPoolQuote**](docs/LiquidityPoolsApi.md#buildcreateliquiditypoolquote) | **POST** /liquidity-pools | Build Create Liquidity Pool Transaction Quote
*LiquidityPoolsApi* | [**BuildRemoveLiquidityQuote**](docs/LiquidityPoolsApi.md#buildremoveliquidityquote) | **POST** /liquidity-pools/{pool}/remove | Build Remove Liquidity Transaction Quote
*LiquidityPoolsApi* | [**BuildSkimQuote**](docs/LiquidityPoolsApi.md#buildskimquote) | **POST** /liquidity-pools/{pool}/skim | Build Skim Transaction Quote
*LiquidityPoolsApi* | [**BuildStartStakingQuote**](docs/LiquidityPoolsApi.md#buildstartstakingquote) | **POST** /liquidity-pools/{pool}/staking/start | Build Start Staking Transaction Quote
*LiquidityPoolsApi* | [**BuildStopStakingQuote**](docs/LiquidityPoolsApi.md#buildstopstakingquote) | **POST** /liquidity-pools/{pool}/staking/stop | Build Stop Staking Transaction Quote
*LiquidityPoolsApi* | [**BuildSyncQuote**](docs/LiquidityPoolsApi.md#buildsyncquote) | **POST** /liquidity-pools/{pool}/sync | Build Sync Transaction Quote
*LiquidityPoolsApi* | [**GetLiquidityAmountInQuote**](docs/LiquidityPoolsApi.md#getliquidityamountinquote) | **POST** /liquidity-pools/{pool}/add/amount-in | Add Liquidity Amount In Quote
*LiquidityPoolsApi* | [**GetLiquidityPool**](docs/LiquidityPoolsApi.md#getliquiditypool) | **GET** /liquidity-pools/{pool} | Get Liquidity Pool
*LiquidityPoolsApi* | [**GetLiquidityPoolHistory**](docs/LiquidityPoolsApi.md#getliquiditypoolhistory) | **GET** /liquidity-pools/{pool}/history | Get Liquidity Pool History
*LiquidityPoolsApi* | [**GetLiquidityPools**](docs/LiquidityPoolsApi.md#getliquiditypools) | **GET** /liquidity-pools | Get Liquidity Pools
*MarketTokensApi* | [**GetMarketToken**](docs/MarketTokensApi.md#getmarkettoken) | **GET** /markets/{market}/tokens/{token} | Get Market Token
*MarketTokensApi* | [**GetMarketTokenHistory**](docs/MarketTokensApi.md#getmarkettokenhistory) | **GET** /markets/{market}/tokens/{token}/history | Get Market Token History
*MarketTokensApi* | [**GetMarketTokens**](docs/MarketTokensApi.md#getmarkettokens) | **GET** /markets/{market}/tokens | Get Market Tokens
*MarketTokensApi* | [**GetSwapAmountInQuote**](docs/MarketTokensApi.md#getswapamountinquote) | **POST** /markets/{market}/tokens/{token}/swap/amount-in | Swap Amount In Quote
*MarketTokensApi* | [**GetSwapAmountOutQuote**](docs/MarketTokensApi.md#getswapamountoutquote) | **POST** /markets/{market}/tokens/{token}/swap/amount-out | Swap Amount Out Quote
*MarketTokensApi* | [**Swap**](docs/MarketTokensApi.md#swap) | **POST** /markets/{market}/tokens/{token}/swap | Build Swap Tokens Transaction Quote
*MarketsApi* | [**BuildClaimMarketOwnershipQuote**](docs/MarketsApi.md#buildclaimmarketownershipquote) | **POST** /markets/{market}/standard/claim-ownership | Build Claim Market Ownership Transaction Quote
*MarketsApi* | [**BuildCollectMarketFeesQuote**](docs/MarketsApi.md#buildcollectmarketfeesquote) | **POST** /markets/{market}/standard/collect-fees | Build Collect Market Fees Transaction Quote
*MarketsApi* | [**BuildCreateStakingMarketQuote**](docs/MarketsApi.md#buildcreatestakingmarketquote) | **POST** /markets/staking | Build Create Staking Market Transaction Quote
*MarketsApi* | [**BuildCreateStandardMarketQuote**](docs/MarketsApi.md#buildcreatestandardmarketquote) | **POST** /markets/standard | Build Create Standard Market Transaction Quote
*MarketsApi* | [**BuildSetMarketOwnershipQuote**](docs/MarketsApi.md#buildsetmarketownershipquote) | **POST** /markets/{market}/standard/set-ownership | Build Set Market Ownership Transaction Quote
*MarketsApi* | [**BuildSetMarketPermissionsQuote**](docs/MarketsApi.md#buildsetmarketpermissionsquote) | **POST** /markets/{market}/standard/permissions/{address} | Build Set Market Permissions Transaction Quote
*MarketsApi* | [**GetMarket**](docs/MarketsApi.md#getmarket) | **GET** /markets/{market} | Get Market
*MarketsApi* | [**GetMarketHistory**](docs/MarketsApi.md#getmarkethistory) | **GET** /markets/{market}/history | Get Market History
*MarketsApi* | [**GetMarketPermissions**](docs/MarketsApi.md#getmarketpermissions) | **GET** /markets/{market}/standard/permissions/{address} | Get Market Permissions
*MarketsApi* | [**GetMarkets**](docs/MarketsApi.md#getmarkets) | **GET** /markets | Get Markets
*MiningGovernancesApi* | [**BuildRewardMiningPoolsQuote**](docs/MiningGovernancesApi.md#buildrewardminingpoolsquote) | **POST** /mining-governances/{governance}/reward-mining-pools | Build Reward Mining Pools Transaction Quote
*MiningGovernancesApi* | [**GetMiningGovernance**](docs/MiningGovernancesApi.md#getmininggovernance) | **GET** /mining-governances/{governance} | Get Mining Governance
*MiningGovernancesApi* | [**GetMiningGovernances**](docs/MiningGovernancesApi.md#getmininggovernances) | **GET** /mining-governances | Get Mining Governances
*MiningPoolsApi* | [**BuildCollectMiningRewardsQuote**](docs/MiningPoolsApi.md#buildcollectminingrewardsquote) | **POST** /mining-pools/{pool}/collect | Build Collect Mining Rewards Transaction Quote
*MiningPoolsApi* | [**BuildStartMiningQuote**](docs/MiningPoolsApi.md#buildstartminingquote) | **POST** /mining-pools/{pool}/start | Build Start Mining Transaction Quote
*MiningPoolsApi* | [**BuildStopMiningQuote**](docs/MiningPoolsApi.md#buildstopminingquote) | **POST** /mining-pools/{pool}/stop | Build Stop Mining Transaction Quote
*MiningPoolsApi* | [**GetMiningPool**](docs/MiningPoolsApi.md#getminingpool) | **GET** /mining-pools/{pool} | Get Mining Pool
*MiningPoolsApi* | [**GetMiningPools**](docs/MiningPoolsApi.md#getminingpools) | **GET** /mining-pools | Get Mining Pools
*StatusApi* | [**GetStatus**](docs/StatusApi.md#getstatus) | **GET** /status | Get Status
*TokensApi* | [**AddToken**](docs/TokensApi.md#addtoken) | **POST** /tokens | Add Token
*TokensApi* | [**BuildApproveAllowanceQuote**](docs/TokensApi.md#buildapproveallowancequote) | **POST** /tokens/{token}/approve | Build Approve Allowance Transaction Quote
*TokensApi* | [**BuildDistributeTokensQuote**](docs/TokensApi.md#builddistributetokensquote) | **POST** /tokens/{token}/distribute | Build Distribute Tokens Transaction Quote
*TokensApi* | [**GetToken**](docs/TokensApi.md#gettoken) | **GET** /tokens/{token} | Get Token
*TokensApi* | [**GetTokenHistory**](docs/TokensApi.md#gettokenhistory) | **GET** /tokens/{token}/history | Get Token History
*TokensApi* | [**GetTokens**](docs/TokensApi.md#gettokens) | **GET** /tokens | Get Tokens
*TransactionsApi* | [**GetTransaction**](docs/TransactionsApi.md#gettransaction) | **GET** /transaction/{hash} | Get Transaction
*TransactionsApi* | [**GetTransactions**](docs/TransactionsApi.md#gettransactions) | **GET** /transactions | Get Transactions
*TransactionsApi* | [**NotifyTransactionBroadcast**](docs/TransactionsApi.md#notifytransactionbroadcast) | **POST** /transactions | Notify Broadcast
*TransactionsApi* | [**ReplayQuote**](docs/TransactionsApi.md#replayquote) | **POST** /transaction/replay-quote | Replay Transaction Quote
*VaultsApi* | [**BuildCompleteProposalQuote**](docs/VaultsApi.md#buildcompleteproposalquote) | **POST** /vaults/{vault}/proposals/{proposalId}/complete | Build Complete Proposal Transaction Quote
*VaultsApi* | [**BuildPledgeQuote**](docs/VaultsApi.md#buildpledgequote) | **POST** /vaults/{vault}/proposals/{proposalId}/pledges | Build Make Pledge Transaction Quote
*VaultsApi* | [**BuildProposeChangeMinimumPledgeQuote**](docs/VaultsApi.md#buildproposechangeminimumpledgequote) | **POST** /vaults/{vault}/proposals/minimum-pledge | Build Propose Change Minimum Pledge Transaction Quote
*VaultsApi* | [**BuildProposeChangeMinimumVoteQuote**](docs/VaultsApi.md#buildproposechangeminimumvotequote) | **POST** /vaults/{vault}/proposals/minimum-vote | Build Propose Change Minimum Vote Transaction Quote
*VaultsApi* | [**BuildProposeCreateCertificateQuote**](docs/VaultsApi.md#buildproposecreatecertificatequote) | **POST** /vaults/{vault}/proposals/create-certificate | Build Propose Create Certificate Transaction Quote
*VaultsApi* | [**BuildProposeRevokeCertificateQuote**](docs/VaultsApi.md#buildproposerevokecertificatequote) | **POST** /vaults/{vault}/proposals/revoke-certificate | Build Propose Revoke Certificate Transaction Quote
*VaultsApi* | [**BuildRedeemCertificateQuote**](docs/VaultsApi.md#buildredeemcertificatequote) | **POST** /vaults/{vault}/certificates/redeem | Build Redeem Vault Certificate Transaction Quote
*VaultsApi* | [**BuildVoteQuote**](docs/VaultsApi.md#buildvotequote) | **POST** /vaults/{vault}/proposals/{proposalId}/votes | Build Cast Vote Transaction Quote
*VaultsApi* | [**BuildWithdrawPledgeQuote**](docs/VaultsApi.md#buildwithdrawpledgequote) | **POST** /vaults/{vault}/proposals/{proposalId}/pledges/withdraw | Build Withdraw Pledge Transaction Quote
*VaultsApi* | [**BuildWithdrawVoteQuote**](docs/VaultsApi.md#buildwithdrawvotequote) | **POST** /vaults/{vault}/proposals/{proposalId}/votes/withdraw | Build Withdraw Vote Transaction Quote
*VaultsApi* | [**GetCertificates**](docs/VaultsApi.md#getcertificates) | **GET** /vaults/{vault}/certificates | Get Vault Certificates
*VaultsApi* | [**GetPledgePosition**](docs/VaultsApi.md#getpledgeposition) | **GET** /vaults/{vault}/proposals/{proposalId}/pledges/{pledger} | Get Vault Proposal Pledge Position
*VaultsApi* | [**GetPledges**](docs/VaultsApi.md#getpledges) | **GET** /vaults/{vault}/pledges | Get Vault Proposal Pledges
*VaultsApi* | [**GetProposals**](docs/VaultsApi.md#getproposals) | **GET** /vaults/{vault}/proposals | Get Vault Proposals
*VaultsApi* | [**GetVault**](docs/VaultsApi.md#getvault) | **GET** /vaults/{vault} | Get Vault
*VaultsApi* | [**GetVaultProposal**](docs/VaultsApi.md#getvaultproposal) | **GET** /vaults/{vault}/proposals/{proposalId} | Get Vault Proposal
*VaultsApi* | [**GetVaults**](docs/VaultsApi.md#getvaults) | **GET** /vaults | Get Vaults
*VaultsApi* | [**GetVotePosition**](docs/VaultsApi.md#getvoteposition) | **GET** /vaults/{vault}/proposals/{proposalId}/votes/{voter} | Get Vault Proposal Vote Position
*VaultsApi* | [**GetVotes**](docs/VaultsApi.md#getvotes) | **GET** /vaults/{vault}/votes | Get Vault Proposal Votes
*WalletsApi* | [**GetApprovedAllowance**](docs/WalletsApi.md#getapprovedallowance) | **GET** /wallets/{address}/allowance/{token}/approved/{spender} | Get Approved Allowance
*WalletsApi* | [**GetBalance**](docs/WalletsApi.md#getbalance) | **GET** /wallets/{address}/balance/{token} | Get Balance
*WalletsApi* | [**GetBalances**](docs/WalletsApi.md#getbalances) | **GET** /wallets/{address}/balance | Get Balances
*WalletsApi* | [**GetMiningPosition**](docs/WalletsApi.md#getminingposition) | **GET** /wallets/{address}/mining/{pool} | Get Mining Position
*WalletsApi* | [**GetMiningPositions**](docs/WalletsApi.md#getminingpositions) | **GET** /wallets/{address}/mining | Get Mining Positions
*WalletsApi* | [**GetStakingPosition**](docs/WalletsApi.md#getstakingposition) | **GET** /wallets/{address}/staking/{pool} | Get Staking Position
*WalletsApi* | [**GetStakingPositions**](docs/WalletsApi.md#getstakingpositions) | **GET** /wallets/{address}/staking | Get Staking Positions
*WalletsApi* | [**RefreshBalance**](docs/WalletsApi.md#refreshbalance) | **POST** /wallets/{address}/balance/{token} | Refresh Balance


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddLiquidityEvent](docs/AddLiquidityEvent.md)
 - [Model.AddTokenRequest](docs/AddTokenRequest.md)
 - [Model.AddressBalanceResponse](docs/AddressBalanceResponse.md)
 - [Model.AddressBalancesResponse](docs/AddressBalancesResponse.md)
 - [Model.ApprovalEvent](docs/ApprovalEvent.md)
 - [Model.ApprovedAllowanceResponse](docs/ApprovedAllowanceResponse.md)
 - [Model.BlockResponse](docs/BlockResponse.md)
 - [Model.CertificateResponse](docs/CertificateResponse.md)
 - [Model.CertificateStatus](docs/CertificateStatus.md)
 - [Model.CertificatesResponse](docs/CertificatesResponse.md)
 - [Model.ChangeMarketPermissionEvent](docs/ChangeMarketPermissionEvent.md)
 - [Model.ClaimPendingDeployerOwnershipEvent](docs/ClaimPendingDeployerOwnershipEvent.md)
 - [Model.ClaimPendingMarketOwnershipEvent](docs/ClaimPendingMarketOwnershipEvent.md)
 - [Model.CollectMiningRewardsEvent](docs/CollectMiningRewardsEvent.md)
 - [Model.CollectStakingRewardsEvent](docs/CollectStakingRewardsEvent.md)
 - [Model.CompleteVaultProposalEvent](docs/CompleteVaultProposalEvent.md)
 - [Model.CostSnapshot](docs/CostSnapshot.md)
 - [Model.CostSummary](docs/CostSummary.md)
 - [Model.CreateLiquidityPoolEvent](docs/CreateLiquidityPoolEvent.md)
 - [Model.CreateMarketEvent](docs/CreateMarketEvent.md)
 - [Model.CreateVaultCertificateEvent](docs/CreateVaultCertificateEvent.md)
 - [Model.CreateVaultProposalEvent](docs/CreateVaultProposalEvent.md)
 - [Model.DistributionEvent](docs/DistributionEvent.md)
 - [Model.EnableMiningEvent](docs/EnableMiningEvent.md)
 - [Model.IndexerStatusResponse](docs/IndexerStatusResponse.md)
 - [Model.Interval](docs/Interval.md)
 - [Model.LiquidityAmountInQuoteRequest](docs/LiquidityAmountInQuoteRequest.md)
 - [Model.LiquidityAmountInQuoteResponse](docs/LiquidityAmountInQuoteResponse.md)
 - [Model.LiquidityPoolOrderByType](docs/LiquidityPoolOrderByType.md)
 - [Model.LiquidityPoolResponse](docs/LiquidityPoolResponse.md)
 - [Model.LiquidityPoolRewardsSnapshot](docs/LiquidityPoolRewardsSnapshot.md)
 - [Model.LiquidityPoolSnapshotResponse](docs/LiquidityPoolSnapshotResponse.md)
 - [Model.LiquidityPoolSnapshotsResponse](docs/LiquidityPoolSnapshotsResponse.md)
 - [Model.LiquidityPoolStakingSnapshot](docs/LiquidityPoolStakingSnapshot.md)
 - [Model.LiquidityPoolStakingSummary](docs/LiquidityPoolStakingSummary.md)
 - [Model.LiquidityPoolSummary](docs/LiquidityPoolSummary.md)
 - [Model.LiquidityPoolTokenBreakdown](docs/LiquidityPoolTokenBreakdown.md)
 - [Model.LiquidityPoolsResponse](docs/LiquidityPoolsResponse.md)
 - [Model.MarketOrderByType](docs/MarketOrderByType.md)
 - [Model.MarketPermission](docs/MarketPermission.md)
 - [Model.MarketResponse](docs/MarketResponse.md)
 - [Model.MarketRewardsSnapshot](docs/MarketRewardsSnapshot.md)
 - [Model.MarketSnapshotResponse](docs/MarketSnapshotResponse.md)
 - [Model.MarketSnapshotsResponse](docs/MarketSnapshotsResponse.md)
 - [Model.MarketStakingSnapshot](docs/MarketStakingSnapshot.md)
 - [Model.MarketStakingSummary](docs/MarketStakingSummary.md)
 - [Model.MarketSummary](docs/MarketSummary.md)
 - [Model.MarketTokenResponse](docs/MarketTokenResponse.md)
 - [Model.MarketTokensResponse](docs/MarketTokensResponse.md)
 - [Model.MarketType](docs/MarketType.md)
 - [Model.MarketsResponse](docs/MarketsResponse.md)
 - [Model.MiningActivityStatus](docs/MiningActivityStatus.md)
 - [Model.MiningGovernanceResponse](docs/MiningGovernanceResponse.md)
 - [Model.MiningGovernancesResponse](docs/MiningGovernancesResponse.md)
 - [Model.MiningPoolResponse](docs/MiningPoolResponse.md)
 - [Model.MiningPoolsResponse](docs/MiningPoolsResponse.md)
 - [Model.MiningPositionResponse](docs/MiningPositionResponse.md)
 - [Model.MiningPositionsResponse](docs/MiningPositionsResponse.md)
 - [Model.MiningStatus](docs/MiningStatus.md)
 - [Model.NominationEvent](docs/NominationEvent.md)
 - [Model.NominationStatus](docs/NominationStatus.md)
 - [Model.NotifyBroadcastRequest](docs/NotifyBroadcastRequest.md)
 - [Model.OhlcDecimalResponse](docs/OhlcDecimalResponse.md)
 - [Model.OhlcFixedDecimalResponse](docs/OhlcFixedDecimalResponse.md)
 - [Model.PagingResponse](docs/PagingResponse.md)
 - [Model.PledgeResponse](docs/PledgeResponse.md)
 - [Model.PledgesResponse](docs/PledgesResponse.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.ProposalResponse](docs/ProposalResponse.md)
 - [Model.ProposalStatus](docs/ProposalStatus.md)
 - [Model.ProposalType](docs/ProposalType.md)
 - [Model.ProposalsResponse](docs/ProposalsResponse.md)
 - [Model.QuoteAddLiquidityRequest](docs/QuoteAddLiquidityRequest.md)
 - [Model.QuoteApproveAllowanceRequest](docs/QuoteApproveAllowanceRequest.md)
 - [Model.QuoteCollectMarketFeesRequest](docs/QuoteCollectMarketFeesRequest.md)
 - [Model.QuoteCollectStakingRewardsRequest](docs/QuoteCollectStakingRewardsRequest.md)
 - [Model.QuoteCreateLiquidityPoolRequest](docs/QuoteCreateLiquidityPoolRequest.md)
 - [Model.QuoteCreateStakingMarketRequest](docs/QuoteCreateStakingMarketRequest.md)
 - [Model.QuoteCreateStandardMarketRequest](docs/QuoteCreateStandardMarketRequest.md)
 - [Model.QuotePledgeRequest](docs/QuotePledgeRequest.md)
 - [Model.QuoteProposeCreateCertificateRequest](docs/QuoteProposeCreateCertificateRequest.md)
 - [Model.QuoteProposeMinimumPledgeRequest](docs/QuoteProposeMinimumPledgeRequest.md)
 - [Model.QuoteProposeMinimumVoteRequest](docs/QuoteProposeMinimumVoteRequest.md)
 - [Model.QuoteProposeRevokeCertificateRequest](docs/QuoteProposeRevokeCertificateRequest.md)
 - [Model.QuoteRemoveLiquidityRequest](docs/QuoteRemoveLiquidityRequest.md)
 - [Model.QuoteRewardMiningPoolsRequest](docs/QuoteRewardMiningPoolsRequest.md)
 - [Model.QuoteSetMarketOwnerRequest](docs/QuoteSetMarketOwnerRequest.md)
 - [Model.QuoteSetMarketPermissionsRequest](docs/QuoteSetMarketPermissionsRequest.md)
 - [Model.QuoteSkimRequest](docs/QuoteSkimRequest.md)
 - [Model.QuoteStartMiningRequest](docs/QuoteStartMiningRequest.md)
 - [Model.QuoteStartStakingRequest](docs/QuoteStartStakingRequest.md)
 - [Model.QuoteStopMiningRequest](docs/QuoteStopMiningRequest.md)
 - [Model.QuoteStopStakingRequest](docs/QuoteStopStakingRequest.md)
 - [Model.QuoteSwapTransactionRequest](docs/QuoteSwapTransactionRequest.md)
 - [Model.QuoteVoteRequest](docs/QuoteVoteRequest.md)
 - [Model.QuoteWithdrawPledgeRequest](docs/QuoteWithdrawPledgeRequest.md)
 - [Model.QuoteWithdrawVoteRequest](docs/QuoteWithdrawVoteRequest.md)
 - [Model.RemoveLiquidityEvent](docs/RemoveLiquidityEvent.md)
 - [Model.ReplayQuoteRequest](docs/ReplayQuoteRequest.md)
 - [Model.ReservesSnapshot](docs/ReservesSnapshot.md)
 - [Model.ReservesSummary](docs/ReservesSummary.md)
 - [Model.RevokeVaultCertificateEvent](docs/RevokeVaultCertificateEvent.md)
 - [Model.RewardMiningPoolEvent](docs/RewardMiningPoolEvent.md)
 - [Model.RewardSummary](docs/RewardSummary.md)
 - [Model.SetPendingDeployerOwnershipEvent](docs/SetPendingDeployerOwnershipEvent.md)
 - [Model.SetPendingMarketOwnershipEvent](docs/SetPendingMarketOwnershipEvent.md)
 - [Model.SortDirection](docs/SortDirection.md)
 - [Model.StakingPositionResponse](docs/StakingPositionResponse.md)
 - [Model.StakingPositionsResponse](docs/StakingPositionsResponse.md)
 - [Model.StakingStatus](docs/StakingStatus.md)
 - [Model.StartMiningEvent](docs/StartMiningEvent.md)
 - [Model.StartStakingEvent](docs/StartStakingEvent.md)
 - [Model.StatusResponse](docs/StatusResponse.md)
 - [Model.StopMiningEvent](docs/StopMiningEvent.md)
 - [Model.StopStakingEvent](docs/StopStakingEvent.md)
 - [Model.StratisSignatureAuthRequest](docs/StratisSignatureAuthRequest.md)
 - [Model.SwapAmountInQuoteRequest](docs/SwapAmountInQuoteRequest.md)
 - [Model.SwapAmountInQuoteResponse](docs/SwapAmountInQuoteResponse.md)
 - [Model.SwapAmountOutQuoteRequest](docs/SwapAmountOutQuoteRequest.md)
 - [Model.SwapAmountOutQuoteResponse](docs/SwapAmountOutQuoteResponse.md)
 - [Model.SwapEvent](docs/SwapEvent.md)
 - [Model.TokenAddress](docs/TokenAddress.md)
 - [Model.TokenAttribute](docs/TokenAttribute.md)
 - [Model.TokenAttributeFilter](docs/TokenAttributeFilter.md)
 - [Model.TokenOrderByType](docs/TokenOrderByType.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.TokenSnapshotResponse](docs/TokenSnapshotResponse.md)
 - [Model.TokenSnapshotsResponse](docs/TokenSnapshotsResponse.md)
 - [Model.TokenSummaryResponse](docs/TokenSummaryResponse.md)
 - [Model.TokenType](docs/TokenType.md)
 - [Model.TokensResponse](docs/TokensResponse.md)
 - [Model.TransactionEvent](docs/TransactionEvent.md)
 - [Model.TransactionEventType](docs/TransactionEventType.md)
 - [Model.TransactionQuoteResponse](docs/TransactionQuoteResponse.md)
 - [Model.TransactionResponse](docs/TransactionResponse.md)
 - [Model.TransactionsResponse](docs/TransactionsResponse.md)
 - [Model.TransferEvent](docs/TransferEvent.md)
 - [Model.ValidationProblemDetails](docs/ValidationProblemDetails.md)
 - [Model.ValidationProblemDetailsAllOf](docs/ValidationProblemDetailsAllOf.md)
 - [Model.VaultProposalPledgeEvent](docs/VaultProposalPledgeEvent.md)
 - [Model.VaultProposalVoteEvent](docs/VaultProposalVoteEvent.md)
 - [Model.VaultProposalWithdrawPledgeEvent](docs/VaultProposalWithdrawPledgeEvent.md)
 - [Model.VaultProposalWithdrawVoteEvent](docs/VaultProposalWithdrawVoteEvent.md)
 - [Model.VaultResponse](docs/VaultResponse.md)
 - [Model.VaultsResponse](docs/VaultsResponse.md)
 - [Model.VolumeSnapshot](docs/VolumeSnapshot.md)
 - [Model.VolumeSummary](docs/VolumeSummary.md)
 - [Model.VoteResponse](docs/VoteResponse.md)
 - [Model.VotesResponse](docs/VotesResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="opdexAuth"></a>
### opdexAuth

- **Type**: Bearer Authentication

