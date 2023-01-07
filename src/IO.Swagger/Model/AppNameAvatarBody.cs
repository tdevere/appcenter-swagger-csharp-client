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
    /// AppNameAvatarBody
    /// </summary>
    [DataContract]
        public partial class AppNameAvatarBody :  IEquatable<AppNameAvatarBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppNameAvatarBody" /> class.
        /// </summary>
        /// <param name="avatar">The image for an app avatar to upload..</param>
        public AppNameAvatarBody(byte[] avatar = default(byte[]))
        {
            this.Avatar = avatar;
        }
        
        /// <summary>
        /// The image for an app avatar to upload.
        /// </summary>
        /// <value>The image for an app avatar to upload.</value>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public byte[] Avatar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppNameAvatarBody {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
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
            return this.Equals(input as AppNameAvatarBody);
        }

        /// <summary>
        /// Returns true if AppNameAvatarBody instances are equal
        /// </summary>
        /// <param name="input">Instance of AppNameAvatarBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppNameAvatarBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
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
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
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
