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
    [DataContract(Name = "ohlcDecimalResponse")]
    public partial class OhlcDecimalResponse : IEquatable<OhlcDecimalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OhlcDecimalResponse" /> class.
        /// </summary>
        /// <param name="open">Value at the start of the time interval.</param>
        /// <param name="high">Highest value during the time interval.</param>
        /// <param name="low">Lowest value during the time interval.</param>
        /// <param name="close">Value at the end of the time interval.</param>
        public OhlcDecimalResponse(decimal open = default(decimal), decimal high = default(decimal), decimal low = default(decimal), decimal close = default(decimal))
        {
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
        }

        /// <summary>
        /// Value at the start of the time interval
        /// </summary>
        /// <value>Value at the start of the time interval</value>
        [DataMember(Name = "open", EmitDefaultValue = false)]
        public decimal Open { get; set; }

        /// <summary>
        /// Highest value during the time interval
        /// </summary>
        /// <value>Highest value during the time interval</value>
        [DataMember(Name = "high", EmitDefaultValue = false)]
        public decimal High { get; set; }

        /// <summary>
        /// Lowest value during the time interval
        /// </summary>
        /// <value>Lowest value during the time interval</value>
        [DataMember(Name = "low", EmitDefaultValue = false)]
        public decimal Low { get; set; }

        /// <summary>
        /// Value at the end of the time interval
        /// </summary>
        /// <value>Value at the end of the time interval</value>
        [DataMember(Name = "close", EmitDefaultValue = false)]
        public decimal Close { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OhlcDecimalResponse {\n");
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
            return this.Equals(input as OhlcDecimalResponse);
        }

        /// <summary>
        /// Returns true if OhlcDecimalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OhlcDecimalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OhlcDecimalResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Open == input.Open ||
                    this.Open.Equals(input.Open)
                ) && 
                (
                    this.High == input.High ||
                    this.High.Equals(input.High)
                ) && 
                (
                    this.Low == input.Low ||
                    this.Low.Equals(input.Low)
                ) && 
                (
                    this.Close == input.Close ||
                    this.Close.Equals(input.Close)
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
                hashCode = (hashCode * 59) + this.Open.GetHashCode();
                hashCode = (hashCode * 59) + this.High.GetHashCode();
                hashCode = (hashCode * 59) + this.Low.GetHashCode();
                hashCode = (hashCode * 59) + this.Close.GetHashCode();
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
            // Open (decimal) minimum
            if (this.Open < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Open, must be a value greater than or equal to 0.0.", new [] { "Open" });
            }

            // High (decimal) minimum
            if (this.High < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for High, must be a value greater than or equal to 0.0.", new [] { "High" });
            }

            // Low (decimal) minimum
            if (this.Low < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Low, must be a value greater than or equal to 0.0.", new [] { "Low" });
            }

            // Close (decimal) minimum
            if (this.Close < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Close, must be a value greater than or equal to 0.0.", new [] { "Close" });
            }

            yield break;
        }
    }

}
