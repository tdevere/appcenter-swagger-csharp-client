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
    /// InlineResponse20044
    /// </summary>
    [DataContract]
        public partial class InlineResponse20044 :  IEquatable<InlineResponse20044>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20044" /> class.
        /// </summary>
        /// <param name="averagePercentage">Average percentage.</param>
        /// <param name="dailyPercentages">The error-free percentage per day..</param>
        public InlineResponse20044(double? averagePercentage = default(double?), List<ErrorFreeDevicePercentagesDailyPercentages> dailyPercentages = default(List<ErrorFreeDevicePercentagesDailyPercentages>))
        {
            this.AveragePercentage = averagePercentage;
            this.DailyPercentages = dailyPercentages;
        }
        
        /// <summary>
        /// Average percentage
        /// </summary>
        /// <value>Average percentage</value>
        [DataMember(Name="averagePercentage", EmitDefaultValue=false)]
        public double? AveragePercentage { get; set; }

        /// <summary>
        /// The error-free percentage per day.
        /// </summary>
        /// <value>The error-free percentage per day.</value>
        [DataMember(Name="dailyPercentages", EmitDefaultValue=false)]
        public List<ErrorFreeDevicePercentagesDailyPercentages> DailyPercentages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20044 {\n");
            sb.Append("  AveragePercentage: ").Append(AveragePercentage).Append("\n");
            sb.Append("  DailyPercentages: ").Append(DailyPercentages).Append("\n");
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
            return this.Equals(input as InlineResponse20044);
        }

        /// <summary>
        /// Returns true if InlineResponse20044 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20044 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20044 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AveragePercentage == input.AveragePercentage ||
                    (this.AveragePercentage != null &&
                    this.AveragePercentage.Equals(input.AveragePercentage))
                ) && 
                (
                    this.DailyPercentages == input.DailyPercentages ||
                    this.DailyPercentages != null &&
                    input.DailyPercentages != null &&
                    this.DailyPercentages.SequenceEqual(input.DailyPercentages)
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
                if (this.AveragePercentage != null)
                    hashCode = hashCode * 59 + this.AveragePercentage.GetHashCode();
                if (this.DailyPercentages != null)
                    hashCode = hashCode * 59 + this.DailyPercentages.GetHashCode();
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
