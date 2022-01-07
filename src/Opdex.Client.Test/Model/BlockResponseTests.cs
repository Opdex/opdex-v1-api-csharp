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
    ///  Class for testing BlockResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BlockResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BlockResponse
        //private BlockResponse instance;

        public BlockResponseTests()
        {
            // TODO uncomment below to create an instance of BlockResponse
            //instance = new BlockResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BlockResponse
        /// </summary>
        [Fact]
        public void BlockResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" BlockResponse
            //Assert.IsType<BlockResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Hash'
        /// </summary>
        [Fact]
        public void HashTest()
        {
            // TODO unit test for the property 'Hash'
        }
        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Fact]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
        /// <summary>
        /// Test the property 'Time'
        /// </summary>
        [Fact]
        public void TimeTest()
        {
            // TODO unit test for the property 'Time'
        }
        /// <summary>
        /// Test the property 'MedianTime'
        /// </summary>
        [Fact]
        public void MedianTimeTest()
        {
            // TODO unit test for the property 'MedianTime'
        }

    }

}
