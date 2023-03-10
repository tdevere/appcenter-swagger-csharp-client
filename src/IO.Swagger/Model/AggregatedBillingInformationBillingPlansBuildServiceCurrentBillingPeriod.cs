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
    /// Billing plans for a given period
    /// </summary>
    [DataContract]
        public partial class AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod :  IEquatable<AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod" /> class.
        /// </summary>
        /// <param name="startTime">Inclusive start of the period.</param>
        /// <param name="endTime">Exclusive end of the period..</param>
        /// <param name="byAccount">byAccount.</param>
        public AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod(string startTime = default(string), string endTime = default(string), AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriodByAccount byAccount = default(AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriodByAccount))
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ByAccount = byAccount;
        }
        
        /// <summary>
        /// Inclusive start of the period
        /// </summary>
        /// <value>Inclusive start of the period</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Exclusive end of the period.
        /// </summary>
        /// <value>Exclusive end of the period.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets ByAccount
        /// </summary>
        [DataMember(Name="byAccount", EmitDefaultValue=false)]
        public AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriodByAccount ByAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ByAccount: ").Append(ByAccount).Append("\n");
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
            return this.Equals(input as AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod);
        }

        /// <summary>
        /// Returns true if AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregatedBillingInformationBillingPlansBuildServiceCurrentBillingPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ByAccount == input.ByAccount ||
                    (this.ByAccount != null &&
                    this.ByAccount.Equals(input.ByAccount))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ByAccount != null)
                    hashCode = hashCode * 59 + this.ByAccount.GetHashCode();
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
