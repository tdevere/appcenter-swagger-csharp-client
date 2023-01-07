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
    /// InlineResponse20046
    /// </summary>
    [DataContract]
        public partial class InlineResponse20046 :  IEquatable<InlineResponse20046>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20046" /> class.
        /// </summary>
        /// <param name="errorCount">errorCount.</param>
        /// <param name="models">models.</param>
        public InlineResponse20046(long? errorCount = default(long?), List<ErrorGroupModelsModels> models = default(List<ErrorGroupModelsModels>))
        {
            this.ErrorCount = errorCount;
            this.Models = models;
        }
        
        /// <summary>
        /// Gets or Sets ErrorCount
        /// </summary>
        [DataMember(Name="errorCount", EmitDefaultValue=false)]
        public long? ErrorCount { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name="models", EmitDefaultValue=false)]
        public List<ErrorGroupModelsModels> Models { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20046 {\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
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
            return this.Equals(input as InlineResponse20046);
        }

        /// <summary>
        /// Returns true if InlineResponse20046 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20046 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20046 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCount == input.ErrorCount ||
                    (this.ErrorCount != null &&
                    this.ErrorCount.Equals(input.ErrorCount))
                ) && 
                (
                    this.Models == input.Models ||
                    this.Models != null &&
                    input.Models != null &&
                    this.Models.SequenceEqual(input.Models)
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
                if (this.ErrorCount != null)
                    hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.Models != null)
                    hashCode = hashCode * 59 + this.Models.GetHashCode();
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