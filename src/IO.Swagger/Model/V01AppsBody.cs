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
    /// V01AppsBody
    /// </summary>
    [DataContract]
        public partial class V01AppsBody :  IEquatable<V01AppsBody>, IValidatableObject
    {
        /// <summary>
        /// The OS the app will be running on
        /// </summary>
        /// <value>The OS the app will be running on</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OsEnum
        {
            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 1,
            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            IOS = 2,
            /// <summary>
            /// Enum MacOS for value: macOS
            /// </summary>
            [EnumMember(Value = "macOS")]
            MacOS = 3,
            /// <summary>
            /// Enum Tizen for value: Tizen
            /// </summary>
            [EnumMember(Value = "Tizen")]
            Tizen = 4,
            /// <summary>
            /// Enum TvOS for value: tvOS
            /// </summary>
            [EnumMember(Value = "tvOS")]
            TvOS = 5,
            /// <summary>
            /// Enum Windows for value: Windows
            /// </summary>
            [EnumMember(Value = "Windows")]
            Windows = 6,
            /// <summary>
            /// Enum Linux for value: Linux
            /// </summary>
            [EnumMember(Value = "Linux")]
            Linux = 7,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 8        }
        /// <summary>
        /// The OS the app will be running on
        /// </summary>
        /// <value>The OS the app will be running on</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public OsEnum Os { get; set; }
        /// <summary>
        /// The platform of the app
        /// </summary>
        /// <value>The platform of the app</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PlatformEnum
        {
            /// <summary>
            /// Enum Java for value: Java
            /// </summary>
            [EnumMember(Value = "Java")]
            Java = 1,
            /// <summary>
            /// Enum ObjectiveCSwift for value: Objective-C-Swift
            /// </summary>
            [EnumMember(Value = "Objective-C-Swift")]
            ObjectiveCSwift = 2,
            /// <summary>
            /// Enum UWP for value: UWP
            /// </summary>
            [EnumMember(Value = "UWP")]
            UWP = 3,
            /// <summary>
            /// Enum Cordova for value: Cordova
            /// </summary>
            [EnumMember(Value = "Cordova")]
            Cordova = 4,
            /// <summary>
            /// Enum ReactNative for value: React-Native
            /// </summary>
            [EnumMember(Value = "React-Native")]
            ReactNative = 5,
            /// <summary>
            /// Enum Xamarin for value: Xamarin
            /// </summary>
            [EnumMember(Value = "Xamarin")]
            Xamarin = 6,
            /// <summary>
            /// Enum Unity for value: Unity
            /// </summary>
            [EnumMember(Value = "Unity")]
            Unity = 7,
            /// <summary>
            /// Enum Electron for value: Electron
            /// </summary>
            [EnumMember(Value = "Electron")]
            Electron = 8,
            /// <summary>
            /// Enum WPF for value: WPF
            /// </summary>
            [EnumMember(Value = "WPF")]
            WPF = 9,
            /// <summary>
            /// Enum WinForms for value: WinForms
            /// </summary>
            [EnumMember(Value = "WinForms")]
            WinForms = 10,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 11        }
        /// <summary>
        /// The platform of the app
        /// </summary>
        /// <value>The platform of the app</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V01AppsBody" /> class.
        /// </summary>
        /// <param name="description">A short text describing the app.</param>
        /// <param name="releaseType">A one-word descriptive release-type value that starts with a capital letter but is otherwise lowercase.</param>
        /// <param name="displayName">The descriptive name of the app. This can contain any characters (required).</param>
        /// <param name="name">The name of the app used in URLs.</param>
        /// <param name="os">The OS the app will be running on (required).</param>
        /// <param name="platform">The platform of the app (required).</param>
        public V01AppsBody(string description = default(string), string releaseType = default(string), string displayName = default(string), string name = default(string), OsEnum os = default(OsEnum), PlatformEnum platform = default(PlatformEnum))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for V01AppsBody and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new InvalidDataException("os is a required property for V01AppsBody and cannot be null");
            }
            else
            {
                this.Os = os;
            }
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new InvalidDataException("platform is a required property for V01AppsBody and cannot be null");
            }
            else
            {
                this.Platform = platform;
            }
            this.Description = description;
            this.ReleaseType = releaseType;
            this.Name = name;
        }
        
        /// <summary>
        /// A short text describing the app
        /// </summary>
        /// <value>A short text describing the app</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A one-word descriptive release-type value that starts with a capital letter but is otherwise lowercase
        /// </summary>
        /// <value>A one-word descriptive release-type value that starts with a capital letter but is otherwise lowercase</value>
        [DataMember(Name="release_type", EmitDefaultValue=false)]
        public string ReleaseType { get; set; }

        /// <summary>
        /// The descriptive name of the app. This can contain any characters
        /// </summary>
        /// <value>The descriptive name of the app. This can contain any characters</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the app used in URLs
        /// </summary>
        /// <value>The name of the app used in URLs</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01AppsBody {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ReleaseType: ").Append(ReleaseType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(input as V01AppsBody);
        }

        /// <summary>
        /// Returns true if V01AppsBody instances are equal
        /// </summary>
        /// <param name="input">Instance of V01AppsBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01AppsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ReleaseType == input.ReleaseType ||
                    (this.ReleaseType != null &&
                    this.ReleaseType.Equals(input.ReleaseType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ReleaseType != null)
                    hashCode = hashCode * 59 + this.ReleaseType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
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
