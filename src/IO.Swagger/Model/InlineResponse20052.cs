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
    /// InlineResponse20052
    /// </summary>
    [DataContract]
        public partial class InlineResponse20052 :  IEquatable<InlineResponse20052>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20052" /> class.
        /// </summary>
        /// <param name="hasMoreResults">hasMoreResults.</param>
        /// <param name="errorGroups">errorGroups.</param>
        public InlineResponse20052(bool? hasMoreResults = default(bool?), List<AllOfinlineResponse20052ErrorGroupsItems> errorGroups = default(List<AllOfinlineResponse20052ErrorGroupsItems>))
        {
            this.HasMoreResults = hasMoreResults;
            this.ErrorGroups = errorGroups;
        }
        
        /// <summary>
        /// Gets or Sets HasMoreResults
        /// </summary>
        [DataMember(Name="hasMoreResults", EmitDefaultValue=false)]
        public bool? HasMoreResults { get; set; }

        /// <summary>
        /// Gets or Sets ErrorGroups
        /// </summary>
        [DataMember(Name="errorGroups", EmitDefaultValue=false)]
        public List<AllOfinlineResponse20052ErrorGroupsItems> ErrorGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20052 {\n");
            sb.Append("  HasMoreResults: ").Append(HasMoreResults).Append("\n");
            sb.Append("  ErrorGroups: ").Append(ErrorGroups).Append("\n");
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
            return this.Equals(input as InlineResponse20052);
        }

        /// <summary>
        /// Returns true if InlineResponse20052 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20052 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20052 input)
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
                    this.ErrorGroups == input.ErrorGroups ||
                    this.ErrorGroups != null &&
                    input.ErrorGroups != null &&
                    this.ErrorGroups.SequenceEqual(input.ErrorGroups)
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
                if (this.ErrorGroups != null)
                    hashCode = hashCode * 59 + this.ErrorGroups.GetHashCode();
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
