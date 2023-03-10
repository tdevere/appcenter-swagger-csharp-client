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
    /// AlertingCrashGroup
    /// </summary>
    [DataContract]
        public partial class AlertingCrashGroup :  IEquatable<AlertingCrashGroup>, IValidatableObject
    {
        /// <summary>
        /// SDK/Platform this thread is beeing generated from
        /// </summary>
        /// <value>SDK/Platform this thread is beeing generated from</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AppPlatformEnum
        {
            /// <summary>
            /// Enum Ios for value: ios
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios = 1,
            /// <summary>
            /// Enum Android for value: android
            /// </summary>
            [EnumMember(Value = "android")]
            Android = 2,
            /// <summary>
            /// Enum Xamarin for value: xamarin
            /// </summary>
            [EnumMember(Value = "xamarin")]
            Xamarin = 3,
            /// <summary>
            /// Enum ReactNative for value: react-native
            /// </summary>
            [EnumMember(Value = "react-native")]
            ReactNative = 4,
            /// <summary>
            /// Enum Ndk for value: ndk
            /// </summary>
            [EnumMember(Value = "ndk")]
            Ndk = 5,
            /// <summary>
            /// Enum Unity for value: unity
            /// </summary>
            [EnumMember(Value = "unity")]
            Unity = 6,
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7        }
        /// <summary>
        /// SDK/Platform this thread is beeing generated from
        /// </summary>
        /// <value>SDK/Platform this thread is beeing generated from</value>
        [DataMember(Name="app_platform", EmitDefaultValue=false)]
        public AppPlatformEnum? AppPlatform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingCrashGroup" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="appDisplayName">appDisplayName.</param>
        /// <param name="appPlatform">SDK/Platform this thread is beeing generated from.</param>
        /// <param name="appVersion">appVersion.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="reason">reason.</param>
        /// <param name="stackTrace">stackTrace.</param>
        public AlertingCrashGroup(string url = default(string), string appDisplayName = default(string), AppPlatformEnum? appPlatform = default(AppPlatformEnum?), string appVersion = default(string), string id = default(string), string name = default(string), string reason = default(string), List<string> stackTrace = default(List<string>))
        {
            this.Url = url;
            this.AppDisplayName = appDisplayName;
            this.AppPlatform = appPlatform;
            this.AppVersion = appVersion;
            this.Id = id;
            this.Name = name;
            this.Reason = reason;
            this.StackTrace = stackTrace;
        }
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets AppDisplayName
        /// </summary>
        [DataMember(Name="app_display_name", EmitDefaultValue=false)]
        public string AppDisplayName { get; set; }


        /// <summary>
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="app_version", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name="stack_trace", EmitDefaultValue=false)]
        public List<string> StackTrace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertingCrashGroup {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AppDisplayName: ").Append(AppDisplayName).Append("\n");
            sb.Append("  AppPlatform: ").Append(AppPlatform).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
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
            return this.Equals(input as AlertingCrashGroup);
        }

        /// <summary>
        /// Returns true if AlertingCrashGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertingCrashGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertingCrashGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AppDisplayName == input.AppDisplayName ||
                    (this.AppDisplayName != null &&
                    this.AppDisplayName.Equals(input.AppDisplayName))
                ) && 
                (
                    this.AppPlatform == input.AppPlatform ||
                    (this.AppPlatform != null &&
                    this.AppPlatform.Equals(input.AppPlatform))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    this.StackTrace != null &&
                    input.StackTrace != null &&
                    this.StackTrace.SequenceEqual(input.StackTrace)
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AppDisplayName != null)
                    hashCode = hashCode * 59 + this.AppDisplayName.GetHashCode();
                if (this.AppPlatform != null)
                    hashCode = hashCode * 59 + this.AppPlatform.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
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
