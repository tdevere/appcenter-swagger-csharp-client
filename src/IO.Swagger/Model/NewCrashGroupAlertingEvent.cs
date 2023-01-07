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
    /// New crash group alerting event
    /// </summary>
    [DataContract]
        public partial class NewCrashGroupAlertingEvent :  IEquatable<NewCrashGroupAlertingEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCrashGroupAlertingEvent" /> class.
        /// </summary>
        /// <param name="crashGroupProperties">crashGroupProperties.</param>
        public NewCrashGroupAlertingEvent(NewCrashGroupAlertingEventCrashGroupProperties crashGroupProperties = default(NewCrashGroupAlertingEventCrashGroupProperties))
        {
            this.CrashGroupProperties = crashGroupProperties;
        }
        
        /// <summary>
        /// Gets or Sets CrashGroupProperties
        /// </summary>
        [DataMember(Name="crash_group_properties", EmitDefaultValue=false)]
        public NewCrashGroupAlertingEventCrashGroupProperties CrashGroupProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCrashGroupAlertingEvent {\n");
            sb.Append("  CrashGroupProperties: ").Append(CrashGroupProperties).Append("\n");
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
            return this.Equals(input as NewCrashGroupAlertingEvent);
        }

        /// <summary>
        /// Returns true if NewCrashGroupAlertingEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of NewCrashGroupAlertingEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCrashGroupAlertingEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrashGroupProperties == input.CrashGroupProperties ||
                    (this.CrashGroupProperties != null &&
                    this.CrashGroupProperties.Equals(input.CrashGroupProperties))
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
                if (this.CrashGroupProperties != null)
                    hashCode = hashCode * 59 + this.CrashGroupProperties.GetHashCode();
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