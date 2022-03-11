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
    /// Details for the mined token distribution schedule
    /// </summary>
    [DataContract(Name = "minedTokenDistributionDetails")]
    public partial class MinedTokenDistributionDetails : IEquatable<MinedTokenDistributionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinedTokenDistributionDetails" /> class.
        /// </summary>
        /// <param name="vault">An address on the Cirrus network.</param>
        /// <param name="miningGovernance">An address on the Cirrus network.</param>
        /// <param name="nextDistributionBlock">Block number at which the next distribution is available.</param>
        /// <param name="history">Details for the historical mined token distributions.</param>
        public MinedTokenDistributionDetails(string vault = default(string), string miningGovernance = default(string), int nextDistributionBlock = default(int), List<MinedTokenDistribution> history = default(List<MinedTokenDistribution>))
        {
            this.Vault = vault;
            this.MiningGovernance = miningGovernance;
            this.NextDistributionBlock = nextDistributionBlock;
            this.History = history;
        }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "vault", EmitDefaultValue = false)]
        public string Vault { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "miningGovernance", EmitDefaultValue = false)]
        public string MiningGovernance { get; set; }

        /// <summary>
        /// Block number at which the next distribution is available
        /// </summary>
        /// <value>Block number at which the next distribution is available</value>
        [DataMember(Name = "nextDistributionBlock", EmitDefaultValue = false)]
        public int NextDistributionBlock { get; set; }

        /// <summary>
        /// Details for the historical mined token distributions
        /// </summary>
        /// <value>Details for the historical mined token distributions</value>
        [DataMember(Name = "history", EmitDefaultValue = false)]
        public List<MinedTokenDistribution> History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MinedTokenDistributionDetails {\n");
            sb.Append("  Vault: ").Append(Vault).Append("\n");
            sb.Append("  MiningGovernance: ").Append(MiningGovernance).Append("\n");
            sb.Append("  NextDistributionBlock: ").Append(NextDistributionBlock).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            return this.Equals(input as MinedTokenDistributionDetails);
        }

        /// <summary>
        /// Returns true if MinedTokenDistributionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MinedTokenDistributionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinedTokenDistributionDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Vault == input.Vault ||
                    (this.Vault != null &&
                    this.Vault.Equals(input.Vault))
                ) && 
                (
                    this.MiningGovernance == input.MiningGovernance ||
                    (this.MiningGovernance != null &&
                    this.MiningGovernance.Equals(input.MiningGovernance))
                ) && 
                (
                    this.NextDistributionBlock == input.NextDistributionBlock ||
                    this.NextDistributionBlock.Equals(input.NextDistributionBlock)
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    input.History != null &&
                    this.History.SequenceEqual(input.History)
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
                if (this.Vault != null)
                {
                    hashCode = (hashCode * 59) + this.Vault.GetHashCode();
                }
                if (this.MiningGovernance != null)
                {
                    hashCode = (hashCode * 59) + this.MiningGovernance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NextDistributionBlock.GetHashCode();
                if (this.History != null)
                {
                    hashCode = (hashCode * 59) + this.History.GetHashCode();
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
            // Vault (string) maxLength
            if (this.Vault != null && this.Vault.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vault, length must be less than 42.", new [] { "Vault" });
            }

            // Vault (string) minLength
            if (this.Vault != null && this.Vault.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vault, length must be greater than 30.", new [] { "Vault" });
            }

            // Vault (string) pattern
            Regex regexVault = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexVault.Match(this.Vault).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vault, must match a pattern of " + regexVault, new [] { "Vault" });
            }

            // MiningGovernance (string) maxLength
            if (this.MiningGovernance != null && this.MiningGovernance.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningGovernance, length must be less than 42.", new [] { "MiningGovernance" });
            }

            // MiningGovernance (string) minLength
            if (this.MiningGovernance != null && this.MiningGovernance.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningGovernance, length must be greater than 30.", new [] { "MiningGovernance" });
            }

            // MiningGovernance (string) pattern
            Regex regexMiningGovernance = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexMiningGovernance.Match(this.MiningGovernance).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningGovernance, must match a pattern of " + regexMiningGovernance, new [] { "MiningGovernance" });
            }

            // NextDistributionBlock (int) minimum
            if (this.NextDistributionBlock < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextDistributionBlock, must be a value greater than or equal to 1.", new [] { "NextDistributionBlock" });
            }

            yield break;
        }
    }

}
