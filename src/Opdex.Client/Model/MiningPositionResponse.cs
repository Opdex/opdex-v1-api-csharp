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
    /// Details a mining position
    /// </summary>
    [DataContract(Name = "miningPositionResponse")]
    public partial class MiningPositionResponse : IEquatable<MiningPositionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiningPositionResponse" /> class.
        /// </summary>
        /// <param name="address">An address on the Cirrus network.</param>
        /// <param name="amount">Decimal value with uncapped precision and size.</param>
        /// <param name="miningPool">An address on the Cirrus network.</param>
        /// <param name="miningToken">An address on the Cirrus network.</param>
        /// <param name="createdBlock">Block number at which the entity was created.</param>
        /// <param name="modifiedBlock">Block number at which the entity state was last modified.</param>
        public MiningPositionResponse(string address = default(string), string amount = default(string), string miningPool = default(string), string miningToken = default(string), int createdBlock = default(int), int modifiedBlock = default(int))
        {
            this.Address = address;
            this.Amount = amount;
            this.MiningPool = miningPool;
            this.MiningToken = miningToken;
            this.CreatedBlock = createdBlock;
            this.ModifiedBlock = modifiedBlock;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "miningPool", EmitDefaultValue = false)]
        public string MiningPool { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "miningToken", EmitDefaultValue = false)]
        public string MiningToken { get; set; }

        /// <summary>
        /// Block number at which the entity was created
        /// </summary>
        /// <value>Block number at which the entity was created</value>
        [DataMember(Name = "createdBlock", EmitDefaultValue = false)]
        public int CreatedBlock { get; set; }

        /// <summary>
        /// Block number at which the entity state was last modified
        /// </summary>
        /// <value>Block number at which the entity state was last modified</value>
        [DataMember(Name = "modifiedBlock", EmitDefaultValue = false)]
        public int ModifiedBlock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiningPositionResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MiningPool: ").Append(MiningPool).Append("\n");
            sb.Append("  MiningToken: ").Append(MiningToken).Append("\n");
            sb.Append("  CreatedBlock: ").Append(CreatedBlock).Append("\n");
            sb.Append("  ModifiedBlock: ").Append(ModifiedBlock).Append("\n");
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
            return this.Equals(input as MiningPositionResponse);
        }

        /// <summary>
        /// Returns true if MiningPositionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MiningPositionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiningPositionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.MiningPool == input.MiningPool ||
                    (this.MiningPool != null &&
                    this.MiningPool.Equals(input.MiningPool))
                ) && 
                (
                    this.MiningToken == input.MiningToken ||
                    (this.MiningToken != null &&
                    this.MiningToken.Equals(input.MiningToken))
                ) && 
                (
                    this.CreatedBlock == input.CreatedBlock ||
                    this.CreatedBlock.Equals(input.CreatedBlock)
                ) && 
                (
                    this.ModifiedBlock == input.ModifiedBlock ||
                    this.ModifiedBlock.Equals(input.ModifiedBlock)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.MiningPool != null)
                {
                    hashCode = (hashCode * 59) + this.MiningPool.GetHashCode();
                }
                if (this.MiningToken != null)
                {
                    hashCode = (hashCode * 59) + this.MiningToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedBlock.GetHashCode();
                hashCode = (hashCode * 59) + this.ModifiedBlock.GetHashCode();
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
            // Address (string) maxLength
            if (this.Address != null && this.Address.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be less than 42.", new [] { "Address" });
            }

            // Address (string) minLength
            if (this.Address != null && this.Address.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be greater than 30.", new [] { "Address" });
            }

            // Address (string) pattern
            Regex regexAddress = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexAddress.Match(this.Address).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, must match a pattern of " + regexAddress, new [] { "Address" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
            }

            // MiningPool (string) maxLength
            if (this.MiningPool != null && this.MiningPool.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningPool, length must be less than 42.", new [] { "MiningPool" });
            }

            // MiningPool (string) minLength
            if (this.MiningPool != null && this.MiningPool.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningPool, length must be greater than 30.", new [] { "MiningPool" });
            }

            // MiningPool (string) pattern
            Regex regexMiningPool = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexMiningPool.Match(this.MiningPool).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningPool, must match a pattern of " + regexMiningPool, new [] { "MiningPool" });
            }

            // MiningToken (string) maxLength
            if (this.MiningToken != null && this.MiningToken.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningToken, length must be less than 42.", new [] { "MiningToken" });
            }

            // MiningToken (string) minLength
            if (this.MiningToken != null && this.MiningToken.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningToken, length must be greater than 30.", new [] { "MiningToken" });
            }

            // MiningToken (string) pattern
            Regex regexMiningToken = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexMiningToken.Match(this.MiningToken).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningToken, must match a pattern of " + regexMiningToken, new [] { "MiningToken" });
            }

            // CreatedBlock (int) minimum
            if (this.CreatedBlock < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedBlock, must be a value greater than or equal to 1.", new [] { "CreatedBlock" });
            }

            // ModifiedBlock (int) minimum
            if (this.ModifiedBlock < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModifiedBlock, must be a value greater than or equal to 1.", new [] { "ModifiedBlock" });
            }

            yield break;
        }
    }

}
