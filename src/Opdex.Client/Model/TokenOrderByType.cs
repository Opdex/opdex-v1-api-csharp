/*
 * Opdex Platform API
 *
 * The Opdex Platform Web API is an interface for querying information from the Opdex contract indexer and quoting Opdex smart contract transactions. The Opdex contract indexer is a job that continually runs and stores relevant broadcast transaction data, in a way that represents the current known state of the Opdex protocol at the present time.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Opdex.Client.Client.OpenAPIDateConverter;

namespace Opdex.Client.Model
{
    /// <summary>
    /// Property to sort tokens by
    /// </summary>
    /// <value>Property to sort tokens by</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenOrderByType
    {
        /// <summary>
        /// Enum Name for value: Name
        /// </summary>
        [EnumMember(Value = "Name")]
        Name = 1,

        /// <summary>
        /// Enum Symbol for value: Symbol
        /// </summary>
        [EnumMember(Value = "Symbol")]
        Symbol = 2,

        /// <summary>
        /// Enum DailyPriceChangePercent for value: DailyPriceChangePercent
        /// </summary>
        [EnumMember(Value = "DailyPriceChangePercent")]
        DailyPriceChangePercent = 3,

        /// <summary>
        /// Enum PriceUsd for value: PriceUsd
        /// </summary>
        [EnumMember(Value = "PriceUsd")]
        PriceUsd = 4

    }

}
