using System;
using System.Net.Http;
using Opdex.Client.Api;

namespace Opdex.Client;

/// <summary>
/// Accesses the Opdex V1 Platform API
/// </summary>
public class OpdexApi : IOpdexApi
{
    /// <summary>
    /// Creates an accessor to the Opdex V1 Platform API with the provided HTTP client
    /// </summary>
    /// <param name="httpClient">HTTP client, configured to make calls to a hosted Opdex V1 Platform API</param>
    public OpdexApi(HttpClient httpClient)
    {
        if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));
        Authentication = new AuthenticationApi(httpClient);
        Blocks = new BlocksApi(httpClient);
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

    /// <inheritdoc />
    public IAuthenticationApi Authentication { get; }
    /// <inheritdoc />
    public IBlocksApi Blocks { get; }
    /// <inheritdoc />
    public IIndexerApi Indexer { get; }
    /// <inheritdoc />
    public ILiquidityPoolsApi LiquidityPools { get; }
    /// <inheritdoc />
    public IMarketsApi Markets { get; }
    /// <inheritdoc />
    public IMarketTokensApi MarketTokens { get; }
    /// <inheritdoc />
    public IMiningGovernancesApi MiningGovernances { get; }
    /// <inheritdoc />
    public IMiningPoolsApi MiningPools { get; }
    /// <inheritdoc />
    public IStatusApi Status { get; }
    /// <inheritdoc />
    public ITokensApi Tokens { get; }
    /// <inheritdoc />
    public ITransactionsApi Transactions { get; }
    /// <inheritdoc />
    public IVaultsApi Vaults { get; }
    /// <inheritdoc />
    public IWalletsApi Wallets { get; }
}

/// <summary>
/// Accesses the Opdex V1 Core API
/// </summary>
public interface IOpdexApi
{
    /// <summary>
    /// Authenticate with the API
    /// </summary>
    IAuthenticationApi Authentication { get; }

    /// <summary>
    /// Retrieve indexed block data
    /// </summary>
    IBlocksApi Blocks { get; }

    /// <summary>
    /// Interact with the indexer
    /// </summary>
    IIndexerApi Indexer { get; }

    /// <summary>
    /// Interact with standard and staking liquidity pools
    /// </summary>
    ILiquidityPoolsApi LiquidityPools { get; }

    /// <summary>
    /// Manage and query standard and staking markets
    /// </summary>
    IMarketsApi Markets { get; }

    /// <summary>
    /// Quote swaps and query token data within markets
    /// </summary>
    IMarketTokensApi MarketTokens { get; }

    /// <summary>
    /// Quote mining governance distribution
    /// </summary>
    IMiningGovernancesApi MiningGovernances { get; }

    /// <summary>
    /// Quote and query liquidity mining pools
    /// </summary>
    IMiningPoolsApi MiningPools { get; }

    /// <summary>
    /// View health and API status
    /// </summary>
    IStatusApi Status { get; }

    /// <summary>
    /// Manage and query tracked tokens
    /// </summary>
    ITokensApi Tokens { get; }

    /// <summary>
    /// View and build transactions
    /// </summary>
    ITransactionsApi Transactions { get; }

    /// <summary>
    /// Interact with an Opdex vault DAO
    /// </summary>
    IVaultsApi Vaults { get; }

    /// <summary>
    /// Track and query token balances
    /// </summary>
    IWalletsApi Wallets { get; }
}