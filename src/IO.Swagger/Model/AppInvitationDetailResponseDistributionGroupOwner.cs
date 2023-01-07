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
    /// The information about the app&#x27;s owner
    /// </summary>
    [DataContract]
        public partial class AppInvitationDetailResponseDistributionGroupOwner :  IEquatable<AppInvitationDetailResponseDistributionGroupOwner>, IValidatableObject
    {
        /// <summary>
        /// The owner type. Can either be &#x27;org&#x27; or &#x27;user&#x27;
        /// </summary>
        /// <value>The owner type. Can either be &#x27;org&#x27; or &#x27;user&#x27;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Org for value: org
            /// </summary>
            [EnumMember(Value = "org")]
            Org = 1,
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 2        }
        /// <summary>
        /// The owner type. Can either be &#x27;org&#x27; or &#x27;user&#x27;
        /// </summary>
        /// <value>The owner type. Can either be &#x27;org&#x27; or &#x27;user&#x27;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppInvitationDetailResponseDistributionGroupOwner" /> class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the owner (required).</param>
        /// <param name="avatarUrl">The avatar URL of the owner.</param>
        /// <param name="displayName">The owner&#x27;s display name (required).</param>
        /// <param name="email">The owner&#x27;s email address.</param>
        /// <param name="name">The unique name that used to identify the owner (required).</param>
        /// <param name="type">The owner type. Can either be &#x27;org&#x27; or &#x27;user&#x27; (required).</param>
        public AppInvitationDetailResponseDistributionGroupOwner(Guid? id = default(Guid?), string avatarUrl = default(string), string displayName = default(string), string email = default(string), string name = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AppInvitationDetailResponseDistributionGroupOwner and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for AppInvitationDetailResponseDistributionGroupOwner and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AppInvitationDetailResponseDistributionGroupOwner and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for AppInvitationDetailResponseDistributionGroupOwner and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.AvatarUrl = avatarUrl;
            this.Email = email;
        }
        
        /// <summary>
        /// The unique id (UUID) of the owner
        /// </summary>
        /// <value>The unique id (UUID) of the owner</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The avatar URL of the owner
        /// </summary>
        /// <value>The avatar URL of the owner</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The owner&#x27;s display name
        /// </summary>
        /// <value>The owner&#x27;s display name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The owner&#x27;s email address
        /// </summary>
        /// <value>The owner&#x27;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The unique name that used to identify the owner
        /// </summary>
        /// <value>The unique name that used to identify the owner</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppInvitationDetailResponseDistributionGroupOwner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AppInvitationDetailResponseDistributionGroupOwner);
        }

        /// <summary>
        /// Returns true if AppInvitationDetailResponseDistributionGroupOwner instances are equal
        /// </summary>
        /// <param name="input">Instance of AppInvitationDetailResponseDistributionGroupOwner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppInvitationDetailResponseDistributionGroupOwner input)
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
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
