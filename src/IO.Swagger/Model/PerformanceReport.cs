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
    /// Report data for a single test (a.k.a. scenario)
    /// </summary>
    [DataContract]
        public partial class PerformanceReport :  IEquatable<PerformanceReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReport" /> class.
        /// </summary>
        /// <param name="deviceSnapshotId">deviceSnapshotId.</param>
        /// <param name="performanceData">performanceData.</param>
        /// <param name="video">video.</param>
        public PerformanceReport(string deviceSnapshotId = default(string), PerformanceReportPerformanceData performanceData = default(PerformanceReportPerformanceData), PerformanceReportVideo video = default(PerformanceReportVideo))
        {
            this.DeviceSnapshotId = deviceSnapshotId;
            this.PerformanceData = performanceData;
            this.Video = video;
        }
        
        /// <summary>
        /// Gets or Sets DeviceSnapshotId
        /// </summary>
        [DataMember(Name="device_snapshot_id", EmitDefaultValue=false)]
        public string DeviceSnapshotId { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceData
        /// </summary>
        [DataMember(Name="performance_data", EmitDefaultValue=false)]
        public PerformanceReportPerformanceData PerformanceData { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public PerformanceReportVideo Video { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceReport {\n");
            sb.Append("  DeviceSnapshotId: ").Append(DeviceSnapshotId).Append("\n");
            sb.Append("  PerformanceData: ").Append(PerformanceData).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
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
            return this.Equals(input as PerformanceReport);
        }

        /// <summary>
        /// Returns true if PerformanceReport instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceSnapshotId == input.DeviceSnapshotId ||
                    (this.DeviceSnapshotId != null &&
                    this.DeviceSnapshotId.Equals(input.DeviceSnapshotId))
                ) && 
                (
                    this.PerformanceData == input.PerformanceData ||
                    (this.PerformanceData != null &&
                    this.PerformanceData.Equals(input.PerformanceData))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
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
                if (this.DeviceSnapshotId != null)
                    hashCode = hashCode * 59 + this.DeviceSnapshotId.GetHashCode();
                if (this.PerformanceData != null)
                    hashCode = hashCode * 59 + this.PerformanceData.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
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
