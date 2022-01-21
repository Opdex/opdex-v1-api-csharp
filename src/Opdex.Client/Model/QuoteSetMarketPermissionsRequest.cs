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
    /// Request to retrieve a set market permissions call quote
    /// </summary>
    [DataContract(Name = "quoteSetMarketPermissionsRequest")]
    public partial class QuoteSetMarketPermissionsRequest : IEquatable<QuoteSetMarketPermissionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSetMarketPermissionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteSetMarketPermissionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSetMarketPermissionsRequest" /> class.
        /// </summary>
        /// <param name="permission">permission (required).</param>
        /// <param name="authorize">If true, assigns the subject address the permission; otherwise revokes the permission if false (required).</param>
        public QuoteSetMarketPermissionsRequest(MarketPermission permission = default(MarketPermission), bool authorize = default(bool))
        {
            // to ensure "permission" is required (not null)
            if (permission == null) {
                throw new ArgumentNullException("permission is a required property for QuoteSetMarketPermissionsRequest and cannot be null");
            }
            this.Permission = permission;
            this.Authorize = authorize;
        }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name = "permission", IsRequired = true, EmitDefaultValue = false)]
        public MarketPermission Permission { get; set; }

        /// <summary>
        /// If true, assigns the subject address the permission; otherwise revokes the permission if false
        /// </summary>
        /// <value>If true, assigns the subject address the permission; otherwise revokes the permission if false</value>
        [DataMember(Name = "authorize", IsRequired = true, EmitDefaultValue = true)]
        public bool Authorize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteSetMarketPermissionsRequest {\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Authorize: ").Append(Authorize).Append("\n");
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
            return this.Equals(input as QuoteSetMarketPermissionsRequest);
        }

        /// <summary>
        /// Returns true if QuoteSetMarketPermissionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteSetMarketPermissionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteSetMarketPermissionsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Authorize == input.Authorize ||
                    this.Authorize.Equals(input.Authorize)
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
                if (this.Permission != null)
                {
                    hashCode = (hashCode * 59) + this.Permission.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Authorize.GetHashCode();
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