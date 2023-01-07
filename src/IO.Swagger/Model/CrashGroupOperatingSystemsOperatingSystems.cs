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
    /// CrashGroupOperatingSystemsOperatingSystems
    /// </summary>
    [DataContract]
        public partial class CrashGroupOperatingSystemsOperatingSystems :  IEquatable<CrashGroupOperatingSystemsOperatingSystems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupOperatingSystemsOperatingSystems" /> class.
        /// </summary>
        /// <param name="operatingSystemName">OS name..</param>
        /// <param name="crashCount">Count of OS..</param>
        public CrashGroupOperatingSystemsOperatingSystems(string operatingSystemName = default(string), long? crashCount = default(long?))
        {
            this.OperatingSystemName = operatingSystemName;
            this.CrashCount = crashCount;
        }
        
        /// <summary>
        /// OS name.
        /// </summary>
        /// <value>OS name.</value>
        [DataMember(Name="operating_system_name", EmitDefaultValue=false)]
        public string OperatingSystemName { get; set; }

        /// <summary>
        /// Count of OS.
        /// </summary>
        /// <value>Count of OS.</value>
        [DataMember(Name="crash_count", EmitDefaultValue=false)]
        public long? CrashCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupOperatingSystemsOperatingSystems {\n");
            sb.Append("  OperatingSystemName: ").Append(OperatingSystemName).Append("\n");
            sb.Append("  CrashCount: ").Append(CrashCount).Append("\n");
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
            return this.Equals(input as CrashGroupOperatingSystemsOperatingSystems);
        }

        /// <summary>
        /// Returns true if CrashGroupOperatingSystemsOperatingSystems instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupOperatingSystemsOperatingSystems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupOperatingSystemsOperatingSystems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperatingSystemName == input.OperatingSystemName ||
                    (this.OperatingSystemName != null &&
                    this.OperatingSystemName.Equals(input.OperatingSystemName))
                ) && 
                (
                    this.CrashCount == input.CrashCount ||
                    (this.CrashCount != null &&
                    this.CrashCount.Equals(input.CrashCount))
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
                if (this.OperatingSystemName != null)
                    hashCode = hashCode * 59 + this.OperatingSystemName.GetHashCode();
                if (this.CrashCount != null)
                    hashCode = hashCode * 59 + this.CrashCount.GetHashCode();
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
