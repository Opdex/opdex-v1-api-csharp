/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Opdex.Client.Client;
using Opdex.Client.Api;
// uncomment below to import models
//using Opdex.Client.Model;

namespace Opdex.Client.Test.Api
{
    /// <summary>
    ///  Class for testing LiquidityPoolsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LiquidityPoolsApiTests : IDisposable
    {
        private LiquidityPoolsApi instance;

        public LiquidityPoolsApiTests()
        {
            instance = new LiquidityPoolsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LiquidityPoolsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LiquidityPoolsApi
            //Assert.IsType<LiquidityPoolsApi>(instance);
        }

        /// <summary>
        /// Test BuildAddLiquidityQuote
        /// </summary>
        [Fact]
        public void BuildAddLiquidityQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //QuoteAddLiquidityRequest quoteAddLiquidityRequest = null;
            //var response = instance.BuildAddLiquidityQuote(pool, quoteAddLiquidityRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildCollectStakingRewardsQuote
        /// </summary>
        [Fact]
        public void BuildCollectStakingRewardsQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //QuoteCollectStakingRewardsRequest quoteCollectStakingRewardsRequest = null;
            //var response = instance.BuildCollectStakingRewardsQuote(pool, quoteCollectStakingRewardsRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildCreateLiquidityPoolQuote
        /// </summary>
        [Fact]
        public void BuildCreateLiquidityPoolQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuoteCreateLiquidityPoolRequest quoteCreateLiquidityPoolRequest = null;
            //var response = instance.BuildCreateLiquidityPoolQuote(quoteCreateLiquidityPoolRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildRemoveLiquidityQuote
        /// </summary>
        [Fact]
        public void BuildRemoveLiquidityQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //QuoteRemoveLiquidityRequest quoteRemoveLiquidityRequest = null;
            //var response = instance.BuildRemoveLiquidityQuote(pool, quoteRemoveLiquidityRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildSkimQuote
        /// </summary>
        [Fact]
        public void BuildSkimQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //QuoteSkimRequest quoteSkimRequest = null;
            //var response = instance.BuildSkimQuote(pool, quoteSkimRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildStartStakingQuote
        /// </summary>
        [Fact]
        public void BuildStartStakingQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //QuoteStartStakingRequest quoteStartStakingRequest = null;
            //var response = instance.BuildStartStakingQuote(pool, quoteStartStakingRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildStopStakingQuote
        /// </summary>
        [Fact]
        public void BuildStopStakingQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //QuoteStopStakingRequest quoteStopStakingRequest = null;
            //var response = instance.BuildStopStakingQuote(pool, quoteStopStakingRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test BuildSyncQuote
        /// </summary>
        [Fact]
        public void BuildSyncQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //var response = instance.BuildSyncQuote(pool);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }

        /// <summary>
        /// Test GetLiquidityAmountInQuote
        /// </summary>
        [Fact]
        public void GetLiquidityAmountInQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //LiquidityAmountInQuoteRequest liquidityAmountInQuoteRequest = null;
            //var response = instance.GetLiquidityAmountInQuote(pool, liquidityAmountInQuoteRequest);
            //Assert.IsType<LiquidityAmountInQuoteResponse>(response);
        }

        /// <summary>
        /// Test GetLiquidityPool
        /// </summary>
        [Fact]
        public void GetLiquidityPoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //var response = instance.GetLiquidityPool(pool);
            //Assert.IsType<LiquidityPoolResponse>(response);
        }

        /// <summary>
        /// Test GetLiquidityPoolHistory
        /// </summary>
        [Fact]
        public void GetLiquidityPoolHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pool = null;
            //DateTime startDateTime = null;
            //DateTime endDateTime = null;
            //Interval? interval = null;
            //SortDirection? direction = null;
            //int? limit = null;
            //string cursor = null;
            //var response = instance.GetLiquidityPoolHistory(pool, startDateTime, endDateTime, interval, direction, limit, cursor);
            //Assert.IsType<LiquidityPoolSnapshotsResponse>(response);
        }

        /// <summary>
        /// Test GetLiquidityPools
        /// </summary>
        [Fact]
        public void GetLiquidityPoolsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyword = null;
            //List<string> markets = null;
            //List<string> liquidityPools = null;
            //List<string> tokens = null;
            //StakingStatus? stakingStatus = null;
            //NominationStatus? nominationStatus = null;
            //MiningStatus? miningStatus = null;
            //LiquidityPoolOrderByType? orderBy = null;
            //SortDirection? direction = null;
            //int? limit = null;
            //string cursor = null;
            //var response = instance.GetLiquidityPools(keyword, markets, liquidityPools, tokens, stakingStatus, nominationStatus, miningStatus, orderBy, direction, limit, cursor);
            //Assert.IsType<LiquidityPoolsResponse>(response);
        }
    }
}
