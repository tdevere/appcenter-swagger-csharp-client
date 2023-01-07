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
    /// Build configuration when React Native, or other JavaScript tech, is part of the build steps
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript :  IEquatable<V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript" /> class.
        /// </summary>
        /// <param name="packageJsonPath">Path to package.json file for the main project, e.g. \&quot;package.json\&quot; or \&quot;myapp/package.json\&quot;.</param>
        /// <param name="runTests">Whether to run Jest unit tests, via npm test, during the build.</param>
        /// <param name="reactNativeVersion">Version of React Native from package.json files.</param>
        public V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript(string packageJsonPath = default(string), bool? runTests = default(bool?), string reactNativeVersion = default(string))
        {
            this.PackageJsonPath = packageJsonPath;
            this.RunTests = runTests;
            this.ReactNativeVersion = reactNativeVersion;
        }
        
        /// <summary>
        /// Path to package.json file for the main project, e.g. \&quot;package.json\&quot; or \&quot;myapp/package.json\&quot;
        /// </summary>
        /// <value>Path to package.json file for the main project, e.g. \&quot;package.json\&quot; or \&quot;myapp/package.json\&quot;</value>
        [DataMember(Name="packageJsonPath", EmitDefaultValue=false)]
        public string PackageJsonPath { get; set; }

        /// <summary>
        /// Whether to run Jest unit tests, via npm test, during the build
        /// </summary>
        /// <value>Whether to run Jest unit tests, via npm test, during the build</value>
        [DataMember(Name="runTests", EmitDefaultValue=false)]
        public bool? RunTests { get; set; }

        /// <summary>
        /// Version of React Native from package.json files
        /// </summary>
        /// <value>Version of React Native from package.json files</value>
        [DataMember(Name="reactNativeVersion", EmitDefaultValue=false)]
        public string ReactNativeVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript {\n");
            sb.Append("  PackageJsonPath: ").Append(PackageJsonPath).Append("\n");
            sb.Append("  RunTests: ").Append(RunTests).Append("\n");
            sb.Append("  ReactNativeVersion: ").Append(ReactNativeVersion).Append("\n");
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
            return this.Equals(input as V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNamebranchesbranchconfigToolsetsJavascript input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageJsonPath == input.PackageJsonPath ||
                    (this.PackageJsonPath != null &&
                    this.PackageJsonPath.Equals(input.PackageJsonPath))
                ) && 
                (
                    this.RunTests == input.RunTests ||
                    (this.RunTests != null &&
                    this.RunTests.Equals(input.RunTests))
                ) && 
                (
                    this.ReactNativeVersion == input.ReactNativeVersion ||
                    (this.ReactNativeVersion != null &&
                    this.ReactNativeVersion.Equals(input.ReactNativeVersion))
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
                if (this.PackageJsonPath != null)
                    hashCode = hashCode * 59 + this.PackageJsonPath.GetHashCode();
                if (this.RunTests != null)
                    hashCode = hashCode * 59 + this.RunTests.GetHashCode();
                if (this.ReactNativeVersion != null)
                    hashCode = hashCode * 59 + this.ReactNativeVersion.GetHashCode();
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
