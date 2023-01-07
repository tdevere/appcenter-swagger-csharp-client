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
    /// BranchBuildsBody
    /// </summary>
    [DataContract]
        public partial class BranchBuildsBody :  IEquatable<BranchBuildsBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchBuildsBody" /> class.
        /// </summary>
        /// <param name="sourceVersion">Version to build which represents the full Git commit reference.</param>
        /// <param name="debug">Run build in debug mode.</param>
        public BranchBuildsBody(string sourceVersion = default(string), bool? debug = default(bool?))
        {
            this.SourceVersion = sourceVersion;
            this.Debug = debug;
        }
        
        /// <summary>
        /// Version to build which represents the full Git commit reference
        /// </summary>
        /// <value>Version to build which represents the full Git commit reference</value>
        [DataMember(Name="sourceVersion", EmitDefaultValue=false)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// Run build in debug mode
        /// </summary>
        /// <value>Run build in debug mode</value>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchBuildsBody {\n");
            sb.Append("  SourceVersion: ").Append(SourceVersion).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
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
            return this.Equals(input as BranchBuildsBody);
        }

        /// <summary>
        /// Returns true if BranchBuildsBody instances are equal
        /// </summary>
        /// <param name="input">Instance of BranchBuildsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchBuildsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceVersion == input.SourceVersion ||
                    (this.SourceVersion != null &&
                    this.SourceVersion.Equals(input.SourceVersion))
                ) && 
                (
                    this.Debug == input.Debug ||
                    (this.Debug != null &&
                    this.Debug.Equals(input.Debug))
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
                if (this.SourceVersion != null)
                    hashCode = hashCode * 59 + this.SourceVersion.GetHashCode();
                if (this.Debug != null)
                    hashCode = hashCode * 59 + this.Debug.GetHashCode();
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
