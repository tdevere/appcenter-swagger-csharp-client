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
    /// The information for a single iOS device
    /// </summary>
    [DataContract]
        public partial class PublishDevicesResponse :  IEquatable<PublishDevicesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishDevicesResponse" /> class.
        /// </summary>
        /// <param name="profileFileName">The file name for the provisioning profile..</param>
        /// <param name="profilesZipBase64">The updated provisioning profiles zip base64 encoded. (required).</param>
        public PublishDevicesResponse(string profileFileName = default(string), string profilesZipBase64 = default(string))
        {
            // to ensure "profilesZipBase64" is required (not null)
            if (profilesZipBase64 == null)
            {
                throw new InvalidDataException("profilesZipBase64 is a required property for PublishDevicesResponse and cannot be null");
            }
            else
            {
                this.ProfilesZipBase64 = profilesZipBase64;
            }
            this.ProfileFileName = profileFileName;
        }
        
        /// <summary>
        /// The file name for the provisioning profile.
        /// </summary>
        /// <value>The file name for the provisioning profile.</value>
        [DataMember(Name="profile_file_name", EmitDefaultValue=false)]
        public string ProfileFileName { get; set; }

        /// <summary>
        /// The updated provisioning profiles zip base64 encoded.
        /// </summary>
        /// <value>The updated provisioning profiles zip base64 encoded.</value>
        [DataMember(Name="profiles_zip_base64", EmitDefaultValue=false)]
        public string ProfilesZipBase64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishDevicesResponse {\n");
            sb.Append("  ProfileFileName: ").Append(ProfileFileName).Append("\n");
            sb.Append("  ProfilesZipBase64: ").Append(ProfilesZipBase64).Append("\n");
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
            return this.Equals(input as PublishDevicesResponse);
        }

        /// <summary>
        /// Returns true if PublishDevicesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PublishDevicesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublishDevicesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileFileName == input.ProfileFileName ||
                    (this.ProfileFileName != null &&
                    this.ProfileFileName.Equals(input.ProfileFileName))
                ) && 
                (
                    this.ProfilesZipBase64 == input.ProfilesZipBase64 ||
                    (this.ProfilesZipBase64 != null &&
                    this.ProfilesZipBase64.Equals(input.ProfilesZipBase64))
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
                if (this.ProfileFileName != null)
                    hashCode = hashCode * 59 + this.ProfileFileName.GetHashCode();
                if (this.ProfilesZipBase64 != null)
                    hashCode = hashCode * 59 + this.ProfilesZipBase64.GetHashCode();
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
