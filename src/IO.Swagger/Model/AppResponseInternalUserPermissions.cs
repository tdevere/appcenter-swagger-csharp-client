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
    /// the permissions for the specified app user
    /// </summary>
    [DataContract]
        public partial class AppResponseInternalUserPermissions :  IEquatable<AppResponseInternalUserPermissions>, IValidatableObject
    {
        /// <summary>
        /// Defines Permissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PermissionsEnum
        {
            /// <summary>
            /// Enum Manager for value: manager
            /// </summary>
            [EnumMember(Value = "manager")]
            Manager = 1,
            /// <summary>
            /// Enum Developer for value: developer
            /// </summary>
            [EnumMember(Value = "developer")]
            Developer = 2,
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 3,
            /// <summary>
            /// Enum Tester for value: tester
            /// </summary>
            [EnumMember(Value = "tester")]
            Tester = 4        }
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppResponseInternalUserPermissions" /> class.
        /// </summary>
        /// <param name="permissions">permissions.</param>
        /// <param name="userId">userId.</param>
        public AppResponseInternalUserPermissions(List<PermissionsEnum> permissions = default(List<PermissionsEnum>), Guid? userId = default(Guid?))
        {
            this.Permissions = permissions;
            this.UserId = userId;
        }
        

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppResponseInternalUserPermissions {\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AppResponseInternalUserPermissions);
        }

        /// <summary>
        /// Returns true if AppResponseInternalUserPermissions instances are equal
        /// </summary>
        /// <param name="input">Instance of AppResponseInternalUserPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppResponseInternalUserPermissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
