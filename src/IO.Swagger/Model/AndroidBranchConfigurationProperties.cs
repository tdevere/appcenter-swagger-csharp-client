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
    /// Build configuration for Android projects
    /// </summary>
    [DataContract]
        public partial class AndroidBranchConfigurationProperties :  IEquatable<AndroidBranchConfigurationProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidBranchConfigurationProperties" /> class.
        /// </summary>
        /// <param name="gradleWrapperPath">Path to the Gradle wrapper script.</param>
        /// <param name="module">The Gradle module to build.</param>
        /// <param name="buildVariant">The Android build variant to build.</param>
        /// <param name="runTests">Whether to run unit tests during the build (default) (default to true).</param>
        /// <param name="runLint">Whether to run lint checks during the build (default).</param>
        /// <param name="isRoot">Whether it is the root module or not.</param>
        /// <param name="automaticSigning">Whether to apply automatic signing or not.</param>
        /// <param name="keystorePassword">The password of the keystore.</param>
        /// <param name="keyAlias">The key alias.</param>
        /// <param name="keyPassword">The key password.</param>
        /// <param name="keystoreFilename">The name of the keystore file.</param>
        /// <param name="keystoreEncoded">The keystore encoded value.</param>
        public AndroidBranchConfigurationProperties(string gradleWrapperPath = default(string), string module = default(string), string buildVariant = default(string), bool? runTests = true, bool? runLint = default(bool?), bool? isRoot = default(bool?), bool? automaticSigning = default(bool?), string keystorePassword = default(string), string keyAlias = default(string), string keyPassword = default(string), string keystoreFilename = default(string), string keystoreEncoded = default(string))
        {
            this.GradleWrapperPath = gradleWrapperPath;
            this.Module = module;
            this.BuildVariant = buildVariant;
            // use default value if no "runTests" provided
            if (runTests == null)
            {
                this.RunTests = true;
            }
            else
            {
                this.RunTests = runTests;
            }
            this.RunLint = runLint;
            this.IsRoot = isRoot;
            this.AutomaticSigning = automaticSigning;
            this.KeystorePassword = keystorePassword;
            this.KeyAlias = keyAlias;
            this.KeyPassword = keyPassword;
            this.KeystoreFilename = keystoreFilename;
            this.KeystoreEncoded = keystoreEncoded;
        }
        
        /// <summary>
        /// Path to the Gradle wrapper script
        /// </summary>
        /// <value>Path to the Gradle wrapper script</value>
        [DataMember(Name="gradleWrapperPath", EmitDefaultValue=false)]
        public string GradleWrapperPath { get; set; }

        /// <summary>
        /// The Gradle module to build
        /// </summary>
        /// <value>The Gradle module to build</value>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public string Module { get; set; }

        /// <summary>
        /// The Android build variant to build
        /// </summary>
        /// <value>The Android build variant to build</value>
        [DataMember(Name="buildVariant", EmitDefaultValue=false)]
        public string BuildVariant { get; set; }

        /// <summary>
        /// Whether to run unit tests during the build (default)
        /// </summary>
        /// <value>Whether to run unit tests during the build (default)</value>
        [DataMember(Name="runTests", EmitDefaultValue=false)]
        public bool? RunTests { get; set; }

        /// <summary>
        /// Whether to run lint checks during the build (default)
        /// </summary>
        /// <value>Whether to run lint checks during the build (default)</value>
        [DataMember(Name="runLint", EmitDefaultValue=false)]
        public bool? RunLint { get; set; }

        /// <summary>
        /// Whether it is the root module or not
        /// </summary>
        /// <value>Whether it is the root module or not</value>
        [DataMember(Name="isRoot", EmitDefaultValue=false)]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Whether to apply automatic signing or not
        /// </summary>
        /// <value>Whether to apply automatic signing or not</value>
        [DataMember(Name="automaticSigning", EmitDefaultValue=false)]
        public bool? AutomaticSigning { get; set; }

        /// <summary>
        /// The password of the keystore
        /// </summary>
        /// <value>The password of the keystore</value>
        [DataMember(Name="keystorePassword", EmitDefaultValue=false)]
        public string KeystorePassword { get; set; }

        /// <summary>
        /// The key alias
        /// </summary>
        /// <value>The key alias</value>
        [DataMember(Name="keyAlias", EmitDefaultValue=false)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// The key password
        /// </summary>
        /// <value>The key password</value>
        [DataMember(Name="keyPassword", EmitDefaultValue=false)]
        public string KeyPassword { get; set; }

        /// <summary>
        /// The name of the keystore file
        /// </summary>
        /// <value>The name of the keystore file</value>
        [DataMember(Name="keystoreFilename", EmitDefaultValue=false)]
        public string KeystoreFilename { get; set; }

        /// <summary>
        /// The keystore encoded value
        /// </summary>
        /// <value>The keystore encoded value</value>
        [DataMember(Name="keystoreEncoded", EmitDefaultValue=false)]
        public string KeystoreEncoded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AndroidBranchConfigurationProperties {\n");
            sb.Append("  GradleWrapperPath: ").Append(GradleWrapperPath).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  BuildVariant: ").Append(BuildVariant).Append("\n");
            sb.Append("  RunTests: ").Append(RunTests).Append("\n");
            sb.Append("  RunLint: ").Append(RunLint).Append("\n");
            sb.Append("  IsRoot: ").Append(IsRoot).Append("\n");
            sb.Append("  AutomaticSigning: ").Append(AutomaticSigning).Append("\n");
            sb.Append("  KeystorePassword: ").Append(KeystorePassword).Append("\n");
            sb.Append("  KeyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  KeyPassword: ").Append(KeyPassword).Append("\n");
            sb.Append("  KeystoreFilename: ").Append(KeystoreFilename).Append("\n");
            sb.Append("  KeystoreEncoded: ").Append(KeystoreEncoded).Append("\n");
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
            return this.Equals(input as AndroidBranchConfigurationProperties);
        }

        /// <summary>
        /// Returns true if AndroidBranchConfigurationProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of AndroidBranchConfigurationProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AndroidBranchConfigurationProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradleWrapperPath == input.GradleWrapperPath ||
                    (this.GradleWrapperPath != null &&
                    this.GradleWrapperPath.Equals(input.GradleWrapperPath))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && 
                (
                    this.BuildVariant == input.BuildVariant ||
                    (this.BuildVariant != null &&
                    this.BuildVariant.Equals(input.BuildVariant))
                ) && 
                (
                    this.RunTests == input.RunTests ||
                    (this.RunTests != null &&
                    this.RunTests.Equals(input.RunTests))
                ) && 
                (
                    this.RunLint == input.RunLint ||
                    (this.RunLint != null &&
                    this.RunLint.Equals(input.RunLint))
                ) && 
                (
                    this.IsRoot == input.IsRoot ||
                    (this.IsRoot != null &&
                    this.IsRoot.Equals(input.IsRoot))
                ) && 
                (
                    this.AutomaticSigning == input.AutomaticSigning ||
                    (this.AutomaticSigning != null &&
                    this.AutomaticSigning.Equals(input.AutomaticSigning))
                ) && 
                (
                    this.KeystorePassword == input.KeystorePassword ||
                    (this.KeystorePassword != null &&
                    this.KeystorePassword.Equals(input.KeystorePassword))
                ) && 
                (
                    this.KeyAlias == input.KeyAlias ||
                    (this.KeyAlias != null &&
                    this.KeyAlias.Equals(input.KeyAlias))
                ) && 
                (
                    this.KeyPassword == input.KeyPassword ||
                    (this.KeyPassword != null &&
                    this.KeyPassword.Equals(input.KeyPassword))
                ) && 
                (
                    this.KeystoreFilename == input.KeystoreFilename ||
                    (this.KeystoreFilename != null &&
                    this.KeystoreFilename.Equals(input.KeystoreFilename))
                ) && 
                (
                    this.KeystoreEncoded == input.KeystoreEncoded ||
                    (this.KeystoreEncoded != null &&
                    this.KeystoreEncoded.Equals(input.KeystoreEncoded))
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
                if (this.GradleWrapperPath != null)
                    hashCode = hashCode * 59 + this.GradleWrapperPath.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.BuildVariant != null)
                    hashCode = hashCode * 59 + this.BuildVariant.GetHashCode();
                if (this.RunTests != null)
                    hashCode = hashCode * 59 + this.RunTests.GetHashCode();
                if (this.RunLint != null)
                    hashCode = hashCode * 59 + this.RunLint.GetHashCode();
                if (this.IsRoot != null)
                    hashCode = hashCode * 59 + this.IsRoot.GetHashCode();
                if (this.AutomaticSigning != null)
                    hashCode = hashCode * 59 + this.AutomaticSigning.GetHashCode();
                if (this.KeystorePassword != null)
                    hashCode = hashCode * 59 + this.KeystorePassword.GetHashCode();
                if (this.KeyAlias != null)
                    hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.KeyPassword != null)
                    hashCode = hashCode * 59 + this.KeyPassword.GetHashCode();
                if (this.KeystoreFilename != null)
                    hashCode = hashCode * 59 + this.KeystoreFilename.GetHashCode();
                if (this.KeystoreEncoded != null)
                    hashCode = hashCode * 59 + this.KeystoreEncoded.GetHashCode();
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
