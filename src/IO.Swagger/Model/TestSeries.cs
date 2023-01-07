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
    /// Summary of a single test series
    /// </summary>
    [DataContract]
        public partial class TestSeries :  IEquatable<TestSeries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestSeries" /> class.
        /// </summary>
        /// <param name="slug">Unique, human-readable identifier of the test series (required).</param>
        /// <param name="name">Name of the test series (required).</param>
        /// <param name="mostRecentActivity">Date of the latest test run that used this test series.</param>
        /// <param name="testRuns">Most recent test runs.</param>
        public TestSeries(string slug = default(string), string name = default(string), string mostRecentActivity = default(string), List<TestRunSummary> testRuns = default(List<TestRunSummary>))
        {
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for TestSeries and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TestSeries and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.MostRecentActivity = mostRecentActivity;
            this.TestRuns = testRuns;
        }
        
        /// <summary>
        /// Unique, human-readable identifier of the test series
        /// </summary>
        /// <value>Unique, human-readable identifier of the test series</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }

        /// <summary>
        /// Name of the test series
        /// </summary>
        /// <value>Name of the test series</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Date of the latest test run that used this test series
        /// </summary>
        /// <value>Date of the latest test run that used this test series</value>
        [DataMember(Name="mostRecentActivity", EmitDefaultValue=false)]
        public string MostRecentActivity { get; set; }

        /// <summary>
        /// Most recent test runs
        /// </summary>
        /// <value>Most recent test runs</value>
        [DataMember(Name="testRuns", EmitDefaultValue=false)]
        public List<TestRunSummary> TestRuns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestSeries {\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MostRecentActivity: ").Append(MostRecentActivity).Append("\n");
            sb.Append("  TestRuns: ").Append(TestRuns).Append("\n");
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
            return this.Equals(input as TestSeries);
        }

        /// <summary>
        /// Returns true if TestSeries instances are equal
        /// </summary>
        /// <param name="input">Instance of TestSeries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestSeries input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MostRecentActivity == input.MostRecentActivity ||
                    (this.MostRecentActivity != null &&
                    this.MostRecentActivity.Equals(input.MostRecentActivity))
                ) && 
                (
                    this.TestRuns == input.TestRuns ||
                    this.TestRuns != null &&
                    input.TestRuns != null &&
                    this.TestRuns.SequenceEqual(input.TestRuns)
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
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MostRecentActivity != null)
                    hashCode = hashCode * 59 + this.MostRecentActivity.GetHashCode();
                if (this.TestRuns != null)
                    hashCode = hashCode * 59 + this.TestRuns.GetHashCode();
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
