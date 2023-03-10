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
    /// CodePushUploadedRelease
    /// </summary>
    [DataContract]
        public partial class CodePushUploadedRelease :  IEquatable<CodePushUploadedRelease>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodePushUploadedRelease" /> class.
        /// </summary>
        /// <param name="releaseUpload">releaseUpload (required).</param>
        /// <param name="targetBinaryVersion">the binary version of the application (required).</param>
        /// <param name="deploymentName">This specifies which deployment you want to release the update to. Default is Staging..</param>
        /// <param name="description">This provides an optional \&quot;change log\&quot; for the deployment..</param>
        /// <param name="disabled">This specifies whether an update should be downloadable by end users or not..</param>
        /// <param name="mandatory">This specifies whether the update should be considered mandatory or not (e.g. it includes a critical security fix)..</param>
        /// <param name="noDuplicateReleaseError">This specifies that if the update is identical to the latest release on the deployment, the CLI should generate a warning instead of an error..</param>
        /// <param name="rollout">This specifies the percentage of users (as an integer between 1 and 100) that should be eligible to receive this update..</param>
        public CodePushUploadedRelease(V01appsownerNameappNamedeploymentsdeploymentNamereleasesReleaseUpload releaseUpload = default(V01appsownerNameappNamedeploymentsdeploymentNamereleasesReleaseUpload), string targetBinaryVersion = default(string), string deploymentName = default(string), string description = default(string), bool? disabled = default(bool?), bool? mandatory = default(bool?), bool? noDuplicateReleaseError = default(bool?), int? rollout = default(int?))
        {
            // to ensure "releaseUpload" is required (not null)
            if (releaseUpload == null)
            {
                throw new InvalidDataException("releaseUpload is a required property for CodePushUploadedRelease and cannot be null");
            }
            else
            {
                this.ReleaseUpload = releaseUpload;
            }
            // to ensure "targetBinaryVersion" is required (not null)
            if (targetBinaryVersion == null)
            {
                throw new InvalidDataException("targetBinaryVersion is a required property for CodePushUploadedRelease and cannot be null");
            }
            else
            {
                this.TargetBinaryVersion = targetBinaryVersion;
            }
            this.DeploymentName = deploymentName;
            this.Description = description;
            this.Disabled = disabled;
            this.Mandatory = mandatory;
            this.NoDuplicateReleaseError = noDuplicateReleaseError;
            this.Rollout = rollout;
        }
        
        /// <summary>
        /// Gets or Sets ReleaseUpload
        /// </summary>
        [DataMember(Name="release_upload", EmitDefaultValue=false)]
        public V01appsownerNameappNamedeploymentsdeploymentNamereleasesReleaseUpload ReleaseUpload { get; set; }

        /// <summary>
        /// the binary version of the application
        /// </summary>
        /// <value>the binary version of the application</value>
        [DataMember(Name="target_binary_version", EmitDefaultValue=false)]
        public string TargetBinaryVersion { get; set; }

        /// <summary>
        /// This specifies which deployment you want to release the update to. Default is Staging.
        /// </summary>
        /// <value>This specifies which deployment you want to release the update to. Default is Staging.</value>
        [DataMember(Name="deployment_name", EmitDefaultValue=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// This provides an optional \&quot;change log\&quot; for the deployment.
        /// </summary>
        /// <value>This provides an optional \&quot;change log\&quot; for the deployment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// This specifies whether an update should be downloadable by end users or not.
        /// </summary>
        /// <value>This specifies whether an update should be downloadable by end users or not.</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// This specifies whether the update should be considered mandatory or not (e.g. it includes a critical security fix).
        /// </summary>
        /// <value>This specifies whether the update should be considered mandatory or not (e.g. it includes a critical security fix).</value>
        [DataMember(Name="mandatory", EmitDefaultValue=false)]
        public bool? Mandatory { get; set; }

        /// <summary>
        /// This specifies that if the update is identical to the latest release on the deployment, the CLI should generate a warning instead of an error.
        /// </summary>
        /// <value>This specifies that if the update is identical to the latest release on the deployment, the CLI should generate a warning instead of an error.</value>
        [DataMember(Name="no_duplicate_release_error", EmitDefaultValue=false)]
        public bool? NoDuplicateReleaseError { get; set; }

        /// <summary>
        /// This specifies the percentage of users (as an integer between 1 and 100) that should be eligible to receive this update.
        /// </summary>
        /// <value>This specifies the percentage of users (as an integer between 1 and 100) that should be eligible to receive this update.</value>
        [DataMember(Name="rollout", EmitDefaultValue=false)]
        public int? Rollout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodePushUploadedRelease {\n");
            sb.Append("  ReleaseUpload: ").Append(ReleaseUpload).Append("\n");
            sb.Append("  TargetBinaryVersion: ").Append(TargetBinaryVersion).Append("\n");
            sb.Append("  DeploymentName: ").Append(DeploymentName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Mandatory: ").Append(Mandatory).Append("\n");
            sb.Append("  NoDuplicateReleaseError: ").Append(NoDuplicateReleaseError).Append("\n");
            sb.Append("  Rollout: ").Append(Rollout).Append("\n");
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
            return this.Equals(input as CodePushUploadedRelease);
        }

        /// <summary>
        /// Returns true if CodePushUploadedRelease instances are equal
        /// </summary>
        /// <param name="input">Instance of CodePushUploadedRelease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodePushUploadedRelease input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReleaseUpload == input.ReleaseUpload ||
                    (this.ReleaseUpload != null &&
                    this.ReleaseUpload.Equals(input.ReleaseUpload))
                ) && 
                (
                    this.TargetBinaryVersion == input.TargetBinaryVersion ||
                    (this.TargetBinaryVersion != null &&
                    this.TargetBinaryVersion.Equals(input.TargetBinaryVersion))
                ) && 
                (
                    this.DeploymentName == input.DeploymentName ||
                    (this.DeploymentName != null &&
                    this.DeploymentName.Equals(input.DeploymentName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.Mandatory == input.Mandatory ||
                    (this.Mandatory != null &&
                    this.Mandatory.Equals(input.Mandatory))
                ) && 
                (
                    this.NoDuplicateReleaseError == input.NoDuplicateReleaseError ||
                    (this.NoDuplicateReleaseError != null &&
                    this.NoDuplicateReleaseError.Equals(input.NoDuplicateReleaseError))
                ) && 
                (
                    this.Rollout == input.Rollout ||
                    (this.Rollout != null &&
                    this.Rollout.Equals(input.Rollout))
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
                if (this.ReleaseUpload != null)
                    hashCode = hashCode * 59 + this.ReleaseUpload.GetHashCode();
                if (this.TargetBinaryVersion != null)
                    hashCode = hashCode * 59 + this.TargetBinaryVersion.GetHashCode();
                if (this.DeploymentName != null)
                    hashCode = hashCode * 59 + this.DeploymentName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Mandatory != null)
                    hashCode = hashCode * 59 + this.Mandatory.GetHashCode();
                if (this.NoDuplicateReleaseError != null)
                    hashCode = hashCode * 59 + this.NoDuplicateReleaseError.GetHashCode();
                if (this.Rollout != null)
                    hashCode = hashCode * 59 + this.Rollout.GetHashCode();
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
