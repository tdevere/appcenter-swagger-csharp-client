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
    /// IntuneGroup
    /// </summary>
    [DataContract]
        public partial class IntuneGroup :  IEquatable<IntuneGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntuneGroup" /> class.
        /// </summary>
        /// <param name="id">the id of the Group.</param>
        /// <param name="displayName">the display name of the group.</param>
        /// <param name="securityEnabled">species if it is a security group.</param>
        public IntuneGroup(string id = default(string), string displayName = default(string), bool? securityEnabled = default(bool?))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.SecurityEnabled = securityEnabled;
        }
        
        /// <summary>
        /// the id of the Group
        /// </summary>
        /// <value>the id of the Group</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// the display name of the group
        /// </summary>
        /// <value>the display name of the group</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// species if it is a security group
        /// </summary>
        /// <value>species if it is a security group</value>
        [DataMember(Name="securityEnabled", EmitDefaultValue=false)]
        public bool? SecurityEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntuneGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SecurityEnabled: ").Append(SecurityEnabled).Append("\n");
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
            return this.Equals(input as IntuneGroup);
        }

        /// <summary>
        /// Returns true if IntuneGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of IntuneGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntuneGroup input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.SecurityEnabled == input.SecurityEnabled ||
                    (this.SecurityEnabled != null &&
                    this.SecurityEnabled.Equals(input.SecurityEnabled))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SecurityEnabled != null)
                    hashCode = hashCode * 59 + this.SecurityEnabled.GetHashCode();
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
