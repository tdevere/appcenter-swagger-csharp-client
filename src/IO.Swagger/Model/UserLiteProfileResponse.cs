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
    /// UserLiteProfileResponse
    /// </summary>
    [DataContract]
        public partial class UserLiteProfileResponse :  IEquatable<UserLiteProfileResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLiteProfileResponse" /> class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the user (required).</param>
        /// <param name="displayName">The full name of the user. Might for example be first and last name (required).</param>
        /// <param name="email">The email address of the user (required).</param>
        public UserLiteProfileResponse(Guid? id = default(Guid?), string displayName = default(string), string email = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserLiteProfileResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for UserLiteProfileResponse and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for UserLiteProfileResponse and cannot be null");
            }
            else
            {
                this.Email = email;
            }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLiteProfileResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as UserLiteProfileResponse);
        }

        /// <summary>
        /// Returns true if UserLiteProfileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserLiteProfileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLiteProfileResponse input)
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
