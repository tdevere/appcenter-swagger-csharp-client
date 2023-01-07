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
    /// Generic log.
    /// </summary>
    [DataContract]
        public partial class GenericLogContainerDiagnosticsLogs :  IEquatable<GenericLogContainerDiagnosticsLogs>, IValidatableObject
    {
        /// <summary>
        /// Log type. 
        /// </summary>
        /// <value>Log type. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Event for value: event
            /// </summary>
            [EnumMember(Value = "event")]
            Event = 1,
            /// <summary>
            /// Enum Page for value: page
            /// </summary>
            [EnumMember(Value = "page")]
            Page = 2,
            /// <summary>
            /// Enum Startsession for value: start_session
            /// </summary>
            [EnumMember(Value = "start_session")]
            Startsession = 3,
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4,
            /// <summary>
            /// Enum Pushinstallation for value: push_installation
            /// </summary>
            [EnumMember(Value = "push_installation")]
            Pushinstallation = 5,
            /// <summary>
            /// Enum Startservice for value: start_service
            /// </summary>
            [EnumMember(Value = "start_service")]
            Startservice = 6,
            /// <summary>
            /// Enum Customproperties for value: custom_properties
            /// </summary>
            [EnumMember(Value = "custom_properties")]
            Customproperties = 7        }
        /// <summary>
        /// Log type. 
        /// </summary>
        /// <value>Log type. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericLogContainerDiagnosticsLogs" /> class.
        /// </summary>
        /// <param name="type">Log type.  (required).</param>
        /// <param name="timestamp">Log creation timestamp.  (required).</param>
        /// <param name="installId">Install ID.  (required).</param>
        /// <param name="sessionId">Session ID. .</param>
        /// <param name="eventId">Event ID. .</param>
        /// <param name="eventName">Event name. .</param>
        /// <param name="messageId">Message ID. .</param>
        /// <param name="properties">event specific properties. .</param>
        /// <param name="device">device (required).</param>
        public GenericLogContainerDiagnosticsLogs(TypeEnum type = default(TypeEnum), DateTime? timestamp = default(DateTime?), Guid? installId = default(Guid?), Guid? sessionId = default(Guid?), string eventId = default(string), string eventName = default(string), string messageId = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>), LogContainerDevice device = default(LogContainerDevice))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GenericLogContainerDiagnosticsLogs and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for GenericLogContainerDiagnosticsLogs and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "installId" is required (not null)
            if (installId == null)
            {
                throw new InvalidDataException("installId is a required property for GenericLogContainerDiagnosticsLogs and cannot be null");
            }
            else
            {
                this.InstallId = installId;
            }
            // to ensure "device" is required (not null)
            if (device == null)
            {
                throw new InvalidDataException("device is a required property for GenericLogContainerDiagnosticsLogs and cannot be null");
            }
            else
            {
                this.Device = device;
            }
            this.SessionId = sessionId;
            this.EventId = eventId;
            this.EventName = eventName;
            this.MessageId = messageId;
            this.Properties = properties;
        }
        

        /// <summary>
        /// Log creation timestamp. 
        /// </summary>
        /// <value>Log creation timestamp. </value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Install ID. 
        /// </summary>
        /// <value>Install ID. </value>
        [DataMember(Name="install_id", EmitDefaultValue=false)]
        public Guid? InstallId { get; set; }

        /// <summary>
        /// Session ID. 
        /// </summary>
        /// <value>Session ID. </value>
        [DataMember(Name="session_id", EmitDefaultValue=false)]
        public Guid? SessionId { get; set; }

        /// <summary>
        /// Event ID. 
        /// </summary>
        /// <value>Event ID. </value>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Event name. 
        /// </summary>
        /// <value>Event name. </value>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Message ID. 
        /// </summary>
        /// <value>Message ID. </value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// event specific properties. 
        /// </summary>
        /// <value>event specific properties. </value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public LogContainerDevice Device { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenericLogContainerDiagnosticsLogs {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  InstallId: ").Append(InstallId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
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
            return this.Equals(input as GenericLogContainerDiagnosticsLogs);
        }

        /// <summary>
        /// Returns true if GenericLogContainerDiagnosticsLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericLogContainerDiagnosticsLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericLogContainerDiagnosticsLogs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.InstallId == input.InstallId ||
                    (this.InstallId != null &&
                    this.InstallId.Equals(input.InstallId))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.InstallId != null)
                    hashCode = hashCode * 59 + this.InstallId.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
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
