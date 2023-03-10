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
    /// InlineResponse20077
    /// </summary>
    [DataContract]
        public partial class InlineResponse20077 :  IEquatable<InlineResponse20077>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20077" /> class.
        /// </summary>
        /// <param name="distribution">The count of sessions in these buckets..</param>
        /// <param name="previousAverageDuration">The previous average session duration for previous time range..</param>
        /// <param name="averageDuration">The average session duration for current time range..</param>
        public InlineResponse20077(List<SessionDurationsDistributionDistribution> distribution = default(List<SessionDurationsDistributionDistribution>), string previousAverageDuration = default(string), string averageDuration = default(string))
        {
            this.Distribution = distribution;
            this.PreviousAverageDuration = previousAverageDuration;
            this.AverageDuration = averageDuration;
        }
        
        /// <summary>
        /// The count of sessions in these buckets.
        /// </summary>
        /// <value>The count of sessions in these buckets.</value>
        [DataMember(Name="distribution", EmitDefaultValue=false)]
        public List<SessionDurationsDistributionDistribution> Distribution { get; set; }

        /// <summary>
        /// The previous average session duration for previous time range.
        /// </summary>
        /// <value>The previous average session duration for previous time range.</value>
        [DataMember(Name="previous_average_duration", EmitDefaultValue=false)]
        public string PreviousAverageDuration { get; set; }

        /// <summary>
        /// The average session duration for current time range.
        /// </summary>
        /// <value>The average session duration for current time range.</value>
        [DataMember(Name="average_duration", EmitDefaultValue=false)]
        public string AverageDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20077 {\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
            sb.Append("  PreviousAverageDuration: ").Append(PreviousAverageDuration).Append("\n");
            sb.Append("  AverageDuration: ").Append(AverageDuration).Append("\n");
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
            return this.Equals(input as InlineResponse20077);
        }

        /// <summary>
        /// Returns true if InlineResponse20077 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20077 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20077 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Distribution == input.Distribution ||
                    this.Distribution != null &&
                    input.Distribution != null &&
                    this.Distribution.SequenceEqual(input.Distribution)
                ) && 
                (
                    this.PreviousAverageDuration == input.PreviousAverageDuration ||
                    (this.PreviousAverageDuration != null &&
                    this.PreviousAverageDuration.Equals(input.PreviousAverageDuration))
                ) && 
                (
                    this.AverageDuration == input.AverageDuration ||
                    (this.AverageDuration != null &&
                    this.AverageDuration.Equals(input.AverageDuration))
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
                if (this.Distribution != null)
                    hashCode = hashCode * 59 + this.Distribution.GetHashCode();
                if (this.PreviousAverageDuration != null)
                    hashCode = hashCode * 59 + this.PreviousAverageDuration.GetHashCode();
                if (this.AverageDuration != null)
                    hashCode = hashCode * 59 + this.AverageDuration.GetHashCode();
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
