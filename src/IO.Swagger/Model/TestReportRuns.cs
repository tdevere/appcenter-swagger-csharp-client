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
    /// TestReportRuns
    /// </summary>
    [DataContract]
        public partial class TestReportRuns :  IEquatable<TestReportRuns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestReportRuns" /> class.
        /// </summary>
        /// <param name="number">number.</param>
        /// <param name="steps">steps.</param>
        /// <param name="failed">failed.</param>
        /// <param name="skipped">skipped.</param>
        /// <param name="reportUrl">reportUrl.</param>
        /// <param name="id">id.</param>
        public TestReportRuns(decimal? number = default(decimal?), List<TestReportSteps> steps = default(List<TestReportSteps>), decimal? failed = default(decimal?), decimal? skipped = default(decimal?), string reportUrl = default(string), string id = default(string))
        {
            this.Number = number;
            this.Steps = steps;
            this.Failed = failed;
            this.Skipped = skipped;
            this.ReportUrl = reportUrl;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public decimal? Number { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<TestReportSteps> Steps { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public decimal? Failed { get; set; }

        /// <summary>
        /// Gets or Sets Skipped
        /// </summary>
        [DataMember(Name="skipped", EmitDefaultValue=false)]
        public decimal? Skipped { get; set; }

        /// <summary>
        /// Gets or Sets ReportUrl
        /// </summary>
        [DataMember(Name="report_url", EmitDefaultValue=false)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestReportRuns {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
            sb.Append("  ReportUrl: ").Append(ReportUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as TestReportRuns);
        }

        /// <summary>
        /// Returns true if TestReportRuns instances are equal
        /// </summary>
        /// <param name="input">Instance of TestReportRuns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestReportRuns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Skipped == input.Skipped ||
                    (this.Skipped != null &&
                    this.Skipped.Equals(input.Skipped))
                ) && 
                (
                    this.ReportUrl == input.ReportUrl ||
                    (this.ReportUrl != null &&
                    this.ReportUrl.Equals(input.ReportUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Skipped != null)
                    hashCode = hashCode * 59 + this.Skipped.GetHashCode();
                if (this.ReportUrl != null)
                    hashCode = hashCode * 59 + this.ReportUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
