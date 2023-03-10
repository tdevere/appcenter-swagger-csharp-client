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
    /// Device characteristics.
    /// </summary>
    [DataContract]
        public partial class DeviceDiagnostics :  IEquatable<DeviceDiagnostics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDiagnostics" /> class.
        /// </summary>
        /// <param name="sdkName">Name of the SDK. Consists of the name of the SDK and the platform, e.g. \&quot;appcenter.ios\&quot;, \&quot;hockeysdk.android\&quot;.  (required).</param>
        /// <param name="sdkVersion">Version of the SDK in semver format, e.g. \&quot;1.2.0\&quot; or \&quot;0.12.3-alpha.1\&quot;.  (required).</param>
        /// <param name="wrapperSdkVersion">Version of the wrapper SDK in semver format. When the SDK is embedding another base SDK (for example Xamarin.Android wraps Android), the Xamarin specific version is populated into this field while sdkVersion refers to the original Android SDK. .</param>
        /// <param name="wrapperSdkName">Name of the wrapper SDK. Consists of the name of the SDK and the wrapper platform, e.g. \&quot;appcenter.xamarin\&quot;, \&quot;hockeysdk.cordova\&quot;. .</param>
        /// <param name="model">Device model (example: iPad2,3). .</param>
        /// <param name="oemName">Device manufacturer (example: HTC). .</param>
        /// <param name="osName">OS name (example: iOS). The following OS names are standardized (non-exclusive): Android, iOS, macOS, tvOS, Windows.  (required).</param>
        /// <param name="osVersion">OS version (example: 9.3.0).  (required).</param>
        /// <param name="osBuild">OS build code (example: LMY47X). .</param>
        /// <param name="osApiLevel">API level when applicable like in Android (example: 15). .</param>
        /// <param name="locale">Language code (example: en_US).  (required).</param>
        /// <param name="timeZoneOffset">The offset in minutes from UTC for the device time zone, including daylight savings time.  (required).</param>
        /// <param name="screenSize">Screen size of the device in pixels (example: 640x480). .</param>
        /// <param name="appVersion">Application version name, e.g. 1.1.0  (required).</param>
        /// <param name="carrierName">Carrier name (for mobile devices). .</param>
        /// <param name="carrierCode">Carrier country code (for mobile devices). .</param>
        /// <param name="carrierCountry">Carrier country. .</param>
        /// <param name="appBuild">The app&#x27;s build number, e.g. 42.  (required).</param>
        /// <param name="appNamespace">The bundle identifier, package identifier, or namespace, depending on what the individual plattforms use,  .e.g com.microsoft.example. .</param>
        /// <param name="liveUpdateReleaseLabel">Label that is used to identify application code &#x27;version&#x27; released via Live Update beacon running on device .</param>
        /// <param name="liveUpdateDeploymentKey">Identifier of environment that current application release belongs to, deployment key then maps to environment like Production, Staging. .</param>
        /// <param name="liveUpdatePackageHash">Hash of all files (ReactNative or Cordova) deployed to device via LiveUpdate beacon. Helps identify the Release version on device or need to download updates in future. .</param>
        /// <param name="wrapperRuntimeVersion">Version of the wrapper technology framework (Xamarin runtime version or ReactNative or Cordova etc...). See wrapper_sdk_name to see if this version refers to Xamarin or ReactNative or other. .</param>
        public DeviceDiagnostics(string sdkName = default(string), string sdkVersion = default(string), string wrapperSdkVersion = default(string), string wrapperSdkName = default(string), string model = default(string), string oemName = default(string), string osName = default(string), string osVersion = default(string), string osBuild = default(string), int? osApiLevel = default(int?), string locale = default(string), int? timeZoneOffset = default(int?), string screenSize = default(string), string appVersion = default(string), string carrierName = default(string), string carrierCode = default(string), string carrierCountry = default(string), string appBuild = default(string), string appNamespace = default(string), string liveUpdateReleaseLabel = default(string), string liveUpdateDeploymentKey = default(string), string liveUpdatePackageHash = default(string), string wrapperRuntimeVersion = default(string))
        {
            // to ensure "sdkName" is required (not null)
            if (sdkName == null)
            {
                throw new InvalidDataException("sdkName is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.SdkName = sdkName;
            }
            // to ensure "sdkVersion" is required (not null)
            if (sdkVersion == null)
            {
                throw new InvalidDataException("sdkVersion is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.SdkVersion = sdkVersion;
            }
            // to ensure "osName" is required (not null)
            if (osName == null)
            {
                throw new InvalidDataException("osName is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.OsName = osName;
            }
            // to ensure "osVersion" is required (not null)
            if (osVersion == null)
            {
                throw new InvalidDataException("osVersion is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.OsVersion = osVersion;
            }
            // to ensure "locale" is required (not null)
            if (locale == null)
            {
                throw new InvalidDataException("locale is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.Locale = locale;
            }
            // to ensure "timeZoneOffset" is required (not null)
            if (timeZoneOffset == null)
            {
                throw new InvalidDataException("timeZoneOffset is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.TimeZoneOffset = timeZoneOffset;
            }
            // to ensure "appVersion" is required (not null)
            if (appVersion == null)
            {
                throw new InvalidDataException("appVersion is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.AppVersion = appVersion;
            }
            // to ensure "appBuild" is required (not null)
            if (appBuild == null)
            {
                throw new InvalidDataException("appBuild is a required property for DeviceDiagnostics and cannot be null");
            }
            else
            {
                this.AppBuild = appBuild;
            }
            this.WrapperSdkVersion = wrapperSdkVersion;
            this.WrapperSdkName = wrapperSdkName;
            this.Model = model;
            this.OemName = oemName;
            this.OsBuild = osBuild;
            this.OsApiLevel = osApiLevel;
            this.ScreenSize = screenSize;
            this.CarrierName = carrierName;
            this.CarrierCode = carrierCode;
            this.CarrierCountry = carrierCountry;
            this.AppNamespace = appNamespace;
            this.LiveUpdateReleaseLabel = liveUpdateReleaseLabel;
            this.LiveUpdateDeploymentKey = liveUpdateDeploymentKey;
            this.LiveUpdatePackageHash = liveUpdatePackageHash;
            this.WrapperRuntimeVersion = wrapperRuntimeVersion;
        }
        
        /// <summary>
        /// Name of the SDK. Consists of the name of the SDK and the platform, e.g. \&quot;appcenter.ios\&quot;, \&quot;hockeysdk.android\&quot;. 
        /// </summary>
        /// <value>Name of the SDK. Consists of the name of the SDK and the platform, e.g. \&quot;appcenter.ios\&quot;, \&quot;hockeysdk.android\&quot;. </value>
        [DataMember(Name="sdk_name", EmitDefaultValue=false)]
        public string SdkName { get; set; }

        /// <summary>
        /// Version of the SDK in semver format, e.g. \&quot;1.2.0\&quot; or \&quot;0.12.3-alpha.1\&quot;. 
        /// </summary>
        /// <value>Version of the SDK in semver format, e.g. \&quot;1.2.0\&quot; or \&quot;0.12.3-alpha.1\&quot;. </value>
        [DataMember(Name="sdk_version", EmitDefaultValue=false)]
        public string SdkVersion { get; set; }

        /// <summary>
        /// Version of the wrapper SDK in semver format. When the SDK is embedding another base SDK (for example Xamarin.Android wraps Android), the Xamarin specific version is populated into this field while sdkVersion refers to the original Android SDK. 
        /// </summary>
        /// <value>Version of the wrapper SDK in semver format. When the SDK is embedding another base SDK (for example Xamarin.Android wraps Android), the Xamarin specific version is populated into this field while sdkVersion refers to the original Android SDK. </value>
        [DataMember(Name="wrapper_sdk_version", EmitDefaultValue=false)]
        public string WrapperSdkVersion { get; set; }

        /// <summary>
        /// Name of the wrapper SDK. Consists of the name of the SDK and the wrapper platform, e.g. \&quot;appcenter.xamarin\&quot;, \&quot;hockeysdk.cordova\&quot;. 
        /// </summary>
        /// <value>Name of the wrapper SDK. Consists of the name of the SDK and the wrapper platform, e.g. \&quot;appcenter.xamarin\&quot;, \&quot;hockeysdk.cordova\&quot;. </value>
        [DataMember(Name="wrapper_sdk_name", EmitDefaultValue=false)]
        public string WrapperSdkName { get; set; }

        /// <summary>
        /// Device model (example: iPad2,3). 
        /// </summary>
        /// <value>Device model (example: iPad2,3). </value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Device manufacturer (example: HTC). 
        /// </summary>
        /// <value>Device manufacturer (example: HTC). </value>
        [DataMember(Name="oem_name", EmitDefaultValue=false)]
        public string OemName { get; set; }

        /// <summary>
        /// OS name (example: iOS). The following OS names are standardized (non-exclusive): Android, iOS, macOS, tvOS, Windows. 
        /// </summary>
        /// <value>OS name (example: iOS). The following OS names are standardized (non-exclusive): Android, iOS, macOS, tvOS, Windows. </value>
        [DataMember(Name="os_name", EmitDefaultValue=false)]
        public string OsName { get; set; }

        /// <summary>
        /// OS version (example: 9.3.0). 
        /// </summary>
        /// <value>OS version (example: 9.3.0). </value>
        [DataMember(Name="os_version", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// OS build code (example: LMY47X). 
        /// </summary>
        /// <value>OS build code (example: LMY47X). </value>
        [DataMember(Name="os_build", EmitDefaultValue=false)]
        public string OsBuild { get; set; }

        /// <summary>
        /// API level when applicable like in Android (example: 15). 
        /// </summary>
        /// <value>API level when applicable like in Android (example: 15). </value>
        [DataMember(Name="os_api_level", EmitDefaultValue=false)]
        public int? OsApiLevel { get; set; }

        /// <summary>
        /// Language code (example: en_US). 
        /// </summary>
        /// <value>Language code (example: en_US). </value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// The offset in minutes from UTC for the device time zone, including daylight savings time. 
        /// </summary>
        /// <value>The offset in minutes from UTC for the device time zone, including daylight savings time. </value>
        [DataMember(Name="time_zone_offset", EmitDefaultValue=false)]
        public int? TimeZoneOffset { get; set; }

        /// <summary>
        /// Screen size of the device in pixels (example: 640x480). 
        /// </summary>
        /// <value>Screen size of the device in pixels (example: 640x480). </value>
        [DataMember(Name="screen_size", EmitDefaultValue=false)]
        public string ScreenSize { get; set; }

        /// <summary>
        /// Application version name, e.g. 1.1.0 
        /// </summary>
        /// <value>Application version name, e.g. 1.1.0 </value>
        [DataMember(Name="app_version", EmitDefaultValue=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Carrier name (for mobile devices). 
        /// </summary>
        /// <value>Carrier name (for mobile devices). </value>
        [DataMember(Name="carrier_name", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Carrier country code (for mobile devices). 
        /// </summary>
        /// <value>Carrier country code (for mobile devices). </value>
        [DataMember(Name="carrier_code", EmitDefaultValue=false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Carrier country. 
        /// </summary>
        /// <value>Carrier country. </value>
        [DataMember(Name="carrier_country", EmitDefaultValue=false)]
        public string CarrierCountry { get; set; }

        /// <summary>
        /// The app&#x27;s build number, e.g. 42. 
        /// </summary>
        /// <value>The app&#x27;s build number, e.g. 42. </value>
        [DataMember(Name="app_build", EmitDefaultValue=false)]
        public string AppBuild { get; set; }

        /// <summary>
        /// The bundle identifier, package identifier, or namespace, depending on what the individual plattforms use,  .e.g com.microsoft.example. 
        /// </summary>
        /// <value>The bundle identifier, package identifier, or namespace, depending on what the individual plattforms use,  .e.g com.microsoft.example. </value>
        [DataMember(Name="app_namespace", EmitDefaultValue=false)]
        public string AppNamespace { get; set; }

        /// <summary>
        /// Label that is used to identify application code &#x27;version&#x27; released via Live Update beacon running on device 
        /// </summary>
        /// <value>Label that is used to identify application code &#x27;version&#x27; released via Live Update beacon running on device </value>
        [DataMember(Name="live_update_release_label", EmitDefaultValue=false)]
        public string LiveUpdateReleaseLabel { get; set; }

        /// <summary>
        /// Identifier of environment that current application release belongs to, deployment key then maps to environment like Production, Staging. 
        /// </summary>
        /// <value>Identifier of environment that current application release belongs to, deployment key then maps to environment like Production, Staging. </value>
        [DataMember(Name="live_update_deployment_key", EmitDefaultValue=false)]
        public string LiveUpdateDeploymentKey { get; set; }

        /// <summary>
        /// Hash of all files (ReactNative or Cordova) deployed to device via LiveUpdate beacon. Helps identify the Release version on device or need to download updates in future. 
        /// </summary>
        /// <value>Hash of all files (ReactNative or Cordova) deployed to device via LiveUpdate beacon. Helps identify the Release version on device or need to download updates in future. </value>
        [DataMember(Name="live_update_package_hash", EmitDefaultValue=false)]
        public string LiveUpdatePackageHash { get; set; }

        /// <summary>
        /// Version of the wrapper technology framework (Xamarin runtime version or ReactNative or Cordova etc...). See wrapper_sdk_name to see if this version refers to Xamarin or ReactNative or other. 
        /// </summary>
        /// <value>Version of the wrapper technology framework (Xamarin runtime version or ReactNative or Cordova etc...). See wrapper_sdk_name to see if this version refers to Xamarin or ReactNative or other. </value>
        [DataMember(Name="wrapper_runtime_version", EmitDefaultValue=false)]
        public string WrapperRuntimeVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceDiagnostics {\n");
            sb.Append("  SdkName: ").Append(SdkName).Append("\n");
            sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
            sb.Append("  WrapperSdkVersion: ").Append(WrapperSdkVersion).Append("\n");
            sb.Append("  WrapperSdkName: ").Append(WrapperSdkName).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  OemName: ").Append(OemName).Append("\n");
            sb.Append("  OsName: ").Append(OsName).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  OsBuild: ").Append(OsBuild).Append("\n");
            sb.Append("  OsApiLevel: ").Append(OsApiLevel).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  TimeZoneOffset: ").Append(TimeZoneOffset).Append("\n");
            sb.Append("  ScreenSize: ").Append(ScreenSize).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CarrierCountry: ").Append(CarrierCountry).Append("\n");
            sb.Append("  AppBuild: ").Append(AppBuild).Append("\n");
            sb.Append("  AppNamespace: ").Append(AppNamespace).Append("\n");
            sb.Append("  LiveUpdateReleaseLabel: ").Append(LiveUpdateReleaseLabel).Append("\n");
            sb.Append("  LiveUpdateDeploymentKey: ").Append(LiveUpdateDeploymentKey).Append("\n");
            sb.Append("  LiveUpdatePackageHash: ").Append(LiveUpdatePackageHash).Append("\n");
            sb.Append("  WrapperRuntimeVersion: ").Append(WrapperRuntimeVersion).Append("\n");
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
            return this.Equals(input as DeviceDiagnostics);
        }

        /// <summary>
        /// Returns true if DeviceDiagnostics instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceDiagnostics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceDiagnostics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SdkName == input.SdkName ||
                    (this.SdkName != null &&
                    this.SdkName.Equals(input.SdkName))
                ) && 
                (
                    this.SdkVersion == input.SdkVersion ||
                    (this.SdkVersion != null &&
                    this.SdkVersion.Equals(input.SdkVersion))
                ) && 
                (
                    this.WrapperSdkVersion == input.WrapperSdkVersion ||
                    (this.WrapperSdkVersion != null &&
                    this.WrapperSdkVersion.Equals(input.WrapperSdkVersion))
                ) && 
                (
                    this.WrapperSdkName == input.WrapperSdkName ||
                    (this.WrapperSdkName != null &&
                    this.WrapperSdkName.Equals(input.WrapperSdkName))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.OemName == input.OemName ||
                    (this.OemName != null &&
                    this.OemName.Equals(input.OemName))
                ) && 
                (
                    this.OsName == input.OsName ||
                    (this.OsName != null &&
                    this.OsName.Equals(input.OsName))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.OsBuild == input.OsBuild ||
                    (this.OsBuild != null &&
                    this.OsBuild.Equals(input.OsBuild))
                ) && 
                (
                    this.OsApiLevel == input.OsApiLevel ||
                    (this.OsApiLevel != null &&
                    this.OsApiLevel.Equals(input.OsApiLevel))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.TimeZoneOffset == input.TimeZoneOffset ||
                    (this.TimeZoneOffset != null &&
                    this.TimeZoneOffset.Equals(input.TimeZoneOffset))
                ) && 
                (
                    this.ScreenSize == input.ScreenSize ||
                    (this.ScreenSize != null &&
                    this.ScreenSize.Equals(input.ScreenSize))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.CarrierCountry == input.CarrierCountry ||
                    (this.CarrierCountry != null &&
                    this.CarrierCountry.Equals(input.CarrierCountry))
                ) && 
                (
                    this.AppBuild == input.AppBuild ||
                    (this.AppBuild != null &&
                    this.AppBuild.Equals(input.AppBuild))
                ) && 
                (
                    this.AppNamespace == input.AppNamespace ||
                    (this.AppNamespace != null &&
                    this.AppNamespace.Equals(input.AppNamespace))
                ) && 
                (
                    this.LiveUpdateReleaseLabel == input.LiveUpdateReleaseLabel ||
                    (this.LiveUpdateReleaseLabel != null &&
                    this.LiveUpdateReleaseLabel.Equals(input.LiveUpdateReleaseLabel))
                ) && 
                (
                    this.LiveUpdateDeploymentKey == input.LiveUpdateDeploymentKey ||
                    (this.LiveUpdateDeploymentKey != null &&
                    this.LiveUpdateDeploymentKey.Equals(input.LiveUpdateDeploymentKey))
                ) && 
                (
                    this.LiveUpdatePackageHash == input.LiveUpdatePackageHash ||
                    (this.LiveUpdatePackageHash != null &&
                    this.LiveUpdatePackageHash.Equals(input.LiveUpdatePackageHash))
                ) && 
                (
                    this.WrapperRuntimeVersion == input.WrapperRuntimeVersion ||
                    (this.WrapperRuntimeVersion != null &&
                    this.WrapperRuntimeVersion.Equals(input.WrapperRuntimeVersion))
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
                if (this.SdkName != null)
                    hashCode = hashCode * 59 + this.SdkName.GetHashCode();
                if (this.SdkVersion != null)
                    hashCode = hashCode * 59 + this.SdkVersion.GetHashCode();
                if (this.WrapperSdkVersion != null)
                    hashCode = hashCode * 59 + this.WrapperSdkVersion.GetHashCode();
                if (this.WrapperSdkName != null)
                    hashCode = hashCode * 59 + this.WrapperSdkName.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.OemName != null)
                    hashCode = hashCode * 59 + this.OemName.GetHashCode();
                if (this.OsName != null)
                    hashCode = hashCode * 59 + this.OsName.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.OsBuild != null)
                    hashCode = hashCode * 59 + this.OsBuild.GetHashCode();
                if (this.OsApiLevel != null)
                    hashCode = hashCode * 59 + this.OsApiLevel.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.TimeZoneOffset != null)
                    hashCode = hashCode * 59 + this.TimeZoneOffset.GetHashCode();
                if (this.ScreenSize != null)
                    hashCode = hashCode * 59 + this.ScreenSize.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.CarrierCode != null)
                    hashCode = hashCode * 59 + this.CarrierCode.GetHashCode();
                if (this.CarrierCountry != null)
                    hashCode = hashCode * 59 + this.CarrierCountry.GetHashCode();
                if (this.AppBuild != null)
                    hashCode = hashCode * 59 + this.AppBuild.GetHashCode();
                if (this.AppNamespace != null)
                    hashCode = hashCode * 59 + this.AppNamespace.GetHashCode();
                if (this.LiveUpdateReleaseLabel != null)
                    hashCode = hashCode * 59 + this.LiveUpdateReleaseLabel.GetHashCode();
                if (this.LiveUpdateDeploymentKey != null)
                    hashCode = hashCode * 59 + this.LiveUpdateDeploymentKey.GetHashCode();
                if (this.LiveUpdatePackageHash != null)
                    hashCode = hashCode * 59 + this.LiveUpdatePackageHash.GetHashCode();
                if (this.WrapperRuntimeVersion != null)
                    hashCode = hashCode * 59 + this.WrapperRuntimeVersion.GetHashCode();
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
