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
    /// Most important information about a test run.
    /// </summary>
    [DataContract]
        public partial class TestRunSummary :  IEquatable<TestRunSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunSummary" /> class.
        /// </summary>
        /// <param name="date">Date of the test run..</param>
        /// <param name="statusDescription">Human-readable status of the test run..</param>
        /// <param name="failed">Number of failed tests.</param>
        /// <param name="passed">Number of passed tests.</param>
        /// <param name="completed">Tells whether the test run has completed.</param>
        public TestRunSummary(string date = default(string), string statusDescription = default(string), decimal? failed = default(decimal?), decimal? passed = default(decimal?), bool? completed = default(bool?))
        {
            this.Date = date;
            this.StatusDescription = statusDescription;
            this.Failed = failed;
            this.Passed = passed;
            this.Completed = completed;
        }
        
        /// <summary>
        /// Date of the test run.
        /// </summary>
        /// <value>Date of the test run.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Human-readable status of the test run.
        /// </summary>
        /// <value>Human-readable status of the test run.</value>
        [DataMember(Name="statusDescription", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Number of failed tests
        /// </summary>
        /// <value>Number of failed tests</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public decimal? Failed { get; set; }

        /// <summary>
        /// Number of passed tests
        /// </summary>
        /// <value>Number of passed tests</value>
        [DataMember(Name="passed", EmitDefaultValue=false)]
        public decimal? Passed { get; set; }

        /// <summary>
        /// Tells whether the test run has completed
        /// </summary>
        /// <value>Tells whether the test run has completed</value>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestRunSummary {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Passed: ").Append(Passed).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
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
            return this.Equals(input as TestRunSummary);
        }

        /// <summary>
        /// Returns true if TestRunSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Failed == input.Failed ||
                    (this.Failed != null &&
                    this.Failed.Equals(input.Failed))
                ) && 
                (
                    this.Passed == input.Passed ||
                    (this.Passed != null &&
                    this.Passed.Equals(input.Passed))
                ) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Passed != null)
                    hashCode = hashCode * 59 + this.Passed.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
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