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
    /// MiningPoolResponse
    /// </summary>
    [DataContract(Name = "miningPoolResponse")]
    public partial class MiningPoolResponse : IEquatable<MiningPoolResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiningPoolResponse" /> class.
        /// </summary>
        /// <param name="address">An address on the Cirrus network.</param>
        /// <param name="liquidityPool">An address on the Cirrus network.</param>
        /// <param name="miningPeriodEndBlock">Block number which the current mining period ends.</param>
        /// <param name="rewardPerBlock">Decimal value with uncapped precision and size.</param>
        /// <param name="rewardPerLpt">Decimal value with uncapped precision and size.</param>
        /// <param name="tokensMining">Decimal value with uncapped precision and size.</param>
        /// <param name="isActive">True if liquidity mining is active, otherwise false.</param>
        /// <param name="createdBlock">Block number at which the entity was created.</param>
        /// <param name="modifiedBlock">Block number at which the entity state was last modified.</param>
        public MiningPoolResponse(string address = default(string), string liquidityPool = default(string), int miningPeriodEndBlock = default(int), string rewardPerBlock = default(string), string rewardPerLpt = default(string), string tokensMining = default(string), bool isActive = default(bool), int createdBlock = default(int), int modifiedBlock = default(int))
        {
            this.Address = address;
            this.LiquidityPool = liquidityPool;
            this.MiningPeriodEndBlock = miningPeriodEndBlock;
            this.RewardPerBlock = rewardPerBlock;
            this.RewardPerLpt = rewardPerLpt;
            this.TokensMining = tokensMining;
            this.IsActive = isActive;
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
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "liquidityPool", EmitDefaultValue = false)]
        public string LiquidityPool { get; set; }

        /// <summary>
        /// Block number which the current mining period ends
        /// </summary>
        /// <value>Block number which the current mining period ends</value>
        [DataMember(Name = "miningPeriodEndBlock", EmitDefaultValue = false)]
        public int MiningPeriodEndBlock { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "rewardPerBlock", EmitDefaultValue = false)]
        public string RewardPerBlock { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "rewardPerLpt", EmitDefaultValue = false)]
        public string RewardPerLpt { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokensMining", EmitDefaultValue = false)]
        public string TokensMining { get; set; }

        /// <summary>
        /// True if liquidity mining is active, otherwise false
        /// </summary>
        /// <value>True if liquidity mining is active, otherwise false</value>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

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
            sb.Append("class MiningPoolResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LiquidityPool: ").Append(LiquidityPool).Append("\n");
            sb.Append("  MiningPeriodEndBlock: ").Append(MiningPeriodEndBlock).Append("\n");
            sb.Append("  RewardPerBlock: ").Append(RewardPerBlock).Append("\n");
            sb.Append("  RewardPerLpt: ").Append(RewardPerLpt).Append("\n");
            sb.Append("  TokensMining: ").Append(TokensMining).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as MiningPoolResponse);
        }

        /// <summary>
        /// Returns true if MiningPoolResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MiningPoolResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiningPoolResponse input)
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
                    this.LiquidityPool == input.LiquidityPool ||
                    (this.LiquidityPool != null &&
                    this.LiquidityPool.Equals(input.LiquidityPool))
                ) && 
                (
                    this.MiningPeriodEndBlock == input.MiningPeriodEndBlock ||
                    this.MiningPeriodEndBlock.Equals(input.MiningPeriodEndBlock)
                ) && 
                (
                    this.RewardPerBlock == input.RewardPerBlock ||
                    (this.RewardPerBlock != null &&
                    this.RewardPerBlock.Equals(input.RewardPerBlock))
                ) && 
                (
                    this.RewardPerLpt == input.RewardPerLpt ||
                    (this.RewardPerLpt != null &&
                    this.RewardPerLpt.Equals(input.RewardPerLpt))
                ) && 
                (
                    this.TokensMining == input.TokensMining ||
                    (this.TokensMining != null &&
                    this.TokensMining.Equals(input.TokensMining))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
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
                if (this.LiquidityPool != null)
                {
                    hashCode = (hashCode * 59) + this.LiquidityPool.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MiningPeriodEndBlock.GetHashCode();
                if (this.RewardPerBlock != null)
                {
                    hashCode = (hashCode * 59) + this.RewardPerBlock.GetHashCode();
                }
                if (this.RewardPerLpt != null)
                {
                    hashCode = (hashCode * 59) + this.RewardPerLpt.GetHashCode();
                }
                if (this.TokensMining != null)
                {
                    hashCode = (hashCode * 59) + this.TokensMining.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
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

            // LiquidityPool (string) maxLength
            if (this.LiquidityPool != null && this.LiquidityPool.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LiquidityPool, length must be less than 42.", new [] { "LiquidityPool" });
            }

            // LiquidityPool (string) minLength
            if (this.LiquidityPool != null && this.LiquidityPool.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LiquidityPool, length must be greater than 30.", new [] { "LiquidityPool" });
            }

            // LiquidityPool (string) pattern
            Regex regexLiquidityPool = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]+$", RegexOptions.CultureInvariant);
            if (false == regexLiquidityPool.Match(this.LiquidityPool).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LiquidityPool, must match a pattern of " + regexLiquidityPool, new [] { "LiquidityPool" });
            }

            // MiningPeriodEndBlock (int) minimum
            if (this.MiningPeriodEndBlock < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiningPeriodEndBlock, must be a value greater than or equal to 1.", new [] { "MiningPeriodEndBlock" });
            }

            // RewardPerBlock (string) pattern
            Regex regexRewardPerBlock = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexRewardPerBlock.Match(this.RewardPerBlock).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RewardPerBlock, must match a pattern of " + regexRewardPerBlock, new [] { "RewardPerBlock" });
            }

            // RewardPerLpt (string) pattern
            Regex regexRewardPerLpt = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexRewardPerLpt.Match(this.RewardPerLpt).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RewardPerLpt, must match a pattern of " + regexRewardPerLpt, new [] { "RewardPerLpt" });
            }

            // TokensMining (string) pattern
            Regex regexTokensMining = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokensMining.Match(this.TokensMining).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokensMining, must match a pattern of " + regexTokensMining, new [] { "TokensMining" });
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
