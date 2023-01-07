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
    /// Apple Test Flight Groups Response Type
    /// </summary>
    [DataContract]
        public partial class InlineResponse20074 :  IEquatable<InlineResponse20074>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20074" /> class.
        /// </summary>
        /// <param name="id">id of the group..</param>
        /// <param name="providerId">provider id of the group..</param>
        /// <param name="appleId">apple id of the group..</param>
        /// <param name="name">name of the group..</param>
        public InlineResponse20074(string id = default(string), decimal? providerId = default(decimal?), decimal? appleId = default(decimal?), string name = default(string))
        {
            this.Id = id;
            this.ProviderId = providerId;
            this.AppleId = appleId;
            this.Name = name;
        }
        
        /// <summary>
        /// id of the group.
        /// </summary>
        /// <value>id of the group.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// provider id of the group.
        /// </summary>
        /// <value>provider id of the group.</value>
        [DataMember(Name="providerId", EmitDefaultValue=false)]
        public decimal? ProviderId { get; set; }

        /// <summary>
        /// apple id of the group.
        /// </summary>
        /// <value>apple id of the group.</value>
        [DataMember(Name="appleId", EmitDefaultValue=false)]
        public decimal? AppleId { get; set; }

        /// <summary>
        /// name of the group.
        /// </summary>
        /// <value>name of the group.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20074 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  AppleId: ").Append(AppleId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as InlineResponse20074);
        }

        /// <summary>
        /// Returns true if InlineResponse20074 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20074 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20074 input)
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
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.AppleId == input.AppleId ||
                    (this.AppleId != null &&
                    this.AppleId.Equals(input.AppleId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.AppleId != null)
                    hashCode = hashCode * 59 + this.AppleId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
