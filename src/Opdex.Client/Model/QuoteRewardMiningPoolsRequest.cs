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
using FileParameter = Opdex.Client.Client.FileParameter;
using OpenAPIDateConverter = Opdex.Client.Client.OpenAPIDateConverter;

namespace Opdex.Client.Model
{
    /// <summary>
    /// Request to retrieve a reward mining pools call quote
    /// </summary>
    [DataContract(Name = "quoteRewardMiningPoolsRequest")]
    public partial class QuoteRewardMiningPoolsRequest : IEquatable<QuoteRewardMiningPoolsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteRewardMiningPoolsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteRewardMiningPoolsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteRewardMiningPoolsRequest" /> class.
        /// </summary>
        /// <param name="fullDistribution">When true, determines all nominated mining pools receive token rewards, otherwise only one receives token rewards (required).</param>
        public QuoteRewardMiningPoolsRequest(bool fullDistribution = default(bool))
        {
            this.FullDistribution = fullDistribution;
        }

        /// <summary>
        /// When true, determines all nominated mining pools receive token rewards, otherwise only one receives token rewards
        /// </summary>
        /// <value>When true, determines all nominated mining pools receive token rewards, otherwise only one receives token rewards</value>
        [DataMember(Name = "fullDistribution", IsRequired = true, EmitDefaultValue = true)]
        public bool FullDistribution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteRewardMiningPoolsRequest {\n");
            sb.Append("  FullDistribution: ").Append(FullDistribution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuoteRewardMiningPoolsRequest);
        }

        /// <summary>
        /// Returns true if QuoteRewardMiningPoolsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteRewardMiningPoolsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteRewardMiningPoolsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FullDistribution == input.FullDistribution ||
                    this.FullDistribution.Equals(input.FullDistribution)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.FullDistribution.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}