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
    /// The name of the device set and the list of device IDs
    /// </summary>
    [DataContract]
        public partial class DeviceSetUpdateInformation2 :  IEquatable<DeviceSetUpdateInformation2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSetUpdateInformation2" /> class.
        /// </summary>
        /// <param name="devices">List of device IDs (required).</param>
        /// <param name="name">The name of the device set (required).</param>
        public DeviceSetUpdateInformation2(List<string> devices = default(List<string>), string name = default(string))
        {
            // to ensure "devices" is required (not null)
            if (devices == null)
            {
                throw new InvalidDataException("devices is a required property for DeviceSetUpdateInformation2 and cannot be null");
            }
            else
            {
                this.Devices = devices;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DeviceSetUpdateInformation2 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// List of device IDs
        /// </summary>
        /// <value>List of device IDs</value>
        [DataMember(Name="devices", EmitDefaultValue=false)]
        public List<string> Devices { get; set; }

        /// <summary>
        /// The name of the device set
        /// </summary>
        /// <value>The name of the device set</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceSetUpdateInformation2 {\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
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
            return this.Equals(input as DeviceSetUpdateInformation2);
        }

        /// <summary>
        /// Returns true if DeviceSetUpdateInformation2 instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceSetUpdateInformation2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceSetUpdateInformation2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    input.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
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
                if (this.Devices != null)
                    hashCode = hashCode * 59 + this.Devices.GetHashCode();
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
