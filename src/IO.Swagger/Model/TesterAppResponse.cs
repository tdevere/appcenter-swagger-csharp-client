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
    /// TesterAppResponse
    /// </summary>
    [DataContract]
        public partial class TesterAppResponse :  IEquatable<TesterAppResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Permissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PermissionsEnum
        {
            /// <summary>
            /// Enum Canremovefromapp for value: can_remove_from_app
            /// </summary>
            [EnumMember(Value = "can_remove_from_app")]
            Canremovefromapp = 1        }
        /// <summary>
        /// The permissions associated with the app
        /// </summary>
        /// <value>The permissions associated with the app</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TesterAppResponse" /> class.
        /// </summary>
        /// <param name="microsoftInternal">it indicates if the app is microsoft internal.</param>
        /// <param name="permissions">The permissions associated with the app.</param>
        public TesterAppResponse(bool? microsoftInternal = default(bool?), List<PermissionsEnum> permissions = default(List<PermissionsEnum>))
        {
            this.MicrosoftInternal = microsoftInternal;
            this.Permissions = permissions;
        }
        
        /// <summary>
        /// it indicates if the app is microsoft internal
        /// </summary>
        /// <value>it indicates if the app is microsoft internal</value>
        [DataMember(Name="microsoft_internal", EmitDefaultValue=false)]
        public bool? MicrosoftInternal { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TesterAppResponse {\n");
            sb.Append("  MicrosoftInternal: ").Append(MicrosoftInternal).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as TesterAppResponse);
        }

        /// <summary>
        /// Returns true if TesterAppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TesterAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TesterAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MicrosoftInternal == input.MicrosoftInternal ||
                    (this.MicrosoftInternal != null &&
                    this.MicrosoftInternal.Equals(input.MicrosoftInternal))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.MicrosoftInternal != null)
                    hashCode = hashCode * 59 + this.MicrosoftInternal.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
