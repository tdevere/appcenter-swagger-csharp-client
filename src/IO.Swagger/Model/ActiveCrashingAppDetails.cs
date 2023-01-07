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
    /// ActiveCrashingAppDetails
    /// </summary>
    [DataContract]
        public partial class ActiveCrashingAppDetails :  IEquatable<ActiveCrashingAppDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveCrashingAppDetails" /> class.
        /// </summary>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="appsWithCrashes">details of the apps with crashes.</param>
        public ActiveCrashingAppDetails(string nextLink = default(string), List<ActiveCrashingAppDetailsAppsWithCrashes> appsWithCrashes = default(List<ActiveCrashingAppDetailsAppsWithCrashes>))
        {
            this.NextLink = nextLink;
            this.AppsWithCrashes = appsWithCrashes;
        }
        
        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name="nextLink", EmitDefaultValue=false)]
        public string NextLink { get; set; }

        /// <summary>
        /// details of the apps with crashes
        /// </summary>
        /// <value>details of the apps with crashes</value>
        [DataMember(Name="appsWithCrashes", EmitDefaultValue=false)]
        public List<ActiveCrashingAppDetailsAppsWithCrashes> AppsWithCrashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveCrashingAppDetails {\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
            sb.Append("  AppsWithCrashes: ").Append(AppsWithCrashes).Append("\n");
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
            return this.Equals(input as ActiveCrashingAppDetails);
        }

        /// <summary>
        /// Returns true if ActiveCrashingAppDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveCrashingAppDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveCrashingAppDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextLink == input.NextLink ||
                    (this.NextLink != null &&
                    this.NextLink.Equals(input.NextLink))
                ) && 
                (
                    this.AppsWithCrashes == input.AppsWithCrashes ||
                    this.AppsWithCrashes != null &&
                    input.AppsWithCrashes != null &&
                    this.AppsWithCrashes.SequenceEqual(input.AppsWithCrashes)
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
                if (this.NextLink != null)
                    hashCode = hashCode * 59 + this.NextLink.GetHashCode();
                if (this.AppsWithCrashes != null)
                    hashCode = hashCode * 59 + this.AppsWithCrashes.GetHashCode();
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
