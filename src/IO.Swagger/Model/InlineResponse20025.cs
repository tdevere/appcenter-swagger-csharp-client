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
    /// InlineResponse20025
    /// </summary>
    [DataContract]
        public partial class InlineResponse20025 :  IEquatable<InlineResponse20025>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20025" /> class.
        /// </summary>
        /// <param name="hashFilesUrl">hashFilesUrl.</param>
        public InlineResponse20025(string hashFilesUrl = default(string))
        {
            this.HashFilesUrl = hashFilesUrl;
        }
        
        /// <summary>
        /// Gets or Sets HashFilesUrl
        /// </summary>
        [DataMember(Name="hash_files_url", EmitDefaultValue=false)]
        public string HashFilesUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20025 {\n");
            sb.Append("  HashFilesUrl: ").Append(HashFilesUrl).Append("\n");
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
            return this.Equals(input as InlineResponse20025);
        }

        /// <summary>
        /// Returns true if InlineResponse20025 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20025 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20025 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HashFilesUrl == input.HashFilesUrl ||
                    (this.HashFilesUrl != null &&
                    this.HashFilesUrl.Equals(input.HashFilesUrl))
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
                if (this.HashFilesUrl != null)
                    hashCode = hashCode * 59 + this.HashFilesUrl.GetHashCode();
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
