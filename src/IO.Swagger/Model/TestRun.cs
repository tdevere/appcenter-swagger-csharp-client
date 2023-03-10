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
    /// Summary single test run on Xamarin Test Cloud
    /// </summary>
    [DataContract]
        public partial class TestRun :  IEquatable<TestRun>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRun" /> class.
        /// </summary>
        /// <param name="id">The unique id of the test upload.</param>
        /// <param name="date">The date and time the test was uploaded.</param>
        /// <param name="appVersion">The compiled version of the app binary.</param>
        /// <param name="testSeries">The name of the test series with which this test upload is associated.</param>
        /// <param name="platform">The device platform targeted by the test. Possible values are &#x27;ios&#x27; or &#x27;android&#x27;.</param>
        /// <param name="runStatus">The current status of the test run, in relation to the various phases.</param>
        /// <param name="resultStatus">The passed/failed state.</param>
        /// <param name="state">Deprecated. Use runStatus instead..</param>
        /// <param name="status">Deprecated. Use resultStatus instead..</param>
        /// <param name="description">Human readable explanation of the current test status.</param>
        /// <param name="stats">stats.</param>
        /// <param name="testType">The name of the test framework used to run this test.</param>
        public TestRun(Guid? id = default(Guid?), string date = default(string), string appVersion = default(string), string testSeries = default(string), string platform = default(string), string runStatus = default(string), string resultStatus = default(string), string state = default(string), string status = default(string), string description = default(string), TestRunStatistics stats = default(TestRunStatistics), string testType = default(string))
        {
            this.Id = id;
            this.Date = date;
            this.AppVersion = appVersion;
            this.TestSeries = testSeries;
            this.Platform = platform;
            this.RunStatus = runStatus;
            this.ResultStatus = resultStatus;
            this.State = state;
            this.Status = status;
            this.Description = description;
            this.Stats = stats;
            this.TestType = testType;
        }
        
        /// <summary>
        /// The unique id of the test upload
        /// </summary>
        /// <value>The unique id of the test upload</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The date and time the test was uploaded
        /// </summary>
        /// <value>The date and time the test was uploaded</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// The compiled version of the app binary
        /// </summary>
        /// <value>The compiled version of the app binary</value>
        [DataMember(Name="appVersion", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// The name of the test series with which this test upload is associated
        /// </summary>
        /// <value>The name of the test series with which this test upload is associated</value>
        [DataMember(Name="testSeries", EmitDefaultValue=false)]
        public string TestSeries { get; set; }

        /// <summary>
        /// The device platform targeted by the test. Possible values are &#x27;ios&#x27; or &#x27;android&#x27;
        /// </summary>
        /// <value>The device platform targeted by the test. Possible values are &#x27;ios&#x27; or &#x27;android&#x27;</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The current status of the test run, in relation to the various phases
        /// </summary>
        /// <value>The current status of the test run, in relation to the various phases</value>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public string RunStatus { get; set; }

        /// <summary>
        /// The passed/failed state
        /// </summary>
        /// <value>The passed/failed state</value>
        [DataMember(Name="resultStatus", EmitDefaultValue=false)]
        public string ResultStatus { get; set; }

        /// <summary>
        /// Deprecated. Use runStatus instead.
        /// </summary>
        /// <value>Deprecated. Use runStatus instead.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Deprecated. Use resultStatus instead.
        /// </summary>
        /// <value>Deprecated. Use resultStatus instead.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Human readable explanation of the current test status
        /// </summary>
        /// <value>Human readable explanation of the current test status</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public TestRunStatistics Stats { get; set; }

        /// <summary>
        /// The name of the test framework used to run this test
        /// </summary>
        /// <value>The name of the test framework used to run this test</value>
        [DataMember(Name="testType", EmitDefaultValue=false)]
        public string TestType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestRun {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  TestSeries: ").Append(TestSeries).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  RunStatus: ").Append(RunStatus).Append("\n");
            sb.Append("  ResultStatus: ").Append(ResultStatus).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  TestType: ").Append(TestType).Append("\n");
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
            return this.Equals(input as TestRun);
        }

        /// <summary>
        /// Returns true if TestRun instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.TestSeries == input.TestSeries ||
                    (this.TestSeries != null &&
                    this.TestSeries.Equals(input.TestSeries))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.RunStatus == input.RunStatus ||
                    (this.RunStatus != null &&
                    this.RunStatus.Equals(input.RunStatus))
                ) && 
                (
                    this.ResultStatus == input.ResultStatus ||
                    (this.ResultStatus != null &&
                    this.ResultStatus.Equals(input.ResultStatus))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.TestType == input.TestType ||
                    (this.TestType != null &&
                    this.TestType.Equals(input.TestType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.TestSeries != null)
                    hashCode = hashCode * 59 + this.TestSeries.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.RunStatus != null)
                    hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.ResultStatus != null)
                    hashCode = hashCode * 59 + this.ResultStatus.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.TestType != null)
                    hashCode = hashCode * 59 + this.TestType.GetHashCode();
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
