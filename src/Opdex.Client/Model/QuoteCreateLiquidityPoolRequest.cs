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
    /// Request to retrieve a create liquidity pool call quote
    /// </summary>
    [DataContract(Name = "quoteCreateLiquidityPoolRequest")]
    public partial class QuoteCreateLiquidityPoolRequest : IEquatable<QuoteCreateLiquidityPoolRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteCreateLiquidityPoolRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteCreateLiquidityPoolRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteCreateLiquidityPoolRequest" /> class.
        /// </summary>
        /// <param name="token">An address on the Cirrus network (required).</param>
        /// <param name="market">An address on the Cirrus network (required).</param>
        public QuoteCreateLiquidityPoolRequest(string token = default(string), string market = default(string))
        {
            // to ensure "token" is required (not null)
            if (token == null) {
                throw new ArgumentNullException("token is a required property for QuoteCreateLiquidityPoolRequest and cannot be null");
            }
            this.Token = token;
            // to ensure "market" is required (not null)
            if (market == null) {
                throw new ArgumentNullException("market is a required property for QuoteCreateLiquidityPoolRequest and cannot be null");
            }
            this.Market = market;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "market", IsRequired = true, EmitDefaultValue = false)]
        public string Market { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteCreateLiquidityPoolRequest {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
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
            return this.Equals(input as QuoteCreateLiquidityPoolRequest);
        }

        /// <summary>
        /// Returns true if QuoteCreateLiquidityPoolRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteCreateLiquidityPoolRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteCreateLiquidityPoolRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Market == input.Market ||
                    (this.Market != null &&
                    this.Market.Equals(input.Market))
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
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.Market != null)
                {
                    hashCode = (hashCode * 59) + this.Market.GetHashCode();
                }
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
            // Token (string) maxLength
            if (this.Token != null && this.Token.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be less than 42.", new [] { "Token" });
            }

            // Token (string) minLength
            if (this.Token != null && this.Token.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be greater than 30.", new [] { "Token" });
            }

            // Token (string) pattern
            Regex regexToken = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexToken.Match(this.Token).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, must match a pattern of " + regexToken, new [] { "Token" });
            }

            // Market (string) maxLength
            if (this.Market != null && this.Market.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Market, length must be less than 42.", new [] { "Market" });
            }

            // Market (string) minLength
            if (this.Market != null && this.Market.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Market, length must be greater than 30.", new [] { "Market" });
            }

            // Market (string) pattern
            Regex regexMarket = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexMarket.Match(this.Market).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Market, must match a pattern of " + regexMarket, new [] { "Market" });
            }

            yield break;
        }
    }

}
