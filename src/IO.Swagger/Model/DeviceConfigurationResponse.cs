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
    /// A response containing the fully encoded binary blob for a mobileconfig
    /// </summary>
    [DataContract]
        public partial class DeviceConfigurationResponse :  IEquatable<DeviceConfigurationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceConfigurationResponse" /> class.
        /// </summary>
        /// <param name="dataUrl">A data URL containing a signed mobileconfig profile (required).</param>
        public DeviceConfigurationResponse(string dataUrl = default(string))
        {
            // to ensure "dataUrl" is required (not null)
            if (dataUrl == null)
            {
                throw new InvalidDataException("dataUrl is a required property for DeviceConfigurationResponse and cannot be null");
            }
            else
            {
                this.DataUrl = dataUrl;
            }
        }
        
        /// <summary>
        /// A data URL containing a signed mobileconfig profile
        /// </summary>
        /// <value>A data URL containing a signed mobileconfig profile</value>
        [DataMember(Name="data_url", EmitDefaultValue=false)]
        public string DataUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceConfigurationResponse {\n");
            sb.Append("  DataUrl: ").Append(DataUrl).Append("\n");
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
            return this.Equals(input as DeviceConfigurationResponse);
        }

        /// <summary>
        /// Returns true if DeviceConfigurationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceConfigurationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataUrl == input.DataUrl ||
                    (this.DataUrl != null &&
                    this.DataUrl.Equals(input.DataUrl))
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
                if (this.DataUrl != null)
                    hashCode = hashCode * 59 + this.DataUrl.GetHashCode();
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
