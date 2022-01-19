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
    /// ReservesSnapshot
    /// </summary>
    [DataContract(Name = "reservesSnapshot")]
    public partial class ReservesSnapshot : IEquatable<ReservesSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservesSnapshot" /> class.
        /// </summary>
        /// <param name="crs">crs.</param>
        /// <param name="src">src.</param>
        /// <param name="usd">usd.</param>
        public ReservesSnapshot(OhlcFixedDecimalResponse crs = default(OhlcFixedDecimalResponse), OhlcFixedDecimalResponse src = default(OhlcFixedDecimalResponse), OhlcDecimalResponse usd = default(OhlcDecimalResponse))
        {
            this.Crs = crs;
            this.Src = src;
            this.Usd = usd;
        }

        /// <summary>
        /// Gets or Sets Crs
        /// </summary>
        [DataMember(Name = "crs", EmitDefaultValue = false)]
        public OhlcFixedDecimalResponse Crs { get; set; }

        /// <summary>
        /// Gets or Sets Src
        /// </summary>
        [DataMember(Name = "src", EmitDefaultValue = false)]
        public OhlcFixedDecimalResponse Src { get; set; }

        /// <summary>
        /// Gets or Sets Usd
        /// </summary>
        [DataMember(Name = "usd", EmitDefaultValue = false)]
        public OhlcDecimalResponse Usd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReservesSnapshot {\n");
            sb.Append("  Crs: ").Append(Crs).Append("\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  Usd: ").Append(Usd).Append("\n");
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
            return this.Equals(input as ReservesSnapshot);
        }

        /// <summary>
        /// Returns true if ReservesSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of ReservesSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservesSnapshot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Crs == input.Crs ||
                    (this.Crs != null &&
                    this.Crs.Equals(input.Crs))
                ) && 
                (
                    this.Src == input.Src ||
                    (this.Src != null &&
                    this.Src.Equals(input.Src))
                ) && 
                (
                    this.Usd == input.Usd ||
                    (this.Usd != null &&
                    this.Usd.Equals(input.Usd))
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
                if (this.Crs != null)
                {
                    hashCode = (hashCode * 59) + this.Crs.GetHashCode();
                }
                if (this.Src != null)
                {
                    hashCode = (hashCode * 59) + this.Src.GetHashCode();
                }
                if (this.Usd != null)
                {
                    hashCode = (hashCode * 59) + this.Usd.GetHashCode();
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
            yield break;
        }
    }

}
