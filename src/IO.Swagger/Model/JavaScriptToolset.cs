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
    /// JavaScriptToolset
    /// </summary>
    [DataContract]
        public partial class JavaScriptToolset :  IEquatable<JavaScriptToolset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JavaScriptToolset" /> class.
        /// </summary>
        /// <param name="packageJsonPaths">Paths for detected package.json files (required).</param>
        /// <param name="javascriptSolutions">The React Native solutions detected.</param>
        public JavaScriptToolset(List<string> packageJsonPaths = default(List<string>), List<JavaScriptToolsetJavascriptSolutions> javascriptSolutions = default(List<JavaScriptToolsetJavascriptSolutions>))
        {
            // to ensure "packageJsonPaths" is required (not null)
            if (packageJsonPaths == null)
            {
                throw new InvalidDataException("packageJsonPaths is a required property for JavaScriptToolset and cannot be null");
            }
            else
            {
                this.PackageJsonPaths = packageJsonPaths;
            }
            this.JavascriptSolutions = javascriptSolutions;
        }
        
        /// <summary>
        /// Paths for detected package.json files
        /// </summary>
        /// <value>Paths for detected package.json files</value>
        [DataMember(Name="packageJsonPaths", EmitDefaultValue=false)]
        public List<string> PackageJsonPaths { get; set; }

        /// <summary>
        /// The React Native solutions detected
        /// </summary>
        /// <value>The React Native solutions detected</value>
        [DataMember(Name="javascriptSolutions", EmitDefaultValue=false)]
        public List<JavaScriptToolsetJavascriptSolutions> JavascriptSolutions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JavaScriptToolset {\n");
            sb.Append("  PackageJsonPaths: ").Append(PackageJsonPaths).Append("\n");
            sb.Append("  JavascriptSolutions: ").Append(JavascriptSolutions).Append("\n");
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
            return this.Equals(input as JavaScriptToolset);
        }

        /// <summary>
        /// Returns true if JavaScriptToolset instances are equal
        /// </summary>
        /// <param name="input">Instance of JavaScriptToolset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JavaScriptToolset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageJsonPaths == input.PackageJsonPaths ||
                    this.PackageJsonPaths != null &&
                    input.PackageJsonPaths != null &&
                    this.PackageJsonPaths.SequenceEqual(input.PackageJsonPaths)
                ) && 
                (
                    this.JavascriptSolutions == input.JavascriptSolutions ||
                    this.JavascriptSolutions != null &&
                    input.JavascriptSolutions != null &&
                    this.JavascriptSolutions.SequenceEqual(input.JavascriptSolutions)
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
                if (this.PackageJsonPaths != null)
                    hashCode = hashCode * 59 + this.PackageJsonPaths.GetHashCode();
                if (this.JavascriptSolutions != null)
                    hashCode = hashCode * 59 + this.JavascriptSolutions.GetHashCode();
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
