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
    /// AppCrashesInfoFeatures
    /// </summary>
    [DataContract]
        public partial class AppCrashesInfoFeatures :  IEquatable<AppCrashesInfoFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCrashesInfoFeatures" /> class.
        /// </summary>
        /// <param name="crashgroupModifyStatus">App supports modification of crashgroup status.</param>
        /// <param name="crashgroupModifyAnnotation">App supports modification of crashgroup annotation.</param>
        /// <param name="search">App supports search API.</param>
        /// <param name="crashgroupAnalyticsCrashfreeusers">App supports the &#x27;crash free user&#x27; metric.</param>
        /// <param name="crashgroupAnalyticsImpactedusers">App supports the &#x27;impacted users&#x27; metric.</param>
        /// <param name="crashDownloadRaw">App supports download of raw crashes.</param>
        public AppCrashesInfoFeatures(bool? crashgroupModifyStatus = default(bool?), bool? crashgroupModifyAnnotation = default(bool?), bool? search = default(bool?), bool? crashgroupAnalyticsCrashfreeusers = default(bool?), bool? crashgroupAnalyticsImpactedusers = default(bool?), bool? crashDownloadRaw = default(bool?))
        {
            this.CrashgroupModifyStatus = crashgroupModifyStatus;
            this.CrashgroupModifyAnnotation = crashgroupModifyAnnotation;
            this.Search = search;
            this.CrashgroupAnalyticsCrashfreeusers = crashgroupAnalyticsCrashfreeusers;
            this.CrashgroupAnalyticsImpactedusers = crashgroupAnalyticsImpactedusers;
            this.CrashDownloadRaw = crashDownloadRaw;
        }
        
        /// <summary>
        /// App supports modification of crashgroup status
        /// </summary>
        /// <value>App supports modification of crashgroup status</value>
        [DataMember(Name="crashgroup_modify_status", EmitDefaultValue=false)]
        public bool? CrashgroupModifyStatus { get; set; }

        /// <summary>
        /// App supports modification of crashgroup annotation
        /// </summary>
        /// <value>App supports modification of crashgroup annotation</value>
        [DataMember(Name="crashgroup_modify_annotation", EmitDefaultValue=false)]
        public bool? CrashgroupModifyAnnotation { get; set; }

        /// <summary>
        /// App supports search API
        /// </summary>
        /// <value>App supports search API</value>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public bool? Search { get; set; }

        /// <summary>
        /// App supports the &#x27;crash free user&#x27; metric
        /// </summary>
        /// <value>App supports the &#x27;crash free user&#x27; metric</value>
        [DataMember(Name="crashgroup_analytics_crashfreeusers", EmitDefaultValue=false)]
        public bool? CrashgroupAnalyticsCrashfreeusers { get; set; }

        /// <summary>
        /// App supports the &#x27;impacted users&#x27; metric
        /// </summary>
        /// <value>App supports the &#x27;impacted users&#x27; metric</value>
        [DataMember(Name="crashgroup_analytics_impactedusers", EmitDefaultValue=false)]
        public bool? CrashgroupAnalyticsImpactedusers { get; set; }

        /// <summary>
        /// App supports download of raw crashes
        /// </summary>
        /// <value>App supports download of raw crashes</value>
        [DataMember(Name="crash_download_raw", EmitDefaultValue=false)]
        public bool? CrashDownloadRaw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCrashesInfoFeatures {\n");
            sb.Append("  CrashgroupModifyStatus: ").Append(CrashgroupModifyStatus).Append("\n");
            sb.Append("  CrashgroupModifyAnnotation: ").Append(CrashgroupModifyAnnotation).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  CrashgroupAnalyticsCrashfreeusers: ").Append(CrashgroupAnalyticsCrashfreeusers).Append("\n");
            sb.Append("  CrashgroupAnalyticsImpactedusers: ").Append(CrashgroupAnalyticsImpactedusers).Append("\n");
            sb.Append("  CrashDownloadRaw: ").Append(CrashDownloadRaw).Append("\n");
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
            return this.Equals(input as AppCrashesInfoFeatures);
        }

        /// <summary>
        /// Returns true if AppCrashesInfoFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of AppCrashesInfoFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppCrashesInfoFeatures input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrashgroupModifyStatus == input.CrashgroupModifyStatus ||
                    (this.CrashgroupModifyStatus != null &&
                    this.CrashgroupModifyStatus.Equals(input.CrashgroupModifyStatus))
                ) && 
                (
                    this.CrashgroupModifyAnnotation == input.CrashgroupModifyAnnotation ||
                    (this.CrashgroupModifyAnnotation != null &&
                    this.CrashgroupModifyAnnotation.Equals(input.CrashgroupModifyAnnotation))
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.CrashgroupAnalyticsCrashfreeusers == input.CrashgroupAnalyticsCrashfreeusers ||
                    (this.CrashgroupAnalyticsCrashfreeusers != null &&
                    this.CrashgroupAnalyticsCrashfreeusers.Equals(input.CrashgroupAnalyticsCrashfreeusers))
                ) && 
                (
                    this.CrashgroupAnalyticsImpactedusers == input.CrashgroupAnalyticsImpactedusers ||
                    (this.CrashgroupAnalyticsImpactedusers != null &&
                    this.CrashgroupAnalyticsImpactedusers.Equals(input.CrashgroupAnalyticsImpactedusers))
                ) && 
                (
                    this.CrashDownloadRaw == input.CrashDownloadRaw ||
                    (this.CrashDownloadRaw != null &&
                    this.CrashDownloadRaw.Equals(input.CrashDownloadRaw))
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
                if (this.CrashgroupModifyStatus != null)
                    hashCode = hashCode * 59 + this.CrashgroupModifyStatus.GetHashCode();
                if (this.CrashgroupModifyAnnotation != null)
                    hashCode = hashCode * 59 + this.CrashgroupModifyAnnotation.GetHashCode();
                if (this.Search != null)
                    hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.CrashgroupAnalyticsCrashfreeusers != null)
                    hashCode = hashCode * 59 + this.CrashgroupAnalyticsCrashfreeusers.GetHashCode();
                if (this.CrashgroupAnalyticsImpactedusers != null)
                    hashCode = hashCode * 59 + this.CrashgroupAnalyticsImpactedusers.GetHashCode();
                if (this.CrashDownloadRaw != null)
                    hashCode = hashCode * 59 + this.CrashDownloadRaw.GetHashCode();
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
