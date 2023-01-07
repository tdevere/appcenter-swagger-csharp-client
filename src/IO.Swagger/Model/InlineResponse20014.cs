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
    /// InlineResponse20014
    /// </summary>
    [DataContract]
        public partial class InlineResponse20014 :  IEquatable<InlineResponse20014>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20014" /> class.
        /// </summary>
        /// <param name="invitationId">The id of the invitation (required).</param>
        /// <param name="organization">organization.</param>
        /// <param name="app">app.</param>
        public InlineResponse20014(Guid? invitationId = default(Guid?), V01invitationssentOrganization organization = default(V01invitationssentOrganization), AllOfinlineResponse20014App app = default(AllOfinlineResponse20014App))
        {
            // to ensure "invitationId" is required (not null)
            if (invitationId == null)
            {
                throw new InvalidDataException("invitationId is a required property for InlineResponse20014 and cannot be null");
            }
            else
            {
                this.InvitationId = invitationId;
            }
            this.Organization = organization;
            this.App = app;
        }
        
        /// <summary>
        /// The id of the invitation
        /// </summary>
        /// <value>The id of the invitation</value>
        [DataMember(Name="invitation_id", EmitDefaultValue=false)]
        public Guid? InvitationId { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public V01invitationssentOrganization Organization { get; set; }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public AllOfinlineResponse20014App App { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20014 {\n");
            sb.Append("  InvitationId: ").Append(InvitationId).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
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
            return this.Equals(input as InlineResponse20014);
        }

        /// <summary>
        /// Returns true if InlineResponse20014 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20014 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20014 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvitationId == input.InvitationId ||
                    (this.InvitationId != null &&
                    this.InvitationId.Equals(input.InvitationId))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
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
                if (this.InvitationId != null)
                    hashCode = hashCode * 59 + this.InvitationId.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
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
