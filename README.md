# Opdex V1 API C# SDK

[![NuGet](https://img.shields.io/nuget/v/Opdex.Client)](https://www.nuget.org/packages/Opdex.Client)

The [Opdex Platform Web API](https://github.com/Opdex/opdex-v1-api) is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. This project maintains a C# SDK that integrates with the API.

<a name="getting-started"></a>
## Getting Started

To get started, install the NuGet package into your project.

```
dotnet add package Opdex.V1.Sdk
```

<a name="usage"></a>
## Usage

Using the API client is as simple as creating an instance of `OpdexApi`. It is recommended to configure `OpdexApi` as a [typed client](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#how-to-use-typed-clients-with-ihttpclientfactory), in the following way:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddHttpClient<IOpdexApi, OpdexApi>(config => config.BaseAddress = new Uri("https://v1-test-api.opdex.com/v1"));
}
```

It is then possible to access `IOpdexApi` wherever it can be resolved through dependency injection. For example, you might inject it into a class constructor.

```csharp
public class MyService
{
    private readonly IOpdexApi _opdexApi;

    public MyService(IOpdexApi opdexApi)
    {
        _opdexApi = opdexApi;
    }

    public async Task DoSomething()
    {
        var market = await _opdexApi.Markets.GetMarketAsync("t7RorA7xQCMVYKPM1ibPE1NSswaLbpqLQb");
    }
}
```

<a name="endpoints"></a>
## Endpoints

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**Authenticate**](docs/AuthenticationApi.md#authenticate) | **POST** /auth | Stratis Signature Auth
*AuthenticationApi* | [**AuthenticateCallback**](docs/AuthenticationApi.md#authenticatecallback) | **POST** /auth/callback | Stratis Signature Auth Callback
*AuthenticationApi* | [**GetStratisId**](docs/AuthenticationApi.md#getstratisid) | **GET** /auth | Get Stratis Id
*BlocksApi* | [**GetBlock**](docs/BlocksApi.md#getblock) | **GET** /blocks/{height} | Get Block
*BlocksApi* | [**GetBlocks**](docs/BlocksApi.md#getblocks) | **GET** /blocks | Get Blocks
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
