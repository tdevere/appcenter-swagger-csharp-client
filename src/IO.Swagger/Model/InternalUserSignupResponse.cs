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
    /// InternalUserSignupResponse
    /// </summary>
    [DataContract]
        public partial class InternalUserSignupResponse :  IEquatable<InternalUserSignupResponse>, IValidatableObject
    {
        /// <summary>
        /// The current status of the user record after signup
        /// </summary>
        /// <value>The current status of the user record after signup</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Complete for value: Complete
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete = 1,
            /// <summary>
            /// Enum NeedsVerification for value: NeedsVerification
            /// </summary>
            [EnumMember(Value = "NeedsVerification")]
            NeedsVerification = 2        }
        /// <summary>
        /// The current status of the user record after signup
        /// </summary>
        /// <value>The current status of the user record after signup</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalUserSignupResponse" /> class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the user (required).</param>
        /// <param name="displayName">The full name of the user. Might for example be first and last name (required).</param>
        /// <param name="email">The email address of the user (required).</param>
        /// <param name="externalProvider">The name of the external auth provider.</param>
        /// <param name="externalUserId">The user ID given by the external provider.</param>
        /// <param name="name">The unique name that is used to identify the user. (required).</param>
        /// <param name="status">The current status of the user record after signup.</param>
        public InternalUserSignupResponse(Guid? id = default(Guid?), string displayName = default(string), string email = default(string), string externalProvider = default(string), string externalUserId = default(string), string name = default(string), StatusEnum? status = default(StatusEnum?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InternalUserSignupResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for InternalUserSignupResponse and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for InternalUserSignupResponse and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InternalUserSignupResponse and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.ExternalProvider = externalProvider;
            this.ExternalUserId = externalUserId;
            this.Status = status;
        }
        
        /// <summary>
        /// The unique id (UUID) of the user
        /// </summary>
        /// <value>The unique id (UUID) of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The full name of the user. Might for example be first and last name
        /// </summary>
        /// <value>The full name of the user. Might for example be first and last name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the user
        /// </summary>
        /// <value>The email address of the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The name of the external auth provider
        /// </summary>
        /// <value>The name of the external auth provider</value>
        [DataMember(Name="external_provider", EmitDefaultValue=false)]
        public string ExternalProvider { get; set; }

        /// <summary>
        /// The user ID given by the external provider
        /// </summary>
        /// <value>The user ID given by the external provider</value>
        [DataMember(Name="external_user_id", EmitDefaultValue=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// The unique name that is used to identify the user.
        /// </summary>
        /// <value>The unique name that is used to identify the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternalUserSignupResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalProvider: ").Append(ExternalProvider).Append("\n");
            sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as InternalUserSignupResponse);
        }

        /// <summary>
        /// Returns true if InternalUserSignupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalUserSignupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalUserSignupResponse input)
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
                    this.ExternalProvider == input.ExternalProvider ||
                    (this.ExternalProvider != null &&
                    this.ExternalProvider.Equals(input.ExternalProvider))
                ) && 
                (
                    this.ExternalUserId == input.ExternalUserId ||
                    (this.ExternalUserId != null &&
                    this.ExternalUserId.Equals(input.ExternalUserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExternalProvider != null)
                    hashCode = hashCode * 59 + this.ExternalProvider.GetHashCode();
                if (this.ExternalUserId != null)
                    hashCode = hashCode * 59 + this.ExternalUserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
