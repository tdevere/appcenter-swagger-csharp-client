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
    /// Event Setting
    /// </summary>
    [DataContract]
        public partial class AlertEmailSettingsSettings :  IEquatable<AlertEmailSettingsSettings>, IValidatableObject
    {
        /// <summary>
        /// Event Name
        /// </summary>
        /// <value>Event Name</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum EventTypeEnum
        {
            /// <summary>
            /// Enum CrashnewCrashGroupCreated for value: crash_newCrashGroupCreated
            /// </summary>
            [EnumMember(Value = "crash_newCrashGroupCreated")]
            CrashnewCrashGroupCreated = 1        }
        /// <summary>
        /// Event Name
        /// </summary>
        /// <value>Event Name</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Frequency of event
        /// </summary>
        /// <value>Frequency of event</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ValueEnum
        {
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 1,
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 2,
            /// <summary>
            /// Enum Daily for value: Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily = 3,
            /// <summary>
            /// Enum DailyAndIndividual for value: DailyAndIndividual
            /// </summary>
            [EnumMember(Value = "DailyAndIndividual")]
            DailyAndIndividual = 4,
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 5        }
        /// <summary>
        /// Frequency of event
        /// </summary>
        /// <value>Frequency of event</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public ValueEnum Value { get; set; }
        /// <summary>
        /// Default frequency of event
        /// </summary>
        /// <value>Default frequency of event</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DefaultValueEnum
        {
            /// <summary>
            /// Enum Disabled for value: Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled = 1,
            /// <summary>
            /// Enum Individual for value: Individual
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual = 2,
            /// <summary>
            /// Enum Daily for value: Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily = 3,
            /// <summary>
            /// Enum DailyAndIndividual for value: DailyAndIndividual
            /// </summary>
            [EnumMember(Value = "DailyAndIndividual")]
            DailyAndIndividual = 4        }
        /// <summary>
        /// Default frequency of event
        /// </summary>
        /// <value>Default frequency of event</value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public DefaultValueEnum? DefaultValue { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertEmailSettingsSettings" /> class.
        /// </summary>
        /// <param name="eventType">Event Name (required).</param>
        /// <param name="value">Frequency of event (required).</param>
        /// <param name="defaultValue">Default frequency of event.</param>
        public AlertEmailSettingsSettings(EventTypeEnum eventType = default(EventTypeEnum), ValueEnum value = default(ValueEnum), DefaultValueEnum? defaultValue = default(DefaultValueEnum?))
        {
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for AlertEmailSettingsSettings and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for AlertEmailSettingsSettings and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            this.DefaultValue = defaultValue;
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertEmailSettingsSettings {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(input as AlertEmailSettingsSettings);
        }

        /// <summary>
        /// Returns true if AlertEmailSettingsSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertEmailSettingsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertEmailSettingsSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
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
