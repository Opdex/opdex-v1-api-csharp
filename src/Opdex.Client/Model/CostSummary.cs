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
    /// CostSummary
    /// </summary>
    [DataContract(Name = "costSummary")]
    public partial class CostSummary : IEquatable<CostSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CostSummary" /> class.
        /// </summary>
        /// <param name="crsPerSrc">Decimal value with uncapped precision and size.</param>
        /// <param name="srcPerCrs">Decimal value with uncapped precision and size.</param>
        public CostSummary(string crsPerSrc = default(string), string srcPerCrs = default(string))
        {
            this.CrsPerSrc = crsPerSrc;
            this.SrcPerCrs = srcPerCrs;
        }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "crsPerSrc", EmitDefaultValue = false)]
        public string CrsPerSrc { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "srcPerCrs", EmitDefaultValue = false)]
        public string SrcPerCrs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CostSummary {\n");
            sb.Append("  CrsPerSrc: ").Append(CrsPerSrc).Append("\n");
            sb.Append("  SrcPerCrs: ").Append(SrcPerCrs).Append("\n");
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
            return this.Equals(input as CostSummary);
        }

        /// <summary>
        /// Returns true if CostSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CostSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CrsPerSrc == input.CrsPerSrc ||
                    (this.CrsPerSrc != null &&
                    this.CrsPerSrc.Equals(input.CrsPerSrc))
                ) && 
                (
                    this.SrcPerCrs == input.SrcPerCrs ||
                    (this.SrcPerCrs != null &&
                    this.SrcPerCrs.Equals(input.SrcPerCrs))
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
                if (this.CrsPerSrc != null)
                {
                    hashCode = (hashCode * 59) + this.CrsPerSrc.GetHashCode();
                }
                if (this.SrcPerCrs != null)
                {
                    hashCode = (hashCode * 59) + this.SrcPerCrs.GetHashCode();
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
            // CrsPerSrc (string) pattern
            Regex regexCrsPerSrc = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexCrsPerSrc.Match(this.CrsPerSrc).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CrsPerSrc, must match a pattern of " + regexCrsPerSrc, new [] { "CrsPerSrc" });
            }

            // SrcPerCrs (string) pattern
            Regex regexSrcPerCrs = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexSrcPerCrs.Match(this.SrcPerCrs).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SrcPerCrs, must match a pattern of " + regexSrcPerCrs, new [] { "SrcPerCrs" });
            }

            yield break;
        }
    }

}
