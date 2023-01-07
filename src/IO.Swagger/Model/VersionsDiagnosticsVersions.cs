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
    /// VersionsDiagnosticsVersions
    /// </summary>
    [DataContract]
        public partial class VersionsDiagnosticsVersions :  IEquatable<VersionsDiagnosticsVersions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionsDiagnosticsVersions" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="count">version count.</param>
        /// <param name="previousCount">the count of previous time range of the version.</param>
        public VersionsDiagnosticsVersions(string version = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            this.Version = version;
            this.Count = count;
            this.PreviousCount = previousCount;
        }
        
        /// <summary>
        /// version
        /// </summary>
        /// <value>version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// version count
        /// </summary>
        /// <value>version count</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// the count of previous time range of the version
        /// </summary>
        /// <value>the count of previous time range of the version</value>
        [DataMember(Name="previous_count", EmitDefaultValue=false)]
        public long? PreviousCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionsDiagnosticsVersions {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PreviousCount: ").Append(PreviousCount).Append("\n");
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
            return this.Equals(input as VersionsDiagnosticsVersions);
        }

        /// <summary>
        /// Returns true if VersionsDiagnosticsVersions instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionsDiagnosticsVersions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionsDiagnosticsVersions input)
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
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.PreviousCount == input.PreviousCount ||
                    (this.PreviousCount != null &&
                    this.PreviousCount.Equals(input.PreviousCount))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.PreviousCount != null)
                    hashCode = hashCode * 59 + this.PreviousCount.GetHashCode();
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
