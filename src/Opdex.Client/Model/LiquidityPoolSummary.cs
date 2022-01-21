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
    /// LiquidityPoolSummary
    /// </summary>
    [DataContract(Name = "liquidityPoolSummary")]
    public partial class LiquidityPoolSummary : IEquatable<LiquidityPoolSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidityPoolSummary" /> class.
        /// </summary>
        /// <param name="reserves">reserves.</param>
        /// <param name="rewards">rewards.</param>
        /// <param name="volume">volume.</param>
        /// <param name="cost">cost.</param>
        /// <param name="staking">staking.</param>
        public LiquidityPoolSummary(ReservesSummary reserves = default(ReservesSummary), RewardSummary rewards = default(RewardSummary), VolumeSummary volume = default(VolumeSummary), CostSummary cost = default(CostSummary), LiquidityPoolStakingSummary staking = default(LiquidityPoolStakingSummary))
        {
            this.Reserves = reserves;
            this.Rewards = rewards;
            this.Volume = volume;
            this.Cost = cost;
            this.Staking = staking;
        }

        /// <summary>
        /// Gets or Sets Reserves
        /// </summary>
        [DataMember(Name = "reserves", EmitDefaultValue = false)]
        public ReservesSummary Reserves { get; set; }

        /// <summary>
        /// Gets or Sets Rewards
        /// </summary>
        [DataMember(Name = "rewards", EmitDefaultValue = false)]
        public RewardSummary Rewards { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public VolumeSummary Volume { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public CostSummary Cost { get; set; }

        /// <summary>
        /// Gets or Sets Staking
        /// </summary>
        [DataMember(Name = "staking", EmitDefaultValue = false)]
        public LiquidityPoolStakingSummary Staking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LiquidityPoolSummary {\n");
            sb.Append("  Reserves: ").Append(Reserves).Append("\n");
            sb.Append("  Rewards: ").Append(Rewards).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Staking: ").Append(Staking).Append("\n");
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
            return this.Equals(input as LiquidityPoolSummary);
        }

        /// <summary>
        /// Returns true if LiquidityPoolSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of LiquidityPoolSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiquidityPoolSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reserves == input.Reserves ||
                    (this.Reserves != null &&
                    this.Reserves.Equals(input.Reserves))
                ) && 
                (
                    this.Rewards == input.Rewards ||
                    (this.Rewards != null &&
                    this.Rewards.Equals(input.Rewards))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.Staking == input.Staking ||
                    (this.Staking != null &&
                    this.Staking.Equals(input.Staking))
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
                if (this.Reserves != null)
                {
                    hashCode = (hashCode * 59) + this.Reserves.GetHashCode();
                }
                if (this.Rewards != null)
                {
                    hashCode = (hashCode * 59) + this.Rewards.GetHashCode();
                }
                if (this.Volume != null)
                {
                    hashCode = (hashCode * 59) + this.Volume.GetHashCode();
                }
                if (this.Cost != null)
                {
                    hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                }
                if (this.Staking != null)
                {
                    hashCode = (hashCode * 59) + this.Staking.GetHashCode();
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