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
    /// InlineResponse20032
    /// </summary>
    [DataContract]
        public partial class InlineResponse20032 :  IEquatable<InlineResponse20032>, IValidatableObject
    {
        /// <summary>
        /// State of the configuration
        /// </summary>
        /// <value>State of the configuration</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum Unauthorized for value: unauthorized
            /// </summary>
            [EnumMember(Value = "unauthorized")]
            Unauthorized = 1,
            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2,
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 3        }
        /// <summary>
        /// State of the configuration
        /// </summary>
        /// <value>State of the configuration</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20032" /> class.
        /// </summary>
        /// <param name="id">Repository configuration identifier (required).</param>
        /// <param name="type">Type of repository (required).</param>
        /// <param name="state">State of the configuration (required).</param>
        /// <param name="userEmail">Email of the user who linked the repository.</param>
        public InlineResponse20032(string id = default(string), string type = default(string), StateEnum state = default(StateEnum), string userEmail = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InlineResponse20032 and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for InlineResponse20032 and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for InlineResponse20032 and cannot be null");
            }
            else
            {
                this.State = state;
            }
            this.UserEmail = userEmail;
        }
        
        /// <summary>
        /// Repository configuration identifier
        /// </summary>
        /// <value>Repository configuration identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Type of repository
        /// </summary>
        /// <value>Type of repository</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Email of the user who linked the repository
        /// </summary>
        /// <value>Email of the user who linked the repository</value>
        [DataMember(Name="user_email", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20032 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
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
            return this.Equals(input as InlineResponse20032);
        }

        /// <summary>
        /// Returns true if InlineResponse20032 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20032 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20032 input)
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
                    this.UserEmail == input.UserEmail ||
                    (this.UserEmail != null &&
                    this.UserEmail.Equals(input.UserEmail))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UserEmail != null)
                    hashCode = hashCode * 59 + this.UserEmail.GetHashCode();
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