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
    /// LegacyAppListResponseCollaborators
    /// </summary>
    [DataContract]
        public partial class LegacyAppListResponseCollaborators :  IEquatable<LegacyAppListResponseCollaborators>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAppListResponseCollaborators" /> class.
        /// </summary>
        /// <param name="isCurrentAccount">Is current collaborator the same as current account..</param>
        /// <param name="permission">Which permission does current account has..</param>
        public LegacyAppListResponseCollaborators(bool? isCurrentAccount = default(bool?), string permission = default(string))
        {
            this.IsCurrentAccount = isCurrentAccount;
            this.Permission = permission;
        }
        
        /// <summary>
        /// Is current collaborator the same as current account.
        /// </summary>
        /// <value>Is current collaborator the same as current account.</value>
        [DataMember(Name="isCurrentAccount", EmitDefaultValue=false)]
        public bool? IsCurrentAccount { get; set; }

        /// <summary>
        /// Which permission does current account has.
        /// </summary>
        /// <value>Which permission does current account has.</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public string Permission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyAppListResponseCollaborators {\n");
            sb.Append("  IsCurrentAccount: ").Append(IsCurrentAccount).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
            return this.Equals(input as LegacyAppListResponseCollaborators);
        }

        /// <summary>
        /// Returns true if LegacyAppListResponseCollaborators instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyAppListResponseCollaborators to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyAppListResponseCollaborators input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsCurrentAccount == input.IsCurrentAccount ||
                    (this.IsCurrentAccount != null &&
                    this.IsCurrentAccount.Equals(input.IsCurrentAccount))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
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
                if (this.IsCurrentAccount != null)
                    hashCode = hashCode * 59 + this.IsCurrentAccount.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
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
