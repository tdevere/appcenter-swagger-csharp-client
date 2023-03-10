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
    /// Build configuration when Xcode is part of the build steps
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNamebranchesbranchconfigToolsetsXcode :  IEquatable<V01appsownerNameappNamebranchesbranchconfigToolsetsXcode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNamebranchesbranchconfigToolsetsXcode" /> class.
        /// </summary>
        /// <param name="projectOrWorkspacePath">Xcode project/workspace path.</param>
        /// <param name="podfilePath">Path to CococaPods file, if present.</param>
        /// <param name="cartfilePath">Path to Carthage file, if present.</param>
        /// <param name="provisioningProfileEncoded">provisioningProfileEncoded.</param>
        /// <param name="certificateEncoded">certificateEncoded.</param>
        /// <param name="provisioningProfileFileId">provisioningProfileFileId.</param>
        /// <param name="certificateFileId">certificateFileId.</param>
        /// <param name="provisioningProfileUploadId">provisioningProfileUploadId.</param>
        /// <param name="appExtensionProvisioningProfileFiles">appExtensionProvisioningProfileFiles.</param>
        /// <param name="certificateUploadId">certificateUploadId.</param>
        /// <param name="certificatePassword">certificatePassword.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="xcodeVersion">Xcode version used to build. Available versions can be found in \&quot;/xcode_versions\&quot; API. Default is latest stable version, at the time when the configuration is set..</param>
        /// <param name="provisioningProfileFilename">provisioningProfileFilename.</param>
        /// <param name="certificateFilename">certificateFilename.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="automaticSigning">automaticSigning.</param>
        /// <param name="xcodeProjectSha">The selected pbxproject hash to the repositroy.</param>
        /// <param name="archiveConfiguration">The build configuration of the target to archive.</param>
        /// <param name="targetToArchive">The target id of the selected scheme to archive.</param>
        /// <param name="forceLegacyBuildSystem">Setting this to true forces the build to use Xcode legacy build system. Otherwise, the setting from workspace settings is used. By default new build system is used if workspace setting is not committed to the repository. Only used for iOS React Native app, with Xcode 10. .</param>
        public V01appsownerNameappNamebranchesbranchconfigToolsetsXcode(string projectOrWorkspacePath = default(string), string podfilePath = default(string), string cartfilePath = default(string), string provisioningProfileEncoded = default(string), string certificateEncoded = default(string), string provisioningProfileFileId = default(string), string certificateFileId = default(string), string provisioningProfileUploadId = default(string), List<V01appsownerNameappNamebranchesbranchconfigToolsetsXcodeAppExtensionProvisioningProfileFiles> appExtensionProvisioningProfileFiles = default(List<V01appsownerNameappNamebranchesbranchconfigToolsetsXcodeAppExtensionProvisioningProfileFiles>), string certificateUploadId = default(string), string certificatePassword = default(string), string scheme = default(string), string xcodeVersion = default(string), string provisioningProfileFilename = default(string), string certificateFilename = default(string), string teamId = default(string), bool? automaticSigning = default(bool?), string xcodeProjectSha = default(string), string archiveConfiguration = default(string), string targetToArchive = default(string), bool? forceLegacyBuildSystem = default(bool?))
        {
            this.ProjectOrWorkspacePath = projectOrWorkspacePath;
            this.PodfilePath = podfilePath;
            this.CartfilePath = cartfilePath;
            this.ProvisioningProfileEncoded = provisioningProfileEncoded;
            this.CertificateEncoded = certificateEncoded;
            this.ProvisioningProfileFileId = provisioningProfileFileId;
            this.CertificateFileId = certificateFileId;
            this.ProvisioningProfileUploadId = provisioningProfileUploadId;
            this.AppExtensionProvisioningProfileFiles = appExtensionProvisioningProfileFiles;
            this.CertificateUploadId = certificateUploadId;
            this.CertificatePassword = certificatePassword;
            this.Scheme = scheme;
            this.XcodeVersion = xcodeVersion;
            this.ProvisioningProfileFilename = provisioningProfileFilename;
            this.CertificateFilename = certificateFilename;
            this.TeamId = teamId;
            this.AutomaticSigning = automaticSigning;
            this.XcodeProjectSha = xcodeProjectSha;
            this.ArchiveConfiguration = archiveConfiguration;
            this.TargetToArchive = targetToArchive;
            this.ForceLegacyBuildSystem = forceLegacyBuildSystem;
        }
        
        /// <summary>
        /// Xcode project/workspace path
        /// </summary>
        /// <value>Xcode project/workspace path</value>
        [DataMember(Name="projectOrWorkspacePath", EmitDefaultValue=false)]
        public string ProjectOrWorkspacePath { get; set; }

        /// <summary>
        /// Path to CococaPods file, if present
        /// </summary>
        /// <value>Path to CococaPods file, if present</value>
        [DataMember(Name="podfilePath", EmitDefaultValue=false)]
        public string PodfilePath { get; set; }

        /// <summary>
        /// Path to Carthage file, if present
        /// </summary>
        /// <value>Path to Carthage file, if present</value>
        [DataMember(Name="cartfilePath", EmitDefaultValue=false)]
        public string CartfilePath { get; set; }

        /// <summary>
        /// Gets or Sets ProvisioningProfileEncoded
        /// </summary>
        [DataMember(Name="provisioningProfileEncoded", EmitDefaultValue=false)]
        public string ProvisioningProfileEncoded { get; set; }

        /// <summary>
        /// Gets or Sets CertificateEncoded
        /// </summary>
        [DataMember(Name="certificateEncoded", EmitDefaultValue=false)]
        public string CertificateEncoded { get; set; }

        /// <summary>
        /// Gets or Sets ProvisioningProfileFileId
        /// </summary>
        [DataMember(Name="provisioningProfileFileId", EmitDefaultValue=false)]
        public string ProvisioningProfileFileId { get; set; }

        /// <summary>
        /// Gets or Sets CertificateFileId
        /// </summary>
        [DataMember(Name="certificateFileId", EmitDefaultValue=false)]
        public string CertificateFileId { get; set; }

        /// <summary>
        /// Gets or Sets ProvisioningProfileUploadId
        /// </summary>
        [DataMember(Name="provisioningProfileUploadId", EmitDefaultValue=false)]
        public string ProvisioningProfileUploadId { get; set; }

        /// <summary>
        /// Gets or Sets AppExtensionProvisioningProfileFiles
        /// </summary>
        [DataMember(Name="appExtensionProvisioningProfileFiles", EmitDefaultValue=false)]
        public List<V01appsownerNameappNamebranchesbranchconfigToolsetsXcodeAppExtensionProvisioningProfileFiles> AppExtensionProvisioningProfileFiles { get; set; }

        /// <summary>
        /// Gets or Sets CertificateUploadId
        /// </summary>
        [DataMember(Name="certificateUploadId", EmitDefaultValue=false)]
        public string CertificateUploadId { get; set; }

        /// <summary>
        /// Gets or Sets CertificatePassword
        /// </summary>
        [DataMember(Name="certificatePassword", EmitDefaultValue=false)]
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Xcode version used to build. Available versions can be found in \&quot;/xcode_versions\&quot; API. Default is latest stable version, at the time when the configuration is set.
        /// </summary>
        /// <value>Xcode version used to build. Available versions can be found in \&quot;/xcode_versions\&quot; API. Default is latest stable version, at the time when the configuration is set.</value>
        [DataMember(Name="xcodeVersion", EmitDefaultValue=false)]
        public string XcodeVersion { get; set; }

        /// <summary>
        /// Gets or Sets ProvisioningProfileFilename
        /// </summary>
        [DataMember(Name="provisioningProfileFilename", EmitDefaultValue=false)]
        public string ProvisioningProfileFilename { get; set; }

        /// <summary>
        /// Gets or Sets CertificateFilename
        /// </summary>
        [DataMember(Name="certificateFilename", EmitDefaultValue=false)]
        public string CertificateFilename { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticSigning
        /// </summary>
        [DataMember(Name="automaticSigning", EmitDefaultValue=false)]
        public bool? AutomaticSigning { get; set; }

        /// <summary>
        /// The selected pbxproject hash to the repositroy
        /// </summary>
        /// <value>The selected pbxproject hash to the repositroy</value>
        [DataMember(Name="xcodeProjectSha", EmitDefaultValue=false)]
        public string XcodeProjectSha { get; set; }

        /// <summary>
        /// The build configuration of the target to archive
        /// </summary>
        /// <value>The build configuration of the target to archive</value>
        [DataMember(Name="archiveConfiguration", EmitDefaultValue=false)]
        public string ArchiveConfiguration { get; set; }

        /// <summary>
        /// The target id of the selected scheme to archive
        /// </summary>
        /// <value>The target id of the selected scheme to archive</value>
        [DataMember(Name="targetToArchive", EmitDefaultValue=false)]
        public string TargetToArchive { get; set; }

        /// <summary>
        /// Setting this to true forces the build to use Xcode legacy build system. Otherwise, the setting from workspace settings is used. By default new build system is used if workspace setting is not committed to the repository. Only used for iOS React Native app, with Xcode 10. 
        /// </summary>
        /// <value>Setting this to true forces the build to use Xcode legacy build system. Otherwise, the setting from workspace settings is used. By default new build system is used if workspace setting is not committed to the repository. Only used for iOS React Native app, with Xcode 10. </value>
        [DataMember(Name="forceLegacyBuildSystem", EmitDefaultValue=false)]
        public bool? ForceLegacyBuildSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNamebranchesbranchconfigToolsetsXcode {\n");
            sb.Append("  ProjectOrWorkspacePath: ").Append(ProjectOrWorkspacePath).Append("\n");
            sb.Append("  PodfilePath: ").Append(PodfilePath).Append("\n");
            sb.Append("  CartfilePath: ").Append(CartfilePath).Append("\n");
            sb.Append("  ProvisioningProfileEncoded: ").Append(ProvisioningProfileEncoded).Append("\n");
            sb.Append("  CertificateEncoded: ").Append(CertificateEncoded).Append("\n");
            sb.Append("  ProvisioningProfileFileId: ").Append(ProvisioningProfileFileId).Append("\n");
            sb.Append("  CertificateFileId: ").Append(CertificateFileId).Append("\n");
            sb.Append("  ProvisioningProfileUploadId: ").Append(ProvisioningProfileUploadId).Append("\n");
            sb.Append("  AppExtensionProvisioningProfileFiles: ").Append(AppExtensionProvisioningProfileFiles).Append("\n");
            sb.Append("  CertificateUploadId: ").Append(CertificateUploadId).Append("\n");
            sb.Append("  CertificatePassword: ").Append(CertificatePassword).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  XcodeVersion: ").Append(XcodeVersion).Append("\n");
            sb.Append("  ProvisioningProfileFilename: ").Append(ProvisioningProfileFilename).Append("\n");
            sb.Append("  CertificateFilename: ").Append(CertificateFilename).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  AutomaticSigning: ").Append(AutomaticSigning).Append("\n");
            sb.Append("  XcodeProjectSha: ").Append(XcodeProjectSha).Append("\n");
            sb.Append("  ArchiveConfiguration: ").Append(ArchiveConfiguration).Append("\n");
            sb.Append("  TargetToArchive: ").Append(TargetToArchive).Append("\n");
            sb.Append("  ForceLegacyBuildSystem: ").Append(ForceLegacyBuildSystem).Append("\n");
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
            return this.Equals(input as V01appsownerNameappNamebranchesbranchconfigToolsetsXcode);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNamebranchesbranchconfigToolsetsXcode instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNamebranchesbranchconfigToolsetsXcode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNamebranchesbranchconfigToolsetsXcode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectOrWorkspacePath == input.ProjectOrWorkspacePath ||
                    (this.ProjectOrWorkspacePath != null &&
                    this.ProjectOrWorkspacePath.Equals(input.ProjectOrWorkspacePath))
                ) && 
                (
                    this.PodfilePath == input.PodfilePath ||
                    (this.PodfilePath != null &&
                    this.PodfilePath.Equals(input.PodfilePath))
                ) && 
                (
                    this.CartfilePath == input.CartfilePath ||
                    (this.CartfilePath != null &&
                    this.CartfilePath.Equals(input.CartfilePath))
                ) && 
                (
                    this.ProvisioningProfileEncoded == input.ProvisioningProfileEncoded ||
                    (this.ProvisioningProfileEncoded != null &&
                    this.ProvisioningProfileEncoded.Equals(input.ProvisioningProfileEncoded))
                ) && 
                (
                    this.CertificateEncoded == input.CertificateEncoded ||
                    (this.CertificateEncoded != null &&
                    this.CertificateEncoded.Equals(input.CertificateEncoded))
                ) && 
                (
                    this.ProvisioningProfileFileId == input.ProvisioningProfileFileId ||
                    (this.ProvisioningProfileFileId != null &&
                    this.ProvisioningProfileFileId.Equals(input.ProvisioningProfileFileId))
                ) && 
                (
                    this.CertificateFileId == input.CertificateFileId ||
                    (this.CertificateFileId != null &&
                    this.CertificateFileId.Equals(input.CertificateFileId))
                ) && 
                (
                    this.ProvisioningProfileUploadId == input.ProvisioningProfileUploadId ||
                    (this.ProvisioningProfileUploadId != null &&
                    this.ProvisioningProfileUploadId.Equals(input.ProvisioningProfileUploadId))
                ) && 
                (
                    this.AppExtensionProvisioningProfileFiles == input.AppExtensionProvisioningProfileFiles ||
                    this.AppExtensionProvisioningProfileFiles != null &&
                    input.AppExtensionProvisioningProfileFiles != null &&
                    this.AppExtensionProvisioningProfileFiles.SequenceEqual(input.AppExtensionProvisioningProfileFiles)
                ) && 
                (
                    this.CertificateUploadId == input.CertificateUploadId ||
                    (this.CertificateUploadId != null &&
                    this.CertificateUploadId.Equals(input.CertificateUploadId))
                ) && 
                (
                    this.CertificatePassword == input.CertificatePassword ||
                    (this.CertificatePassword != null &&
                    this.CertificatePassword.Equals(input.CertificatePassword))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
                ) && 
                (
                    this.XcodeVersion == input.XcodeVersion ||
                    (this.XcodeVersion != null &&
                    this.XcodeVersion.Equals(input.XcodeVersion))
                ) && 
                (
                    this.ProvisioningProfileFilename == input.ProvisioningProfileFilename ||
                    (this.ProvisioningProfileFilename != null &&
                    this.ProvisioningProfileFilename.Equals(input.ProvisioningProfileFilename))
                ) && 
                (
                    this.CertificateFilename == input.CertificateFilename ||
                    (this.CertificateFilename != null &&
                    this.CertificateFilename.Equals(input.CertificateFilename))
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.AutomaticSigning == input.AutomaticSigning ||
                    (this.AutomaticSigning != null &&
                    this.AutomaticSigning.Equals(input.AutomaticSigning))
                ) && 
                (
                    this.XcodeProjectSha == input.XcodeProjectSha ||
                    (this.XcodeProjectSha != null &&
                    this.XcodeProjectSha.Equals(input.XcodeProjectSha))
                ) && 
                (
                    this.ArchiveConfiguration == input.ArchiveConfiguration ||
                    (this.ArchiveConfiguration != null &&
                    this.ArchiveConfiguration.Equals(input.ArchiveConfiguration))
                ) && 
                (
                    this.TargetToArchive == input.TargetToArchive ||
                    (this.TargetToArchive != null &&
                    this.TargetToArchive.Equals(input.TargetToArchive))
                ) && 
                (
                    this.ForceLegacyBuildSystem == input.ForceLegacyBuildSystem ||
                    (this.ForceLegacyBuildSystem != null &&
                    this.ForceLegacyBuildSystem.Equals(input.ForceLegacyBuildSystem))
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
                if (this.ProjectOrWorkspacePath != null)
                    hashCode = hashCode * 59 + this.ProjectOrWorkspacePath.GetHashCode();
                if (this.PodfilePath != null)
                    hashCode = hashCode * 59 + this.PodfilePath.GetHashCode();
                if (this.CartfilePath != null)
                    hashCode = hashCode * 59 + this.CartfilePath.GetHashCode();
                if (this.ProvisioningProfileEncoded != null)
                    hashCode = hashCode * 59 + this.ProvisioningProfileEncoded.GetHashCode();
                if (this.CertificateEncoded != null)
                    hashCode = hashCode * 59 + this.CertificateEncoded.GetHashCode();
                if (this.ProvisioningProfileFileId != null)
                    hashCode = hashCode * 59 + this.ProvisioningProfileFileId.GetHashCode();
                if (this.CertificateFileId != null)
                    hashCode = hashCode * 59 + this.CertificateFileId.GetHashCode();
                if (this.ProvisioningProfileUploadId != null)
                    hashCode = hashCode * 59 + this.ProvisioningProfileUploadId.GetHashCode();
                if (this.AppExtensionProvisioningProfileFiles != null)
                    hashCode = hashCode * 59 + this.AppExtensionProvisioningProfileFiles.GetHashCode();
                if (this.CertificateUploadId != null)
                    hashCode = hashCode * 59 + this.CertificateUploadId.GetHashCode();
                if (this.CertificatePassword != null)
                    hashCode = hashCode * 59 + this.CertificatePassword.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
                if (this.XcodeVersion != null)
                    hashCode = hashCode * 59 + this.XcodeVersion.GetHashCode();
                if (this.ProvisioningProfileFilename != null)
                    hashCode = hashCode * 59 + this.ProvisioningProfileFilename.GetHashCode();
                if (this.CertificateFilename != null)
                    hashCode = hashCode * 59 + this.CertificateFilename.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.AutomaticSigning != null)
                    hashCode = hashCode * 59 + this.AutomaticSigning.GetHashCode();
                if (this.XcodeProjectSha != null)
                    hashCode = hashCode * 59 + this.XcodeProjectSha.GetHashCode();
                if (this.ArchiveConfiguration != null)
                    hashCode = hashCode * 59 + this.ArchiveConfiguration.GetHashCode();
                if (this.TargetToArchive != null)
                    hashCode = hashCode * 59 + this.TargetToArchive.GetHashCode();
                if (this.ForceLegacyBuildSystem != null)
                    hashCode = hashCode * 59 + this.ForceLegacyBuildSystem.GetHashCode();
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
