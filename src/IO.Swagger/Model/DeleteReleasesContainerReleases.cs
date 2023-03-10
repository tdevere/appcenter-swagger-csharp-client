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
    /// DeleteReleasesContainerReleases
    /// </summary>
    [DataContract]
        public partial class DeleteReleasesContainerReleases :  IEquatable<DeleteReleasesContainerReleases>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteReleasesContainerReleases" /> class.
        /// </summary>
        /// <param name="release">Release Id.  (required).</param>
        public DeleteReleasesContainerReleases(string release = default(string))
        {
            // to ensure "release" is required (not null)
            if (release == null)
            {
                throw new InvalidDataException("release is a required property for DeleteReleasesContainerReleases and cannot be null");
            }
            else
            {
                this.Release = release;
            }
        }
        
        /// <summary>
        /// Release Id. 
        /// </summary>
        /// <value>Release Id. </value>
        [DataMember(Name="release", EmitDefaultValue=false)]
        public string Release { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteReleasesContainerReleases {\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
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
            return this.Equals(input as DeleteReleasesContainerReleases);
        }

        /// <summary>
        /// Returns true if DeleteReleasesContainerReleases instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteReleasesContainerReleases to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteReleasesContainerReleases input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Release == input.Release ||
                    (this.Release != null &&
                    this.Release.Equals(input.Release))
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
                if (this.Release != null)
                    hashCode = hashCode * 59 + this.Release.GetHashCode();
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
