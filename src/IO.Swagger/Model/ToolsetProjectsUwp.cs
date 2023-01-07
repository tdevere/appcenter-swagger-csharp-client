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
    /// ToolsetProjectsUwp
    /// </summary>
    [DataContract]
        public partial class ToolsetProjectsUwp :  IEquatable<ToolsetProjectsUwp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsetProjectsUwp" /> class.
        /// </summary>
        /// <param name="uwpSolutions">The UWP solutions detected (required).</param>
        public ToolsetProjectsUwp(List<UWPToolsetUwpSolutions> uwpSolutions = default(List<UWPToolsetUwpSolutions>))
        {
            // to ensure "uwpSolutions" is required (not null)
            if (uwpSolutions == null)
            {
                throw new InvalidDataException("uwpSolutions is a required property for ToolsetProjectsUwp and cannot be null");
            }
            else
            {
                this.UwpSolutions = uwpSolutions;
            }
        }
        
        /// <summary>
        /// The UWP solutions detected
        /// </summary>
        /// <value>The UWP solutions detected</value>
        [DataMember(Name="uwpSolutions", EmitDefaultValue=false)]
        public List<UWPToolsetUwpSolutions> UwpSolutions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToolsetProjectsUwp {\n");
            sb.Append("  UwpSolutions: ").Append(UwpSolutions).Append("\n");
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
            return this.Equals(input as ToolsetProjectsUwp);
        }

        /// <summary>
        /// Returns true if ToolsetProjectsUwp instances are equal
        /// </summary>
        /// <param name="input">Instance of ToolsetProjectsUwp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToolsetProjectsUwp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UwpSolutions == input.UwpSolutions ||
                    this.UwpSolutions != null &&
                    input.UwpSolutions != null &&
                    this.UwpSolutions.SequenceEqual(input.UwpSolutions)
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
                if (this.UwpSolutions != null)
                    hashCode = hashCode * 59 + this.UwpSolutions.GetHashCode();
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
