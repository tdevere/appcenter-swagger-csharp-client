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
    /// PatchRepoInfo
    /// </summary>
    [DataContract]
        public partial class PatchRepoInfo :  IEquatable<PatchRepoInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRepoInfo" /> class.
        /// </summary>
        /// <param name="externalUserId">The external user ID.</param>
        public PatchRepoInfo(string externalUserId = default(string))
        {
            this.ExternalUserId = externalUserId;
        }
        
        /// <summary>
        /// The external user ID
        /// </summary>
        /// <value>The external user ID</value>
        [DataMember(Name="external_user_id", EmitDefaultValue=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchRepoInfo {\n");
            sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
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
            return this.Equals(input as PatchRepoInfo);
        }

        /// <summary>
        /// Returns true if PatchRepoInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchRepoInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchRepoInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalUserId == input.ExternalUserId ||
                    (this.ExternalUserId != null &&
                    this.ExternalUserId.Equals(input.ExternalUserId))
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
                if (this.ExternalUserId != null)
                    hashCode = hashCode * 59 + this.ExternalUserId.GetHashCode();
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
