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
    /// UserProfileAdminResponse
    /// </summary>
    [DataContract]
        public partial class UserProfileAdminResponse :  IEquatable<UserProfileAdminResponse>, IValidatableObject
    {
        /// <summary>
        /// The user&#x27;s role in the organization
        /// </summary>
        /// <value>The user&#x27;s role in the organization</value>
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
        /// The user&#x27;s role in the organization
        /// </summary>
        /// <value>The user&#x27;s role in the organization</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileAdminResponse" /> class.
        /// </summary>
        /// <param name="role">The user&#x27;s role in the organization.</param>
        public UserProfileAdminResponse(RoleEnum? role = default(RoleEnum?))
        {
            this.Role = role;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileAdminResponse {\n");
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
            return this.Equals(input as UserProfileAdminResponse);
        }

        /// <summary>
        /// Returns true if UserProfileAdminResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileAdminResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileAdminResponse input)
        {
            if (input == null)
                return false;

            return 
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
