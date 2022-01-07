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
    /// Request to retrieve a token swap call quote
    /// </summary>
    [DataContract(Name = "quoteSwapTransactionRequest")]
    public partial class QuoteSwapTransactionRequest : IEquatable<QuoteSwapTransactionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSwapTransactionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteSwapTransactionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSwapTransactionRequest" /> class.
        /// </summary>
        /// <param name="tokenOut">tokenOut (required).</param>
        /// <param name="tokenInAmount">Decimal value with uncapped precision and size (required).</param>
        /// <param name="tokenOutAmount">Decimal value with uncapped precision and size (required).</param>
        /// <param name="tokenInExactAmount">Token in amount is exact when true, otherwise token out amount is exact (required).</param>
        /// <param name="tokenInMaximumAmount">Decimal value with uncapped precision and size (required).</param>
        /// <param name="tokenOutMinimumAmount">Decimal value with uncapped precision and size (required).</param>
        /// <param name="recipient">An address on the Cirrus network (required).</param>
        /// <param name="deadline">Block height the transaction should be mined at, which if not met causes the transaction to fail.</param>
        public QuoteSwapTransactionRequest(TokenAddress tokenOut = default(TokenAddress), string tokenInAmount = default(string), string tokenOutAmount = default(string), bool tokenInExactAmount = default(bool), string tokenInMaximumAmount = default(string), string tokenOutMinimumAmount = default(string), string recipient = default(string), decimal deadline = default(decimal))
        {
            // to ensure "tokenOut" is required (not null)
            if (tokenOut == null) {
                throw new ArgumentNullException("tokenOut is a required property for QuoteSwapTransactionRequest and cannot be null");
            }
            this.TokenOut = tokenOut;
            // to ensure "tokenInAmount" is required (not null)
            if (tokenInAmount == null) {
                throw new ArgumentNullException("tokenInAmount is a required property for QuoteSwapTransactionRequest and cannot be null");
            }
            this.TokenInAmount = tokenInAmount;
            // to ensure "tokenOutAmount" is required (not null)
            if (tokenOutAmount == null) {
                throw new ArgumentNullException("tokenOutAmount is a required property for QuoteSwapTransactionRequest and cannot be null");
            }
            this.TokenOutAmount = tokenOutAmount;
            this.TokenInExactAmount = tokenInExactAmount;
            // to ensure "tokenInMaximumAmount" is required (not null)
            if (tokenInMaximumAmount == null) {
                throw new ArgumentNullException("tokenInMaximumAmount is a required property for QuoteSwapTransactionRequest and cannot be null");
            }
            this.TokenInMaximumAmount = tokenInMaximumAmount;
            // to ensure "tokenOutMinimumAmount" is required (not null)
            if (tokenOutMinimumAmount == null) {
                throw new ArgumentNullException("tokenOutMinimumAmount is a required property for QuoteSwapTransactionRequest and cannot be null");
            }
            this.TokenOutMinimumAmount = tokenOutMinimumAmount;
            // to ensure "recipient" is required (not null)
            if (recipient == null) {
                throw new ArgumentNullException("recipient is a required property for QuoteSwapTransactionRequest and cannot be null");
            }
            this.Recipient = recipient;
            this.Deadline = deadline;
        }

        /// <summary>
        /// Gets or Sets TokenOut
        /// </summary>
        [DataMember(Name = "tokenOut", IsRequired = true, EmitDefaultValue = false)]
        public TokenAddress TokenOut { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokenInAmount", IsRequired = true, EmitDefaultValue = false)]
        public string TokenInAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokenOutAmount", IsRequired = true, EmitDefaultValue = false)]
        public string TokenOutAmount { get; set; }

        /// <summary>
        /// Token in amount is exact when true, otherwise token out amount is exact
        /// </summary>
        /// <value>Token in amount is exact when true, otherwise token out amount is exact</value>
        [DataMember(Name = "tokenInExactAmount", IsRequired = true, EmitDefaultValue = true)]
        public bool TokenInExactAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokenInMaximumAmount", IsRequired = true, EmitDefaultValue = false)]
        public string TokenInMaximumAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokenOutMinimumAmount", IsRequired = true, EmitDefaultValue = false)]
        public string TokenOutMinimumAmount { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Block height the transaction should be mined at, which if not met causes the transaction to fail
        /// </summary>
        /// <value>Block height the transaction should be mined at, which if not met causes the transaction to fail</value>
        [DataMember(Name = "deadline", EmitDefaultValue = false)]
        public decimal Deadline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteSwapTransactionRequest {\n");
            sb.Append("  TokenOut: ").Append(TokenOut).Append("\n");
            sb.Append("  TokenInAmount: ").Append(TokenInAmount).Append("\n");
            sb.Append("  TokenOutAmount: ").Append(TokenOutAmount).Append("\n");
            sb.Append("  TokenInExactAmount: ").Append(TokenInExactAmount).Append("\n");
            sb.Append("  TokenInMaximumAmount: ").Append(TokenInMaximumAmount).Append("\n");
            sb.Append("  TokenOutMinimumAmount: ").Append(TokenOutMinimumAmount).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
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
            return this.Equals(input as QuoteSwapTransactionRequest);
        }

        /// <summary>
        /// Returns true if QuoteSwapTransactionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteSwapTransactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteSwapTransactionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenOut == input.TokenOut ||
                    (this.TokenOut != null &&
                    this.TokenOut.Equals(input.TokenOut))
                ) && 
                (
                    this.TokenInAmount == input.TokenInAmount ||
                    (this.TokenInAmount != null &&
                    this.TokenInAmount.Equals(input.TokenInAmount))
                ) && 
                (
                    this.TokenOutAmount == input.TokenOutAmount ||
                    (this.TokenOutAmount != null &&
                    this.TokenOutAmount.Equals(input.TokenOutAmount))
                ) && 
                (
                    this.TokenInExactAmount == input.TokenInExactAmount ||
                    this.TokenInExactAmount.Equals(input.TokenInExactAmount)
                ) && 
                (
                    this.TokenInMaximumAmount == input.TokenInMaximumAmount ||
                    (this.TokenInMaximumAmount != null &&
                    this.TokenInMaximumAmount.Equals(input.TokenInMaximumAmount))
                ) && 
                (
                    this.TokenOutMinimumAmount == input.TokenOutMinimumAmount ||
                    (this.TokenOutMinimumAmount != null &&
                    this.TokenOutMinimumAmount.Equals(input.TokenOutMinimumAmount))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Deadline == input.Deadline ||
                    this.Deadline.Equals(input.Deadline)
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
                if (this.TokenOut != null)
                {
                    hashCode = (hashCode * 59) + this.TokenOut.GetHashCode();
                }
                if (this.TokenInAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TokenInAmount.GetHashCode();
                }
                if (this.TokenOutAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TokenOutAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TokenInExactAmount.GetHashCode();
                if (this.TokenInMaximumAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TokenInMaximumAmount.GetHashCode();
                }
                if (this.TokenOutMinimumAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TokenOutMinimumAmount.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deadline.GetHashCode();
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
            // TokenInAmount (string) pattern
            Regex regexTokenInAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokenInAmount.Match(this.TokenInAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenInAmount, must match a pattern of " + regexTokenInAmount, new [] { "TokenInAmount" });
            }

            // TokenOutAmount (string) pattern
            Regex regexTokenOutAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokenOutAmount.Match(this.TokenOutAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenOutAmount, must match a pattern of " + regexTokenOutAmount, new [] { "TokenOutAmount" });
            }

            // TokenInMaximumAmount (string) pattern
            Regex regexTokenInMaximumAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokenInMaximumAmount.Match(this.TokenInMaximumAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenInMaximumAmount, must match a pattern of " + regexTokenInMaximumAmount, new [] { "TokenInMaximumAmount" });
            }

            // TokenOutMinimumAmount (string) pattern
            Regex regexTokenOutMinimumAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokenOutMinimumAmount.Match(this.TokenOutMinimumAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenOutMinimumAmount, must match a pattern of " + regexTokenOutMinimumAmount, new [] { "TokenOutMinimumAmount" });
            }

            // Recipient (string) maxLength
            if (this.Recipient != null && this.Recipient.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, length must be less than 42.", new [] { "Recipient" });
            }

            // Recipient (string) minLength
            if (this.Recipient != null && this.Recipient.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, length must be greater than 30.", new [] { "Recipient" });
            }

            // Recipient (string) pattern
            Regex regexRecipient = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexRecipient.Match(this.Recipient).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, must match a pattern of " + regexRecipient, new [] { "Recipient" });
            }

            // Deadline (decimal) minimum
            if (this.Deadline < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Deadline, must be a value greater than or equal to 0.", new [] { "Deadline" });
            }

            yield break;
        }
    }

}