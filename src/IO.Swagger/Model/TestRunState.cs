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
    /// Current status of a test run
    /// </summary>
    [DataContract]
        public partial class TestRunState :  IEquatable<TestRunState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunState" /> class.
        /// </summary>
        /// <param name="message">Multi-line message that describes the status.</param>
        /// <param name="waitTime">Time (in seconds) that the client should wait for before checking the status again.</param>
        /// <param name="exitCode">The exit code that the client should use when exiting. Used for indicating status to the caller of the client. 0: test run completes with no failing tests 1: test run completes with at least one failing test 2: test run failed to complete. Status for test run is unknown .</param>
        public TestRunState(List<string> message = default(List<string>), int? waitTime = default(int?), int? exitCode = default(int?))
        {
            this.Message = message;
            this.WaitTime = waitTime;
            this.ExitCode = exitCode;
        }
        
        /// <summary>
        /// Multi-line message that describes the status
        /// </summary>
        /// <value>Multi-line message that describes the status</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public List<string> Message { get; set; }

        /// <summary>
        /// Time (in seconds) that the client should wait for before checking the status again
        /// </summary>
        /// <value>Time (in seconds) that the client should wait for before checking the status again</value>
        [DataMember(Name="wait_time", EmitDefaultValue=false)]
        public int? WaitTime { get; set; }

        /// <summary>
        /// The exit code that the client should use when exiting. Used for indicating status to the caller of the client. 0: test run completes with no failing tests 1: test run completes with at least one failing test 2: test run failed to complete. Status for test run is unknown 
        /// </summary>
        /// <value>The exit code that the client should use when exiting. Used for indicating status to the caller of the client. 0: test run completes with no failing tests 1: test run completes with at least one failing test 2: test run failed to complete. Status for test run is unknown </value>
        [DataMember(Name="exit_code", EmitDefaultValue=false)]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestRunState {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  WaitTime: ").Append(WaitTime).Append("\n");
            sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
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
            return this.Equals(input as TestRunState);
        }

        /// <summary>
        /// Returns true if TestRunState instances are equal
        /// </summary>
        /// <param name="input">Instance of TestRunState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestRunState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    this.Message != null &&
                    input.Message != null &&
                    this.Message.SequenceEqual(input.Message)
                ) && 
                (
                    this.WaitTime == input.WaitTime ||
                    (this.WaitTime != null &&
                    this.WaitTime.Equals(input.WaitTime))
                ) && 
                (
                    this.ExitCode == input.ExitCode ||
                    (this.ExitCode != null &&
                    this.ExitCode.Equals(input.ExitCode))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.WaitTime != null)
                    hashCode = hashCode * 59 + this.WaitTime.GetHashCode();
                if (this.ExitCode != null)
                    hashCode = hashCode * 59 + this.ExitCode.GetHashCode();
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
