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
    /// TeamAppUpdateRequest
    /// </summary>
    [DataContract]
        public partial class TeamAppUpdateRequest :  IEquatable<TeamAppUpdateRequest>, IValidatableObject
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
            Viewer = 3        }
        /// <summary>
        /// The permissions all members of the team have on the app
        /// </summary>
        /// <value>The permissions all members of the team have on the app</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAppUpdateRequest" /> class.
        /// </summary>
        /// <param name="permissions">The permissions all members of the team have on the app (required).</param>
        public TeamAppUpdateRequest(List<PermissionsEnum> permissions = default(List<PermissionsEnum>))
        {
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for TeamAppUpdateRequest and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamAppUpdateRequest {\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as TeamAppUpdateRequest);
        }

        /// <summary>
        /// Returns true if TeamAppUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamAppUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamAppUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
