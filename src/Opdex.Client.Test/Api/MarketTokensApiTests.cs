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
    ///  Class for testing MarketTokensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MarketTokensApiTests : IDisposable
    {
        private MarketTokensApi instance;

        public MarketTokensApiTests()
        {
            instance = new MarketTokensApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MarketTokensApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MarketTokensApi
            //Assert.IsType<MarketTokensApi>(instance);
        }

        /// <summary>
        /// Test MarketsMarketTokensGet
        /// </summary>
        [Fact]
        public void MarketsMarketTokensGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string market = null;
            //TokenType? tokenType = null;
            //List<string> tokens = null;
            //string keyword = null;
            //TokenOrderByType? orderBy = null;
            //SortDirection? direction = null;
            //int? limit = null;
            //string cursor = null;
            //var response = instance.MarketsMarketTokensGet(market, tokenType, tokens, keyword, orderBy, direction, limit, cursor);
            //Assert.IsType<MarketTokensResponse>(response);
        }

        /// <summary>
        /// Test MarketsMarketTokensTokenGet
        /// </summary>
        [Fact]
        public void MarketsMarketTokensTokenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string market = null;
            //string token = null;
            //var response = instance.MarketsMarketTokensTokenGet(market, token);
            //Assert.IsType<MarketTokenResponse>(response);
        }

        /// <summary>
        /// Test MarketsMarketTokensTokenHistoryGet
        /// </summary>
        [Fact]
        public void MarketsMarketTokensTokenHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string market = null;
            //string token = null;
            //DateTime startDateTime = null;
            //DateTime endDateTime = null;
            //Interval? interval = null;
            //SortDirection? direction = null;
            //int? limit = null;
            //string cursor = null;
            //var response = instance.MarketsMarketTokensTokenHistoryGet(market, token, startDateTime, endDateTime, interval, direction, limit, cursor);
            //Assert.IsType<TokenSnapshotsResponse>(response);
        }

        /// <summary>
        /// Test MarketsMarketTokensTokenSwapAmountInPost
        /// </summary>
        [Fact]
        public void MarketsMarketTokensTokenSwapAmountInPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string market = null;
            //string token = null;
            //SwapAmountInQuoteRequest swapAmountInQuoteRequest = null;
            //var response = instance.MarketsMarketTokensTokenSwapAmountInPost(market, token, swapAmountInQuoteRequest);
            //Assert.IsType<SwapAmountInQuoteResponse>(response);
        }

        /// <summary>
        /// Test MarketsMarketTokensTokenSwapAmountOutPost
        /// </summary>
        [Fact]
        public void MarketsMarketTokensTokenSwapAmountOutPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string market = null;
            //string token = null;
            //SwapAmountOutQuoteRequest swapAmountOutQuoteRequest = null;
            //var response = instance.MarketsMarketTokensTokenSwapAmountOutPost(market, token, swapAmountOutQuoteRequest);
            //Assert.IsType<SwapAmountOutQuoteResponse>(response);
        }

        /// <summary>
        /// Test MarketsMarketTokensTokenSwapPost
        /// </summary>
        [Fact]
        public void MarketsMarketTokensTokenSwapPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string market = null;
            //string token = null;
            //QuoteSwapTransactionRequest quoteSwapTransactionRequest = null;
            //var response = instance.MarketsMarketTokensTokenSwapPost(market, token, quoteSwapTransactionRequest);
            //Assert.IsType<TransactionQuoteResponse>(response);
        }
    }
}
