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
    /// VaultResponse
    /// </summary>
    [DataContract(Name = "vaultResponse")]
    public partial class VaultResponse : IEquatable<VaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultResponse" /> class.
        /// </summary>
        /// <param name="vault">An address on the Cirrus network.</param>
        /// <param name="token">An address on the Cirrus network.</param>
        /// <param name="tokensUnassigned">Decimal value with uncapped precision and size.</param>
        /// <param name="tokensProposed">Decimal value with uncapped precision and size.</param>
        /// <param name="tokensLocked">Decimal value with uncapped precision and size.</param>
        /// <param name="totalPledgeMinimum">Decimal value with uncapped precision and size.</param>
        /// <param name="totalVoteMinimum">Decimal value with uncapped precision and size.</param>
        /// <param name="vestingDuration">Number of blocks that a certificate is vested for, before it can be redeemed.</param>
        public VaultResponse(string vault = default(string), string token = default(string), string tokensUnassigned = default(string), string tokensProposed = default(string), string tokensLocked = default(string), string totalPledgeMinimum = default(string), string totalVoteMinimum = default(string), int vestingDuration = default(int))
        {
            this.Vault = vault;
            this.Token = token;
            this.TokensUnassigned = tokensUnassigned;
            this.TokensProposed = tokensProposed;
            this.TokensLocked = tokensLocked;
            this.TotalPledgeMinimum = totalPledgeMinimum;
            this.TotalVoteMinimum = totalVoteMinimum;
            this.VestingDuration = vestingDuration;
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
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokensUnassigned", EmitDefaultValue = false)]
        public string TokensUnassigned { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokensProposed", EmitDefaultValue = false)]
        public string TokensProposed { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "tokensLocked", EmitDefaultValue = false)]
        public string TokensLocked { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "totalPledgeMinimum", EmitDefaultValue = false)]
        public string TotalPledgeMinimum { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "totalVoteMinimum", EmitDefaultValue = false)]
        public string TotalVoteMinimum { get; set; }

        /// <summary>
        /// Number of blocks that a certificate is vested for, before it can be redeemed
        /// </summary>
        /// <value>Number of blocks that a certificate is vested for, before it can be redeemed</value>
        [DataMember(Name = "vestingDuration", EmitDefaultValue = false)]
        public int VestingDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VaultResponse {\n");
            sb.Append("  Vault: ").Append(Vault).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokensUnassigned: ").Append(TokensUnassigned).Append("\n");
            sb.Append("  TokensProposed: ").Append(TokensProposed).Append("\n");
            sb.Append("  TokensLocked: ").Append(TokensLocked).Append("\n");
            sb.Append("  TotalPledgeMinimum: ").Append(TotalPledgeMinimum).Append("\n");
            sb.Append("  TotalVoteMinimum: ").Append(TotalVoteMinimum).Append("\n");
            sb.Append("  VestingDuration: ").Append(VestingDuration).Append("\n");
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
            return this.Equals(input as VaultResponse);
        }

        /// <summary>
        /// Returns true if VaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultResponse input)
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
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokensUnassigned == input.TokensUnassigned ||
                    (this.TokensUnassigned != null &&
                    this.TokensUnassigned.Equals(input.TokensUnassigned))
                ) && 
                (
                    this.TokensProposed == input.TokensProposed ||
                    (this.TokensProposed != null &&
                    this.TokensProposed.Equals(input.TokensProposed))
                ) && 
                (
                    this.TokensLocked == input.TokensLocked ||
                    (this.TokensLocked != null &&
                    this.TokensLocked.Equals(input.TokensLocked))
                ) && 
                (
                    this.TotalPledgeMinimum == input.TotalPledgeMinimum ||
                    (this.TotalPledgeMinimum != null &&
                    this.TotalPledgeMinimum.Equals(input.TotalPledgeMinimum))
                ) && 
                (
                    this.TotalVoteMinimum == input.TotalVoteMinimum ||
                    (this.TotalVoteMinimum != null &&
                    this.TotalVoteMinimum.Equals(input.TotalVoteMinimum))
                ) && 
                (
                    this.VestingDuration == input.VestingDuration ||
                    this.VestingDuration.Equals(input.VestingDuration)
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
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.TokensUnassigned != null)
                {
                    hashCode = (hashCode * 59) + this.TokensUnassigned.GetHashCode();
                }
                if (this.TokensProposed != null)
                {
                    hashCode = (hashCode * 59) + this.TokensProposed.GetHashCode();
                }
                if (this.TokensLocked != null)
                {
                    hashCode = (hashCode * 59) + this.TokensLocked.GetHashCode();
                }
                if (this.TotalPledgeMinimum != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPledgeMinimum.GetHashCode();
                }
                if (this.TotalVoteMinimum != null)
                {
                    hashCode = (hashCode * 59) + this.TotalVoteMinimum.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VestingDuration.GetHashCode();
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
            Regex regexVault = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexVault.Match(this.Vault).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vault, must match a pattern of " + regexVault, new [] { "Vault" });
            }

            // Token (string) maxLength
            if (this.Token != null && this.Token.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be less than 42.", new [] { "Token" });
            }

            // Token (string) minLength
            if (this.Token != null && this.Token.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be greater than 30.", new [] { "Token" });
            }

            // Token (string) pattern
            Regex regexToken = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexToken.Match(this.Token).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, must match a pattern of " + regexToken, new [] { "Token" });
            }

            // TokensUnassigned (string) pattern
            Regex regexTokensUnassigned = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokensUnassigned.Match(this.TokensUnassigned).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokensUnassigned, must match a pattern of " + regexTokensUnassigned, new [] { "TokensUnassigned" });
            }

            // TokensProposed (string) pattern
            Regex regexTokensProposed = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokensProposed.Match(this.TokensProposed).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokensProposed, must match a pattern of " + regexTokensProposed, new [] { "TokensProposed" });
            }

            // TokensLocked (string) pattern
            Regex regexTokensLocked = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTokensLocked.Match(this.TokensLocked).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokensLocked, must match a pattern of " + regexTokensLocked, new [] { "TokensLocked" });
            }

            // TotalPledgeMinimum (string) pattern
            Regex regexTotalPledgeMinimum = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTotalPledgeMinimum.Match(this.TotalPledgeMinimum).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalPledgeMinimum, must match a pattern of " + regexTotalPledgeMinimum, new [] { "TotalPledgeMinimum" });
            }

            // TotalVoteMinimum (string) pattern
            Regex regexTotalVoteMinimum = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexTotalVoteMinimum.Match(this.TotalVoteMinimum).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalVoteMinimum, must match a pattern of " + regexTotalVoteMinimum, new [] { "TotalVoteMinimum" });
            }

            // VestingDuration (int) minimum
            if (this.VestingDuration < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VestingDuration, must be a value greater than or equal to 0.", new [] { "VestingDuration" });
            }

            yield break;
        }
    }

}
