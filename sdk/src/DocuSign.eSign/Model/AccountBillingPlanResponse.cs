/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Defines an account billing plan response object.
    /// </summary>
    [DataContract]
    public partial class AccountBillingPlanResponse :  IEquatable<AccountBillingPlanResponse>, IValidatableObject
    {
        public AccountBillingPlanResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBillingPlanResponse" /> class.
        /// </summary>
        /// <param name="BillingAddress">BillingAddress.</param>
        /// <param name="BillingAddressIsCreditCardAddress">When set to **true**, the credit card address information is the same as that returned as the billing address. If false, then the billing address is considered a billing contact address, and the credit card address can be different..</param>
        /// <param name="BillingPlan">BillingPlan.</param>
        /// <param name="CreditCardInformation">CreditCardInformation.</param>
        /// <param name="ReferralInformation">ReferralInformation.</param>
        /// <param name="SuccessorPlans">.</param>
        public AccountBillingPlanResponse(AccountAddress BillingAddress = default(AccountAddress), string BillingAddressIsCreditCardAddress = default(string), AccountBillingPlan BillingPlan = default(AccountBillingPlan), CreditCardInformation CreditCardInformation = default(CreditCardInformation), ReferralInformation ReferralInformation = default(ReferralInformation), List<BillingPlan> SuccessorPlans = default(List<BillingPlan>))
        {
            this.BillingAddress = BillingAddress;
            this.BillingAddressIsCreditCardAddress = BillingAddressIsCreditCardAddress;
            this.BillingPlan = BillingPlan;
            this.CreditCardInformation = CreditCardInformation;
            this.ReferralInformation = ReferralInformation;
            this.SuccessorPlans = SuccessorPlans;
        }
        
        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AccountAddress BillingAddress { get; set; }
        /// <summary>
        /// When set to **true**, the credit card address information is the same as that returned as the billing address. If false, then the billing address is considered a billing contact address, and the credit card address can be different.
        /// </summary>
        /// <value>When set to **true**, the credit card address information is the same as that returned as the billing address. If false, then the billing address is considered a billing contact address, and the credit card address can be different.</value>
        [DataMember(Name="billingAddressIsCreditCardAddress", EmitDefaultValue=false)]
        public string BillingAddressIsCreditCardAddress { get; set; }
        /// <summary>
        /// Gets or Sets BillingPlan
        /// </summary>
        [DataMember(Name="billingPlan", EmitDefaultValue=false)]
        public AccountBillingPlan BillingPlan { get; set; }
        /// <summary>
        /// Gets or Sets CreditCardInformation
        /// </summary>
        [DataMember(Name="creditCardInformation", EmitDefaultValue=false)]
        public CreditCardInformation CreditCardInformation { get; set; }
        /// <summary>
        /// Gets or Sets ReferralInformation
        /// </summary>
        [DataMember(Name="referralInformation", EmitDefaultValue=false)]
        public ReferralInformation ReferralInformation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="successorPlans", EmitDefaultValue=false)]
        public List<BillingPlan> SuccessorPlans { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountBillingPlanResponse {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BillingAddressIsCreditCardAddress: ").Append(BillingAddressIsCreditCardAddress).Append("\n");
            sb.Append("  BillingPlan: ").Append(BillingPlan).Append("\n");
            sb.Append("  CreditCardInformation: ").Append(CreditCardInformation).Append("\n");
            sb.Append("  ReferralInformation: ").Append(ReferralInformation).Append("\n");
            sb.Append("  SuccessorPlans: ").Append(SuccessorPlans).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AccountBillingPlanResponse);
        }

        /// <summary>
        /// Returns true if AccountBillingPlanResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountBillingPlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountBillingPlanResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.BillingAddressIsCreditCardAddress == other.BillingAddressIsCreditCardAddress ||
                    this.BillingAddressIsCreditCardAddress != null &&
                    this.BillingAddressIsCreditCardAddress.Equals(other.BillingAddressIsCreditCardAddress)
                ) && 
                (
                    this.BillingPlan == other.BillingPlan ||
                    this.BillingPlan != null &&
                    this.BillingPlan.Equals(other.BillingPlan)
                ) && 
                (
                    this.CreditCardInformation == other.CreditCardInformation ||
                    this.CreditCardInformation != null &&
                    this.CreditCardInformation.Equals(other.CreditCardInformation)
                ) && 
                (
                    this.ReferralInformation == other.ReferralInformation ||
                    this.ReferralInformation != null &&
                    this.ReferralInformation.Equals(other.ReferralInformation)
                ) && 
                (
                    this.SuccessorPlans == other.SuccessorPlans ||
                    this.SuccessorPlans != null &&
                    this.SuccessorPlans.SequenceEqual(other.SuccessorPlans)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.BillingAddressIsCreditCardAddress != null)
                    hash = hash * 59 + this.BillingAddressIsCreditCardAddress.GetHashCode();
                if (this.BillingPlan != null)
                    hash = hash * 59 + this.BillingPlan.GetHashCode();
                if (this.CreditCardInformation != null)
                    hash = hash * 59 + this.CreditCardInformation.GetHashCode();
                if (this.ReferralInformation != null)
                    hash = hash * 59 + this.ReferralInformation.GetHashCode();
                if (this.SuccessorPlans != null)
                    hash = hash * 59 + this.SuccessorPlans.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}