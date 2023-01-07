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
    /// OrgNameInvitationsBody1
    /// </summary>
    [DataContract]
        public partial class OrgNameInvitationsBody1 :  IEquatable<OrgNameInvitationsBody1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgNameInvitationsBody1" /> class.
        /// </summary>
        /// <param name="userEmail">The user&#x27;s email address (required).</param>
        public OrgNameInvitationsBody1(string userEmail = default(string))
        {
            // to ensure "userEmail" is required (not null)
            if (userEmail == null)
            {
                throw new InvalidDataException("userEmail is a required property for OrgNameInvitationsBody1 and cannot be null");
            }
            else
            {
                this.UserEmail = userEmail;
            }
        }
        
        /// <summary>
        /// The user&#x27;s email address
        /// </summary>
        /// <value>The user&#x27;s email address</value>
        [DataMember(Name="user_email", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgNameInvitationsBody1 {\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
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
            return this.Equals(input as OrgNameInvitationsBody1);
        }

        /// <summary>
        /// Returns true if OrgNameInvitationsBody1 instances are equal
        /// </summary>
        /// <param name="input">Instance of OrgNameInvitationsBody1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgNameInvitationsBody1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
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
                if (this.UserEmail != null)
                    hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
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