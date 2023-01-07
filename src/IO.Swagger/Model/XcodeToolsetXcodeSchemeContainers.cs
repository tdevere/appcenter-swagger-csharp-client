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
    /// XcodeToolsetXcodeSchemeContainers
    /// </summary>
    [DataContract]
        public partial class XcodeToolsetXcodeSchemeContainers :  IEquatable<XcodeToolsetXcodeSchemeContainers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeToolsetXcodeSchemeContainers" /> class.
        /// </summary>
        /// <param name="path">Path to project (required).</param>
        /// <param name="sharedSchemes">Project schemes (required).</param>
        /// <param name="podfilePath">Path to CocoaPods file, if present.</param>
        /// <param name="cartfilePath">Path to Carthage file, if present.</param>
        /// <param name="xcodeProjectSha">repo object Id of the pbxproject.</param>
        /// <param name="workspaceProjectPaths">Related projects paths for xcworkspace.</param>
        /// <param name="appExtensionTargets">Information regarding project app extensions, if present.</param>
        public XcodeToolsetXcodeSchemeContainers(string path = default(string), List<XcodeToolsetSharedSchemes> sharedSchemes = default(List<XcodeToolsetSharedSchemes>), string podfilePath = default(string), string cartfilePath = default(string), string xcodeProjectSha = default(string), string workspaceProjectPaths = default(string), List<XcodeToolsetAppExtensionTargets> appExtensionTargets = default(List<XcodeToolsetAppExtensionTargets>))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for XcodeToolsetXcodeSchemeContainers and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            // to ensure "sharedSchemes" is required (not null)
            if (sharedSchemes == null)
            {
                throw new InvalidDataException("sharedSchemes is a required property for XcodeToolsetXcodeSchemeContainers and cannot be null");
            }
            else
            {
                this.SharedSchemes = sharedSchemes;
            }
            this.PodfilePath = podfilePath;
            this.CartfilePath = cartfilePath;
            this.XcodeProjectSha = xcodeProjectSha;
            this.WorkspaceProjectPaths = workspaceProjectPaths;
            this.AppExtensionTargets = appExtensionTargets;
        }
        
        /// <summary>
        /// Path to project
        /// </summary>
        /// <value>Path to project</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Project schemes
        /// </summary>
        /// <value>Project schemes</value>
        [DataMember(Name="sharedSchemes", EmitDefaultValue=false)]
        public List<XcodeToolsetSharedSchemes> SharedSchemes { get; set; }

        /// <summary>
        /// Path to CocoaPods file, if present
        /// </summary>
        /// <value>Path to CocoaPods file, if present</value>
        [DataMember(Name="podfilePath", EmitDefaultValue=false)]
        public string PodfilePath { get; set; }

        /// <summary>
        /// Path to Carthage file, if present
        /// </summary>
        /// <value>Path to Carthage file, if present</value>
        [DataMember(Name="cartfilePath", EmitDefaultValue=false)]
        public string CartfilePath { get; set; }

        /// <summary>
        /// repo object Id of the pbxproject
        /// </summary>
        /// <value>repo object Id of the pbxproject</value>
        [DataMember(Name="xcodeProjectSha", EmitDefaultValue=false)]
        public string XcodeProjectSha { get; set; }

        /// <summary>
        /// Related projects paths for xcworkspace
        /// </summary>
        /// <value>Related projects paths for xcworkspace</value>
        [DataMember(Name="workspaceProjectPaths", EmitDefaultValue=false)]
        public string WorkspaceProjectPaths { get; set; }

        /// <summary>
        /// Information regarding project app extensions, if present
        /// </summary>
        /// <value>Information regarding project app extensions, if present</value>
        [DataMember(Name="appExtensionTargets", EmitDefaultValue=false)]
        public List<XcodeToolsetAppExtensionTargets> AppExtensionTargets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XcodeToolsetXcodeSchemeContainers {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  SharedSchemes: ").Append(SharedSchemes).Append("\n");
            sb.Append("  PodfilePath: ").Append(PodfilePath).Append("\n");
            sb.Append("  CartfilePath: ").Append(CartfilePath).Append("\n");
            sb.Append("  XcodeProjectSha: ").Append(XcodeProjectSha).Append("\n");
            sb.Append("  WorkspaceProjectPaths: ").Append(WorkspaceProjectPaths).Append("\n");
            sb.Append("  AppExtensionTargets: ").Append(AppExtensionTargets).Append("\n");
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
            return this.Equals(input as XcodeToolsetXcodeSchemeContainers);
        }

        /// <summary>
        /// Returns true if XcodeToolsetXcodeSchemeContainers instances are equal
        /// </summary>
        /// <param name="input">Instance of XcodeToolsetXcodeSchemeContainers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XcodeToolsetXcodeSchemeContainers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.SharedSchemes == input.SharedSchemes ||
                    this.SharedSchemes != null &&
                    input.SharedSchemes != null &&
                    this.SharedSchemes.SequenceEqual(input.SharedSchemes)
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
                    this.XcodeProjectSha == input.XcodeProjectSha ||
                    (this.XcodeProjectSha != null &&
                    this.XcodeProjectSha.Equals(input.XcodeProjectSha))
                ) && 
                (
                    this.WorkspaceProjectPaths == input.WorkspaceProjectPaths ||
                    (this.WorkspaceProjectPaths != null &&
                    this.WorkspaceProjectPaths.Equals(input.WorkspaceProjectPaths))
                ) && 
                (
                    this.AppExtensionTargets == input.AppExtensionTargets ||
                    this.AppExtensionTargets != null &&
                    input.AppExtensionTargets != null &&
                    this.AppExtensionTargets.SequenceEqual(input.AppExtensionTargets)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.SharedSchemes != null)
                    hashCode = hashCode * 59 + this.SharedSchemes.GetHashCode();
                if (this.PodfilePath != null)
                    hashCode = hashCode * 59 + this.PodfilePath.GetHashCode();
                if (this.CartfilePath != null)
                    hashCode = hashCode * 59 + this.CartfilePath.GetHashCode();
                if (this.XcodeProjectSha != null)
                    hashCode = hashCode * 59 + this.XcodeProjectSha.GetHashCode();
                if (this.WorkspaceProjectPaths != null)
                    hashCode = hashCode * 59 + this.WorkspaceProjectPaths.GetHashCode();
                if (this.AppExtensionTargets != null)
                    hashCode = hashCode * 59 + this.AppExtensionTargets.GetHashCode();
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
