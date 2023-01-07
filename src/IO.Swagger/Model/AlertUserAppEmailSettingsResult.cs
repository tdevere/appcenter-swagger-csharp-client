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
    /// Alerting Email Settings of the user for a particular app
    /// </summary>
    [DataContract]
        public partial class AlertUserAppEmailSettingsResult :  IEquatable<AlertUserAppEmailSettingsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertUserAppEmailSettingsResult" /> class.
        /// </summary>
        /// <param name="requestId">Unique request.</param>
        /// <param name="appId">Application ID.</param>
        /// <param name="userEnabled">A flag indicating if settings are enabled at user/global level.</param>
        public AlertUserAppEmailSettingsResult(string requestId = default(string), string appId = default(string), bool? userEnabled = default(bool?))
        {
            this.RequestId = requestId;
            this.AppId = appId;
            this.UserEnabled = userEnabled;
        }
        
        /// <summary>
        /// Unique request
        /// </summary>
        /// <value>Unique request</value>
        [DataMember(Name="request_id", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        /// <value>Application ID</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// A flag indicating if settings are enabled at user/global level
        /// </summary>
        /// <value>A flag indicating if settings are enabled at user/global level</value>
        [DataMember(Name="user_enabled", EmitDefaultValue=false)]
        public bool? UserEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertUserAppEmailSettingsResult {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  UserEnabled: ").Append(UserEnabled).Append("\n");
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
            return this.Equals(input as AlertUserAppEmailSettingsResult);
        }

        /// <summary>
        /// Returns true if AlertUserAppEmailSettingsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AlertUserAppEmailSettingsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertUserAppEmailSettingsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.UserEnabled == input.UserEnabled ||
                    (this.UserEnabled != null &&
                    this.UserEnabled.Equals(input.UserEnabled))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.UserEnabled != null)
                    hashCode = hashCode * 59 + this.UserEnabled.GetHashCode();
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