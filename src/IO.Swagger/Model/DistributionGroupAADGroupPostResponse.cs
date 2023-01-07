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
    /// DistributionGroupAADGroupPostResponse
    /// </summary>
    [DataContract]
        public partial class DistributionGroupAADGroupPostResponse :  IEquatable<DistributionGroupAADGroupPostResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributionGroupAADGroupPostResponse" /> class.
        /// </summary>
        /// <param name="id">The internal unique id (UUID) of the AAD group..</param>
        /// <param name="aadGroupId">The AAD unique id (UUID) of the AAD group..</param>
        /// <param name="displayName">The display name of the AAD group.</param>
        public DistributionGroupAADGroupPostResponse(Guid? id = default(Guid?), Guid? aadGroupId = default(Guid?), string displayName = default(string))
        {
            this.Id = id;
            this.AadGroupId = aadGroupId;
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// The internal unique id (UUID) of the AAD group.
        /// </summary>
        /// <value>The internal unique id (UUID) of the AAD group.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The AAD unique id (UUID) of the AAD group.
        /// </summary>
        /// <value>The AAD unique id (UUID) of the AAD group.</value>
        [DataMember(Name="aad_group_id", EmitDefaultValue=false)]
        public Guid? AadGroupId { get; set; }

        /// <summary>
        /// The display name of the AAD group
        /// </summary>
        /// <value>The display name of the AAD group</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributionGroupAADGroupPostResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AadGroupId: ").Append(AadGroupId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as DistributionGroupAADGroupPostResponse);
        }

        /// <summary>
        /// Returns true if DistributionGroupAADGroupPostResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributionGroupAADGroupPostResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributionGroupAADGroupPostResponse input)
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
                    this.AadGroupId == input.AadGroupId ||
                    (this.AadGroupId != null &&
                    this.AadGroupId.Equals(input.AadGroupId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.AadGroupId != null)
                    hashCode = hashCode * 59 + this.AadGroupId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
