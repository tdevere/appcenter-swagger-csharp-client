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
    /// InternalBulkAppResponse
    /// </summary>
    [DataContract]
        public partial class InternalBulkAppResponse :  IEquatable<InternalBulkAppResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBulkAppResponse" /> class.
        /// </summary>
        /// <param name="appName">The name of the app.</param>
        /// <param name="ownerDisplayName">The display name of the owner.</param>
        public InternalBulkAppResponse(string appName = default(string), string ownerDisplayName = default(string))
        {
            this.AppName = appName;
            this.OwnerDisplayName = ownerDisplayName;
        }
        
        /// <summary>
        /// The name of the app
        /// </summary>
        /// <value>The name of the app</value>
        [DataMember(Name="app_name", EmitDefaultValue=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The display name of the owner
        /// </summary>
        /// <value>The display name of the owner</value>
        [DataMember(Name="owner_display_name", EmitDefaultValue=false)]
        public string OwnerDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternalBulkAppResponse {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  OwnerDisplayName: ").Append(OwnerDisplayName).Append("\n");
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
            return this.Equals(input as InternalBulkAppResponse);
        }

        /// <summary>
        /// Returns true if InternalBulkAppResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalBulkAppResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalBulkAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.OwnerDisplayName == input.OwnerDisplayName ||
                    (this.OwnerDisplayName != null &&
                    this.OwnerDisplayName.Equals(input.OwnerDisplayName))
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
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.OwnerDisplayName != null)
                    hashCode = hashCode * 59 + this.OwnerDisplayName.GetHashCode();
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
