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
    /// Alerting bugtracker resource
    /// </summary>
    [DataContract]
        public partial class AlertingBugtracker :  IEquatable<AlertingBugtracker>, IValidatableObject
    {
        /// <summary>
        /// type of bugtracker
        /// </summary>
        /// <value>type of bugtracker</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Github for value: github
            /// </summary>
            [EnumMember(Value = "github")]
            Github = 1,
            /// <summary>
            /// Enum Vsts for value: vsts
            /// </summary>
            [EnumMember(Value = "vsts")]
            Vsts = 2,
            /// <summary>
            /// Enum Jira for value: jira
            /// </summary>
            [EnumMember(Value = "jira")]
            Jira = 3        }
        /// <summary>
        /// type of bugtracker
        /// </summary>
        /// <value>type of bugtracker</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// bugtracker state
        /// </summary>
        /// <value>bugtracker state</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 1,
            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 2,
            /// <summary>
            /// Enum Unauthorized for value: unauthorized
            /// </summary>
            [EnumMember(Value = "unauthorized")]
            Unauthorized = 3        }
        /// <summary>
        /// bugtracker state
        /// </summary>
        /// <value>bugtracker state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Alerting EventTypes enum
        /// </summary>
        /// <value>Alerting EventTypes enum</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum EventTypesEnum
        {
            /// <summary>
            /// Enum NewCrashGroupCreated for value: newCrashGroupCreated
            /// </summary>
            [EnumMember(Value = "newCrashGroupCreated")]
            NewCrashGroupCreated = 1,
            /// <summary>
            /// Enum NewAppReleased for value: newAppReleased
            /// </summary>
            [EnumMember(Value = "newAppReleased")]
            NewAppReleased = 2        }
        /// <summary>
        /// Event types enabled for bugtracker
        /// </summary>
        /// <value>Event types enabled for bugtracker</value>
        [DataMember(Name="event_types", EmitDefaultValue=false)]
        public List<EventTypesEnum> EventTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingBugtracker" /> class.
        /// </summary>
        /// <param name="type">type of bugtracker.</param>
        /// <param name="state">bugtracker state.</param>
        /// <param name="tokenId">ID of OAuth token.</param>
        /// <param name="eventTypes">Event types enabled for bugtracker.</param>
        /// <param name="settings">settings.</param>
        public AlertingBugtracker(TypeEnum? type = default(TypeEnum?), StateEnum? state = default(StateEnum?), string tokenId = default(string), List<EventTypesEnum> eventTypes = default(List<EventTypesEnum>), AlertingBugtrackerSettings settings = default(AlertingBugtrackerSettings))
        {
            this.Type = type;
            this.State = state;
            this.TokenId = tokenId;
            this.EventTypes = eventTypes;
            this.Settings = settings;
        }
        


        /// <summary>
        /// ID of OAuth token
        /// </summary>
        /// <value>ID of OAuth token</value>
        [DataMember(Name="token_id", EmitDefaultValue=false)]
        public string TokenId { get; set; }


        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public AlertingBugtrackerSettings Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertingBugtracker {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as AlertingBugtracker);
        }

        /// <summary>
        /// Returns true if AlertingBugtracker instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertingBugtracker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertingBugtracker input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.EventTypes == input.EventTypes ||
                    this.EventTypes != null &&
                    input.EventTypes != null &&
                    this.EventTypes.SequenceEqual(input.EventTypes)
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.EventTypes != null)
                    hashCode = hashCode * 59 + this.EventTypes.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
