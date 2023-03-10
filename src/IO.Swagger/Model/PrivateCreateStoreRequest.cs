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
    /// create the store through private API. Used by UI.
    /// </summary>
    [DataContract]
        public partial class PrivateCreateStoreRequest :  IEquatable<PrivateCreateStoreRequest>, IValidatableObject
    {
        /// <summary>
        /// store Type
        /// </summary>
        /// <value>store Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Intune for value: intune
            /// </summary>
            [EnumMember(Value = "intune")]
            Intune = 1        }
        /// <summary>
        /// store Type
        /// </summary>
        /// <value>store Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateCreateStoreRequest" /> class.
        /// </summary>
        /// <param name="type">store Type.</param>
        /// <param name="name">name of the store..</param>
        /// <param name="intuneDetails">intuneDetails.</param>
        public PrivateCreateStoreRequest(TypeEnum? type = default(TypeEnum?), string name = default(string), PrivateCreateStoreRequestIntuneDetails intuneDetails = default(PrivateCreateStoreRequestIntuneDetails))
        {
            this.Type = type;
            this.Name = name;
            this.IntuneDetails = intuneDetails;
        }
        

        /// <summary>
        /// name of the store.
        /// </summary>
        /// <value>name of the store.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IntuneDetails
        /// </summary>
        [DataMember(Name="intune_details", EmitDefaultValue=false)]
        public PrivateCreateStoreRequestIntuneDetails IntuneDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateCreateStoreRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntuneDetails: ").Append(IntuneDetails).Append("\n");
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
            return this.Equals(input as PrivateCreateStoreRequest);
        }

        /// <summary>
        /// Returns true if PrivateCreateStoreRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateCreateStoreRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateCreateStoreRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IntuneDetails == input.IntuneDetails ||
                    (this.IntuneDetails != null &&
                    this.IntuneDetails.Equals(input.IntuneDetails))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IntuneDetails != null)
                    hashCode = hashCode * 59 + this.IntuneDetails.GetHashCode();
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
