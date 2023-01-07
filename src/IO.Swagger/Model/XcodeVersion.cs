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
    /// The Xcode version
    /// </summary>
    [DataContract]
        public partial class XcodeVersion :  IEquatable<XcodeVersion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeVersion" /> class.
        /// </summary>
        /// <param name="name">The version name.</param>
        /// <param name="current">If the Xcode is latest stable.</param>
        public XcodeVersion(string name = default(string), bool? current = default(bool?))
        {
            this.Name = name;
            this.Current = current;
        }
        
        /// <summary>
        /// The version name
        /// </summary>
        /// <value>The version name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// If the Xcode is latest stable
        /// </summary>
        /// <value>If the Xcode is latest stable</value>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public bool? Current { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XcodeVersion {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
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
            return this.Equals(input as XcodeVersion);
        }

        /// <summary>
        /// Returns true if XcodeVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of XcodeVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XcodeVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Current == input.Current ||
                    (this.Current != null &&
                    this.Current.Equals(input.Current))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Current != null)
                    hashCode = hashCode * 59 + this.Current.GetHashCode();
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
