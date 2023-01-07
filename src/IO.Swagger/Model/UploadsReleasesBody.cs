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
    /// UploadsReleasesBody
    /// </summary>
    [DataContract]
        public partial class UploadsReleasesBody :  IEquatable<UploadsReleasesBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsReleasesBody" /> class.
        /// </summary>
        /// <param name="buildVersion">User defined build version.</param>
        /// <param name="buildNumber">User defined build number.</param>
        public UploadsReleasesBody(string buildVersion = default(string), string buildNumber = default(string))
        {
            this.BuildVersion = buildVersion;
            this.BuildNumber = buildNumber;
        }
        
        /// <summary>
        /// User defined build version
        /// </summary>
        /// <value>User defined build version</value>
        [DataMember(Name="build_version", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }

        /// <summary>
        /// User defined build number
        /// </summary>
        /// <value>User defined build number</value>
        [DataMember(Name="build_number", EmitDefaultValue=false)]
        public string BuildNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadsReleasesBody {\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
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
            return this.Equals(input as UploadsReleasesBody);
        }

        /// <summary>
        /// Returns true if UploadsReleasesBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadsReleasesBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadsReleasesBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuildVersion == input.BuildVersion ||
                    (this.BuildVersion != null &&
                    this.BuildVersion.Equals(input.BuildVersion))
                ) && 
                (
                    this.BuildNumber == input.BuildNumber ||
                    (this.BuildNumber != null &&
                    this.BuildNumber.Equals(input.BuildNumber))
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
                if (this.BuildVersion != null)
                    hashCode = hashCode * 59 + this.BuildVersion.GetHashCode();
                if (this.BuildNumber != null)
                    hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
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
