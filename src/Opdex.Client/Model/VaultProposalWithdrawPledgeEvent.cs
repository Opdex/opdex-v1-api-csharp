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
    /// Indicates a pledge was withdrawn from a vault proposal
    /// </summary>
    [DataContract(Name = "vaultProposalWithdrawPledgeEvent")]
    public partial class VaultProposalWithdrawPledgeEvent : IEquatable<VaultProposalWithdrawPledgeEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultProposalWithdrawPledgeEvent" /> class.
        /// </summary>
        /// <param name="proposalId">Identifier for the proposal.</param>
        /// <param name="pledger">An address on the Cirrus network.</param>
        /// <param name="withdrawAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="pledgerAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="proposalPledgeAmount">Decimal value with uncapped precision and size.</param>
        /// <param name="pledgeWithdrawn">Whether the proposal is active and status is pledge.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="contract">An address on the Cirrus network.</param>
        /// <param name="sortOrder">Index to sort event order.</param>
        public VaultProposalWithdrawPledgeEvent(int proposalId = default(int), string pledger = default(string), string withdrawAmount = default(string), string pledgerAmount = default(string), string proposalPledgeAmount = default(string), bool pledgeWithdrawn = default(bool), TransactionEventType eventType = default(TransactionEventType), string contract = default(string), int sortOrder = default(int))
        {
            this.ProposalId = proposalId;
            this.Pledger = pledger;
            this.WithdrawAmount = withdrawAmount;
            this.PledgerAmount = pledgerAmount;
            this.ProposalPledgeAmount = proposalPledgeAmount;
            this.PledgeWithdrawn = pledgeWithdrawn;
            this.EventType = eventType;
            this.Contract = contract;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Identifier for the proposal
        /// </summary>
        /// <value>Identifier for the proposal</value>
        [DataMember(Name = "proposalId", EmitDefaultValue = false)]
        public int ProposalId { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "pledger", EmitDefaultValue = false)]
        public string Pledger { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "withdrawAmount", EmitDefaultValue = false)]
        public string WithdrawAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "pledgerAmount", EmitDefaultValue = false)]
        public string PledgerAmount { get; set; }

        /// <summary>
        /// Decimal value with uncapped precision and size
        /// </summary>
        /// <value>Decimal value with uncapped precision and size</value>
        [DataMember(Name = "proposalPledgeAmount", EmitDefaultValue = false)]
        public string ProposalPledgeAmount { get; set; }

        /// <summary>
        /// Whether the proposal is active and status is pledge
        /// </summary>
        /// <value>Whether the proposal is active and status is pledge</value>
        [DataMember(Name = "pledgeWithdrawn", EmitDefaultValue = true)]
        public bool PledgeWithdrawn { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public TransactionEventType EventType { get; set; }

        /// <summary>
        /// An address on the Cirrus network
        /// </summary>
        /// <value>An address on the Cirrus network</value>
        [DataMember(Name = "contract", EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Index to sort event order
        /// </summary>
        /// <value>Index to sort event order</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VaultProposalWithdrawPledgeEvent {\n");
            sb.Append("  ProposalId: ").Append(ProposalId).Append("\n");
            sb.Append("  Pledger: ").Append(Pledger).Append("\n");
            sb.Append("  WithdrawAmount: ").Append(WithdrawAmount).Append("\n");
            sb.Append("  PledgerAmount: ").Append(PledgerAmount).Append("\n");
            sb.Append("  ProposalPledgeAmount: ").Append(ProposalPledgeAmount).Append("\n");
            sb.Append("  PledgeWithdrawn: ").Append(PledgeWithdrawn).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as VaultProposalWithdrawPledgeEvent);
        }

        /// <summary>
        /// Returns true if VaultProposalWithdrawPledgeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultProposalWithdrawPledgeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultProposalWithdrawPledgeEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProposalId == input.ProposalId ||
                    this.ProposalId.Equals(input.ProposalId)
                ) && 
                (
                    this.Pledger == input.Pledger ||
                    (this.Pledger != null &&
                    this.Pledger.Equals(input.Pledger))
                ) && 
                (
                    this.WithdrawAmount == input.WithdrawAmount ||
                    (this.WithdrawAmount != null &&
                    this.WithdrawAmount.Equals(input.WithdrawAmount))
                ) && 
                (
                    this.PledgerAmount == input.PledgerAmount ||
                    (this.PledgerAmount != null &&
                    this.PledgerAmount.Equals(input.PledgerAmount))
                ) && 
                (
                    this.ProposalPledgeAmount == input.ProposalPledgeAmount ||
                    (this.ProposalPledgeAmount != null &&
                    this.ProposalPledgeAmount.Equals(input.ProposalPledgeAmount))
                ) && 
                (
                    this.PledgeWithdrawn == input.PledgeWithdrawn ||
                    this.PledgeWithdrawn.Equals(input.PledgeWithdrawn)
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder.Equals(input.SortOrder)
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
                hashCode = (hashCode * 59) + this.ProposalId.GetHashCode();
                if (this.Pledger != null)
                {
                    hashCode = (hashCode * 59) + this.Pledger.GetHashCode();
                }
                if (this.WithdrawAmount != null)
                {
                    hashCode = (hashCode * 59) + this.WithdrawAmount.GetHashCode();
                }
                if (this.PledgerAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PledgerAmount.GetHashCode();
                }
                if (this.ProposalPledgeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ProposalPledgeAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PledgeWithdrawn.GetHashCode();
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortOrder.GetHashCode();
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
            // ProposalId (int) minimum
            if (this.ProposalId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProposalId, must be a value greater than or equal to 1.", new [] { "ProposalId" });
            }

            // Pledger (string) maxLength
            if (this.Pledger != null && this.Pledger.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pledger, length must be less than 42.", new [] { "Pledger" });
            }

            // Pledger (string) minLength
            if (this.Pledger != null && this.Pledger.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pledger, length must be greater than 30.", new [] { "Pledger" });
            }

            // Pledger (string) pattern
            Regex regexPledger = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexPledger.Match(this.Pledger).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pledger, must match a pattern of " + regexPledger, new [] { "Pledger" });
            }

            // WithdrawAmount (string) pattern
            Regex regexWithdrawAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexWithdrawAmount.Match(this.WithdrawAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WithdrawAmount, must match a pattern of " + regexWithdrawAmount, new [] { "WithdrawAmount" });
            }

            // PledgerAmount (string) pattern
            Regex regexPledgerAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexPledgerAmount.Match(this.PledgerAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PledgerAmount, must match a pattern of " + regexPledgerAmount, new [] { "PledgerAmount" });
            }

            // ProposalPledgeAmount (string) pattern
            Regex regexProposalPledgeAmount = new Regex(@"^\\d*\\.\\d{1,18}$", RegexOptions.CultureInvariant);
            if (false == regexProposalPledgeAmount.Match(this.ProposalPledgeAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProposalPledgeAmount, must match a pattern of " + regexProposalPledgeAmount, new [] { "ProposalPledgeAmount" });
            }

            // Contract (string) maxLength
            if (this.Contract != null && this.Contract.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be less than 42.", new [] { "Contract" });
            }

            // Contract (string) minLength
            if (this.Contract != null && this.Contract.Length < 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, length must be greater than 30.", new [] { "Contract" });
            }

            // Contract (string) pattern
            Regex regexContract = new Regex(@"^[a-km-zA-HJ-NP-Z1-9]$", RegexOptions.CultureInvariant);
            if (false == regexContract.Match(this.Contract).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contract, must match a pattern of " + regexContract, new [] { "Contract" });
            }

            // SortOrder (int) minimum
            if (this.SortOrder < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortOrder, must be a value greater than or equal to 0.", new [] { "SortOrder" });
            }

            yield break;
        }
    }

}
