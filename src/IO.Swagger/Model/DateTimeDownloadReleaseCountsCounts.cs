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
    /// DateTimeDownloadReleaseCountsCounts
    /// </summary>
    [DataContract]
        public partial class DateTimeDownloadReleaseCountsCounts :  IEquatable<DateTimeDownloadReleaseCountsCounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeDownloadReleaseCountsCounts" /> class.
        /// </summary>
        /// <param name="datetime">The ISO 8601 datetime..</param>
        /// <param name="total">total.</param>
        /// <param name="unique">unique.</param>
        public DateTimeDownloadReleaseCountsCounts(string datetime = default(string), long? total = default(long?), long? unique = default(long?))
        {
            this.Datetime = datetime;
            this.Total = total;
            this.Unique = unique;
        }
        
        /// <summary>
        /// The ISO 8601 datetime.
        /// </summary>
        /// <value>The ISO 8601 datetime.</value>
        [DataMember(Name="datetime", EmitDefaultValue=false)]
        public string Datetime { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or Sets Unique
        /// </summary>
        [DataMember(Name="unique", EmitDefaultValue=false)]
        public long? Unique { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeDownloadReleaseCountsCounts {\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
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
            return this.Equals(input as DateTimeDownloadReleaseCountsCounts);
        }

        /// <summary>
        /// Returns true if DateTimeDownloadReleaseCountsCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of DateTimeDownloadReleaseCountsCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTimeDownloadReleaseCountsCounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datetime == input.Datetime ||
                    (this.Datetime != null &&
                    this.Datetime.Equals(input.Datetime))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Unique == input.Unique ||
                    (this.Unique != null &&
                    this.Unique.Equals(input.Unique))
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
                if (this.Datetime != null)
                    hashCode = hashCode * 59 + this.Datetime.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Unique != null)
                    hashCode = hashCode * 59 + this.Unique.GetHashCode();
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
