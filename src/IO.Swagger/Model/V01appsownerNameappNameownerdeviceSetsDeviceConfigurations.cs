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
    /// V01appsownerNameappNameownerdeviceSetsDeviceConfigurations
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNameownerdeviceSetsDeviceConfigurations :  IEquatable<V01appsownerNameappNameownerdeviceSetsDeviceConfigurations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNameownerdeviceSetsDeviceConfigurations" /> class.
        /// </summary>
        /// <param name="id">The unique id of the device configuration.</param>
        /// <param name="image">image.</param>
        /// <param name="model">model.</param>
        /// <param name="os">os.</param>
        /// <param name="osName">osName.</param>
        public V01appsownerNameappNameownerdeviceSetsDeviceConfigurations(Guid? id = default(Guid?), V01appsownerNameappNameuserdeviceSetsImage image = default(V01appsownerNameappNameuserdeviceSetsImage), V01appsownerNameappNameuserdeviceSetsModel model = default(V01appsownerNameappNameuserdeviceSetsModel), string os = default(string), string osName = default(string))
        {
            this.Id = id;
            this.Image = image;
            this.Model = model;
            this.Os = os;
            this.OsName = osName;
        }
        
        /// <summary>
        /// The unique id of the device configuration
        /// </summary>
        /// <value>The unique id of the device configuration</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public V01appsownerNameappNameuserdeviceSetsImage Image { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public V01appsownerNameappNameuserdeviceSetsModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets OsName
        /// </summary>
        [DataMember(Name="osName", EmitDefaultValue=false)]
        public string OsName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNameownerdeviceSetsDeviceConfigurations {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  OsName: ").Append(OsName).Append("\n");
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
            return this.Equals(input as V01appsownerNameappNameownerdeviceSetsDeviceConfigurations);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNameownerdeviceSetsDeviceConfigurations instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNameownerdeviceSetsDeviceConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNameownerdeviceSetsDeviceConfigurations input)
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
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.OsName == input.OsName ||
                    (this.OsName != null &&
                    this.OsName.Equals(input.OsName))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.OsName != null)
                    hashCode = hashCode * 59 + this.OsName.GetHashCode();
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
