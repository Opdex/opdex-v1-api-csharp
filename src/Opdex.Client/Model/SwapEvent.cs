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
    /// Indicates a token swap happened
    /// </summary>
    [DataContract(Name = "swapEvent")]
    public partial class SwapEvent : IEquatable<SwapEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapEvent" /> class.
        /// </summary>
        /// <param name="sender">An address on the Cirrus network.</param>
        /// <param name="to">An address on the Cirrus network.</param>
        /// <param name="amountCrsIn">Decimal value with uncapped precision and size.</param>
        /// <param name="amountSrcIn">Decimal value with uncapped precision and size.</param>
        /// <param name="amountCrsOut">Decimal value with uncapped precision and size.</param>
        /// <param name="amountSrcOut">Decimal value with uncapped precision and size.</param>
        /// <param name="srcToken">An address on the Cirrus network.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="contract">An address on the Cirrus network.</param>
        /// <param name="sortOrder">Index to sort event order.</param>
        public SwapEvent(string sender = default(string), string to = default(string), string amountCrsIn = default(string), string amountSrcIn = default(string), string amountCrsOut = default(string), string amountSrcOut = default(string), string srcToken = default(string), TransactionEventType eventType = default(TransactionEventType), string contract = default(string), int sortOrder = default(int))
        {
            this.Sender = sender;
            this.To = to;
            this.AmountCrsIn = amountCrsIn;
            this.AmountSrcIn = amountSrcIn;
            this.AmountCrsOut = amountCrsOut;
            this.AmountSrcOut = amountSrcOut;
            this.SrcToken = srcToken;
            this.EventType = eventType;
            this.Contract = contract;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountCrsIn", EmitDefaultValue = false)]
        public string AmountCrsIn { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountSrcIn", EmitDefaultValue = false)]
        public string AmountSrcIn { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountCrsOut", EmitDefaultValue = false)]
        public string AmountCrsOut { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amountSrcOut", EmitDefaultValue = false)]
        public string AmountSrcOut { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "srcToken", EmitDefaultValue = false)]
        public string SrcToken { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public TransactionEventType EventType { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "contract", EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Index to sort event order
        /// </summary>
        /// <value>Index to sort event order</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SwapEvent {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  AmountCrsIn: ").Append(AmountCrsIn).Append("\n");
            sb.Append("  AmountSrcIn: ").Append(AmountSrcIn).Append("\n");
            sb.Append("  AmountCrsOut: ").Append(AmountCrsOut).Append("\n");
            sb.Append("  AmountSrcOut: ").Append(AmountSrcOut).Append("\n");
            sb.Append("  SrcToken: ").Append(SrcToken).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as SwapEvent);
        }

        /// <summary>
        /// Returns true if SwapEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SwapEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwapEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.AmountCrsIn == input.AmountCrsIn ||
                    (this.AmountCrsIn != null &&
                    this.AmountCrsIn.Equals(input.AmountCrsIn))
                ) && 
                (
                    this.AmountSrcIn == input.AmountSrcIn ||
                    (this.AmountSrcIn != null &&
                    this.AmountSrcIn.Equals(input.AmountSrcIn))
                ) && 
                (
                    this.AmountCrsOut == input.AmountCrsOut ||
                    (this.AmountCrsOut != null &&
                    this.AmountCrsOut.Equals(input.AmountCrsOut))
                ) && 
                (
                    this.AmountSrcOut == input.AmountSrcOut ||
                    (this.AmountSrcOut != null &&
                    this.AmountSrcOut.Equals(input.AmountSrcOut))
                ) && 
                (
                    this.SrcToken == input.SrcToken ||
                    (this.SrcToken != null &&
                    this.SrcToken.Equals(input.SrcToken))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
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
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.AmountCrsIn != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCrsIn.GetHashCode();
                }
                if (this.AmountSrcIn != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSrcIn.GetHashCode();
                }
                if (this.AmountCrsOut != null)
                {
                    hashCode = (hashCode * 59) + this.AmountCrsOut.GetHashCode();
                }
                if (this.AmountSrcOut != null)
                {
                    hashCode = (hashCode * 59) + this.AmountSrcOut.GetHashCode();
                }
                if (this.SrcToken != null)
                {
                    hashCode = (hashCode * 59) + this.SrcToken.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
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
            // Sender (string) maxLength
            if (this.Sender != null && this.Sender.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sender, length must be less than 42.", new [] { "Sender" });
            }

            // Sender (string) minLength
            if (this.Sender != null && this.Sender.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sender, length must be greater than 30.", new [] { "Sender" });
            }

            // Sender (string) pattern
            Regex regexSender = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexSender.Match(this.Sender).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sender, must match a pattern of " + regexSender, new [] { "Sender" });
            }

            // To (string) maxLength
            if (this.To != null && this.To.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 42.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 30.", new [] { "To" });
            }

            // To (string) pattern
            Regex regexTo = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexTo.Match(this.To).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, must match a pattern of " + regexTo, new [] { "To" });
            }

            // AmountCrsIn (string) pattern
            Regex regexAmountCrsIn = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountCrsIn.Match(this.AmountCrsIn).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountCrsIn, must match a pattern of " + regexAmountCrsIn, new [] { "AmountCrsIn" });
            }

            // AmountSrcIn (string) pattern
            Regex regexAmountSrcIn = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountSrcIn.Match(this.AmountSrcIn).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountSrcIn, must match a pattern of " + regexAmountSrcIn, new [] { "AmountSrcIn" });
            }

            // AmountCrsOut (string) pattern
            Regex regexAmountCrsOut = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountCrsOut.Match(this.AmountCrsOut).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountCrsOut, must match a pattern of " + regexAmountCrsOut, new [] { "AmountCrsOut" });
            }

            // AmountSrcOut (string) pattern
            Regex regexAmountSrcOut = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmountSrcOut.Match(this.AmountSrcOut).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountSrcOut, must match a pattern of " + regexAmountSrcOut, new [] { "AmountSrcOut" });
            }

            // SrcToken (string) maxLength
            if (this.SrcToken != null && this.SrcToken.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SrcToken, length must be less than 42.", new [] { "SrcToken" });
            }

            // SrcToken (string) minLength
            if (this.SrcToken != null && this.SrcToken.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SrcToken, length must be greater than 30.", new [] { "SrcToken" });
            }

            // SrcToken (string) pattern
            Regex regexSrcToken = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexSrcToken.Match(this.SrcToken).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SrcToken, must match a pattern of " + regexSrcToken, new [] { "SrcToken" });
            }

            // Contract (string) maxLength
            if (this.Contract != null && this.Contract.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be less than 42.", new [] { "Contract" });
            }

            // Contract (string) minLength
            if (this.Contract != null && this.Contract.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be greater than 30.", new [] { "Contract" });
            }

            // Contract (string) pattern
            Regex regexContract = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexContract.Match(this.Contract).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, must match a pattern of " + regexContract, new [] { "Contract" });
            }

            // SortOrder (int) minimum
            if (this.SortOrder < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortOrder, must be a value greater than or equal to 0.", new [] { "SortOrder" });
            }

            yield break;
        }
    }

}
