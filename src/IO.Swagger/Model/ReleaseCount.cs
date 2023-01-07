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
    /// ReleaseCount
    /// </summary>
    [DataContract]
        public partial class ReleaseCount :  IEquatable<ReleaseCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCount" /> class.
        /// </summary>
        /// <param name="releaseId">releaseId (required).</param>
        /// <param name="distributionGroup">Distribution group queried. .</param>
        /// <param name="uniqueCount">Count of unique downloads against user id.  (required).</param>
        /// <param name="totalCount">Total count of downloads.  (required).</param>
        public ReleaseCount(string releaseId = default(string), string distributionGroup = default(string), long? uniqueCount = default(long?), long? totalCount = default(long?))
        {
            // to ensure "releaseId" is required (not null)
            if (releaseId == null)
            {
                throw new InvalidDataException("releaseId is a required property for ReleaseCount and cannot be null");
            }
            else
            {
                this.ReleaseId = releaseId;
            }
            // to ensure "uniqueCount" is required (not null)
            if (uniqueCount == null)
            {
                throw new InvalidDataException("uniqueCount is a required property for ReleaseCount and cannot be null");
            }
            else
            {
                this.UniqueCount = uniqueCount;
            }
            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for ReleaseCount and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }
            this.DistributionGroup = distributionGroup;
        }
        
        /// <summary>
        /// Gets or Sets ReleaseId
        /// </summary>
        [DataMember(Name="release_id", EmitDefaultValue=false)]
        public string ReleaseId { get; set; }

        /// <summary>
        /// Distribution group queried. 
        /// </summary>
        /// <value>Distribution group queried. </value>
        [DataMember(Name="distribution_group", EmitDefaultValue=false)]
        public string DistributionGroup { get; set; }

        /// <summary>
        /// Count of unique downloads against user id. 
        /// </summary>
        /// <value>Count of unique downloads against user id. </value>
        [DataMember(Name="unique_count", EmitDefaultValue=false)]
        public long? UniqueCount { get; set; }

        /// <summary>
        /// Total count of downloads. 
        /// </summary>
        /// <value>Total count of downloads. </value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseCount {\n");
            sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  DistributionGroup: ").Append(DistributionGroup).Append("\n");
            sb.Append("  UniqueCount: ").Append(UniqueCount).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as ReleaseCount);
        }

        /// <summary>
        /// Returns true if ReleaseCount instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
                ) && 
                (
                    this.DistributionGroup == input.DistributionGroup ||
                    (this.DistributionGroup != null &&
                    this.DistributionGroup.Equals(input.DistributionGroup))
                ) && 
                (
                    this.UniqueCount == input.UniqueCount ||
                    (this.UniqueCount != null &&
                    this.UniqueCount.Equals(input.UniqueCount))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.DistributionGroup != null)
                    hashCode = hashCode * 59 + this.DistributionGroup.GetHashCode();
                if (this.UniqueCount != null)
                    hashCode = hashCode * 59 + this.UniqueCount.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
