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
    /// Open, high, low, close values within a time interval
    /// </summary>
    [DataContract(Name = "ohlcFixedDecimalResponse")]
    public partial class OhlcFixedDecimalResponse : IEquatable<OhlcFixedDecimalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OhlcFixedDecimalResponse" /> class.
        /// </summary>
        /// <param name="open">Decimal value with uncapped precision and size.</param>
        /// <param name="high">Decimal value with uncapped precision and size.</param>
        /// <param name="low">Decimal value with uncapped precision and size.</param>
        /// <param name="close">Decimal value with uncapped precision and size.</param>
        public OhlcFixedDecimalResponse(string open = default(string), string high = default(string), string low = default(string), string close = default(string))
        {
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
        }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public string Open { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public string High { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public string Low { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public string Close { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OhlcFixedDecimalResponse {\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
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
            return this.Equals(input as OhlcFixedDecimalResponse);
        }

        /// <summary>
        /// Returns true if OhlcFixedDecimalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OhlcFixedDecimalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OhlcFixedDecimalResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
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
                if (this.Open != null)
                {
                    hashCode = (hashCode * 59) + this.Open.GetHashCode();
                }
                if (this.High != null)
                {
                    hashCode = (hashCode * 59) + this.High.GetHashCode();
                }
                if (this.Low != null)
                {
                    hashCode = (hashCode * 59) + this.Low.GetHashCode();
                }
                if (this.Close != null)
                {
                    hashCode = (hashCode * 59) + this.Close.GetHashCode();
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
            // Open (string) pattern
            Regex regexOpen = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexOpen.Match(this.Open).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Open, must match a pattern of " + regexOpen, new [] { "Open" });
            }

            // High (string) pattern
            Regex regexHigh = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexHigh.Match(this.High).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for High, must match a pattern of " + regexHigh, new [] { "High" });
            }

            // Low (string) pattern
            Regex regexLow = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexLow.Match(this.Low).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Low, must match a pattern of " + regexLow, new [] { "Low" });
            }

            // Close (string) pattern
            Regex regexClose = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexClose.Match(this.Close).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Close, must match a pattern of " + regexClose, new [] { "Close" });
            }

            yield break;
        }
    }

}