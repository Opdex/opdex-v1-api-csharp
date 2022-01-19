/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Opdex.Client.Api;
using Opdex.Client.Model;
using Opdex.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Opdex.Client.Test.Model
{
    /// <summary>
    ///  Class for testing QuoteStopStakingRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QuoteStopStakingRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for QuoteStopStakingRequest
        //private QuoteStopStakingRequest instance;

        public QuoteStopStakingRequestTests()
        {
            // TODO uncomment below to create an instance of QuoteStopStakingRequest
            //instance = new QuoteStopStakingRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QuoteStopStakingRequest
        /// </summary>
        [Fact]
        public void QuoteStopStakingRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" QuoteStopStakingRequest
            //Assert.IsType<QuoteStopStakingRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Liquidate'
        /// </summary>
        [Fact]
        public void LiquidateTest()
        {
            // TODO unit test for the property 'Liquidate'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }

    }

}
