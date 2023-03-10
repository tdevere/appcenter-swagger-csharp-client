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
    /// AllOfInvitationDetailResponseApp
    /// </summary>
    [DataContract]
        public partial class AllOfInvitationDetailResponseApp :  IEquatable<AllOfInvitationDetailResponseApp>, IValidatableObject
    {
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
            /// Enum Unity for value: Unity
            /// </summary>
            [EnumMember(Value = "Unity")]
            Unity = 6,
            /// <summary>
            /// Enum Electron for value: Electron
            /// </summary>
            [EnumMember(Value = "Electron")]
            Electron = 7,
            /// <summary>
            /// Enum Xamarin for value: Xamarin
            /// </summary>
            [EnumMember(Value = "Xamarin")]
            Xamarin = 8,
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
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 11,
            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 12        }
        /// <summary>
        /// The platform of the app
        /// </summary>
        /// <value>The platform of the app</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; set; }
        /// <summary>
        /// The creation origin of this app
        /// </summary>
        /// <value>The creation origin of this app</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OriginEnum
        {
            /// <summary>
            /// Enum Appcenter for value: appcenter
            /// </summary>
            [EnumMember(Value = "appcenter")]
            Appcenter = 1,
            /// <summary>
            /// Enum Hockeyapp for value: hockeyapp
            /// </summary>
            [EnumMember(Value = "hockeyapp")]
            Hockeyapp = 2,
            /// <summary>
            /// Enum Codepush for value: codepush
            /// </summary>
            [EnumMember(Value = "codepush")]
            Codepush = 3        }
        /// <summary>
        /// The creation origin of this app
        /// </summary>
        /// <value>The creation origin of this app</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// Defines MemberPermissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MemberPermissionsEnum
        {
            /// <summary>
            /// Enum Manager for value: manager
            /// </summary>
            [EnumMember(Value = "manager")]
            Manager = 1,
            /// <summary>
            /// Enum Developer for value: developer
            /// </summary>
            [EnumMember(Value = "developer")]
            Developer = 2,
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 3,
            /// <summary>
            /// Enum Tester for value: tester
            /// </summary>
            [EnumMember(Value = "tester")]
            Tester = 4        }
        /// <summary>
        /// The permissions of the calling user
        /// </summary>
        /// <value>The permissions of the calling user</value>
        [DataMember(Name="member_permissions", EmitDefaultValue=false)]
        public List<MemberPermissionsEnum> MemberPermissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfInvitationDetailResponseApp" /> class.
        /// </summary>
        /// <param name="appSecret">A unique and secret key used to identify the app in communication with the ingestion endpoint for crash reporting and analytics.</param>
        /// <param name="azureSubscription">azureSubscription.</param>
        /// <param name="platform">The platform of the app.</param>
        /// <param name="origin">The creation origin of this app.</param>
        /// <param name="createdAt">The created date of this app.</param>
        /// <param name="updatedAt">The last updated date of this app.</param>
        /// <param name="memberPermissions">The permissions of the calling user.</param>
        public AllOfInvitationDetailResponseApp(string appSecret = default(string), Object azureSubscription = default(Object), PlatformEnum? platform = default(PlatformEnum?), OriginEnum? origin = default(OriginEnum?), string createdAt = default(string), string updatedAt = default(string), List<MemberPermissionsEnum> memberPermissions = default(List<MemberPermissionsEnum>))
        {
            this.AppSecret = appSecret;
            this.AzureSubscription = azureSubscription;
            this.Platform = platform;
            this.Origin = origin;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.MemberPermissions = memberPermissions;
        }
        
        /// <summary>
        /// A unique and secret key used to identify the app in communication with the ingestion endpoint for crash reporting and analytics
        /// </summary>
        /// <value>A unique and secret key used to identify the app in communication with the ingestion endpoint for crash reporting and analytics</value>
        [DataMember(Name="app_secret", EmitDefaultValue=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// Gets or Sets AzureSubscription
        /// </summary>
        [DataMember(Name="azure_subscription", EmitDefaultValue=false)]
        public Object AzureSubscription { get; set; }



        /// <summary>
        /// The created date of this app
        /// </summary>
        /// <value>The created date of this app</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The last updated date of this app
        /// </summary>
        /// <value>The last updated date of this app</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfInvitationDetailResponseApp {\n");
            sb.Append("  AppSecret: ").Append(AppSecret).Append("\n");
            sb.Append("  AzureSubscription: ").Append(AzureSubscription).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  MemberPermissions: ").Append(MemberPermissions).Append("\n");
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
            return this.Equals(input as AllOfInvitationDetailResponseApp);
        }

        /// <summary>
        /// Returns true if AllOfInvitationDetailResponseApp instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfInvitationDetailResponseApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfInvitationDetailResponseApp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppSecret == input.AppSecret ||
                    (this.AppSecret != null &&
                    this.AppSecret.Equals(input.AppSecret))
                ) && 
                (
                    this.AzureSubscription == input.AzureSubscription ||
                    (this.AzureSubscription != null &&
                    this.AzureSubscription.Equals(input.AzureSubscription))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.MemberPermissions == input.MemberPermissions ||
                    this.MemberPermissions != null &&
                    input.MemberPermissions != null &&
                    this.MemberPermissions.SequenceEqual(input.MemberPermissions)
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
                if (this.AppSecret != null)
                    hashCode = hashCode * 59 + this.AppSecret.GetHashCode();
                if (this.AzureSubscription != null)
                    hashCode = hashCode * 59 + this.AzureSubscription.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.MemberPermissions != null)
                    hashCode = hashCode * 59 + this.MemberPermissions.GetHashCode();
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
