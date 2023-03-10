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
    /// IntuneGroups
    /// </summary>
    [DataContract]
        public partial class IntuneGroups :  IEquatable<IntuneGroups>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntuneGroups" /> class.
        /// </summary>
        /// <param name="odataContext">context.</param>
        /// <param name="value">categories for intune app.</param>
        public IntuneGroups(string odataContext = default(string), List<IntuneGroupsValue> value = default(List<IntuneGroupsValue>))
        {
            this.OdataContext = odataContext;
            this.Value = value;
        }
        
        /// <summary>
        /// context
        /// </summary>
        /// <value>context</value>
        [DataMember(Name="odata.context", EmitDefaultValue=false)]
        public string OdataContext { get; set; }

        /// <summary>
        /// categories for intune app
        /// </summary>
        /// <value>categories for intune app</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<IntuneGroupsValue> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntuneGroups {\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as IntuneGroups);
        }

        /// <summary>
        /// Returns true if IntuneGroups instances are equal
        /// </summary>
        /// <param name="input">Instance of IntuneGroups to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntuneGroups input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OdataContext == input.OdataContext ||
                    (this.OdataContext != null &&
                    this.OdataContext.Equals(input.OdataContext))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.OdataContext != null)
                    hashCode = hashCode * 59 + this.OdataContext.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
