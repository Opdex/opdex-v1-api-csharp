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
    /// Details about a block
    /// </summary>
    [DataContract(Name = "blockResponse")]
    public partial class BlockResponse : IEquatable<BlockResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockResponse" /> class.
        /// </summary>
        /// <param name="hash">SHA256 hash value.</param>
        /// <param name="height">Block number.</param>
        /// <param name="time">Block timestamp as determined by the block producer.</param>
        /// <param name="medianTime">Network-adjusted timestamp.</param>
        public BlockResponse(string hash = default(string), int height = default(int), DateTime time = default(DateTime), DateTime medianTime = default(DateTime))
        {
            this.Hash = hash;
            this.Height = height;
            this.Time = time;
            this.MedianTime = medianTime;
        }

        /// <summary>
        /// SHA256 hash value
        /// </summary>
        /// <value>SHA256 hash value</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// Block number
        /// </summary>
        /// <value>Block number</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Block timestamp as determined by the block producer
        /// </summary>
        /// <value>Block timestamp as determined by the block producer</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Network-adjusted timestamp
        /// </summary>
        /// <value>Network-adjusted timestamp</value>
        [DataMember(Name = "medianTime", EmitDefaultValue = false)]
        public DateTime MedianTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlockResponse {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  MedianTime: ").Append(MedianTime).Append("\n");
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
            return this.Equals(input as BlockResponse);
        }

        /// <summary>
        /// Returns true if BlockResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.MedianTime == input.MedianTime ||
                    (this.MedianTime != null &&
                    this.MedianTime.Equals(input.MedianTime))
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
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                if (this.MedianTime != null)
                {
                    hashCode = (hashCode * 59) + this.MedianTime.GetHashCode();
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
            // Hash (string) maxLength
            if (this.Hash != null && this.Hash.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hash, length must be less than 64.", new [] { "Hash" });
            }

            // Hash (string) minLength
            if (this.Hash != null && this.Hash.Length < 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hash, length must be greater than 64.", new [] { "Hash" });
            }

            // Hash (string) pattern
            Regex regexHash = new Regex(@"^[A-Fa-f0-9]{64}$", RegexOptions.CultureInvariant);
            if (false == regexHash.Match(this.Hash).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hash, must match a pattern of " + regexHash, new [] { "Hash" });
            }

            // Height (int) minimum
            if (this.Height < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Height, must be a value greater than or equal to 1.", new [] { "Height" });
            }

            yield break;
        }
    }

}
