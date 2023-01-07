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
    /// The Xamarin SDK bundle
    /// </summary>
    [DataContract]
        public partial class XamarinSDKBundle :  IEquatable<XamarinSDKBundle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinSDKBundle" /> class.
        /// </summary>
        /// <param name="monoVersion">The Mono version.</param>
        /// <param name="sdkBundle">The Xamarin SDK version.</param>
        /// <param name="current">If the SDK is latest stable.</param>
        /// <param name="stable">If the SDK is stable.</param>
        /// <param name="xcodeVersions">Specific for iOS SDK. A list of Xcode versions supported by current SDK version.</param>
        public XamarinSDKBundle(string monoVersion = default(string), string sdkBundle = default(string), bool? current = default(bool?), bool? stable = default(bool?), List<string> xcodeVersions = default(List<string>))
        {
            this.MonoVersion = monoVersion;
            this.SdkBundle = sdkBundle;
            this.Current = current;
            this.Stable = stable;
            this.XcodeVersions = xcodeVersions;
        }
        
        /// <summary>
        /// The Mono version
        /// </summary>
        /// <value>The Mono version</value>
        [DataMember(Name="monoVersion", EmitDefaultValue=false)]
        public string MonoVersion { get; set; }

        /// <summary>
        /// The Xamarin SDK version
        /// </summary>
        /// <value>The Xamarin SDK version</value>
        [DataMember(Name="sdkBundle", EmitDefaultValue=false)]
        public string SdkBundle { get; set; }

        /// <summary>
        /// If the SDK is latest stable
        /// </summary>
        /// <value>If the SDK is latest stable</value>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public bool? Current { get; set; }

        /// <summary>
        /// If the SDK is stable
        /// </summary>
        /// <value>If the SDK is stable</value>
        [DataMember(Name="stable", EmitDefaultValue=false)]
        public bool? Stable { get; set; }

        /// <summary>
        /// Specific for iOS SDK. A list of Xcode versions supported by current SDK version
        /// </summary>
        /// <value>Specific for iOS SDK. A list of Xcode versions supported by current SDK version</value>
        [DataMember(Name="xcodeVersions", EmitDefaultValue=false)]
        public List<string> XcodeVersions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XamarinSDKBundle {\n");
            sb.Append("  MonoVersion: ").Append(MonoVersion).Append("\n");
            sb.Append("  SdkBundle: ").Append(SdkBundle).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  Stable: ").Append(Stable).Append("\n");
            sb.Append("  XcodeVersions: ").Append(XcodeVersions).Append("\n");
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
            return this.Equals(input as XamarinSDKBundle);
        }

        /// <summary>
        /// Returns true if XamarinSDKBundle instances are equal
        /// </summary>
        /// <param name="input">Instance of XamarinSDKBundle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XamarinSDKBundle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MonoVersion == input.MonoVersion ||
                    (this.MonoVersion != null &&
                    this.MonoVersion.Equals(input.MonoVersion))
                ) && 
                (
                    this.SdkBundle == input.SdkBundle ||
                    (this.SdkBundle != null &&
                    this.SdkBundle.Equals(input.SdkBundle))
                ) && 
                (
                    this.Current == input.Current ||
                    (this.Current != null &&
                    this.Current.Equals(input.Current))
                ) && 
                (
                    this.Stable == input.Stable ||
                    (this.Stable != null &&
                    this.Stable.Equals(input.Stable))
                ) && 
                (
                    this.XcodeVersions == input.XcodeVersions ||
                    this.XcodeVersions != null &&
                    input.XcodeVersions != null &&
                    this.XcodeVersions.SequenceEqual(input.XcodeVersions)
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
                if (this.MonoVersion != null)
                    hashCode = hashCode * 59 + this.MonoVersion.GetHashCode();
                if (this.SdkBundle != null)
                    hashCode = hashCode * 59 + this.SdkBundle.GetHashCode();
                if (this.Current != null)
                    hashCode = hashCode * 59 + this.Current.GetHashCode();
                if (this.Stable != null)
                    hashCode = hashCode * 59 + this.Stable.GetHashCode();
                if (this.XcodeVersions != null)
                    hashCode = hashCode * 59 + this.XcodeVersions.GetHashCode();
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
