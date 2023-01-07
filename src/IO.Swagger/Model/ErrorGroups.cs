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
    /// ErrorGroups
    /// </summary>
    [DataContract]
        public partial class ErrorGroups :  IEquatable<ErrorGroups>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorGroups" /> class.
        /// </summary>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="errorGroups">errorGroups.</param>
        public ErrorGroups(string nextLink = default(string), List<AllOfErrorGroupsErrorGroupsItems> errorGroups = default(List<AllOfErrorGroupsErrorGroupsItems>))
        {
            this.NextLink = nextLink;
            this._ErrorGroups = errorGroups;
        }
        
        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name="nextLink", EmitDefaultValue=false)]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or Sets _ErrorGroups
        /// </summary>
        [DataMember(Name="errorGroups", EmitDefaultValue=false)]
        public List<AllOfErrorGroupsErrorGroupsItems> _ErrorGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorGroups {\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
            sb.Append("  _ErrorGroups: ").Append(_ErrorGroups).Append("\n");
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
            return this.Equals(input as ErrorGroups);
        }

        /// <summary>
        /// Returns true if ErrorGroups instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorGroups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextLink == input.NextLink ||
                    (this.NextLink != null &&
                    this.NextLink.Equals(input.NextLink))
                ) && 
                (
                    this._ErrorGroups == input._ErrorGroups ||
                    this._ErrorGroups != null &&
                    input._ErrorGroups != null &&
                    this._ErrorGroups.SequenceEqual(input._ErrorGroups)
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
                if (this.NextLink != null)
                    hashCode = hashCode * 59 + this.NextLink.GetHashCode();
                if (this._ErrorGroups != null)
                    hashCode = hashCode * 59 + this._ErrorGroups.GetHashCode();
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
