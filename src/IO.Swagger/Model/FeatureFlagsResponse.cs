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
    /// FeatureFlagsResponse
    /// </summary>
    [DataContract]
        public partial class FeatureFlagsResponse :  IEquatable<FeatureFlagsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlagsResponse" /> class.
        /// </summary>
        /// <param name="featureFlags">featureFlags (required).</param>
        public FeatureFlagsResponse(List<string> featureFlags = default(List<string>))
        {
            // to ensure "featureFlags" is required (not null)
            if (featureFlags == null)
            {
                throw new InvalidDataException("featureFlags is a required property for FeatureFlagsResponse and cannot be null");
            }
            else
            {
                this.FeatureFlags = featureFlags;
            }
        }
        
        /// <summary>
        /// Gets or Sets FeatureFlags
        /// </summary>
        [DataMember(Name="feature_flags", EmitDefaultValue=false)]
        public List<string> FeatureFlags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureFlagsResponse {\n");
            sb.Append("  FeatureFlags: ").Append(FeatureFlags).Append("\n");
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
            return this.Equals(input as FeatureFlagsResponse);
        }

        /// <summary>
        /// Returns true if FeatureFlagsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureFlagsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureFlagsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureFlags == input.FeatureFlags ||
                    this.FeatureFlags != null &&
                    input.FeatureFlags != null &&
                    this.FeatureFlags.SequenceEqual(input.FeatureFlags)
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
                if (this.FeatureFlags != null)
                    hashCode = hashCode * 59 + this.FeatureFlags.GetHashCode();
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
