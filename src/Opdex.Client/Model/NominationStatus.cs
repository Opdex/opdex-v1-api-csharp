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
    /// Nomination status filter
    /// </summary>
    /// <value>Nomination status filter</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NominationStatus
    {
        /// <summary>
        /// Enum Nominated for value: Nominated
        /// </summary>
        [EnumMember(Value = "Nominated")]
        Nominated = 1,

        /// <summary>
        /// Enum Excluded for value: Excluded
        /// </summary>
        [EnumMember(Value = "Excluded")]
        Excluded = 2

    }

}
