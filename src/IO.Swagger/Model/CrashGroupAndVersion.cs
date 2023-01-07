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
    /// CrashGroupAndVersion
    /// </summary>
    [DataContract]
        public partial class CrashGroupAndVersion :  IEquatable<CrashGroupAndVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupAndVersion" /> class.
        /// </summary>
        /// <param name="crashGroupId">crashGroupId.</param>
        /// <param name="appVersion">appVersion.</param>
        public CrashGroupAndVersion(string crashGroupId = default(string), string appVersion = default(string))
        {
            this.CrashGroupId = crashGroupId;
            this.AppVersion = appVersion;
        }
        
        /// <summary>
        /// Gets or Sets CrashGroupId
        /// </summary>
        [DataMember(Name="crash_group_id", EmitDefaultValue=false)]
        public string CrashGroupId { get; set; }

        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="app_version", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupAndVersion {\n");
            sb.Append("  CrashGroupId: ").Append(CrashGroupId).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
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
            return this.Equals(input as CrashGroupAndVersion);
        }

        /// <summary>
        /// Returns true if CrashGroupAndVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupAndVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupAndVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrashGroupId == input.CrashGroupId ||
                    (this.CrashGroupId != null &&
                    this.CrashGroupId.Equals(input.CrashGroupId))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
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
                if (this.CrashGroupId != null)
                    hashCode = hashCode * 59 + this.CrashGroupId.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
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
