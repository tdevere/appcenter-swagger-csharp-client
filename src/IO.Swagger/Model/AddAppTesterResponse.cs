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
    /// AddAppTesterResponse
    /// </summary>
    [DataContract]
        public partial class AddAppTesterResponse :  IEquatable<AddAppTesterResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddAppTesterResponse" /> class.
        /// </summary>
        /// <param name="userId">The user ID of the tester that needs to be added (required).</param>
        /// <param name="releaseId">The ID of the release the user was added to (required).</param>
        public AddAppTesterResponse(Guid? userId = default(Guid?), int? releaseId = default(int?))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for AddAppTesterResponse and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "releaseId" is required (not null)
            if (releaseId == null)
            {
                throw new InvalidDataException("releaseId is a required property for AddAppTesterResponse and cannot be null");
            }
            else
            {
                this.ReleaseId = releaseId;
            }
        }
        
        /// <summary>
        /// The user ID of the tester that needs to be added
        /// </summary>
        /// <value>The user ID of the tester that needs to be added</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The ID of the release the user was added to
        /// </summary>
        /// <value>The ID of the release the user was added to</value>
        [DataMember(Name="release_id", EmitDefaultValue=false)]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddAppTesterResponse {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
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
            return this.Equals(input as AddAppTesterResponse);
        }

        /// <summary>
        /// Returns true if AddAppTesterResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AddAppTesterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddAppTesterResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
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
