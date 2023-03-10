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
    /// DistributionGroupResponse
    /// </summary>
    [DataContract]
        public partial class DistributionGroupResponse :  IEquatable<DistributionGroupResponse>, IValidatableObject
    {
        /// <summary>
        /// The creation origin of this distribution group
        /// </summary>
        /// <value>The creation origin of this distribution group</value>
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
            Hockeyapp = 2        }
        /// <summary>
        /// The creation origin of this distribution group
        /// </summary>
        /// <value>The creation origin of this distribution group</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupResponse" /> class.
        /// </summary>
        /// <param name="id">The unique ID of the distribution group (required).</param>
        /// <param name="name">The name of the distribution group used in URLs (required).</param>
        /// <param name="displayName">The name of the distribution group.</param>
        /// <param name="origin">The creation origin of this distribution group (required).</param>
        /// <param name="isPublic">Whether the distribution group is public (required).</param>
        public DistributionGroupResponse(Guid? id = default(Guid?), string name = default(string), string displayName = default(string), OriginEnum origin = default(OriginEnum), bool? isPublic = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DistributionGroupResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DistributionGroupResponse and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "origin" is required (not null)
            if (origin == null)
            {
                throw new InvalidDataException("origin is a required property for DistributionGroupResponse and cannot be null");
            }
            else
            {
                this.Origin = origin;
            }
            // to ensure "isPublic" is required (not null)
            if (isPublic == null)
            {
                throw new InvalidDataException("isPublic is a required property for DistributionGroupResponse and cannot be null");
            }
            else
            {
                this.IsPublic = isPublic;
            }
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// The unique ID of the distribution group
        /// </summary>
        /// <value>The unique ID of the distribution group</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the distribution group used in URLs
        /// </summary>
        /// <value>The name of the distribution group used in URLs</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the distribution group
        /// </summary>
        /// <value>The name of the distribution group</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }


        /// <summary>
        /// Whether the distribution group is public
        /// </summary>
        /// <value>Whether the distribution group is public</value>
        [DataMember(Name="is_public", EmitDefaultValue=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
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
            return this.Equals(input as DistributionGroupResponse);
        }

        /// <summary>
        /// Returns true if DistributionGroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupResponse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
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
