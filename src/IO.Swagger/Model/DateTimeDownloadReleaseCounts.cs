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
    /// DateTimeDownloadReleaseCounts
    /// </summary>
    [DataContract]
        public partial class DateTimeDownloadReleaseCounts :  IEquatable<DateTimeDownloadReleaseCounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeDownloadReleaseCounts" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="unique">unique.</param>
        /// <param name="counts">Release counts per day..</param>
        public DateTimeDownloadReleaseCounts(long? total = default(long?), long? unique = default(long?), List<DateTimeDownloadReleaseCountsCounts> counts = default(List<DateTimeDownloadReleaseCountsCounts>))
        {
            this.Total = total;
            this.Unique = unique;
            this.Counts = counts;
        }
        
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
        /// Release counts per day.
        /// </summary>
        /// <value>Release counts per day.</value>
        [DataMember(Name="counts", EmitDefaultValue=false)]
        public List<DateTimeDownloadReleaseCountsCounts> Counts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeDownloadReleaseCounts {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
            sb.Append("  Counts: ").Append(Counts).Append("\n");
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
            return this.Equals(input as DateTimeDownloadReleaseCounts);
        }

        /// <summary>
        /// Returns true if DateTimeDownloadReleaseCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of DateTimeDownloadReleaseCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTimeDownloadReleaseCounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Unique == input.Unique ||
                    (this.Unique != null &&
                    this.Unique.Equals(input.Unique))
                ) && 
                (
                    this.Counts == input.Counts ||
                    this.Counts != null &&
                    input.Counts != null &&
                    this.Counts.SequenceEqual(input.Counts)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Unique != null)
                    hashCode = hashCode * 59 + this.Unique.GetHashCode();
                if (this.Counts != null)
                    hashCode = hashCode * 59 + this.Counts.GetHashCode();
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
