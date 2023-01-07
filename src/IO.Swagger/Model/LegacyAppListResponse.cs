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
    /// LegacyAppListResponse
    /// </summary>
    [DataContract]
        public partial class LegacyAppListResponse :  IEquatable<LegacyAppListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAppListResponse" /> class.
        /// </summary>
        /// <param name="apps">apps.</param>
        public LegacyAppListResponse(List<LegacyAppListResponseApps> apps = default(List<LegacyAppListResponseApps>))
        {
            this.Apps = apps;
        }
        
        /// <summary>
        /// Gets or Sets Apps
        /// </summary>
        [DataMember(Name="apps", EmitDefaultValue=false)]
        public List<LegacyAppListResponseApps> Apps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyAppListResponse {\n");
            sb.Append("  Apps: ").Append(Apps).Append("\n");
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
            return this.Equals(input as LegacyAppListResponse);
        }

        /// <summary>
        /// Returns true if LegacyAppListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyAppListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyAppListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Apps == input.Apps ||
                    this.Apps != null &&
                    input.Apps != null &&
                    this.Apps.SequenceEqual(input.Apps)
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
                if (this.Apps != null)
                    hashCode = hashCode * 59 + this.Apps.GetHashCode();
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
