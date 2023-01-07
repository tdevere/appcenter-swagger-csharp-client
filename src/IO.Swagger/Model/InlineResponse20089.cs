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
    /// InlineResponse20089
    /// </summary>
    [DataContract]
        public partial class InlineResponse20089 :  IEquatable<InlineResponse20089>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20089" /> class.
        /// </summary>
        /// <param name="avgCountPerDevice">avgCountPerDevice.</param>
        /// <param name="previousAvgCountPerDevice">previousAvgCountPerDevice.</param>
        /// <param name="countPerDevice">countPerDevice.</param>
        public InlineResponse20089(double? avgCountPerDevice = default(double?), double? previousAvgCountPerDevice = default(double?), List<EventCountPerDeviceCountPerDevice> countPerDevice = default(List<EventCountPerDeviceCountPerDevice>))
        {
            this.AvgCountPerDevice = avgCountPerDevice;
            this.PreviousAvgCountPerDevice = previousAvgCountPerDevice;
            this.CountPerDevice = countPerDevice;
        }
        
        /// <summary>
        /// Gets or Sets AvgCountPerDevice
        /// </summary>
        [DataMember(Name="avg_count_per_device", EmitDefaultValue=false)]
        public double? AvgCountPerDevice { get; set; }

        /// <summary>
        /// Gets or Sets PreviousAvgCountPerDevice
        /// </summary>
        [DataMember(Name="previous_avg_count_per_device", EmitDefaultValue=false)]
        public double? PreviousAvgCountPerDevice { get; set; }

        /// <summary>
        /// Gets or Sets CountPerDevice
        /// </summary>
        [DataMember(Name="count_per_device", EmitDefaultValue=false)]
        public List<EventCountPerDeviceCountPerDevice> CountPerDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20089 {\n");
            sb.Append("  AvgCountPerDevice: ").Append(AvgCountPerDevice).Append("\n");
            sb.Append("  PreviousAvgCountPerDevice: ").Append(PreviousAvgCountPerDevice).Append("\n");
            sb.Append("  CountPerDevice: ").Append(CountPerDevice).Append("\n");
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
            return this.Equals(input as InlineResponse20089);
        }

        /// <summary>
        /// Returns true if InlineResponse20089 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20089 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20089 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvgCountPerDevice == input.AvgCountPerDevice ||
                    (this.AvgCountPerDevice != null &&
                    this.AvgCountPerDevice.Equals(input.AvgCountPerDevice))
                ) && 
                (
                    this.PreviousAvgCountPerDevice == input.PreviousAvgCountPerDevice ||
                    (this.PreviousAvgCountPerDevice != null &&
                    this.PreviousAvgCountPerDevice.Equals(input.PreviousAvgCountPerDevice))
                ) && 
                (
                    this.CountPerDevice == input.CountPerDevice ||
                    this.CountPerDevice != null &&
                    input.CountPerDevice != null &&
                    this.CountPerDevice.SequenceEqual(input.CountPerDevice)
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
                if (this.AvgCountPerDevice != null)
                    hashCode = hashCode * 59 + this.AvgCountPerDevice.GetHashCode();
                if (this.PreviousAvgCountPerDevice != null)
                    hashCode = hashCode * 59 + this.PreviousAvgCountPerDevice.GetHashCode();
                if (this.CountPerDevice != null)
                    hashCode = hashCode * 59 + this.CountPerDevice.GetHashCode();
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