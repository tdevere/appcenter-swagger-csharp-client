/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// AddOrganizationAdminRequest
    /// </summary>
    [DataContract]
        public partial class AddOrganizationAdminRequest :  IEquatable<AddOrganizationAdminRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrganizationAdminRequest" /> class.
        /// </summary>
        /// <param name="newOrgAdminId">The internal unique id (UUID) of the account. (required).</param>
        /// <param name="issueId">The id of the related Intercom issue. (required).</param>
        /// <param name="assigningReason">The explanation for adding new org admin. (required).</param>
        /// <param name="responsibleAdminId">The id of the user who started adding new org admin. (required).</param>
        public AddOrganizationAdminRequest(Guid? newOrgAdminId = default(Guid?), string issueId = default(string), string assigningReason = default(string), Guid? responsibleAdminId = default(Guid?))
        {
            // to ensure "newOrgAdminId" is required (not null)
            if (newOrgAdminId == null)
            {
                throw new InvalidDataException("newOrgAdminId is a required property for AddOrganizationAdminRequest and cannot be null");
            }
            else
            {
                this.NewOrgAdminId = newOrgAdminId;
            }
            // to ensure "issueId" is required (not null)
            if (issueId == null)
            {
                throw new InvalidDataException("issueId is a required property for AddOrganizationAdminRequest and cannot be null");
            }
            else
            {
                this.IssueId = issueId;
            }
            // to ensure "assigningReason" is required (not null)
            if (assigningReason == null)
            {
                throw new InvalidDataException("assigningReason is a required property for AddOrganizationAdminRequest and cannot be null");
            }
            else
            {
                this.AssigningReason = assigningReason;
            }
            // to ensure "responsibleAdminId" is required (not null)
            if (responsibleAdminId == null)
            {
                throw new InvalidDataException("responsibleAdminId is a required property for AddOrganizationAdminRequest and cannot be null");
            }
            else
            {
                this.ResponsibleAdminId = responsibleAdminId;
            }
        }
        
        /// <summary>
        /// The internal unique id (UUID) of the account.
        /// </summary>
        /// <value>The internal unique id (UUID) of the account.</value>
        [DataMember(Name="new_org_admin_id", EmitDefaultValue=false)]
        public Guid? NewOrgAdminId { get; set; }

        /// <summary>
        /// The id of the related Intercom issue.
        /// </summary>
        /// <value>The id of the related Intercom issue.</value>
        [DataMember(Name="issue_id", EmitDefaultValue=false)]
        public string IssueId { get; set; }

        /// <summary>
        /// The explanation for adding new org admin.
        /// </summary>
        /// <value>The explanation for adding new org admin.</value>
        [DataMember(Name="assigning_reason", EmitDefaultValue=false)]
        public string AssigningReason { get; set; }

        /// <summary>
        /// The id of the user who started adding new org admin.
        /// </summary>
        /// <value>The id of the user who started adding new org admin.</value>
        [DataMember(Name="responsible_admin_id", EmitDefaultValue=false)]
        public Guid? ResponsibleAdminId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrganizationAdminRequest {\n");
            sb.Append("  NewOrgAdminId: ").Append(NewOrgAdminId).Append("\n");
            sb.Append("  IssueId: ").Append(IssueId).Append("\n");
            sb.Append("  AssigningReason: ").Append(AssigningReason).Append("\n");
            sb.Append("  ResponsibleAdminId: ").Append(ResponsibleAdminId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddOrganizationAdminRequest);
        }

        /// <summary>
        /// Returns true if AddOrganizationAdminRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddOrganizationAdminRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddOrganizationAdminRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewOrgAdminId == input.NewOrgAdminId ||
                    (this.NewOrgAdminId != null &&
                    this.NewOrgAdminId.Equals(input.NewOrgAdminId))
                ) && 
                (
                    this.IssueId == input.IssueId ||
                    (this.IssueId != null &&
                    this.IssueId.Equals(input.IssueId))
                ) && 
                (
                    this.AssigningReason == input.AssigningReason ||
                    (this.AssigningReason != null &&
                    this.AssigningReason.Equals(input.AssigningReason))
                ) && 
                (
                    this.ResponsibleAdminId == input.ResponsibleAdminId ||
                    (this.ResponsibleAdminId != null &&
                    this.ResponsibleAdminId.Equals(input.ResponsibleAdminId))
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
                if (this.NewOrgAdminId != null)
                    hashCode = hashCode * 59 + this.NewOrgAdminId.GetHashCode();
                if (this.IssueId != null)
                    hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.AssigningReason != null)
                    hashCode = hashCode * 59 + this.AssigningReason.GetHashCode();
                if (this.ResponsibleAdminId != null)
                    hashCode = hashCode * 59 + this.ResponsibleAdminId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
