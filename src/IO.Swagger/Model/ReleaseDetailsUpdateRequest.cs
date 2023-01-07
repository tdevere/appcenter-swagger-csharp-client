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
    /// A request containing information for updating details of a release
    /// </summary>
    [DataContract]
        public partial class ReleaseDetailsUpdateRequest :  IEquatable<ReleaseDetailsUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseDetailsUpdateRequest" /> class.
        /// </summary>
        /// <param name="enabled">Toggle this release to be enable distribute/download or not..</param>
        /// <param name="releaseNotes">Release notes for this release..</param>
        /// <param name="build">build.</param>
        public ReleaseDetailsUpdateRequest(bool? enabled = default(bool?), string releaseNotes = default(string), V01appsownerNameappNamereleasesreleaseIdBuild build = default(V01appsownerNameappNamereleasesreleaseIdBuild))
        {
            this.Enabled = enabled;
            this.ReleaseNotes = releaseNotes;
            this.Build = build;
        }
        
        /// <summary>
        /// Toggle this release to be enable distribute/download or not.
        /// </summary>
        /// <value>Toggle this release to be enable distribute/download or not.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Release notes for this release.
        /// </summary>
        /// <value>Release notes for this release.</value>
        [DataMember(Name="release_notes", EmitDefaultValue=false)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public V01appsownerNameappNamereleasesreleaseIdBuild Build { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseDetailsUpdateRequest {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ReleaseNotes: ").Append(ReleaseNotes).Append("\n");
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
            return this.Equals(input as ReleaseDetailsUpdateRequest);
        }

        /// <summary>
        /// Returns true if ReleaseDetailsUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseDetailsUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseDetailsUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ReleaseNotes == input.ReleaseNotes ||
                    (this.ReleaseNotes != null &&
                    this.ReleaseNotes.Equals(input.ReleaseNotes))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ReleaseNotes != null)
                    hashCode = hashCode * 59 + this.ReleaseNotes.GetHashCode();
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
