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
    /// An object containing a UUID for an architecture for an iOS app.
    /// </summary>
    [DataContract]
        public partial class ReleaseCreateRequestIpaUuids :  IEquatable<ReleaseCreateRequestIpaUuids>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreateRequestIpaUuids" /> class.
        /// </summary>
        /// <param name="architecture">The architecture that the UUID belongs to, i.e. armv7 or arm64. (required).</param>
        /// <param name="uuid">The unique identifier. (required).</param>
        public ReleaseCreateRequestIpaUuids(string architecture = default(string), Guid? uuid = default(Guid?))
        {
            // to ensure "architecture" is required (not null)
            if (architecture == null)
            {
                throw new InvalidDataException("architecture is a required property for ReleaseCreateRequestIpaUuids and cannot be null");
            }
            else
            {
                this.Architecture = architecture;
            }
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new InvalidDataException("uuid is a required property for ReleaseCreateRequestIpaUuids and cannot be null");
            }
            else
            {
                this.Uuid = uuid;
            }
        }
        
        /// <summary>
        /// The architecture that the UUID belongs to, i.e. armv7 or arm64.
        /// </summary>
        /// <value>The architecture that the UUID belongs to, i.e. armv7 or arm64.</value>
        [DataMember(Name="architecture", EmitDefaultValue=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// The unique identifier.
        /// </summary>
        /// <value>The unique identifier.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid? Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseCreateRequestIpaUuids {\n");
            sb.Append("  Architecture: ").Append(Architecture).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as ReleaseCreateRequestIpaUuids);
        }

        /// <summary>
        /// Returns true if ReleaseCreateRequestIpaUuids instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseCreateRequestIpaUuids to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseCreateRequestIpaUuids input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
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
