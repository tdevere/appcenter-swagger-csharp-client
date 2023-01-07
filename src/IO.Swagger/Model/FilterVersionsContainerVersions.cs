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
    /// FilterVersionsContainerVersions
    /// </summary>
    [DataContract]
        public partial class FilterVersionsContainerVersions :  IEquatable<FilterVersionsContainerVersions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterVersionsContainerVersions" /> class.
        /// </summary>
        /// <param name="version">App version.  (required).</param>
        /// <param name="build">App build number.  (required).</param>
        public FilterVersionsContainerVersions(string version = default(string), string build = default(string))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for FilterVersionsContainerVersions and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            // to ensure "build" is required (not null)
            if (build == null)
            {
                throw new InvalidDataException("build is a required property for FilterVersionsContainerVersions and cannot be null");
            }
            else
            {
                this.Build = build;
            }
        }
        
        /// <summary>
        /// App version. 
        /// </summary>
        /// <value>App version. </value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// App build number. 
        /// </summary>
        /// <value>App build number. </value>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public string Build { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterVersionsContainerVersions {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
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
            return this.Equals(input as FilterVersionsContainerVersions);
        }

        /// <summary>
        /// Returns true if FilterVersionsContainerVersions instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterVersionsContainerVersions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterVersionsContainerVersions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
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