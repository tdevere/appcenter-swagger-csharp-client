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
    /// Basic information on a release
    /// </summary>
    [DataContract]
        public partial class InlineResponse20033 :  IEquatable<InlineResponse20033>, IValidatableObject
    {
        /// <summary>
        /// The release&#x27;s origin
        /// </summary>
        /// <value>The release&#x27;s origin</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OriginEnum
        {
            /// <summary>
            /// Enum Hockeyapp for value: hockeyapp
            /// </summary>
            [EnumMember(Value = "hockeyapp")]
            Hockeyapp = 1,
            /// <summary>
            /// Enum Appcenter for value: appcenter
            /// </summary>
            [EnumMember(Value = "appcenter")]
            Appcenter = 2        }
        /// <summary>
        /// The release&#x27;s origin
        /// </summary>
        /// <value>The release&#x27;s origin</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt; 
        /// </summary>
        /// <value>OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt; </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DestinationTypeEnum
        {
            /// <summary>
            /// Enum Group for value: group
            /// </summary>
            [EnumMember(Value = "group")]
            Group = 1,
            /// <summary>
            /// Enum Store for value: store
            /// </summary>
            [EnumMember(Value = "store")]
            Store = 2,
            /// <summary>
            /// Enum Tester for value: tester
            /// </summary>
            [EnumMember(Value = "tester")]
            Tester = 3        }
        /// <summary>
        /// OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt; 
        /// </summary>
        /// <value>OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt; </value>
        [DataMember(Name="destination_type", EmitDefaultValue=false)]
        public DestinationTypeEnum? DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20033" /> class.
        /// </summary>
        /// <param name="id">ID identifying this unique release. (required).</param>
        /// <param name="version">The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml.  (required).</param>
        /// <param name="origin">The release&#x27;s origin.</param>
        /// <param name="shortVersion">The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml.  (required).</param>
        /// <param name="enabled">This value determines the whether a release currently is enabled or disabled. (required).</param>
        /// <param name="uploadedAt">UTC time in ISO 8601 format of the uploaded time. (required).</param>
        /// <param name="destinationType">OBSOLETE. Will be removed in next version. The destination type.&lt;br&gt; &lt;b&gt;group&lt;/b&gt;: The release distributed to internal groups and distribution_groups details will be returned.&lt;br&gt; &lt;b&gt;store&lt;/b&gt;: The release distributed to external stores and distribution_stores details will be returned. &lt;br&gt; .</param>
        /// <param name="distributionGroups">OBSOLETE. Will be removed in next version. A list of distribution groups that are associated with this release..</param>
        /// <param name="distributionStores">OBSOLETE. Will be removed in next version. A list of distribution stores that are associated with this release..</param>
        /// <param name="destinations">A list of distribution groups or stores..</param>
        /// <param name="build">build.</param>
        /// <param name="isExternalBuild">This value determines if a release is external or not..</param>
        /// <param name="fileExtension">The file extension of the main (user-uploaded) package file..</param>
        public InlineResponse20033(int? id = default(int?), string version = default(string), OriginEnum? origin = default(OriginEnum?), string shortVersion = default(string), bool? enabled = default(bool?), string uploadedAt = default(string), DestinationTypeEnum? destinationType = default(DestinationTypeEnum?), List<AllOfinlineResponse20033DistributionGroupsItems> distributionGroups = default(List<AllOfinlineResponse20033DistributionGroupsItems>), List<AllOfinlineResponse20033DistributionStoresItems> distributionStores = default(List<AllOfinlineResponse20033DistributionStoresItems>), List<AllOfinlineResponse20033DestinationsItems> destinations = default(List<AllOfinlineResponse20033DestinationsItems>), V01appsownerNameappNamereleasesfilterByTesterBuild build = default(V01appsownerNameappNamereleasesfilterByTesterBuild), bool? isExternalBuild = default(bool?), string fileExtension = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InlineResponse20033 and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for InlineResponse20033 and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            // to ensure "shortVersion" is required (not null)
            if (shortVersion == null)
            {
                throw new InvalidDataException("shortVersion is a required property for InlineResponse20033 and cannot be null");
            }
            else
            {
                this.ShortVersion = shortVersion;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for InlineResponse20033 and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "uploadedAt" is required (not null)
            if (uploadedAt == null)
            {
                throw new InvalidDataException("uploadedAt is a required property for InlineResponse20033 and cannot be null");
            }
            else
            {
                this.UploadedAt = uploadedAt;
            }
            this.Origin = origin;
            this.DestinationType = destinationType;
            this.DistributionGroups = distributionGroups;
            this.DistributionStores = distributionStores;
            this.Destinations = destinations;
            this.Build = build;
            this.IsExternalBuild = isExternalBuild;
            this.FileExtension = fileExtension;
        }
        
        /// <summary>
        /// ID identifying this unique release.
        /// </summary>
        /// <value>ID identifying this unique release.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. 
        /// </summary>
        /// <value>The release&#x27;s version.&lt;br&gt; For iOS: CFBundleVersion from info.plist.&lt;br&gt; For Android: android:versionCode from AppManifest.xml. </value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }


        /// <summary>
        /// The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. 
        /// </summary>
        /// <value>The release&#x27;s short version.&lt;br&gt; For iOS: CFBundleShortVersionString from info.plist.&lt;br&gt; For Android: android:versionName from AppManifest.xml. </value>
        [DataMember(Name="short_version", EmitDefaultValue=false)]
        public string ShortVersion { get; set; }

        /// <summary>
        /// This value determines the whether a release currently is enabled or disabled.
        /// </summary>
        /// <value>This value determines the whether a release currently is enabled or disabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// UTC time in ISO 8601 format of the uploaded time.
        /// </summary>
        /// <value>UTC time in ISO 8601 format of the uploaded time.</value>
        [DataMember(Name="uploaded_at", EmitDefaultValue=false)]
        public string UploadedAt { get; set; }


        /// <summary>
        /// OBSOLETE. Will be removed in next version. A list of distribution groups that are associated with this release.
        /// </summary>
        /// <value>OBSOLETE. Will be removed in next version. A list of distribution groups that are associated with this release.</value>
        [DataMember(Name="distribution_groups", EmitDefaultValue=false)]
        public List<AllOfinlineResponse20033DistributionGroupsItems> DistributionGroups { get; set; }

        /// <summary>
        /// OBSOLETE. Will be removed in next version. A list of distribution stores that are associated with this release.
        /// </summary>
        /// <value>OBSOLETE. Will be removed in next version. A list of distribution stores that are associated with this release.</value>
        [DataMember(Name="distribution_stores", EmitDefaultValue=false)]
        public List<AllOfinlineResponse20033DistributionStoresItems> DistributionStores { get; set; }

        /// <summary>
        /// A list of distribution groups or stores.
        /// </summary>
        /// <value>A list of distribution groups or stores.</value>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<AllOfinlineResponse20033DestinationsItems> Destinations { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public V01appsownerNameappNamereleasesfilterByTesterBuild Build { get; set; }

        /// <summary>
        /// This value determines if a release is external or not.
        /// </summary>
        /// <value>This value determines if a release is external or not.</value>
        [DataMember(Name="is_external_build", EmitDefaultValue=false)]
        public bool? IsExternalBuild { get; set; }

        /// <summary>
        /// The file extension of the main (user-uploaded) package file.
        /// </summary>
        /// <value>The file extension of the main (user-uploaded) package file.</value>
        [DataMember(Name="file_extension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20033 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  ShortVersion: ").Append(ShortVersion).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  UploadedAt: ").Append(UploadedAt).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  DistributionGroups: ").Append(DistributionGroups).Append("\n");
            sb.Append("  DistributionStores: ").Append(DistributionStores).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  IsExternalBuild: ").Append(IsExternalBuild).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
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
            return this.Equals(input as InlineResponse20033);
        }

        /// <summary>
        /// Returns true if InlineResponse20033 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20033 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20033 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.ShortVersion == input.ShortVersion ||
                    (this.ShortVersion != null &&
                    this.ShortVersion.Equals(input.ShortVersion))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.UploadedAt == input.UploadedAt ||
                    (this.UploadedAt != null &&
                    this.UploadedAt.Equals(input.UploadedAt))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.DistributionGroups == input.DistributionGroups ||
                    this.DistributionGroups != null &&
                    input.DistributionGroups != null &&
                    this.DistributionGroups.SequenceEqual(input.DistributionGroups)
                ) && 
                (
                    this.DistributionStores == input.DistributionStores ||
                    this.DistributionStores != null &&
                    input.DistributionStores != null &&
                    this.DistributionStores.SequenceEqual(input.DistributionStores)
                ) && 
                (
                    this.Destinations == input.Destinations ||
                    this.Destinations != null &&
                    input.Destinations != null &&
                    this.Destinations.SequenceEqual(input.Destinations)
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.IsExternalBuild == input.IsExternalBuild ||
                    (this.IsExternalBuild != null &&
                    this.IsExternalBuild.Equals(input.IsExternalBuild))
                ) && 
                (
                    this.FileExtension == input.FileExtension ||
                    (this.FileExtension != null &&
                    this.FileExtension.Equals(input.FileExtension))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.ShortVersion != null)
                    hashCode = hashCode * 59 + this.ShortVersion.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.UploadedAt != null)
                    hashCode = hashCode * 59 + this.UploadedAt.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.DistributionGroups != null)
                    hashCode = hashCode * 59 + this.DistributionGroups.GetHashCode();
                if (this.DistributionStores != null)
                    hashCode = hashCode * 59 + this.DistributionStores.GetHashCode();
                if (this.Destinations != null)
                    hashCode = hashCode * 59 + this.Destinations.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.IsExternalBuild != null)
                    hashCode = hashCode * 59 + this.IsExternalBuild.GetHashCode();
                if (this.FileExtension != null)
                    hashCode = hashCode * 59 + this.FileExtension.GetHashCode();
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
