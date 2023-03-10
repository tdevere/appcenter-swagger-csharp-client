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
    /// InlineResponse20042
    /// </summary>
    [DataContract]
        public partial class InlineResponse20042 :  IEquatable<InlineResponse20042>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20042" /> class.
        /// </summary>
        /// <param name="hasMoreResults">hasMoreResults.</param>
        /// <param name="errors">errors.</param>
        public InlineResponse20042(bool? hasMoreResults = default(bool?), List<HandledErrorsErrors> errors = default(List<HandledErrorsErrors>))
        {
            this.HasMoreResults = hasMoreResults;
            this.Errors = errors;
        }
        
        /// <summary>
        /// Gets or Sets HasMoreResults
        /// </summary>
        [DataMember(Name="hasMoreResults", EmitDefaultValue=false)]
        public bool? HasMoreResults { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<HandledErrorsErrors> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20042 {\n");
            sb.Append("  HasMoreResults: ").Append(HasMoreResults).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as InlineResponse20042);
        }

        /// <summary>
        /// Returns true if InlineResponse20042 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20042 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20042 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasMoreResults == input.HasMoreResults ||
                    (this.HasMoreResults != null &&
                    this.HasMoreResults.Equals(input.HasMoreResults))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.HasMoreResults != null)
                    hashCode = hashCode * 59 + this.HasMoreResults.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
