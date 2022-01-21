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
    /// Request to retrieve an add liquidity to pool call quote
    /// </summary>
    [DataContract(Name = "quoteAddLiquidityRequest")]
    public partial class QuoteAddLiquidityRequest : IEquatable<QuoteAddLiquidityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteAddLiquidityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteAddLiquidityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteAddLiquidityRequest" /> class.
        /// </summary>
        /// <param name="amountCrs">Decimal value with uncapped precision and size (required).</param>
        /// <param name="amountSrc">Decimal value with uncapped precision and size (required).</param>
        /// <param name="amountCrsMin">Decimal value with uncapped precision and size (required).</param>
        /// <param name="amountSrcMin">Decimal value with uncapped precision and size (required).</param>
        /// <param name="recipient">An address on the Cirrus network (required).</param>
        /// <param name="deadline">Block number limit that the transaction is valid for.</param>
        public QuoteAddLiquidityRequest(string amountCrs = default(string), string amountSrc = default(string), string amountCrsMin = default(string), string amountSrcMin = default(string), string recipient = default(string), int deadline = default(int))
        {
            // to ensure "amountCrs" is required (not null)
            if (amountCrs == null) {
                throw new ArgumentNullException("amountCrs is a required property for QuoteAddLiquidityRequest and cannot be null");
            }
            this.AmountCrs = amountCrs;
            // to ensure "amountSrc" is required (not null)
            if (amountSrc == null) {
                throw new ArgumentNullException("amountSrc is a required property for QuoteAddLiquidityRequest and cannot be null");
            }
            this.AmountSrc = amountSrc;
            // to ensure "amountCrsMin" is required (not null)
            if (amountCrsMin == null) {
                throw new ArgumentNullException("amountCrsMin is a required property for QuoteAddLiquidityRequest and cannot be null");
            }
            this.AmountCrsMin = amountCrsMin;
            // to ensure "amountSrcMin" is required (not null)
            if (amountSrcMin == null) {
                throw new ArgumentNullException("amountSrcMin is a required property for QuoteAddLiquidityRequest and cannot be null");
            }
            this.AmountSrcMin = amountSrcMin;
            // to ensure "recipient" is required (not null)
            if (recipient == null) {
                throw new ArgumentNullException("recipient is a required property for QuoteAddLiquidityRequest and cannot be null");
            }
            this.Recipient = recipient;
            this.Deadline = deadline;
        }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountCrs", IsRequired = true, EmitDefaultValue = false)]
        public string AmountCrs { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountSrc", IsRequired = true, EmitDefaultValue = false)]
        public string AmountSrc { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountCrsMin", IsRequired = true, EmitDefaultValue = false)]
        public string AmountCrsMin { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountSrcMin", IsRequired = true, EmitDefaultValue = false)]
        public string AmountSrcMin { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Block number limit that the transaction is valid for
        /// </summary>
        /// <value>Block number limit that the transaction is valid for</value>
        [DataMember(Name = "deadline", EmitDefaultValue = false)]
        public int Deadline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteAddLiquidityRequest {\n");
            sb.Append("  AmountCrs: ").Append(AmountCrs).Append("\n");
            sb.Append("  AmountSrc: ").Append(AmountSrc).Append("\n");
            sb.Append("  AmountCrsMin: ").Append(AmountCrsMin).Append("\n");
            sb.Append("  AmountSrcMin: ").Append(AmountSrcMin).Append("\n");
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
            return this.Equals(input as QuoteAddLiquidityRequest);
        }

        /// <summary>
        /// Returns true if QuoteAddLiquidityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteAddLiquidityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteAddLiquidityRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AmountCrs == input.AmountCrs ||
                    (this.AmountCrs != null &&
                    this.AmountCrs.Equals(input.AmountCrs))
                ) && 
                (
                    this.AmountSrc == input.AmountSrc ||
                    (this.AmountSrc != null &&
                    this.AmountSrc.Equals(input.AmountSrc))
                ) && 
                (
                    this.AmountCrsMin == input.AmountCrsMin ||
                    (this.AmountCrsMin != null &&
                    this.AmountCrsMin.Equals(input.AmountCrsMin))
                ) && 
                (
                    this.AmountSrcMin == input.AmountSrcMin ||
                    (this.AmountSrcMin != null &&
                    this.AmountSrcMin.Equals(input.AmountSrcMin))
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
                if (this.AmountCrs != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCrs.GetHashCode();
                }
                if (this.AmountSrc != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSrc.GetHashCode();
                }
                if (this.AmountCrsMin != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCrsMin.GetHashCode();
                }
                if (this.AmountSrcMin != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSrcMin.GetHashCode();
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
            // AmountCrs (string) pattern
            Regex regexAmountCrs = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountCrs.Match(this.AmountCrs).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountCrs, must match a pattern of " + regexAmountCrs, new [] { "AmountCrs" });
            }

            // AmountSrc (string) pattern
            Regex regexAmountSrc = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountSrc.Match(this.AmountSrc).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountSrc, must match a pattern of " + regexAmountSrc, new [] { "AmountSrc" });
            }

            // AmountCrsMin (string) pattern
            Regex regexAmountCrsMin = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountCrsMin.Match(this.AmountCrsMin).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountCrsMin, must match a pattern of " + regexAmountCrsMin, new [] { "AmountCrsMin" });
            }

            // AmountSrcMin (string) pattern
            Regex regexAmountSrcMin = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountSrcMin.Match(this.AmountSrcMin).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountSrcMin, must match a pattern of " + regexAmountSrcMin, new [] { "AmountSrcMin" });
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

            // Deadline (int) minimum
            if (this.Deadline < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Deadline, must be a value greater than or equal to 1.", new [] { "Deadline" });
            }

            yield break;
        }
    }

}
