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
    /// Audience test result.
    /// </summary>
    [DataContract]
        public partial class AudienceTestResult :  IEquatable<AudienceTestResult>, IValidatableObject
    {
        /// <summary>
        /// Defines Inner
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum InnerEnum
        {
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 1,
            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 2,
            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 3,
            /// <summary>
            /// Enum Datetime for value: date_time
            /// </summary>
            [EnumMember(Value = "date_time")]
            Datetime = 4        }
        /// <summary>
        /// Custom properties used in the definition.
        /// </summary>
        /// <value>Custom properties used in the definition.</value>
        [DataMember(Name="custom_properties", EmitDefaultValue=false)]
        public Dictionary<string, InnerEnum> CustomProperties { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AudienceTestResult" /> class.
        /// </summary>
        /// <param name="definition">Audience definition in OData format..</param>
        /// <param name="customProperties">Custom properties used in the definition..</param>
        /// <param name="estimatedCount">Estimated audience size..</param>
        /// <param name="estimatedTotalCount">Estimated total audience size..</param>
        public AudienceTestResult(string definition = default(string), Dictionary<string, InnerEnum> customProperties = default(Dictionary<string, InnerEnum>), long? estimatedCount = default(long?), long? estimatedTotalCount = default(long?))
        {
            this.Definition = definition;
            this.CustomProperties = customProperties;
            this.EstimatedCount = estimatedCount;
            this.EstimatedTotalCount = estimatedTotalCount;
        }
        
        /// <summary>
        /// Audience definition in OData format.
        /// </summary>
        /// <value>Audience definition in OData format.</value>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public string Definition { get; set; }


        /// <summary>
        /// Estimated audience size.
        /// </summary>
        /// <value>Estimated audience size.</value>
        [DataMember(Name="estimated_count", EmitDefaultValue=false)]
        public long? EstimatedCount { get; set; }

        /// <summary>
        /// Estimated total audience size.
        /// </summary>
        /// <value>Estimated total audience size.</value>
        [DataMember(Name="estimated_total_count", EmitDefaultValue=false)]
        public long? EstimatedTotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudienceTestResult {\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
            sb.Append("  EstimatedCount: ").Append(EstimatedCount).Append("\n");
            sb.Append("  EstimatedTotalCount: ").Append(EstimatedTotalCount).Append("\n");
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
            return this.Equals(input as AudienceTestResult);
        }

        /// <summary>
        /// Returns true if AudienceTestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AudienceTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudienceTestResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
                ) && 
                (
                    this.CustomProperties == input.CustomProperties ||
                    this.CustomProperties != null &&
                    input.CustomProperties != null &&
                    this.CustomProperties.SequenceEqual(input.CustomProperties)
                ) && 
                (
                    this.EstimatedCount == input.EstimatedCount ||
                    (this.EstimatedCount != null &&
                    this.EstimatedCount.Equals(input.EstimatedCount))
                ) && 
                (
                    this.EstimatedTotalCount == input.EstimatedTotalCount ||
                    (this.EstimatedTotalCount != null &&
                    this.EstimatedTotalCount.Equals(input.EstimatedTotalCount))
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
                if (this.Definition != null)
                    hashCode = hashCode * 59 + this.Definition.GetHashCode();
                if (this.CustomProperties != null)
                    hashCode = hashCode * 59 + this.CustomProperties.GetHashCode();
                if (this.EstimatedCount != null)
                    hashCode = hashCode * 59 + this.EstimatedCount.GetHashCode();
                if (this.EstimatedTotalCount != null)
                    hashCode = hashCode * 59 + this.EstimatedTotalCount.GetHashCode();
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
