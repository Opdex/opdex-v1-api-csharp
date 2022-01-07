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
    /// Interval pricing snapshot for a token
    /// </summary>
    [DataContract(Name = "tokenSnapshotResponse")]
    public partial class TokenSnapshotResponse : IEquatable<TokenSnapshotResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenSnapshotResponse" /> class.
        /// </summary>
        /// <param name="price">price.</param>
        /// <param name="timestamp">Start time of the snapshot.</param>
        public TokenSnapshotResponse(OhlcDecimalResponse price = default(OhlcDecimalResponse), DateTime timestamp = default(DateTime))
        {
            this.Price = price;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public OhlcDecimalResponse Price { get; set; }

        /// <summary>
        /// Start time of the snapshot
        /// </summary>
        /// <value>Start time of the snapshot</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenSnapshotResponse {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as TokenSnapshotResponse);
        }

        /// <summary>
        /// Returns true if TokenSnapshotResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenSnapshotResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenSnapshotResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
