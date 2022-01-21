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
    /// Request to retrieve a skim liquidity pool call quote
    /// </summary>
    [DataContract(Name = "quoteSkimRequest")]
    public partial class QuoteSkimRequest : IEquatable<QuoteSkimRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSkimRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteSkimRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSkimRequest" /> class.
        /// </summary>
        /// <param name="recipient">An address on the Cirrus network (required).</param>
        public QuoteSkimRequest(string recipient = default(string))
        {
            // to ensure "recipient" is required (not null)
            if (recipient == null) {
                throw new ArgumentNullException("recipient is a required property for QuoteSkimRequest and cannot be null");
            }
            this.Recipient = recipient;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteSkimRequest {\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
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
            return this.Equals(input as QuoteSkimRequest);
        }

        /// <summary>
        /// Returns true if QuoteSkimRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteSkimRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteSkimRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
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
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
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

            yield break;
        }
    }

}
