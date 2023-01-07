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
    /// UserEmailOrgRoleRequest
    /// </summary>
    [DataContract]
        public partial class UserEmailOrgRoleRequest :  IEquatable<UserEmailOrgRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// The user&#x27;s role
        /// </summary>
        /// <value>The user&#x27;s role</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum Admin for value: admin
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin = 1,
            /// <summary>
            /// Enum Collaborator for value: collaborator
            /// </summary>
            [EnumMember(Value = "collaborator")]
            Collaborator = 2,
            /// <summary>
            /// Enum Member for value: member
            /// </summary>
            [EnumMember(Value = "member")]
            Member = 3        }
        /// <summary>
        /// The user&#x27;s role
        /// </summary>
        /// <value>The user&#x27;s role</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmailOrgRoleRequest" /> class.
        /// </summary>
        /// <param name="userEmail">The user&#x27;s email address (required).</param>
        /// <param name="role">The user&#x27;s role.</param>
        public UserEmailOrgRoleRequest(string userEmail = default(string), RoleEnum? role = default(RoleEnum?))
        {
            // to ensure "userEmail" is required (not null)
            if (userEmail == null)
            {
                throw new InvalidDataException("userEmail is a required property for UserEmailOrgRoleRequest and cannot be null");
            }
            else
            {
                this.UserEmail = userEmail;
            }
            this.Role = role;
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
            sb.Append("class UserEmailOrgRoleRequest {\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as UserEmailOrgRoleRequest);
        }

        /// <summary>
        /// Returns true if UserEmailOrgRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UserEmailOrgRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEmailOrgRoleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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
