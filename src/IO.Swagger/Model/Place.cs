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
    /// The place code and the count.
    /// </summary>
    [DataContract]
        public partial class Place :  IEquatable<Place>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Place" /> class.
        /// </summary>
        /// <param name="code">The place code..</param>
        /// <param name="count">The count of the this place..</param>
        /// <param name="previousCount">The count of previous time range of the place..</param>
        public Place(string code = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            this.Code = code;
            this.Count = count;
            this.PreviousCount = previousCount;
        }
        
        /// <summary>
        /// The place code.
        /// </summary>
        /// <value>The place code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The count of the this place.
        /// </summary>
        /// <value>The count of the this place.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The count of previous time range of the place.
        /// </summary>
        /// <value>The count of previous time range of the place.</value>
        [DataMember(Name="previous_count", EmitDefaultValue=false)]
        public long? PreviousCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Place {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PreviousCount: ").Append(PreviousCount).Append("\n");
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
            return this.Equals(input as Place);
        }

        /// <summary>
        /// Returns true if Place instances are equal
        /// </summary>
        /// <param name="input">Instance of Place to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Place input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.PreviousCount == input.PreviousCount ||
                    (this.PreviousCount != null &&
                    this.PreviousCount.Equals(input.PreviousCount))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.PreviousCount != null)
                    hashCode = hashCode * 59 + this.PreviousCount.GetHashCode();
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