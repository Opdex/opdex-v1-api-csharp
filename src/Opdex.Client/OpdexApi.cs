using System;
using System.Net.Http;
using Opdex.Client.Api;

namespace Opdex.Client;

public class OpdexApi : IOpdexApi
{
    public OpdexApi(HttpClient httpClient)
    {
        if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));
        Authentication = new AuthenticationApi(httpClient);
        Indexer = new IndexerApi(httpClient);
        LiquidityPools = new LiquidityPoolsApi(httpClient);
        Markets = new MarketsApi(httpClient);
        MarketTokens = new MarketTokensApi(httpClient);
        MiningGovernances = new MiningGovernancesApi(httpClient);
        MiningPools = new MiningPoolsApi(httpClient);
        Status = new StatusApi(httpClient);
        Tokens = new TokensApi(httpClient);
        Transactions = new TransactionsApi(httpClient);
        Vaults = new VaultsApi(httpClient);
        Wallets = new WalletsApi(httpClient);
    }

    public IAuthenticationApi Authentication { get; }
    public IIndexerApi Indexer { get; }
    public ILiquidityPoolsApi LiquidityPools { get; }
    public IMarketsApi Markets { get; }
    public IMarketTokensApi MarketTokens { get; }
    public IMiningGovernancesApi MiningGovernances { get; }
    public IMiningPoolsApi MiningPools { get; }
    public IStatusApi Status { get; }
    public ITokensApi Tokens { get; }
    public ITransactionsApi Transactions { get; }
    public IVaultsApi Vaults { get; }
    public IWalletsApi Wallets { get; }
}

public interface IOpdexApi
{
    IAuthenticationApi Authentication { get; }
    IIndexerApi Indexer { get; }
    ILiquidityPoolsApi LiquidityPools { get; }
    IMarketsApi Markets { get; }
    IMarketTokensApi MarketTokens { get; }
    IMiningGovernancesApi MiningGovernances { get; }
    IMiningPoolsApi MiningPools { get; }
    IStatusApi Status { get; }
    ITokensApi Tokens { get; }
    ITransactionsApi Transactions { get; }
    IVaultsApi Vaults { get; }
    IWalletsApi Wallets { get; }
}