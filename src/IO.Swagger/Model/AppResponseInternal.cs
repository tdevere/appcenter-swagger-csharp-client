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
    /// AppResponseInternal
    /// </summary>
    [DataContract]
        public partial class AppResponseInternal :  IEquatable<AppResponseInternal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppResponseInternal" /> class.
        /// </summary>
        /// <param name="featureFlags">The feature flags that are enabled for this app.</param>
        /// <param name="repositories">The repositories associated with this app.</param>
        /// <param name="userPermissions">userPermissions.</param>
        /// <param name="cutoverFromHockeyappAt">The cutover date of this app.</param>
        public AppResponseInternal(List<string> featureFlags = default(List<string>), List<AppResponseInternalRepositories> repositories = default(List<AppResponseInternalRepositories>), AppResponseInternalUserPermissions userPermissions = default(AppResponseInternalUserPermissions), string cutoverFromHockeyappAt = default(string))
        {
            this.FeatureFlags = featureFlags;
            this.Repositories = repositories;
            this.UserPermissions = userPermissions;
            this.CutoverFromHockeyappAt = cutoverFromHockeyappAt;
        }
        
        /// <summary>
        /// The feature flags that are enabled for this app
        /// </summary>
        /// <value>The feature flags that are enabled for this app</value>
        [DataMember(Name="feature_flags", EmitDefaultValue=false)]
        public List<string> FeatureFlags { get; set; }

        /// <summary>
        /// The repositories associated with this app
        /// </summary>
        /// <value>The repositories associated with this app</value>
        [DataMember(Name="repositories", EmitDefaultValue=false)]
        public List<AppResponseInternalRepositories> Repositories { get; set; }

        /// <summary>
        /// Gets or Sets UserPermissions
        /// </summary>
        [DataMember(Name="user_permissions", EmitDefaultValue=false)]
        public AppResponseInternalUserPermissions UserPermissions { get; set; }

        /// <summary>
        /// The cutover date of this app
        /// </summary>
        /// <value>The cutover date of this app</value>
        [DataMember(Name="cutover_from_hockeyapp_at", EmitDefaultValue=false)]
        public string CutoverFromHockeyappAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppResponseInternal {\n");
            sb.Append("  FeatureFlags: ").Append(FeatureFlags).Append("\n");
            sb.Append("  Repositories: ").Append(Repositories).Append("\n");
            sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
            sb.Append("  CutoverFromHockeyappAt: ").Append(CutoverFromHockeyappAt).Append("\n");
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
            return this.Equals(input as AppResponseInternal);
        }

        /// <summary>
        /// Returns true if AppResponseInternal instances are equal
        /// </summary>
        /// <param name="input">Instance of AppResponseInternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppResponseInternal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureFlags == input.FeatureFlags ||
                    this.FeatureFlags != null &&
                    input.FeatureFlags != null &&
                    this.FeatureFlags.SequenceEqual(input.FeatureFlags)
                ) && 
                (
                    this.Repositories == input.Repositories ||
                    this.Repositories != null &&
                    input.Repositories != null &&
                    this.Repositories.SequenceEqual(input.Repositories)
                ) && 
                (
                    this.UserPermissions == input.UserPermissions ||
                    (this.UserPermissions != null &&
                    this.UserPermissions.Equals(input.UserPermissions))
                ) && 
                (
                    this.CutoverFromHockeyappAt == input.CutoverFromHockeyappAt ||
                    (this.CutoverFromHockeyappAt != null &&
                    this.CutoverFromHockeyappAt.Equals(input.CutoverFromHockeyappAt))
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
                if (this.FeatureFlags != null)
                    hashCode = hashCode * 59 + this.FeatureFlags.GetHashCode();
                if (this.Repositories != null)
                    hashCode = hashCode * 59 + this.Repositories.GetHashCode();
                if (this.UserPermissions != null)
                    hashCode = hashCode * 59 + this.UserPermissions.GetHashCode();
                if (this.CutoverFromHockeyappAt != null)
                    hashCode = hashCode * 59 + this.CutoverFromHockeyappAt.GetHashCode();
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
