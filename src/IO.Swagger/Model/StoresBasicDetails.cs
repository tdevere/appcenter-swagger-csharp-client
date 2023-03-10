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
    /// StoresBasicDetails
    /// </summary>
    [DataContract]
        public partial class StoresBasicDetails :  IEquatable<StoresBasicDetails>, IValidatableObject
    {
        /// <summary>
        /// type of the distribution store currently stores type can be intune or googleplay.
        /// </summary>
        /// <value>type of the distribution store currently stores type can be intune or googleplay.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Intune for value: intune
            /// </summary>
            [EnumMember(Value = "intune")]
            Intune = 1,
            /// <summary>
            /// Enum Googleplay for value: googleplay
            /// </summary>
            [EnumMember(Value = "googleplay")]
            Googleplay = 2        }
        /// <summary>
        /// type of the distribution store currently stores type can be intune or googleplay.
        /// </summary>
        /// <value>type of the distribution store currently stores type can be intune or googleplay.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoresBasicDetails" /> class.
        /// </summary>
        /// <param name="id">ID identifying a unique distribution store..</param>
        /// <param name="name">A name identifying a unique distribution store..</param>
        /// <param name="type">type of the distribution store currently stores type can be intune or googleplay..</param>
        /// <param name="publishingStatus">publishing status of the release in the store..</param>
        public StoresBasicDetails(string id = default(string), string name = default(string), TypeEnum? type = default(TypeEnum?), string publishingStatus = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.PublishingStatus = publishingStatus;
        }
        
        /// <summary>
        /// ID identifying a unique distribution store.
        /// </summary>
        /// <value>ID identifying a unique distribution store.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A name identifying a unique distribution store.
        /// </summary>
        /// <value>A name identifying a unique distribution store.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// publishing status of the release in the store.
        /// </summary>
        /// <value>publishing status of the release in the store.</value>
        [DataMember(Name="publishing_status", EmitDefaultValue=false)]
        public string PublishingStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoresBasicDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PublishingStatus: ").Append(PublishingStatus).Append("\n");
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
            return this.Equals(input as StoresBasicDetails);
        }

        /// <summary>
        /// Returns true if StoresBasicDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of StoresBasicDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoresBasicDetails input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PublishingStatus == input.PublishingStatus ||
                    (this.PublishingStatus != null &&
                    this.PublishingStatus.Equals(input.PublishingStatus))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PublishingStatus != null)
                    hashCode = hashCode * 59 + this.PublishingStatus.GetHashCode();
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
