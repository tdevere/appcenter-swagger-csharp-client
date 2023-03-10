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
    /// LegacyCodePushReleaseInfo
    /// </summary>
    [DataContract]
        public partial class LegacyCodePushReleaseInfo :  IEquatable<LegacyCodePushReleaseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCodePushReleaseInfo" /> class.
        /// </summary>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="description">description.</param>
        /// <param name="isDisabled">isDisabled.</param>
        /// <param name="isMandatory">isMandatory.</param>
        /// <param name="rollout">rollout.</param>
        public LegacyCodePushReleaseInfo(string appVersion = default(string), string description = default(string), bool? isDisabled = default(bool?), bool? isMandatory = default(bool?), int? rollout = default(int?))
        {
            this.AppVersion = appVersion;
            this.Description = description;
            this.IsDisabled = isDisabled;
            this.IsMandatory = isMandatory;
            this.Rollout = rollout;
        }
        
        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="appVersion", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name="isDisabled", EmitDefaultValue=false)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets IsMandatory
        /// </summary>
        [DataMember(Name="isMandatory", EmitDefaultValue=false)]
        public bool? IsMandatory { get; set; }

        /// <summary>
        /// Gets or Sets Rollout
        /// </summary>
        [DataMember(Name="rollout", EmitDefaultValue=false)]
        public int? Rollout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyCodePushReleaseInfo {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  IsMandatory: ").Append(IsMandatory).Append("\n");
            sb.Append("  Rollout: ").Append(Rollout).Append("\n");
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
            return this.Equals(input as LegacyCodePushReleaseInfo);
        }

        /// <summary>
        /// Returns true if LegacyCodePushReleaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyCodePushReleaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyCodePushReleaseInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
                ) && 
                (
                    this.IsMandatory == input.IsMandatory ||
                    (this.IsMandatory != null &&
                    this.IsMandatory.Equals(input.IsMandatory))
                ) && 
                (
                    this.Rollout == input.Rollout ||
                    (this.Rollout != null &&
                    this.Rollout.Equals(input.Rollout))
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
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsDisabled != null)
                    hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                if (this.IsMandatory != null)
                    hashCode = hashCode * 59 + this.IsMandatory.GetHashCode();
                if (this.Rollout != null)
                    hashCode = hashCode * 59 + this.Rollout.GetHashCode();
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
