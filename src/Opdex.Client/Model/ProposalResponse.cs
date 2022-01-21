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
    /// ProposalResponse
    /// </summary>
    [DataContract(Name = "proposalResponse")]
    public partial class ProposalResponse : IEquatable<ProposalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProposalResponse" /> class.
        /// </summary>
        /// <param name="vault">An address on the Cirrus network.</param>
        /// <param name="token">An address on the Cirrus network.</param>
        /// <param name="proposalId">Id of the proposal stored by the vault.</param>
        /// <param name="creator">An address on the Cirrus network.</param>
        /// <param name="wallet">An address on the Cirrus network.</param>
        /// <param name="amount">Decimal value with uncapped precision and size.</param>
        /// <param name="description">Description for the proposal.</param>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="expiration">Block number that the proposal status expires, for an active proposal.</param>
        /// <param name="yesAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="noAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="pledgeAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="approved">Whether the proposal has been approved.</param>
        /// <param name="certificate">certificate.</param>
        public ProposalResponse(string vault = default(string), string token = default(string), int proposalId = default(int), string creator = default(string), string wallet = default(string), string amount = default(string), string description = default(string), ProposalType type = default(ProposalType), ProposalStatus status = default(ProposalStatus), int expiration = default(int), string yesAmount = default(string), string noAmount = default(string), string pledgeAmount = default(string), bool approved = default(bool), CertificateResponse certificate = default(CertificateResponse))
        {
            this.Vault = vault;
            this.Token = token;
            this.ProposalId = proposalId;
            this.Creator = creator;
            this.Wallet = wallet;
            this.Amount = amount;
            this.Description = description;
            this.Type = type;
            this.Status = status;
            this.Expiration = expiration;
            this.YesAmount = yesAmount;
            this.NoAmount = noAmount;
            this.PledgeAmount = pledgeAmount;
            this.Approved = approved;
            this.Certificate = certificate;
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
        /// Id of the proposal stored by the vault
        /// </summary>
        /// <value>Id of the proposal stored by the vault</value>
        [DataMember(Name = "proposalId", EmitDefaultValue = false)]
        public int ProposalId { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public string Creator { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "wallet", EmitDefaultValue = false)]
        public string Wallet { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Description for the proposal
        /// </summary>
        /// <value>Description for the proposal</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ProposalType Type { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public ProposalStatus Status { get; set; }

        /// <summary>
        /// Block number that the proposal status expires, for an active proposal
        /// </summary>
        /// <value>Block number that the proposal status expires, for an active proposal</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public int Expiration { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "yesAmount", EmitDefaultValue = false)]
        public string YesAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "noAmount", EmitDefaultValue = false)]
        public string NoAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "pledgeAmount", EmitDefaultValue = false)]
        public string PledgeAmount { get; set; }

        /// <summary>
        /// Whether the proposal has been approved
        /// </summary>
        /// <value>Whether the proposal has been approved</value>
        [DataMember(Name = "approved", EmitDefaultValue = true)]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public CertificateResponse Certificate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProposalResponse {\n");
            sb.Append("  Vault: ").Append(Vault).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  ProposalId: ").Append(ProposalId).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  YesAmount: ").Append(YesAmount).Append("\n");
            sb.Append("  NoAmount: ").Append(NoAmount).Append("\n");
            sb.Append("  PledgeAmount: ").Append(PledgeAmount).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
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
            return this.Equals(input as ProposalResponse);
        }

        /// <summary>
        /// Returns true if ProposalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProposalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProposalResponse input)
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
                    this.ProposalId == input.ProposalId ||
                    this.ProposalId.Equals(input.ProposalId)
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    this.Expiration.Equals(input.Expiration)
                ) && 
                (
                    this.YesAmount == input.YesAmount ||
                    (this.YesAmount != null &&
                    this.YesAmount.Equals(input.YesAmount))
                ) && 
                (
                    this.NoAmount == input.NoAmount ||
                    (this.NoAmount != null &&
                    this.NoAmount.Equals(input.NoAmount))
                ) && 
                (
                    this.PledgeAmount == input.PledgeAmount ||
                    (this.PledgeAmount != null &&
                    this.PledgeAmount.Equals(input.PledgeAmount))
                ) && 
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
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
                hashCode = (hashCode * 59) + this.ProposalId.GetHashCode();
                if (this.Creator != null)
                {
                    hashCode = (hashCode * 59) + this.Creator.GetHashCode();
                }
                if (this.Wallet != null)
                {
                    hashCode = (hashCode * 59) + this.Wallet.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Expiration.GetHashCode();
                if (this.YesAmount != null)
                {
                    hashCode = (hashCode * 59) + this.YesAmount.GetHashCode();
                }
                if (this.NoAmount != null)
                {
                    hashCode = (hashCode * 59) + this.NoAmount.GetHashCode();
                }
                if (this.PledgeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PledgeAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Approved.GetHashCode();
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
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

            // ProposalId (int) minimum
            if (this.ProposalId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProposalId, must be a value greater than or equal to 1.", new [] { "ProposalId" });
            }

            // Creator (string) maxLength
            if (this.Creator != null && this.Creator.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Creator, length must be less than 42.", new [] { "Creator" });
            }

            // Creator (string) minLength
            if (this.Creator != null && this.Creator.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Creator, length must be greater than 30.", new [] { "Creator" });
            }

            // Creator (string) pattern
            Regex regexCreator = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexCreator.Match(this.Creator).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Creator, must match a pattern of " + regexCreator, new [] { "Creator" });
            }

            // Wallet (string) maxLength
            if (this.Wallet != null && this.Wallet.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Wallet, length must be less than 42.", new [] { "Wallet" });
            }

            // Wallet (string) minLength
            if (this.Wallet != null && this.Wallet.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Wallet, length must be greater than 30.", new [] { "Wallet" });
            }

            // Wallet (string) pattern
            Regex regexWallet = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexWallet.Match(this.Wallet).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Wallet, must match a pattern of " + regexWallet, new [] { "Wallet" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 200.", new [] { "Description" });
            }

            // Expiration (int) minimum
            if (this.Expiration < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Expiration, must be a value greater than or equal to 1.", new [] { "Expiration" });
            }

            // YesAmount (string) pattern
            Regex regexYesAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexYesAmount.Match(this.YesAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for YesAmount, must match a pattern of " + regexYesAmount, new [] { "YesAmount" });
            }

            // NoAmount (string) pattern
            Regex regexNoAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexNoAmount.Match(this.NoAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NoAmount, must match a pattern of " + regexNoAmount, new [] { "NoAmount" });
            }

            // PledgeAmount (string) pattern
            Regex regexPledgeAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexPledgeAmount.Match(this.PledgeAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PledgeAmount, must match a pattern of " + regexPledgeAmount, new [] { "PledgeAmount" });
            }

            yield break;
        }
    }

}
